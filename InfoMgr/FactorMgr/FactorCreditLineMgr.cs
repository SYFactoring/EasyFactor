using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    public partial class FactorCreditLineMgr : UserControl
    {
        public FactorCreditLineMgr()
        {
            InitializeComponent();
            this.dgvFactorCreditLines.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvFactorCreditLines);
        }

        private void Query(object sender, EventArgs e)
        {
            string factorCode = tbFactorCode.Text;
            string factorName = tbFactorName.Text;

            var queryResult = App.Current.DbContext.FactorCreditLines.Where(f => f.Factor.FactorCode.Contains(factorCode) && (f.Factor.CompanyNameCN.Contains(factorName) || f.Factor.CompanyNameEN.Contains(factorName)));
            this.dgvFactorCreditLines.DataSource = queryResult;

        }
    }
}
