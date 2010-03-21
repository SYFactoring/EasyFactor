//-----------------------------------------------------------------------
// <copyright file="ClientReview.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Data.Linq;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
namespace CMBC.EasyFactor.DB.dbml
{

    /// <summary>
    /// 
    /// </summary>
    public partial class ClientReview
    {
        private static Regex ReviewNoRegex = new Regex(@"^[A-Z]{2}\d{8}-\d{4}[A-Z]{2,3}(-[A-Z]{2})?$");

        /// <summary>
        /// 
        /// </summary>
        public string RecoarseNon
        {
            get
            {
                List<string> result = new List<string>(2);
                if (this.IsRecoarse.GetValueOrDefault())
                {
                    result.Add("有追");
                }

                if (this.IsNonRecoarse.GetValueOrDefault())
                {
                    result.Add("无追");
                }

                return String.Join(";", result.ToArray());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SellerBuyer
        {
            get
            {
                List<string> result = new List<string>(2);
                if (this.IsSeller.GetValueOrDefault())
                {
                    result.Add("卖方");
                }

                if (this.IsBuyer.GetValueOrDefault())
                {
                    result.Add("买方");
                }

                return String.Join(";", result.ToArray());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LocalInternational
        {
            get
            {
                List<string> result = new List<string>(2);
                if (this.IsLocal.GetValueOrDefault())
                {
                    result.Add("国内");
                }

                if (this.IsInternational.GetValueOrDefault())
                {
                    result.Add("国际");
                }

                return String.Join(";", result.ToArray());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ClientLocation
        {
            get
            {
                if (this.Client.Department != null)
                {
                    return this.Client.Department.Location;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(System.Data.Linq.ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
                if (!ReviewNoRegex.IsMatch(this.ReviewNo))
                {
                    throw new ArgumentException("不符合协查意见编码规则: " + this.ReviewNo);
                }
            }
        }

    }
}
