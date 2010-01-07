
namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.DB.dbml;
    using System.Drawing;

    public partial class OverDueMgr : UserControl
    {
        #region Fields (1)

        private BindingSource bs;

        #endregion Fields

        #region Constructors (1)

        public OverDueMgr()
        {
            InitializeComponent();
            this.bs = new BindingSource();
            this.dgvInvoices.DataSource = this.bs;
            this.dgvInvoices.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);
        }

        #endregion Constructors

        #region Methods (2)

        // Private Methods (2) 

        /// <summary>
        /// Draw back color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.bs.List.Count; i++)
            {
                Invoice invoice = (Invoice)this.bs.List[i];
                if (invoice.AssignOverDueDays > 0)
                {
                    this.dgvInvoices["colDueDate", i].Style.BackColor = Color.Yellow;
                }
                if (invoice.FinanceOverDueDays > 0)
                {
                    this.dgvInvoices["colFinanceDueDate", i].Style.BackColor = Color.Red;
                }
            }

        }

        private void QueryOverDueDays(object sender, EventArgs e)
        {
            int AssignOverDueDays;
            DateTime AssignOverDueDate = default(DateTime);
            if (Int32.TryParse(this.tbAssignOverDueDays.Text, out AssignOverDueDays))
            {
                AssignOverDueDate = DateTime.Now.AddDays(0 - AssignOverDueDays);
            }
            int FinanceOverDueDays;
            DateTime FinanceOverDueDate = default(DateTime);
            if (Int32.TryParse(this.tbFinanceOverDueDays.Text, out FinanceOverDueDays))
            {
                FinanceOverDueDate = DateTime.Now.AddDays(0 - FinanceOverDueDays);
            }

            var queryResult = App.Current.DbContext.Invoices.Where(i =>
                (AssignOverDueDays == 0 ? true : i.DueDate < AssignOverDueDate)
             && (FinanceOverDueDays == 0 ? true : i.FinanceDueDate < FinanceOverDueDate)
             ).ToList();

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        #endregion Methods
    }
}
