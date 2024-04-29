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

namespace SMP.PL.Customers
{
    public partial class AddForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private int Id;
        private AddFormState _state;
        private LoadingForm _loadForm;
        private Customers_UserControl _CustomersControl;
        private string[] _cus_oldData;
        public AddForm(IUnitOfWork unitOfWork, AddFormState state = AddFormState.ADD)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _loadForm = new LoadingForm();
            _state = state;
            if (state == AddFormState.MOD)
                btn_save.Visible = false;
            
        }

        private async void btn_save_Click(object sender, EventArgs e)
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
                    txtSupname.Text = "";
                    txtSupPhone.Text = "";
                    txtSupMail.Text = "";
                    if (_state == AddFormState.ADD)
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
                    if (_state == AddFormState.ADD)
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

        #region Methods
        private bool IsEmpty() => (txtSupname.Text == string.Empty);
        private async Task<bool> AddData()
        {

            var result = await _unitOfWork._cusHelper.AddAsync(new Customer {
                Cus_Name = txtSupname.Text,
                Cus_Phone = txtSupPhone.Text,
                Cus_Email = txtSupMail.Text
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
                    Title = "عملية اضافه",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم اضافة العميل " + "\"" +result.Cus_Name + "\"",
                    AddedDate = DateTime.Now
                });
                // End recording the operation
                if(_CustomersControl is not null)
                    _CustomersControl.LoadData();
                return true;
            }
        }
        private async Task<bool> EditData()
        {
            var result = await _unitOfWork._cusHelper.EditAsync(Id, new Customer { 
                Id = Id,
                Cus_Name = txtSupname.Text,
                Cus_Phone = txtSupPhone.Text,
                Cus_Email = txtSupMail.Text
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
                    Details = _cus_oldData[0] != result.Cus_Name ? $"تم تعديل العميل \"{_cus_oldData[0]}\" الى \"{result.Cus_Name}\"" : $"تم تعديل العميل \"{_cus_oldData[0]}\"",
                    AddedDate = DateTime.Now
                });
                // End recording the operation
                if (_CustomersControl is not null)
                    _CustomersControl.LoadData();
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
                var supTemp = await _unitOfWork._cusHelper.FindAsync(sup => sup.Id == Id);
                if (supTemp is not null)
                {
                    foreach (var sup in supTemp)
                    {
                        txtSupname.Text = sup.Cus_Name;
                        txtSupPhone.Text = sup.Cus_Phone;
                        txtSupMail.Text = sup.Cus_Email;
                    }
                }
                else
                {
                    MessageCollections.ShowServerError();
                }
            }

        }

        public void SetUserControl(Customers_UserControl userControl) => _CustomersControl = userControl;
        public void SetCustomerId(int id) => Id = id;
        public void SetChangedData(params string[] oldData) => _cus_oldData = oldData;
        public void SetFormState(AddFormState state) => _state = state;
        #endregion


    }
}
