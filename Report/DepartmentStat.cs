using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;

namespace CMBC.EasyFactor.Report
{
    public partial class DepartmentStat : UserControl
    {
        public DepartmentStat()
        {
            InitializeComponent();
        }

        private void StatDeparments(object sender, EventArgs e)
        {
            DateTime beginDate = this.dateFrom.Text != string.Empty ? this.dateFrom.Value.Date : this.dateFrom.MinDate;
            DateTime endDate = this.dateTo.Text != string.Empty ? this.dateTo.Value.Date : this.dateTo.MinDate;

            DepartmentReport rpt = new DepartmentReport();
            DBDataContext context = new DBDataContext();

            var data = (from dept in context.Departments
                        select dept).ToList();
            rpt.SetDataSource(data);

            this.reportViewer.ReportSource = rpt;
        }
    }
}
