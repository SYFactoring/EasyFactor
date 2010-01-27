//-----------------------------------------------------------------------
// <copyright file="ClientReview.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Data.Linq;
using System.Text.RegularExpressions;
using System;
namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ClientReview : BaseObject
    {
        private static Regex ReviewNoRegex = new Regex(@"^[A-Z]{2}\d{8}-\d{4}[A-Z]{2,3}-[A-Z]{2}$");

        partial void OnValidate(System.Data.Linq.ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
                if (!ReviewNoRegex.IsMatch(this.ReviewNo))
                {
                    throw new ArgumentException("不符合协查意见编码规则");
                }
            }
        }
    }
}
