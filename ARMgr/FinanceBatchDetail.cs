//-----------------------------------------------------------------------
// <copyright file="FinanceBatchDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;

    /// <summary>
    /// 
    /// </summary>
    public partial class FinanceBatchDetail : DevComponents.DotNetBar.Office2007Form
    {
        /// <summary>
        /// 
        /// </summary>
        public FinanceBatchDetail(InvoiceFinanceBatch batch)
        {
            this.InitializeComponent();
            this.batchBindingSource.DataSource = batch;

            InvoiceMgr invoiceMgr = new InvoiceMgr(batch.Invoices);
            invoiceMgr.Dock = DockStyle.Fill;
            this.panelInvoices.Controls.Add(invoiceMgr);
        }

    }
}
