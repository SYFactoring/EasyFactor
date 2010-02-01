using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMBC.EasyFactor.DB.dbml;

namespace CMBC.EasyFactor.Utils
{
    class InvoiceUtil
    {
        public static void ComputeCommission()
        {
            foreach (Invoice invoice in App.Current.DbContext.Invoices)
            {
                if (!invoice.Commission.HasValue)
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
        }
    }
}
