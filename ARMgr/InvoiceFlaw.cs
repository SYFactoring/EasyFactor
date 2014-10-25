using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceFlaw : Office2007Form
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        /// <param name="isFlaw"></param>
        public InvoiceFlaw(IEnumerable<Invoice> invoiceList, bool isFlaw)
            : this(invoiceList)
        {
            isFlawCheckBox.Checked = isFlaw;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        public InvoiceFlaw(IEnumerable<Invoice> invoiceList)
        {
            InitializeComponent();
            _context = new DBDataContext();
            ImeMode = ImeMode.OnHalf;
            dgvInvoices.AutoGenerateColumns = false;
            _bs = new BindingSource();
            dgvInvoices.DataSource = _bs;

            flawReasonCheckedListBox.DataSource = FlawReason.AllFlawReasons;
            flawReasonCheckedListBox.DisplayMember = "Reason";
            flawReasonCheckedListBox.ValueMember = "Index";

            var list = invoiceList.Select(invoice => _context.Invoices.SingleOrDefault(i => i.InvoiceID == invoice.InvoiceID)).ToList();

            _bs.DataSource = list;
        }


        //?Private?Methods?(3)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseFlaw(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResolveFlaw(object sender, EventArgs e)
        {
            flawResolveDateDateTimePicker.Value = DateTime.Today;
            flawResolveUserNameTextBox.Text = App.Current.CurUser.Name;
            tbFlawResolveReason.Enabled = true;
            flawResolveDateDateTimePicker.Enabled = true;
            flawResolveUserNameTextBox.Enabled = true;
            isFlawCheckBox.Checked = false;

            tbFlawResolveReason.Text = @"全部已解除";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFlaw(object sender, EventArgs e)
        {
            string flawReason = flawReasonCheckedListBox.CheckedItems.Cast<FlawReason>().Aggregate(string.Empty, (current, item) => current + (item.Index + ";"));

            if (isFlawCheckBox.Checked && String.IsNullOrEmpty(flawReason))
            {
                MessageBoxEx.Show("请选择瑕疵原因", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (Invoice invoice in _bs.List)
            {
                invoice.IsFlaw = isFlawCheckBox.Checked;
                invoice.FlawReason = flawReason;
                invoice.FlawOtherReason = tbOtherFlawReason.Text;
                if (flawResolveDateDateTimePicker.Value != default(DateTime))
                {
                    invoice.FlawResolveReason = tbFlawResolveReason.Text;
                    invoice.FlawResolveDate = flawResolveDateDateTimePicker.Value;
                    invoice.FlawResolveUserName = flawResolveUserNameTextBox.Text;
                }
            }

            bool isUpdateOK = true;
            try
            {
                _context.SubmitChanges();
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
    }
}