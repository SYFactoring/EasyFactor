using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.Utils
{
    public class TypeUtil
    {
        #region Methods (2)

        // Public Methods (2) 

        public static string ConvertBoolToStr(System.Nullable<bool> obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }
            if (!obj.HasValue)
            {
                return string.Empty;
            }
            if (obj.Value == true)
            {
                return "Y";
            }
            else if (obj.Value == false)
            {
                return "N";
            }
            else
            {
                return string.Empty;
            }
        }

        public static System.Nullable<bool> ConvertStrToBool(object obj)
        {
            if (obj == null)
            {
                return null;
            }
            string str = String.Format("{0:G}", obj);
            if (string.Empty.Equals(str))
            {
                return null;
            }
            if ("Y".Equals(str))
            {
                return true;
            }
            else if ("N".Equals(str))
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        #endregion Methods

    }
}
