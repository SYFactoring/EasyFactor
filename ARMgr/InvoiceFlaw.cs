using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;

namespace CMBC.EasyFactor.ARMgr
{
    public partial class InvoiceFlaw : DevComponents.DotNetBar.Office2007Form
    {
        private BindingSource bs = new BindingSource();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        public InvoiceFlaw(List<Invoice> invoiceList)
        {
            InitializeComponent();
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.DataSource = bs;

            bs.DataSource = invoiceList;
            foreach (Invoice invoice in invoiceList)
            {
                invoice.Backup();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseFlaw(object sender, EventArgs e)
        {
            foreach (Invoice invoice in this.bs.List)
            {
                invoice.Restore();
            }
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFlaw(object sender, EventArgs e)
        {
            string flawReason = string.Empty;
            foreach (string item in this.flawReasonCheckedListBox.CheckedItems)
            {
                flawReason += (item + ";");
            }
            if (!this.tbFlawReason.Text.Equals(string.Empty))
            {
                flawReason += this.tbFlawReason.Text;
            }


            foreach (Invoice invoice in this.bs.List)
            {
                invoice.IsFlaw = this.isFlawCheckBox.Checked;
                invoice.FlawReason = flawReason;
                invoice.FlawResolveReason = this.tbFlawResolveReason.Text;
                invoice.FlawResolveDate = this.flawResolveDateDateTimePicker.Value;
                invoice.FlawResolveUserName = this.flawResolveUserNameTextBox.Text;
            }
            bool isUpdateOK = true;

            try
            {
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e2)
            {
                isUpdateOK = false;
                MessageBox.Show(e2.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isUpdateOK)
            {
                MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Invoice invoice in this.bs.List)
                {
                    invoice.Backup();
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Flaw(object sender, EventArgs e)
        {
            this.flawReasonCheckedListBox.Enabled = true;
            this.tbFlawReason.Enabled = true;
            this.isFlawCheckBox.Checked = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResolveFlaw(object sender, EventArgs e)
        {
            this.flawResolveDateDateTimePicker.Value = DateTime.Now.Date;
            this.flawResolveUserNameTextBox.Text = App.Current.CurUser.Name;
            this.tbFlawResolveReason.Enabled = true;
            this.flawResolveDateDateTimePicker.Enabled = true;
            this.flawResolveUserNameTextBox.Enabled = true;
            this.isFlawCheckBox.Checked = false;

            this.tbFlawResolveReason.Text = "全部已解除";
        }

    }
}
