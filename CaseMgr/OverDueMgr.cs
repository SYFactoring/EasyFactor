
namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.Utils;

    public partial class OverDueMgr : UserControl
    {
        private BindingSource bs;

        public OverDueMgr()
        {
            InitializeComponent();
            this.bs = new BindingSource();
            this.dgvInvoices.DataSource = this.bs;
            this.dgvInvoices.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);
        }

        private void QueryOverDueDays(object sender, EventArgs e)
        {
            int AROverDueDays;
            DateTime AROverDueDate = default(DateTime);
            if (Int32.TryParse(this.tbAROverDueDays.Text, out AROverDueDays))
            {
                AROverDueDate = DateTime.Now.AddDays(AROverDueDays);
            }
            int FinanceOverDueDays;
            DateTime FinanceOverDueDate = default(DateTime);
            if (Int32.TryParse(this.tbFinanceOverDueDays.Text, out FinanceOverDueDays))
            {
                FinanceOverDueDate = DateTime.Now.AddDays(FinanceOverDueDays);
            }

            var queryResult = App.Current.DbContext.Invoices.Where(i =>
                (AROverDueDays == 0 ? true : i.DueDate < AROverDueDate)
             && (FinanceOverDueDays == 0 ? true : i.FinanceDueDate < FinanceOverDueDate)
             ).ToList();

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }
    }
}
