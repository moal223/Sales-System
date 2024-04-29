using SMP.BL;
using SMP.Core.Interfaces;
using SMP.Core.Models;
using SMP.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SMP.PL.Sell
{
    public partial class AddForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private LoadingForm _loadForm;
        private Sell_UserControl _sellControl;

        string product_name, client;
        double sell_price, quantity, price_per_product, total_price;

        private Purchase product;
        private BindingList<SellOperation> productInfo;
        private List<Purchase> products;
        private List<Customer> customers;
        private List<string> productNames;
        private List<string> customersNames;
        private List<int> IdList;
        private ToolTip addToolTip;
        private ToolTip removeToolTip;
        private ToolTip printToolTip;
        private ToolTip newOPToolTip;
        private AutoCompleteStringCollection ACSC1;
        private AutoCompleteStringCollection ACSC2;
        public AddForm(IUnitOfWork unitOfWork, Sell_UserControl userControl)
        {
            InitializeComponent();

            addToolTip = new ToolTip();
            removeToolTip = new ToolTip();
            printToolTip = new ToolTip();
            newOPToolTip = new ToolTip();

            addToolTip.SetToolTip(btnAdd, "اضافه");
            removeToolTip.SetToolTip(btnDelete, "حذف");
            printToolTip.SetToolTip(btnPrint, "طباعة الفاتوره");
            newOPToolTip.SetToolTip(btnReload, "عمليه جديده");

            _unitOfWork = unitOfWork;
            _loadForm = new LoadingForm();
            productInfo = new BindingList<SellOperation>();
            _sellControl = userControl;
            IdList = new List<int>();
            LoadData();

        }
        private async void AddForm_Activated(object sender, EventArgs e)
        {
            
        }
        private void AddForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Code behind
                GetProducts_Customers();

                customersNames = customers.Select(c => c.Cus_Name).ToList();
                productNames = products.Where(p => !p.IsDelete).Select(p => p.Pur_Name).ToList();
                ACSC1 = new AutoCompleteStringCollection();
                ACSC2 = new AutoCompleteStringCollection();
                ACSC1.AddRange(customersNames.ToArray());
                ACSC2.AddRange(productNames.ToArray());

                cmbClient.DataSource = customersNames;
                cmbProductName.DataSource = productNames;
                cmbClient.AutoCompleteCustomSource = ACSC1;
                cmbProductName.AutoCompleteCustomSource = ACSC2;

                EmptyInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddData();
                EmptyInputs();
                using (var soundPlayer = new SoundPlayer(@"D:\DesktopApps\SMP\SMP\Sounds\mixkit-shop-scanner-beeps-1073_26OcLdtd.wav"))
                {
                    soundPlayer.Play();
                }
            }
            catch
            {

            }
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SetMainInfoOfSellPrice();
            }
            catch
            {

            }
        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                sell_price = (double)nudPrice.Value;
                Calculation();
            }
            catch
            {

            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calculation();
            }
            catch
            {

            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {

            // calculate total for deleted items
            SetIdRowForDelete();
            if (IdList.Count > 0)
            {
                using (var soundPlayer = new SoundPlayer(@"D:\DesktopApps\SMP\SMP\Sounds\tap-notification-180637.wav"))
                {
                    soundPlayer.Play();
                }
                delete();
                lblQuantity.Text = quantity.ToString();
                lblTPricePerProduct.Text = price_per_product.ToString();
                lblTPrice.Text = total_price.ToString();

                LoadData();
                IdList.Clear();
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Access the selected cell and perform your logic
                DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                // Your logic here
            }
        }
        private void nudQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddData();
        }
        private async void linkLabelProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var addProductForm = new PL.Purchases.AddForm(_unitOfWork);
            addProductForm.Show();

            GetProducts_Customers();
            SetMainInfoOfSellPrice();
        }

        private void linkLabelClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var addProductForm = new PL.Customers.AddForm(_unitOfWork);
            addProductForm.Show();

            GetProducts_Customers();
            SetMainInfoOfSellPrice();
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"D:\DesktopApps\SMP\SMP\Sounds\mixkit-mouse-click-close-1113.wav"))
            {
                soundPlayer.Play();
            }
            if (productInfo.Count > 0)
            {
                _loadForm.Show();
                if (await SaveData())
                {
                    _loadForm.Hide();
                    int paperHeight = 500;
                    paperHeight += productInfo.Count * 20;
                    printPreviewDialog1.Document = printDocument1;
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Suit Detail", 500, paperHeight);
                    printPreviewDialog1.ShowDialog();
                    MinuseQuantity();
                    lblTPrice.Text = "0";
                    EmptyInputs();
                    MessageCollections.ShowAddNotification();
                }
                else
                    MessageCollections.ShowServerError();
                _loadForm.Hide();

            }
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"D:\DesktopApps\SMP\SMP\Sounds\mixkit-clear-mouse-clicks-2997.wav"))
            {
                soundPlayer.Play();
            }
            clearOperations();
            lblTPrice.Text = "0";
            EmptyInputs();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SMP System", new Font("Arial", 20, FontStyle.Bold), Brushes.Red, new Point(120, 10));
            e.Graphics.DrawString("Sale Recipt", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(180, 40));

            e.Graphics.DrawString("________________________________________________________________________________________________________________________________________", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(0, 60));

            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(15, 160));
            e.Graphics.DrawString("Client Name: " + cmbClient.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(240, 160));
            e.Graphics.DrawString("Cashier: " + Properties.Settings.Default.UserName, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(240, 190));

            e.Graphics.DrawString("-----------------------------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 235));

            e.Graphics.DrawString("Item Name", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, 255));
            e.Graphics.DrawString("Quantity", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(160, 255));
            e.Graphics.DrawString("Unit Price", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(260, 255));
            e.Graphics.DrawString("Total Price", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(360, 255));

            e.Graphics.DrawString("----------------------------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 275));

            int yPos = 295;
            foreach (var item in productInfo)
            {
                e.Graphics.DrawString(item.Sell_Name, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, yPos));
                e.Graphics.DrawString(item.Quantity.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(160, yPos));
                e.Graphics.DrawString((item.TPrice / item.Quantity).ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(260, yPos));
                e.Graphics.DrawString(item.TPrice.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(360, yPos));
                yPos += 20;
            }

        }

        #region Methods
        private void EmptyInputs()
        {
            cmbProductName.Text = string.Empty;
            cmbClient.Text = string.Empty;
            product_name = string.Empty;
            client = string.Empty;
            nudPrice.Value = 0;
            nudQuantity.Value = 1;
        }
        private void AddData()
        {
            _loadForm.Show();
            productInfo.Add(new SellOperation
            {
                Sell_Name = product_name,
                Sell_Cus = client,
                Quantity = (float)quantity,
                TPrice = (float)price_per_product,
                Sell_Date = DateTime.Now
            });

            total_price = 0;
            foreach (var item in productInfo)
                total_price += item.TPrice;

            lblTPrice.Text = total_price.ToString();
            LoadData();
            _loadForm.Hide();
        }

        private async void GetProducts_Customers()
        {
            customers = _unitOfWork._cusHelper.GetAll().ToList();
            products = _unitOfWork._purHelper.GetAll().ToList();
        }
        private void SetNames()
        {
            // set ui data
            client = cmbClient.Text;
            product_name = cmbProductName.Text;
        }
        private async void GetPrice()
        {
            product = await Task.Run(() => products.FirstOrDefault(p => p.Pur_Name == product_name));
            if (product is not null)
            {
                sell_price = (double)product.Pur_Sell;
                nudPrice.Value = (decimal)sell_price;
            }
        }
        private async void Calculation()
        {
            sell_price = (double)nudPrice.Value;
            // extract the the price and quantity

            quantity = (double)nudQuantity.Value;
            await Task.Run(() => CalculatePrices());

            lblQuantity.Text = quantity.ToString();
            lblTPricePerProduct.Text = price_per_product.ToString();
            lblTPrice.Text = total_price.ToString();
        }
        private async void SetMainInfoOfSellPrice()
        {
            SetNames();
            GetPrice();
            Calculation();
        }
        private void CalculatePrices()
        {
            price_per_product = sell_price * quantity;
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productInfo;
            setColumnTitles();
        }
        private void setColumnTitles()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "اسم المنتج";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "الكميه";
            dataGridView1.Columns[4].HeaderText = "السعر الكلى للمنتج";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }
        private void SetIdRowForDelete()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                IdList.Add(dataGridView1.SelectedRows[0].Index);
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageCollections.ShowDeleteNotificationSell();
            }
        }
        private void delete()
        {
            productInfo.RemoveAt(IdList[0]);

            total_price = 0;
            foreach (var item in productInfo)
                total_price += item.TPrice;
        }
        private async Task<bool> SaveData()
        {
            await _unitOfWork._sellHelper.AddBulkAsync(productInfo);
            int RowNo = await _unitOfWork.CompleteAsync();
            if (RowNo > 0)
            {
                if (_sellControl is not null)
                    _sellControl.LoadData();
                return true;
            }
            else
                return false;

        }
        private void clearOperations()
        {
            productInfo.Clear();
            LoadData();
            total_price = 0;
        }
        private async void MinuseQuantity()
        {
            var pur = new Purchase();
            foreach (var item in productInfo)
            {
                var temps = await _unitOfWork._purHelper.FindAsync(p => p.Pur_Name == item.Sell_Name);
                foreach (var temp in temps)
                {
                    temp.Pur_Qt -= item.Quantity;
                    await _unitOfWork._purHelper.EditAsync(temp.Id, temp);
                }
                    
            }
            clearOperations();
        }
        #endregion

        
    }
}
