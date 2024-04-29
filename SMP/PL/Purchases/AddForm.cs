using SMP.BL;
using SMP.Core.Interfaces;
using SMP.Core.Models;
using SMP.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP.PL.Purchases
{
    public partial class AddForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private int Id;
        private LoadingForm _loadForm;
        private Purchase_UserControl _purControl;
        private AddFormState _state;
        private string _oldData;
        double buy, sell, qt, ts, tb, rev;
        public AddForm(IUnitOfWork unitOfWork, AddFormState state = AddFormState.ADD)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _loadForm = new LoadingForm();
            _state = state;
            if (state == AddFormState.MOD)
                btn_save.Visible = false;
        }
        private async void AddForm_Activated(object sender, EventArgs e)
        {
            comboBoxCat.DataSource = await Task.Run(()=>_unitOfWork._catHelper.GetAll().Select(c => c.CAT_Name).ToList());
            comboBoxSup.DataSource = await Task.Run(() => _unitOfWork._supHelper.GetAll().Select(c => c.Supp_Name).ToList());
        }
        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageCollections.ShowFiledsReqError();
            }
            else
            {
                BetweenLoadingFormCode();
            }
        }

        private async void btn_saveClose_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageCollections.ShowFiledsReqError();
            }
            else
            {
                _loadForm.Show();
                if (await SaveData())
                {
                    if (Id == 0)
                        MessageCollections.ShowAddNotification();
                    else
                        MessageCollections.ShowEditNotification();
                    Close();
                }
                else
                {
                    MessageCollections.ShowServerError();
                }
                _loadForm.Hide();
            }
        }
        private void AddForm_Load(object sender, EventArgs e)
        {
            _loadForm.Show();
            SetFiledData();
            _loadForm.Hide();
        }
        private void linkLabelAddCat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var addForm = new PL.Categories.AddForm(0);
            //addForm.Show();
        }
        private void linkLabelAddSup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var addForm = new PL.Suppliers.AddForm(0);
            //addForm.Show();
        }
        private void nudPurchase_ValueChanged(object sender, EventArgs e)
        {
            CalculatePrices();
        }
        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            CalculatePrices();
        }

        private void nudSelling_ValueChanged(object sender, EventArgs e)
        {
            CalculatePrices();
        }
        #region Methods
        private bool IsEmpty() => txtProductName.Text == string.Empty;
        private async Task<bool> AddData()
        {

            var result = await _unitOfWork._purHelper.AddAsync(new Purchase
            {
                Pur_Name = txtProductName.Text,
                Pur_Type = txtType.Text,
                Pur_Cat = comboBoxCat.Text,
                Pur_Supp = comboBoxSup.Text,
                Pur_Details = txtDetails.Text,
                Pur_Buy = buy,
                Pur_Sell = sell,
                Pur_Qt = qt,
                Pur_TBuy = tb,
                Pur_TSell = ts,
                Pur_TRev = rev
            });
            int RowNo = await _unitOfWork.CompleteAsync();
            if (RowNo == 0)
            {
                return false;
            }
            else
            {
                // Start recording the operation
                await _unitOfWork._systemHelper.AddAsync(new SystemRecords
                {
                    Title = "عملية اضافه شراء",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم اضافة المنتج " + "\"" + result.Pur_Name + "\"",
                    AddedDate = DateTime.Now
                });
                // End recording the operation
                if(_purControl is not null)
                    _purControl.LoadData();
                return true;
            }
        }
        private async Task<bool> EditData()
        {
            var result = await _unitOfWork._purHelper.EditAsync(Id, new Purchase
            {
                Id = Id,
                Pur_Name = txtProductName.Text,
                Pur_Type = txtType.Text,
                Pur_Cat = comboBoxCat.Text,
                Pur_Supp = comboBoxSup.Text,
                Pur_Details = txtDetails.Text,
                Pur_Buy = buy,
                Pur_Sell = sell,
                Pur_Qt = qt,
                Pur_TBuy = tb,
                Pur_TSell = ts,
                Pur_TRev = rev
            });
            int RowNo = await _unitOfWork.CompleteAsync();
            if (RowNo == 0)
                return false;
            else
            {
                // Start recording the operation
                await _unitOfWork._systemHelper.AddAsync(new SystemRecords
                {
                    Title = "عملية تعديل",
                    UserName = Properties.Settings.Default.UserName,
                    Details = $"تم تعديل الصنف \"{_oldData}\" الى \"{result.Pur_Name}\"",
                    AddedDate = DateTime.Now
                });
                // End recording the operation
                if(_purControl is not null)
                    _purControl.LoadData();
                return true;
            }
        }
        private async Task<bool> SaveData()
        {
            // Add
            if (_state == AddFormState.ADD)
            {
                return await AddData();
            }
            //Edit
            else
            {
                return await EditData();
            }
        }
        private async void SetFiledData()
        {
            if (Id > 0)
            {
                var purTemp = await _unitOfWork._purHelper.FindAsync(pur => pur.Id == Id);
                if (purTemp is not null)
                {
                    foreach (var pur in purTemp)
                    {
                        txtProductName.Text = pur.Pur_Name;
                        txtType.Text = pur.Pur_Type;
                        txtDetails.Text = pur.Pur_Details;
                        comboBoxCat.Text = pur.Pur_Cat;
                        comboBoxSup.Text = pur.Pur_Supp;
                        nudPurchase.Value = Convert.ToDecimal(pur.Pur_Buy);
                        nudSelling.Value = Convert.ToDecimal(pur.Pur_Sell);
                        nudQuantity.Value = Convert.ToDecimal(pur.Pur_Qt);
                        lblPurchases.Text = pur.Pur_TBuy.ToString();
                        lblSelling.Text = pur.Pur_TSell.ToString();
                        lblProfit.Text = pur.Pur_TRev.ToString();
                    }
                }
                else
                {
                    MessageCollections.ShowServerError();
                }
            }

        }
        private void CalculatePrices()
        {
            buy = Convert.ToDouble(nudPurchase.Value);
            sell = Convert.ToDouble(nudSelling.Value);
            qt = Convert.ToDouble(nudQuantity.Value);

            tb = buy * qt;
            ts = sell * qt;
            rev = ts - tb;

            lblPurchases.Text = tb.ToString();
            lblSelling.Text = ts.ToString();
            lblProfit.Text = rev.ToString();


        }
        private async void BetweenLoadingFormCode()
        {
            _loadForm.Show();
            if (await SaveData())
            {
                txtProductName.Text = "";
                txtDetails.Text = "";
                txtType.Text = "";
                nudPurchase.Value = 0;
                nudQuantity.Value = 0;
                nudSelling.Value = 0;
                lblProfit.Text = "0";
                lblPurchases.Text = "0";
                lblSelling.Text = "0";
                if (Id == 0)
                    MessageCollections.ShowAddNotification();
                else
                    MessageCollections.ShowEditNotification();
            }
            else
            {
                MessageCollections.ShowServerError();
            }
            _loadForm.Hide();
        }


        public void SetId(int id) => Id = id;
        public void SetOldData(string oldData) => _oldData = oldData;
        public void SetUserControl(Purchase_UserControl userControl) => _purControl = userControl;
        public void SetState(AddFormState state) => _state = state;
        #endregion


     
    }
}
