//-----------------------------------------------------------------------
// <copyright file="Factor.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.Utils.ConstStr;

    /// <summary>
    /// 
    /// </summary>
    public partial class Factor 
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private Dictionary<string, string> _dict;

        /// <summary>
        /// 
        /// </summary>
        public static readonly string CMBC_CODE = "CN01300";

        #endregion Fields

        #region Properties (4)

        /// <summary>
        /// Gets
        /// </summary>
        public FactorCreditLine CreditLine
        {
            get
            {
                return this.FactorCreditLines.SingleOrDefault(f => f.CreditLineStatus == FACTOR_CREDIT_LINE.AVAILABILITY);
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double CreditLineOutstanding
        {
            get
            {
                FactorCreditLine creditLine = this.CreditLine;
                if (creditLine == null)
                {
                    return 0;
                }

                return creditLine.CreditLine - this.GetAssignOutstanding(creditLine.CreditLineCurrency);
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string GroupNameCN
        {
            get
            {
                if (!String.IsNullOrEmpty(_GroupNo))
                {
                    return FactorGroup.GroupNameCN;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string GroupNameEN
        {
            get
            {
                if (!String.IsNullOrEmpty(_GroupNo))
                {
                    return FactorGroup.GroupNameEN;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        #endregion Properties

        #region Methods (6)

        // Public Methods (5) 

        /// <summary>
        /// 
        /// </summary>
        public void BeginMonitor()
        {
            this._dict = new Dictionary<string, string>();
            this.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.Factor_PropertyChanged);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string EndMonitor()
        {
            if (this._dict != null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string value in this._dict.Values)
                {
                    sb.Append(value).Append(Environment.NewLine);
                }

                this.PropertyChanged -= new System.ComponentModel.PropertyChangedEventHandler(this.Factor_PropertyChanged);
                return sb.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public double GetAssignOutstanding(string currency)
        {
            double result = 0;
            foreach (Case curCase in this.BuyerCases.Where(c => c.CaseMark == CASEStr.ENABLE))
            {
                double assignOutstanding = curCase.AssignOutstanding;
                if (curCase.InvoiceCurrency != currency)
                {
                    double exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
                    assignOutstanding *= exchange;
                }

                result += assignOutstanding;
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (!String.IsNullOrEmpty(_CompanyNameCN))
            {
                return _CompanyNameCN;
            }
            else
            {
                return _CompanyNameEN;
            }
        }
        // Private Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Factor_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            this._dict[e.PropertyName] = String.Format("{0} : {1}\n", e.PropertyName, this.GetType().GetProperty(e.PropertyName).GetValue(this, null));
        }

        #endregion Methods
    }
}
