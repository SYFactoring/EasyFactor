
namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar;
    using CMBC.EasyFactor.Utils.ConstStr;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceFlaw : DevComponents.DotNetBar.Office2007Form
    {
        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;

        public InvoiceFlaw(List<Invoice> invoiceList, bool isFlaw)
            : this(invoiceList)
        {
            this.isFlawCheckBox.Checked = isFlaw;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        public InvoiceFlaw(List<Invoice> invoiceList)
        {
            this.InitializeComponent();
            this.context = new DBDataContext();
            this.ImeMode = ImeMode.OnHalf;
            this.dgvInvoices.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvInvoices.DataSource = bs;

            this.flawReasonCheckedListBox.DataSource = FlawReason.AllFlawReasons;
            this.flawReasonCheckedListBox.DisplayMember = "Reason";
            this.flawReasonCheckedListBox.ValueMember = "Index";

            List<Invoice> list = new List<Invoice>();
            foreach (Invoice invoice in invoiceList)
            {
                list.Add(context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoice.InvoiceNo));
            }

            bs.DataSource = list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseFlaw(object sender, EventArgs e)
        {
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

            if (this.isFlawCheckBox.Checked && String.IsNullOrEmpty(flawReason))
            {
                MessageBoxEx.Show("请选择瑕疵原因", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (Invoice invoice in this.bs.List)
            {
                invoice.IsFlaw = this.isFlawCheckBox.Checked;
                invoice.FlawReason = flawReason;
                invoice.FlawOtherReason = this.tbOtherFlawReason.Text;
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
                context.SubmitChanges();
            }
            catch (Exception e2)
            {
                isUpdateOK = false;
                MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isUpdateOK)
            {
                MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
