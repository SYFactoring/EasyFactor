
namespace CMBC.EasyFactor.Utils
{
    using CMBC.EasyFactor.DB.dbml;

    /// <summary>
    /// 
    /// </summary>
    class InvoiceUtil
    {
        /// <summary>
        /// 
        /// </summary>
        public static void ComputeCommission()
        {
            DBDataContext context = new DBDataContext();
            foreach (Invoice invoice in context.Invoices)
            {
                if (invoice.Commission.HasValue == false || TypeUtil.EqualsZero(invoice.Commission))
                {
                    CDA cda = invoice.InvoiceAssignBatch.Case.ActiveCDA;
                    if (cda != null)
                    {
                        switch (cda.CommissionType)
                        {
                            case "按融资金额":
                                invoice.Commission = invoice.FinanceAmount * cda.Price;
                                if (invoice.Commission.HasValue)
                                {
                                    invoice.CommissionDate = invoice.FinanceDate;
                                }

                                break;
                            case "按转让金额":
                                invoice.Commission = invoice.AssignAmount * cda.Price;
                                if (invoice.Commission.HasValue)
                                {
                                    invoice.CommissionDate = invoice.InvoiceAssignBatch.AssignDate;
                                }

                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            context.SubmitChanges();
        }
    }
}
