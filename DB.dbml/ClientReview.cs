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
                    result.Add("����");
                }

                if (IsInternational)
                {
                    result.Add("����");
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
                    result.Add("��׷");
                }

                if (IsNonRecoarse)
                {
                    result.Add("��׷");
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
                    result.Add("����");
                }

                if (IsBuyer)
                {
                    result.Add("��");
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
                    throw new ArgumentException("������Э������������: " + ReviewNo);
                }
            }

            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (RequestAmount<0)
                {
                    throw new Exception(String.Format("���Ž��{0:N2}����Ϊ��: {1}", RequestAmount,
                                 ReviewNo));
                }
            }
        }
    }
}