using SMP.BL;
using SMP.Core.Interfaces;
using SMP.Core.Models;
using SMP.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP.PL.Reports
{
    public partial class Reports_UserControl : UserControl
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly string path;
        private readonly LoadingForm loadingForm;

        public Reports_UserControl(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            loadingForm = new LoadingForm();
            path = System.IO.Directory.GetCurrentDirectory();
            path = path.Split(new string[] { "\\bin" }, StringSplitOptions.None)[0] + "\\PL\\Reports";
        }

        private void Cat_UserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
        private void btn_sellReport_Click(object sender, EventArgs e)
        {
            new ViewReports(_unitOfWork, path + "\\SellsReport.rdlc", firstFunction()).Show();
        }

        #region Helper Methods
        private Dictionary<string, List<string>> firstFunction()
        {
            var productsSell = _unitOfWork._sellHelper.GetAll().GroupBy(s => s.Sell_Name).ToList();
            var purs = _unitOfWork._purHelper.GetAll().ToList();
            Dictionary<string, List<string>> table = new Dictionary<string, List<string>>();

            // add the keys
            table.Add("name", new List<string>());
            table.Add("purchase price", new List<string>());
            table.Add("sell price", new List<string>());
            table.Add("quantity stock", new List<string>());
            table.Add("amount sell", new List<string>());
            table.Add("Total price (purchase)", new List<string>());
            table.Add("Total price (sell)", new List<string>());

            for (var i = 0; i < productsSell.Count(); i++)
            {
                table["name"].Add(productsSell[i].Key);
                Purchase pur =  purs.FirstOrDefault(pr => pr.Pur_Name == productsSell[i].Key);
                if(pur is not null)
                {
                    table["purchase price"].Add(pur.Pur_Buy.ToString());
                    table["sell price"].Add(pur.Pur_Sell.ToString());
                    table["quantity stock"].Add(pur.Pur_Qt.ToString());
                    table["Total price (purchase)"].Add(pur.Pur_TBuy.ToString());

                    float qt = 0, tp = 0;
                    foreach (var item in productsSell[i])
                    {
                        qt += item.Quantity;
                        tp += item.TPrice;
                    }
                    table["amount sell"].Add(qt.ToString());
                    table["Total price (sell)"].Add(tp.ToString());
                }
            }
            return table;
        }

        #endregion



    }
}
