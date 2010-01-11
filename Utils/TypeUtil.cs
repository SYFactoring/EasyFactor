using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMBC.EasyFactor.Utils
{
    public class TypeUtil
    {
        #region Methods (2)

        // Public Methods (2) 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void FormatFloatToPercent(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType == typeof(string) && e.Value != null)
            {
                e.Value = (double)e.Value * 100 + "%";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void ParsePercentToFloat(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType == typeof(System.Nullable<double>) && e.Value != null)
            {
                e.Value = Double.Parse(e.Value.ToString()) / 100;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool ConvertStrToBool(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            string str = String.Format("{0:G}", obj);
            if (string.Empty.Equals(str))
            {
                return false;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="double1"></param>
        /// <returns></returns>
        public static bool EqualsZero(double? double1)
        {
            if (double1 == null)
            {
                return false;
            }
            return (Math.Abs(double1.Value) <= 0.0000001);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="double1"></param>
        /// <returns></returns>
        public static bool GreaterZero(double? double1)
        {
            if (double1 == null)
            {
                return false;
            }
            return (double1 >= 0.0000001);
        }
        #endregion Methods
    }
}
