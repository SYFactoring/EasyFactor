
namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class CaseMgr : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs = new BindingSource();

        /// <summary>
        /// Initializes a new instance of the CaseQuery class.
        /// </summary>
        public CaseMgr(bool isEditable)
        {
            InitializeComponent();
            ControlUtil.SetDoubleBuffered(this.dgvCases);

            this.cbOwnerDepts.DataSource = App.Current.DbContext.Departments;
            this.cbOwnerDepts.DisplayMembers = "DepartmentName";
            this.cbOwnerDepts.ValueMember = "DepartmentCode";
            this.cbOwnerDepts.GroupingMembers = "Domain";

            this.cbCurrency.DataSource = App.Current.DbContext.Currencies;
            this.cbCurrency.DisplayMember = "CurrencyName";
            this.cbCurrency.ValueMember = "CurrencyCode";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCase(object sender, EventArgs e)
        {
            string ownerDept = string.Empty;
            if (this.cbOwnerDepts.SelectedIndex >= 0)
            {
                ownerDept = cbOwnerDepts.SelectedValue.ToString();
                if (ownerDept == "CN01300")
                {
                    ownerDept = string.Empty;
                }
            }

            DateTime beginDate = this.diBegin.MinDate;
            if (this.diBegin.Value > this.diBegin.MinDate)
            {
                beginDate = this.diBegin.Value;
            }

            DateTime endDate = this.diEnd.MaxDate;
            if (this.diEnd.Value > this.diEnd.MinDate && this.diEnd.Value < this.diEnd.MaxDate)
            {
                endDate = this.diEnd.Value;
            }

            var queryResult = App.Current.DbContext.Cases.Where(c =>
                                c.OwnerDepartmentCode.Equals(ownerDept)
                              && c.TransactionType.Equals(this.cbTransactionType.Text)
                              && c.InvoiceCurrency.Equals((string)this.cbCurrency.SelectedValue)
                              && (beginDate == this.diBegin.MinDate ? true : c.CaseAppDate > beginDate.AddDays(-1))
                              && (endDate == this.diEnd.MaxDate ? true : c.CaseAppDate < endDate.AddDays(1))
                              && c.CaseCode.Contains(this.tbCaseCode.Text)
                              && (c.BuyerClient.ClientNameCN.Contains(this.tbClientName.Text)||c.BuyerClient.ClientNameEN_1.Contains(this.tbClientName.Text)||c.BuyerClient.ClientNameEN_2.Contains(this.tbClientName.Text)
                                ||c.SellerClient.ClientNameCN.Contains(this.tbClientName.Text)||c.SellerClient.ClientNameEN_1.Contains(this.tbClientName.Text)||c.SellerClient.ClientNameEN_2.Contains(this.tbClientName.Text))
                              );

            this.bs.DataSource = queryResult;
            this.dgvCases.DataSource = this.bs;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }
    }
}
