using SMP.BL;
using SMP.Core.Interfaces;
using SMP.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP.PL.Sell
{
    public partial class Sell_UserControl : UserControl
    {
        private IUnitOfWork _unitOfWork;
        private readonly LoadingForm loadingForm;
        private int RowId;
        private List<int> IdList;
        private AddForm _addForm;

        public Sell_UserControl(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            loadingForm = new LoadingForm();
            LoadData();
            IdList = new List<int>();
        }

        private void Cat_UserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btn_addCat_Click(object sender, EventArgs e)
        {
            _addForm = new AddForm(_unitOfWork, this);
            _addForm.Show();
        }

        private async void btn_delCat_Click(object sender, EventArgs e)
        {
            var result = MessageCollections.ShowDeleteDialog();
            if (result)
            {
                if (dataGridView1.RowCount > 0)
                {
                    SetIdRowForDelete();
                    if (IdList.Count > 0)
                    {
                        loadingForm.Show();
                        SellOperation sell = null;
                        foreach (int id in IdList)
                        {
                            sell = await _unitOfWork._sellHelper.DeleteAsync(id);
                            int RowNo = await _unitOfWork.CompleteAsync();
                            if (RowNo > 0)
                            {
                                // Start recording the operation
                                await _unitOfWork._systemHelper.AddAsync(new SystemRecords
                                {
                                    Title = "عملية حذف",
                                    UserName = Properties.Settings.Default.UserName,
                                    Details = "تم حذف عملية البيع " + sell.Sell_Name,
                                    AddedDate = DateTime.Now
                                });
                                // End recording the operation
                                LoadData();
                                MessageCollections.ShowDeleteNotification();
                            }
                            else
                            {
                                MessageCollections.ShowServerError();
                            }
                        }
                        loadingForm.Hide();
                    }
                    else
                    {
                        MessageCollections.ShowNoSelectedItemsError();
                    }
                }
                else
                    MessageCollections.ShowEmptyDataError();
            }
            IdList.Clear();
        }
        private void btn_reloadCat_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private async void comboBoxDataSplit_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadingForm.Show();
            var data =  _unitOfWork._sellHelper.GetAll().ToList();
            var dataId = data.Select(x => x.Id).ToList();
            int index = comboBoxDataSplit.SelectedIndex;
            int indexNoOfRow = index * Properties.Settings.Default.DGVRowNo;


            dataGridView1.DataSource = data.Where(x=> x.Id >= dataId[indexNoOfRow]).Take(Properties.Settings.Default.DGVRowNo).ToList();

            if (dataGridView1.DataSource == null)

                MessageCollections.ShowServerError();
            else
                setColumnTitles();
            loadingForm.Hide();
            data.Clear();
            dataId.Clear();
        }



        #region Helper Methods
        public async void LoadData()
        {
            loadingForm.Show();
            var data =  await Task.Run(() => _unitOfWork._sellHelper.GetAll().ToList());
            dataGridView1.DataSource = data.Take(Properties.Settings.Default.DGVRowNo).ToList();

            comboBoxDataSplit.Items.Clear();
            decimal NoOfPage = Math.Ceiling(Convert.ToDecimal(data.Count()) / Convert.ToDecimal(Properties.Settings.Default.DGVRowNo));

            for(int i = 0; i < NoOfPage; i++)
            {
                comboBoxDataSplit.Items.Add(i + 1);
            }

            if (dataGridView1.DataSource == null)

                MessageCollections.ShowServerError();
            else
                setColumnTitles();
            loadingForm.Hide();
        } 
        private void setColumnTitles()
        {
            dataGridView1.Columns[0].HeaderText = "المعرف";
            dataGridView1.Columns[1].HeaderText = "اسم المنتج";
            dataGridView1.Columns[2].HeaderText = "اسم العميل";
            dataGridView1.Columns[3].HeaderText = "الكميه";
            dataGridView1.Columns[4].HeaderText = "السعر الكلى";
            dataGridView1.Columns[5].HeaderText = "تاريخ البيع";
            dataGridView1.Columns[6].Visible = false ;
        }
        private void SetIdRowForDelete()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    IdList.Add(Convert.ToInt32(row.Cells[0].Value));
                }
            }
        }
        private async void Search()
        {
            loadingForm.Show();
            dataGridView1.DataSource = await _unitOfWork._sellHelper.FindAsync(
                sell => sell.Sell_Name.Contains(textBoxSearch.Text)
                || sell.Quantity.ToString().Contains(textBoxSearch.Text)
                || sell.TPrice.ToString().Contains(textBoxSearch.Text)
                || sell.Sell_Date.ToString().Contains(textBoxSearch.Text)
            );
            if (dataGridView1.DataSource is not null)
                setColumnTitles();
            loadingForm.Hide();
        }

        #endregion
    }
}
