//-----------------------------------------------------------------------
// <copyright file="ClientCreditLine.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public partial class ClientCreditLine : BaseObject
    {
        #region Properties (4)

        /// <summary>
        /// Gets
        /// </summary>
        public double AssignCreditLineOutstanding
        {
            get
            {
                double result = this.CreditLine - this.Client.GetAssignOutstanding(this.CreditLineCurrency);
                if (this.ClientCreditLines.Count > 0)
                {
                    foreach (ClientCreditLine creditLine in this.ClientCreditLines)
                    {
                        result -= creditLine.Client.GetAssignOutstanding(this.CreditLineCurrency);
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string ClientNameCN
        {
            get
            {
                if (Client != null)
                {
                    return this.Client.ClientNameCN;
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
        public string ClientNameEN
        {
            get
            {
                if (Client != null)
                {
                    return this.Client.ClientNameEN;
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
        public double FinanceCreditLineOutstanding
        {
            get
            {
                double result = this.CreditLine - this.Client.GetFinanceOutstanding(this.CreditLineCurrency).GetValueOrDefault();
                if (this.ClientCreditLines.Count > 0)
                {
                    foreach (ClientCreditLine creditLine in this.ClientCreditLines)
                    {
                        result -= creditLine.Client.GetFinanceOutstanding(this.CreditLineCurrency).GetValueOrDefault();
                    }
                }

                return result;
            }
        }

        #endregion Properties
    }
}
