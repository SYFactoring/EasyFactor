using CMBC.EasyFactor.DB.dbml;
using System;
using System.Linq;
namespace CMBC.EasyFactor.DB.dbml
{
    partial class DBDataContext
    {
        partial void InsertInvoicePaymentLog(InvoicePaymentLog instance)
        {
            instance.Invoice.PaymentAmount = instance.Invoice.PaymentAmount.GetValueOrDefault() + instance.PaymentAmount;
            if (instance.InvoicePaymentBatch.PaymentDate > instance.Invoice.PaymentDate.GetValueOrDefault())
            {
                instance.Invoice.PaymentDate = instance.InvoicePaymentBatch.PaymentDate;
            }
            this.ExecuteDynamicInsert(instance);
        }

        partial void UpdateInvoicePaymentLog(InvoicePaymentLog instance)
        {
            instance.Invoice.PaymentAmount = instance.Invoice.InvoicePaymentLogs.Sum(log => log.PaymentAmount);
            if (instance.InvoicePaymentBatch.PaymentDate > instance.Invoice.PaymentDate.GetValueOrDefault())
            {
                instance.Invoice.PaymentDate = instance.InvoicePaymentBatch.PaymentDate;
            }
            this.ExecuteDynamicUpdate(instance);
        }

        partial void DeleteInvoicePaymentLog(InvoicePaymentLog instance)
        {
            instance.Invoice.PaymentAmount -= instance.PaymentAmount;
            instance.Invoice.PaymentDate = instance.Invoice.InvoicePaymentLogs.Max(log => log.InvoicePaymentBatch.PaymentDate);
            this.ExecuteDynamicDelete(instance);
        }

        partial void InsertInvoiceRefundLog(InvoiceRefundLog instance)
        {
            instance.Invoice.RefundAmount = instance.Invoice.RefundAmount.GetValueOrDefault() + instance.RefundAmount;
            if (instance.InvoiceRefundBatch.RefundDate > instance.Invoice.RefundDate.GetValueOrDefault())
            {
                instance.Invoice.RefundDate = instance.InvoiceRefundBatch.RefundDate;
            }
            this.ExecuteDynamicInsert(instance);
        }
        partial void UpdateInvoiceRefundLog(InvoiceRefundLog instance)
        {
            instance.Invoice.RefundAmount = instance.Invoice.InvoiceRefundLogs.Sum(log => log.RefundAmount);
            if (instance.InvoiceRefundBatch.RefundDate > instance.Invoice.RefundDate.GetValueOrDefault())
            {
                instance.Invoice.RefundDate = instance.InvoiceRefundBatch.RefundDate;
            }
            this.ExecuteDynamicUpdate(instance);
        }
        partial void DeleteInvoiceRefundLog(InvoiceRefundLog instance)
        {
            instance.Invoice.RefundAmount -= instance.RefundAmount;
            instance.Invoice.RefundDate = instance.Invoice.InvoiceRefundLogs.Max(log => log.InvoiceRefundBatch.RefundDate);
            this.ExecuteDynamicDelete(instance);
        }
    }
}