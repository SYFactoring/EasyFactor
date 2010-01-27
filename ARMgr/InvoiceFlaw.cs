using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.ARMgr
{
    public partial class InvoiceFlaw : DevComponents.DotNetBar.Office2007Form
    {
        private BindingSource bs = new BindingSource();

        public InvoiceFlaw(List<Invoice> invoiceList, string index)
            : this(invoiceList)
        {
            this.isFlawCheckBox.Checked = true;

            for (int i = 0; i < this.flawReasonCheckedListBox.Items.Count; i++)
            {
                string item = ((FlawReason)this.flawReasonCheckedListBox.Items[i]).Index;
                if (item == index)
                {
                    this.flawReasonCheckedListBox.SetItemChecked(i, true);
                    break;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        public InvoiceFlaw(List<Invoice> invoiceList)
        {
            InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.DataSource = bs;

            this.flawReasonCheckedListBox.DataSource = FlawReason.GetAllFlawReasons();
            this.flawReasonCheckedListBox.DisplayMember = "Reason";
            this.flawReasonCheckedListBox.ValueMember = "Index";

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
            foreach (FlawReason item in this.flawReasonCheckedListBox.CheckedItems)
            {
                flawReason += (item.Index + ";");
            }

            if (this.isFlawCheckBox.Checked && flawReason == string.Empty)
            {
                MessageBox.Show("请选择瑕疵原因", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (Invoice invoice in this.bs.List)
            {
                invoice.IsFlaw = this.isFlawCheckBox.Checked;
                invoice.FlawReason = flawReason;
                if (this.flawResolveDateDateTimePicker.Value != default(DateTime))
                {
                    invoice.FlawResolveReason = this.tbFlawResolveReason.Text;
                    invoice.FlawResolveDate = this.flawResolveDateDateTimePicker.Value;
                    invoice.FlawResolveUserName = this.flawResolveUserNameTextBox.Text;
                }
            }

            bool isUpdateOK = true;

            try
            {
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e2)
            {
                isUpdateOK = false;
                MessageBox.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isUpdateOK)
            {
                MessageBox.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
