//-----------------------------------------------------------------------
// <copyright file="ClientReview.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Data.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// 
    /// </summary>
    public partial class ClientReview
    {
		#region?Fields?(1)?

        private static Regex ReviewNoRegex = new Regex(@"^[A-Z]{2}\d{8}-\d{4}[A-Z]{2,3}(-[A-Z]{2})?$");

		#endregion?Fields?

		#region?Properties?(4)?

        /// <summary>
        /// 
        /// </summary>
        public string ClientLocation
        {
            get
            {
                if (this.Client.Department != null)
                {
                    return this.Client.Department.Location.LocationName;
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
        public string LocalInternational
        {
            get
            {
                List<string> result = new List<string>(2);
                if (this.IsLocal)
                {
                    result.Add("����");
                }

                if (this.IsInternational)
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
                List<string> result = new List<string>(2);
                if (this.IsRecoarse)
                {
                    result.Add("��׷");
                }

                if (this.IsNonRecoarse)
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
                List<string> result = new List<string>(2);
                if (this.IsSeller)
                {
                    result.Add("����");
                }

                if (this.IsBuyer)
                {
                    result.Add("��");
                }

                return String.Join(";", result.ToArray());
            }
        }

		#endregion?Properties?

		#region?Methods?(1)?

		//?Private?Methods?(1)?

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
                    throw new ArgumentException("������Э������������: " + this.ReviewNo);
                }
            }
        }

		#endregion?Methods?
    }
}
