using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class Case : BaseObject
    {
		#region Fields (1) 

        private static readonly List<string> allTransTypes;

		#endregion Fields 

		#region Constructors (1) 

        static Case()
        {
            allTransTypes = new List<string>();
            allTransTypes.Add("国内卖方保理");
            allTransTypes.Add("国内买方保理");
            allTransTypes.Add("出口保理");
            allTransTypes.Add("进口保理");
            allTransTypes.Add("国内信保保理");
            allTransTypes.Add("国际信保保理");
            allTransTypes.Add("租赁保理");
        }

		#endregion Constructors 

		#region Methods (1) 

		// Public Methods (1) 

        public static List<string> ConstantTransTypes()
        {
            return allTransTypes;
        }

		#endregion Methods 
    }
}
