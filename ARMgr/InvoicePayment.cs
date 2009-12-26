//-----------------------------------------------------------------------
// <copyright file="InvoicePayment.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoicePayment : UserControl
    {
		#region Constructors (1) 

        /// <summary>
        /// 
        /// </summary>
        public InvoicePayment()
        {
            InitializeComponent();
            this.dgvInvoices.AutoGenerateColumns = false;
        }

		#endregion Constructors 
    }
}
