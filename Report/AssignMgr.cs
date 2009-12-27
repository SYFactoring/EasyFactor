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
using CMBC.EasyFactor.DB.dbml;

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

            this.bs.DataSource = queryResult.ToList();
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        private void GenerateAssignReport(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Workbook workbook = app.Workbooks.Add(true);
            Worksheet sheet = workbook.Worksheets[1] as Worksheet;
            if (!(this.bs.DataSource is List<Invoice>))
            {
                return;
            }

            List<Invoice> invoiceList = this.bs.DataSource as List<Invoice>;
            if (invoiceList.Count == 0)
            {
                return;
            }
            Invoice firstInvoice = invoiceList[0];
            Case selectedCase = firstInvoice.InvoiceAssignBatch.CDA.Case;

            sheet.Cells[1, 1] = String.Format("致{0}公司", selectedCase.SellerClient.ToString());
            sheet.Cells[3, 3] = "应收账款转让明细表";
            sheet.Cells[5, 1] = "买方:";
            sheet.Cells[5, 2] = String.Format("{0}", selectedCase.BuyerClient.ToString());
            sheet.Cells[5, 3] = "（应收账款债务人）";
            sheet.Cells[6, 1] = "进口保理商：";
            sheet.Cells[6, 2] = selectedCase.BuyerFactor.ToString();
            sheet.Cells[7, 1] = "信用风险额度：";
            sheet.Cells[8, 1] = "应收账款余额：";

            sheet.Cells[10, 1] = "发票号";
            sheet.Cells[10, 2] = "转让金额";
            sheet.Cells[10, 3] = "发票日期";
            sheet.Cells[10, 4] = "到期日";
            sheet.Cells[10, 5] = "文件瑕疵";

            int count = invoiceList.Count;
            for (int row = 0; row < count; row++)
            {
                sheet.Cells[row + 11, 1] = invoiceList[row].InvoiceNo;
                sheet.Cells[row + 11, 2] = invoiceList[row].AssignAmount;
                sheet.Cells[row + 11, 3] = invoiceList[row].InvoiceDate;
                sheet.Cells[row + 11, 4] = invoiceList[row].DueDate;
                sheet.Cells[row + 11, 5] = invoiceList[row].IsFlaw==false?"否":"是";
            }

            sheet.Cells[13 + count, 1] = "本行已完成上述发票/贷项发票转让，特此通知";
            sheet.Cells[14 + count, 4] = "中国民生银行        （业务章）";
            sheet.Cells[15 + count, 4] = "签字：";
            sheet.Cells[16 + count, 5] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            app.Visible = true;
        }
    }
}
