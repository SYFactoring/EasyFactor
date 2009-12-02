//-----------------------------------------------------------------------
// <copyright file="InvoiceAssignUI.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InvoiceMgr.InvoiceAssign
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;

    /// <summary>
    /// Invoice Assign user interface
    /// </summary>
    public partial class InvoiceAssignUI : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the InvoiceAssignUI class
        /// </summary>
        public InvoiceAssignUI()
        {
            this.InitializeComponent();

            this.contractOtherInfoPanel.SetContractBasicInfo(this.contractBasicInfoPanel);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ContractChanged()
        {
            this.panelAssign.Visible = this.contractBasicInfoPanel.Contract != null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewBatchNo(object sender, EventArgs e)
        {
            InvoiceAssignBatchNewForm newBatch = new InvoiceAssignBatchNewForm(this.contractBasicInfoPanel.Contract);
            if (newBatch.ShowDialog() == DialogResult.OK)
            {
                this.SetAssignBatch(newBatch.Batch);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batch"></param>
        private void SetAssignBatch(AssignBatch batch)
        {
            this.tbBatchNo.Text = batch.ContractNo + "-" + batch.AssignBatchNo.ToString();
            this.tbDate.Text = batch.BatchDate.Value.ToLongDateString();
            this.tbCurrency.Text = batch.BatchCurrency;
        }
    }
}
