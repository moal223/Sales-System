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

namespace SMP.PL.Categories
{
    public partial class AddForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private AddFormState _state;
        private int Id;
        private LoadingForm _loadForm;
        private Cat_UserControl _catControl;
        private string _cat_oldName;
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
                    txtCatname.Text = "";
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
                    {
                        MessageCollections.ShowAddNotification();
                    }
                        
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
        private bool IsEmpty() => txtCatname.Text == string.Empty;
        private async Task<bool> AddData()
        {

            var result = await _unitOfWork._catHelper.AddAsync(new Category { CAT_Name = txtCatname.Text });
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
                    Details = "تم اضافة الصنف " + "\"" +result.CAT_Name + "\"",
                    AddedDate = DateTime.Now
                });
                // End recording the operation
                if(_catControl is not null)
                    _catControl.LoadData();
                return true;
            }
        }
        private async Task<bool> EditData()
        {
            var result = await _unitOfWork._catHelper.EditAsync(Id, new Category { Id = Id, CAT_Name = txtCatname.Text });
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
                    Details = $"تم تعديل الصنف \"{_cat_oldName}\" الى \"{result.CAT_Name}\"",
                    AddedDate = DateTime.Now
                });
                // End recording the operation
                if (_catControl is not null)
                    _catControl.LoadData();
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
                var catTemp = await _unitOfWork._catHelper.FindAsync(cat => cat.Id == Id);
                if (catTemp is not null)
                {
                    foreach (var cat in catTemp)
                        txtCatname.Text = cat.CAT_Name;
                }
                else
                {
                    MessageCollections.ShowServerError();
                }
            }

        }
        public void SetUserControl(Cat_UserControl cat_UserControl) => _catControl = cat_UserControl;
        public void SetChangedValues(string values) => _cat_oldName = values;
        public void SetCategoryId(int id) => Id = id;
        #endregion

        
    }
}
