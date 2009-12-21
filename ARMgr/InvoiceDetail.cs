

namespace CMBC.EasyFactor.ARMgr
{
    using CMBC.EasyFactor.DB.dbml;

    public partial class InvoiceDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Enums (1)

        public enum OpInvoiceType
        {
            DETAIL_INVOICE,
            FLAW,
        }

        #endregion Enums

        #region Constructors (1)

        public InvoiceDetail(Invoice invoice, OpInvoiceType opInvoiceType)
        {
            InitializeComponent();
        }

        #endregion Constructors
    }
}
