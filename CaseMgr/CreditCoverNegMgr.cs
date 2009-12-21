
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
		#region Fields (2) 

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs = new BindingSource();
           /// <summary>
        /// flag indicates if editable
        /// </summary>
        private bool isEditable;

		#endregion Fields 

		#region Constructors (1) 

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

		#endregion Constructors 

		#region Properties (2) 

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

		#endregion Properties 

		#region Methods (1) 

		// Private Methods (1) 

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

		#endregion Methods 
    }
}
