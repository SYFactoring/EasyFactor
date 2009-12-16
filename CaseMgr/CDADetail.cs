using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.CaseMgr
{
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.InfoMgr;

    public partial class CDADetail : DevComponents.DotNetBar.Office2007Form
    {
        /// <summary>
        /// 
        /// </summary>
        private OpCDAType opCDAType;

        public CDADetail(CDA cda,OpCDAType opCDAType)
        {
            InitializeComponent();
            this.opCDAType = opCDAType;
            if (opCDAType == OpCDAType.NEW_CDA)
            {
                this.CDABindingSource.DataSource = new CDA();
            }
            else
            {
                this.CDABindingSource.DataSource = cda;
                cda.Backup();
            }

            this.UpdateCDAControlStatus();
        }

        /// <summary>
        /// Operation Type 
        /// </summary>
        public enum OpCDAType
        {
            /// <summary>
            /// New CDA
            /// </summary>
            NEW_CDA,

            /// <summary>
            /// Update CDA
            /// </summary>
            UPDATE_CDA,

            /// <summary>
            /// Detail CDA
            /// </summary>
            DETAIL_CDA
        }

        private void UpdateCDAControlStatus()
        {
        }

        private void SelectCase(object sender, EventArgs e)
        {
            CaseMgr caseMgr = new CaseMgr(false);
            QueryForm queryForm = new QueryForm(caseMgr,"选择案件");
            caseMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);
            Case curCase = caseMgr.Selected;
            if (curCase != null)
            {
                CDA cda = (CDA)this.CDABindingSource.DataSource;
                cda.Case = curCase;
            }
        }
    }
}
