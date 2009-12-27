using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.Utils;
using Microsoft.Office.Interop.Excel;

namespace CMBC.EasyFactor.Report
{
    public partial class AssignMgr : UserControl
    {
        private BindingSource bs;

        public AssignMgr()
        {
            InitializeComponent();
            this.bs = new BindingSource();
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.DataSource = this.bs;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);
        }

        private void QueryAssign(object sender, EventArgs e)
        {
            string sellerName = this.tbSeller.Text;
            string buyerName = this.tbBuyer.Text;
            string factorName = this.tbFactor.Text;

            DateTime beginDate = this.diAssignDateBegin.MinDate;
            if (this.diAssignDateBegin.Value > this.diAssignDateBegin.MinDate)
            {
                beginDate = this.diAssignDateBegin.Value;
            }

            DateTime endDate = this.diAssignDateEnd.MaxDate;
            if (this.diAssignDateEnd.Value > this.diAssignDateEnd.MinDate && this.diAssignDateEnd.Value < this.diAssignDateEnd.MaxDate)
            {
                endDate = this.diAssignDateEnd.Value;
            }

            var queryResult = from invoice in App.Current.DbContext.Invoices
                              let seller = invoice.InvoiceAssignBatch.CDA.Case.SellerClient
                              where seller.ClientNameCN.Contains(sellerName) || seller.ClientNameEN_1.Contains(sellerName) || seller.ClientNameEN_2.Contains(sellerName)
                              let buyer = invoice.InvoiceAssignBatch.CDA.Case.BuyerClient
                              where buyer.ClientNameCN.Contains(buyerName) || buyer.ClientNameEN_1.Contains(buyerName) || buyer.ClientNameEN_2.Contains(buyerName)
                              let sellerFactor = invoice.InvoiceAssignBatch.CDA.Case.SellerFactor
                              where sellerFactor.CompanyNameCN.Contains(factorName) || sellerFactor.CompanyNameEN.Contains(factorName)
                              let buyerFactor = invoice.InvoiceAssignBatch.CDA.Case.BuyerFactor
                              where buyerFactor.CompanyNameCN.Contains(factorName) || buyerFactor.CompanyNameEN.Contains(factorName)
                              where
                                 (beginDate == this.diAssignDateBegin.MinDate ? true : invoice.AssignDate > beginDate.AddDays(-1))
                                 && (endDate == this.diAssignDateEnd.MaxDate ? true : invoice.AssignDate < endDate.AddDays(1))
                              select invoice;

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        private void GenerateAssignReport(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new ApplicationClass() { Visible = true };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Workbook workbook = app.Workbooks.Add(true);
            Worksheet sheet = workbook.Worksheets[1] as Worksheet;
            object[,] valueArray = new object[10, 10];
            valueArray[1, 1] = "Hello World";

            for (int row = 1; row <= valueArray.GetUpperBound(0); row++)
            {
                for (int column = 1; column <= valueArray.GetUpperBound(1); column++)
                {
                    sheet.Cells[row, column] = valueArray[row, column];
                }
            }
        }
    }
}
