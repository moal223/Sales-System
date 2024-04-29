using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using SMP.Core.Interfaces;
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
    public partial class ViewReports : Form
    {
        string reportPath;
        IUnitOfWork _unitOfWork;
        Dictionary<string, List<string>> _table;
        public ViewReports(IUnitOfWork unitOfWork, string path, Dictionary<string, List<string>> table)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            reportPath = path;
            _table = table;
        }

        private void ViewReports_Load(object sender, EventArgs e)
        {
            StartReport(new ReportDataSource("DataSet1", _table));
        }

        private void StartReport(ReportDataSource source)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = reportPath;
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}
