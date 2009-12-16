
namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    public partial class CreditCoverNegMgr : UserControl
    {   
    
        /// <summary>
        /// flag indicates if editable
        /// </summary>
        private bool isEditable;

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs = new BindingSource();

        /// <summary>
        /// 
        /// </summary>
        public CreditCoverNegMgr(bool isEditable)
        {
            InitializeComponent();
            this.isEditable = isEditable;
            this.UpdateEditableStatus();
            ControlUtil.SetDoubleBuffered(this.dgvCreditCovers);
        }

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets selected Client
        /// </summary>
        public CreditCoverNegotiation Selected
        {
            get;
            set;
        }

        /// <summary>
        /// Update editable status
        /// </summary>
        private void UpdateEditableStatus()
        {
            if (this.isEditable)
            {
                this.menuItemCreditCoverNew.Enabled = true;
                this.menuItemCreditCoverUpdate.Enabled = true;
                this.menuItemCreditCoverDelete.Enabled = true;
            }
            else
            {
                this.menuItemCreditCoverNew.Enabled = false;
                this.menuItemCreditCoverUpdate.Enabled = false;
                this.menuItemCreditCoverDelete.Enabled = false;
            }
        }
    }
}
