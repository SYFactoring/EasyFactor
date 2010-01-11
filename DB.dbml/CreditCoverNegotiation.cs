using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class CreditCoverNegotiation
    {
        public string SellerName
        {
            get
            {
                return this.Case.SellerClient.ToString();
            }
        }

        public string BuyerName
        {
            get
            {
                return this.Case.BuyerClient.ToString();
            }
        }

        public string SellerFactorName
        {
            get
            {
                return this.Case.SellerFactor.ToString();
            }
        }

        public string BuyerFactorName
        {
            get
            {
                return this.Case.BuyerFactor.ToString();
            }
        }

        public string TransactionType
        {
            get
            {
                return this.Case.TransactionType;
            }
        }

        public string BuyerCountry
        {
            get
            {
                return this.Case.BuyerClient.CountryCode;
            }
        }

        public string CaseCurrency
        {
            get
            {
                return this.Case.InvoiceCurrency;
            }
        }

        public string OwnerDept
        {
            get
            {
                return this.Case.OwnerDepartment.DepartmentName;
            }
        }

        public string ManagerName
        {
            get
            {
                return this.Case.ManagerName;
            }
        }
    }
}
