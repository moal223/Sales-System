using SMP.BL;
using SMP.Core.Interfaces;
using SMP.Core.Models;
using SMP.Enums;
using SMP.PL.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP.PL.Suppliers
{
    public partial class AddForm : Form
    {
        private IUnitOfWork _unitOfWork;
        private int Id;
        private LoadingForm _loadForm;
        private Suppliers_UserControl _SuppliersControl;
        private string[] _oldData;
        private AddFormState _state;
        public AddForm(IUnitOfWork unitOfWork, AddFormState state = AddFormState.ADD)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _loadForm = new LoadingForm();
            _state = state;
            if (_state == AddFormState.MOD)
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

            var result = await _unitOfWork._supHelper.AddAsync(new Supplier {
                Supp_Name = txtSupname.Text, 
                Supp_Phone = txtSupPhone.Text,
                Supp_Email = txtSupMail.Text
            });
            if (result == null)
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
                    Details = "تم اضافة المورد " + "\"" +result.Supp_Name + "\"",
                    AddedDate = DateTime.Now
                });
                // End recording the operation
                if(_SuppliersControl is not null)
                    _SuppliersControl.LoadData();
                return true;
            }
        }
        private async Task<bool> EditData()
        {
            var result = await _unitOfWork._supHelper.EditAsync(Id, new Supplier { 
                Id = Id,
                Supp_Name = txtSupname.Text,
                Supp_Phone = txtSupPhone.Text,
                Supp_Email = txtSupMail.Text
            });
            if (result == null)
                return false;
            else
            {
                // Start recording the operation
                await _unitOfWork._systemHelper.AddAsync(new SystemRecords
                {
                    Title = "عملية تعديل",
                    UserName = Properties.Settings.Default.UserName,
                    Details = $"تم تعديل المورد \"{_oldData[0]}\" الى \"{result.Supp_Name}\"",
                    AddedDate = DateTime.Now
                });
                // End recording the operation
                if (_SuppliersControl is not null)
                    _SuppliersControl.LoadData();
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
                var supTemp = await _unitOfWork._supHelper.FindAsync(sup => sup.Id == Id);
                if (supTemp is not null)
                {
                    foreach (var sup in supTemp)
                    {
                        txtSupname.Text = sup.Supp_Name;
                        txtSupPhone.Text = sup.Supp_Phone;
                        txtSupMail.Text = sup.Supp_Email;
                    }
                }
                else
                {
                    MessageCollections.ShowServerError();
                }
            }

        }
        public void SetUserControl(Suppliers_UserControl userControl) => _SuppliersControl = userControl;
        public void SetChangedValues(params string[] values) => _oldData = values;
        public void SetId(int id) => Id = id;
        #endregion


    }
}
