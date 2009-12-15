using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.CaseMgr.CaseApp
{
    public partial class CaseQuery : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs = new BindingSource();

        public CaseQuery()
        {
            InitializeComponent();
            ControlUtil.SetDoubleBuffered(this.dgvCases);

            this.cbOwnerDepts.DataSource = App.Current.DbContext.Departments;
            this.cbOwnerDepts.DisplayMembers = "DepartmentName";
            this.cbOwnerDepts.ValueMember = "DepartmentCode";
            this.cbOwnerDepts.GroupingMembers = "Domain";

            this.cbCurrency.DataSource = App.Current.DbContext.Currencies;
            this.cbCurrency.DisplayMember = "CurrencyName";
            this.cbCurrency.ValueMember = "CurrencyCode";
        }

        private void QueryCase(object sender, EventArgs e)
        {
            var queryResult = App.Current.DbContext.Cases;

            this.bs.DataSource = queryResult.ToList();
            this.dgvCases.DataSource = bs;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }
    }
}
