//-----------------------------------------------------------------------
// <copyright file="InvoiceAssignBatchNewForm.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InvoiceMgr.InvoiceAssign
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;

    /// <summary>
    /// Invoice Assign Batch New Form
    /// </summary>
    public partial class InvoiceAssignBatchNewForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        //private string newBatchNo;

        /// <summary>
        /// Initializes a new instance of the InvoiceAssignBatchNewForm class
        /// </summary>
        /// <param name="contract"></param>
        public InvoiceAssignBatchNewForm(CMBC.EasyFactor.DB.dbml.Contract contract)
        {
            this.InitializeComponent();

            //try
            //{
            //    this.newBatchNo = contract.ContractNo + "-A" + App.Current.DbContext.AssignBatches.Count(b => b.ContractNo == contract.ContractNo) + 1;
            //    this.tbContractNo.Text = contract.ContractNo;
            //    this.tbAssignBatchNo.Text = contract.ContractNo + "-" + this.newBatchNo.ToString();
            //    this.tbBatchDate.Text = DateTime.Now.ToLongDateString();
            //    var currency = App.Current.DbContext.Currencies;
            //    foreach (var c in currency)
            //    {
            //        this.cbAssignBatchCurrency.Items.Add(c.CurrencyCode);
            //    }

            //    this.cbAssignBatchCurrency.SelectedIndex = 0;
            //}
            //catch (Exception)
            //{
            //    // TODO How to handle the database query failure?
            //    MessageBox.Show("What's wrong?");
            //}
        }

        /// <summary>
        /// Gets or sets Batch
        /// </summary>
        public InvoiceAssignBatch Batch
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void OK(object sender, EventArgs e)
        {
            if (this.cbAssignBatchCurrency.SelectedIndex != -1)
            {
                //try
                //{
                //    this.Batch = new AssignBatch();
                //    this.Batch.ContractNo = this.tbContractNo.Text;
                //    this.Batch.AssignBatchNo = this.newBatchNo;
                //    this.Batch.BatchCurrency = this.cbAssignBatchCurrency.Text;
                //    this.Batch.BatchDate = DateTime.Now;
                //    App.Current.DbContext.AssignBatches.InsertOnSubmit(this.Batch);
                //    App.Current.DbContext.SubmitChanges();
                //    this.DialogResult = DialogResult.OK;
                //}
                //catch (Exception)
                //{
                //    // TODO How to handle the database insert failure?
                //    MessageBox.Show("What's wrong?");
                //}
            }
        }

        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Cancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
