

namespace CMBC.EasyFactor.ARMgr
{
    using CMBC.EasyFactor.DB.dbml;

    public partial class InvoiceDetail : DevComponents.DotNetBar.Office2007Form
    {
        public InvoiceDetail(Invoice invoice, OpInvoiceType opInvoiceType)
        {
            InitializeComponent();
        }

        public enum OpInvoiceType
        {
            DETAIL_INVOICE,
            FLAW,
        }
    }
}
