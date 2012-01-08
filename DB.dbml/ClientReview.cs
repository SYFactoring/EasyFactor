//-----------------------------------------------------------------------
// <copyright file="ClientReview.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Text.RegularExpressions;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ClientReview
    {
        private static readonly Regex ReviewNoRegex = new Regex(@"^[A-Z]{2}\d{8}-\d{4}[A-Z]{2,3}(-[A-Z]{2})?$");


        /// <summary>
        /// 
        /// </summary>
        public string ClientLocation
        {
            get { return Client.Department != null ? Client.Department.Location.LocationName : string.Empty; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LocalInternational
        {
            get
            {
                var result = new List<string>(2);
                if (IsLocal)
                {
                    result.Add("国内");
                }

                if (IsInternational)
                {
                    result.Add("国际");
                }

                return String.Join(";", result.ToArray());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string RecoarseNon
        {
            get
            {
                var result = new List<string>(2);
                if (IsRecoarse)
                {
                    result.Add("有追");
                }

                if (IsNonRecoarse)
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
                var result = new List<string>(2);
                if (IsSeller)
                {
                    result.Add("卖方");
                }

                if (IsBuyer)
                {
                    result.Add("买方");
                }

                return String.Join(";", result.ToArray());
            }
        }


        //?Private?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
                if (!ReviewNoRegex.IsMatch(ReviewNo))
                {
                    throw new ArgumentException("不符合协查意见编码规则: " + ReviewNo);
                }
            }

            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (RequestAmount<0)
                {
                    throw new Exception(String.Format("授信金额{0:N2}不能为负: {1}", RequestAmount,
                                 ReviewNo));
                }
            }
        }
    }
}