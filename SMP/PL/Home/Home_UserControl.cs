using SMP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP.PL.Home
{
    public partial class Home_UserControl : UserControl
    {
        IUnitOfWork _unitOfWork;
        public Home_UserControl(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void Home_UserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            CalculateSellRev();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new PL.Sell.AddForm(_unitOfWork, null)).Show();
            CalculateSellRev();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new PL.Purchases.AddForm(_unitOfWork, Enums.AddFormState.ADD)).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new PL.Customers.AddForm(_unitOfWork, Enums.AddFormState.ADD)).Show();
        }

        private void CalculateSellRev()
        {
            try
            {
                var sells = _unitOfWork._sellHelper.GetAll().Where(s => s.Sell_Date.ToShortDateString() == DateTime.Now.ToShortDateString())
                    .Select(s => s.TPrice);
                float totalSell = 0;
                foreach (var sell in sells)
                    totalSell += sell;
                label2.Text = totalSell.ToString();
            }
            catch { }
        }
    }
}
