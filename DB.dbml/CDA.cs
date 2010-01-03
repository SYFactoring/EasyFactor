using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class CDA : BaseObject
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedCase"></param>
        /// <returns></returns>
        public static string GenerateCDACode(Case selectedCase)
        {
            if (selectedCase == null)
            {
                return string.Empty;
            }
            Contract contract = selectedCase.SellerClient.Contracts.SingleOrDefault(c => c.ContractStatus == "已生效");
            if (contract != null)
            {
                CDA formerCDA = App.Current.DbContext.CDAs.OrderByDescending(c => c.CDACode).FirstOrDefault(c => c.CDACode.StartsWith(contract.ContractCode));
                if (formerCDA == null)
                {
                    return string.Format("{0}-{1:000}", contract.ContractCode, 1);
                }
                else
                {
                    int index = Int32.Parse(formerCDA.CDACode.Substring(formerCDA.CDACode.LastIndexOf("-")+1));
                    return String.Format("{0}-{1:000}", contract.ContractCode, index + 1);
                }
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
