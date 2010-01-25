//-----------------------------------------------------------------------
// <copyright file="Case.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public partial class Case : BaseObject
    {
		#region Properties (3) 

        /// <summary>
        /// Gets 
        /// </summary>
        public CDA ActiveCDA
        {
            get
            {
                return this.CDAs.SingleOrDefault(c => c.CDAStatus == "已签回");
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double AssignOutstanding
        {
            get
            {
                double result = 0;
                foreach (CDA cda in this.CDAs)
                {
                    result += cda.GetAssignOutstanding(this.InvoiceCurrency);
                }
                return result;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double? FinanceOutstanding
        {
            get
            {
                double? result = null;
                foreach (CDA cda in this.CDAs)
                {
                    double? temp = cda.GetFinanceOutstanding(this.InvoiceCurrency).GetValueOrDefault();
                    if (temp.HasValue)
                    {
                        if (result == null)
                        {
                            result = 0;
                        }
                        result += temp.Value;
                    }
                }
                return result;
            }
        }

		#endregion Properties 
    }
}
