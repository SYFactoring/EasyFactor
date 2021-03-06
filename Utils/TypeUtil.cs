//-----------------------------------------------------------------------
// <copyright file="TypeUtil.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CMBC.EasyFactor.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public static class TypeUtil
    {

        public static readonly DateTime MIN_DATE = new DateTime(1753, 1, 1);

        //?Public?Methods?(12)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ConvertBoolToStr(bool? obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }

            return obj.Value ? "Y" : "N";
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
            if (String.IsNullOrEmpty(str))
            {
                return false;
            }

            return "Y".Equals(str, StringComparison.OrdinalIgnoreCase) ||
                   "Yes".Equals(str, StringComparison.OrdinalIgnoreCase) ||
                   "True".Equals(str, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string ConvertToChineseMoney(decimal? number)
        {
            if (number == null)
            {
                return string.Empty;
            }

            decimal input = number.Value;
            string result =
                input.ToString(
                    "#穰'.'#仟#佰#拾#秭'.'#仟#佰#拾#垓'.'#仟#佰#拾#京'.'#仟#佰#拾#兆'.'#仟#佰#拾#亿'.'#仟#佰#拾#万'.'#仟#佰#拾#元.0角0分;负#穰'.'#仟#佰#拾#秭'.'#仟#佰#拾#垓'.'#仟#佰#拾#京'.'#仟#佰#拾#兆'.'#仟#佰#拾#亿'.'#仟#佰#拾#万'.'#仟#佰#拾#元.0角0分;零元");
            // 从字符串左侧开始替换子字符串，遇到汉字“零”或者阿拉伯数字 0 - 9，替换就结束。
            // 替换内容是捕获组 $1，该捕获组表示 0 个或 1 个在字符串最左侧的汉字“负”
            result = Regex.Replace(result, @"^(负?)[^零\d]*", "$1");
            // 替换字符串中以一个 0 开头，后跟一个字符，这种组合的连续。
            // 因为肯定不会出现两个阿拉伯数字连续的情况，所以后跟字符确定为汉字。
            // 规定该汉字不可以匹配汉字“元”。也不可以匹配右侧带“.”的汉字（特殊单位）。
            // 将所有找到的匹配替换为“0”，注意：结果可能会产生“0”的连续的情况。
            result = Regex.Replace(result, @"(0[^元](?!\.))+", "0");
            // 删除字符串最右侧的，或右侧带“.”的汉字左侧的，一个或多个“0”的连续。
            // 所有特殊单位的右侧带“.”，例如“億”“萬”“元”，这保证了上句不会替换它们。
            result = Regex.Replace(result, @"0+(\D\.|$)", "$1");
            // 替换所有以“.”开头的，一个汉字和一个“.”的组合，这是特殊单位左侧的个十百千位都是 0 造成的。
            // 所以删除该特殊单位的字符，左侧会有一个“0”和一个汉字的组合，该组合会包含被删掉的特殊单位的含义。
            result = Regex.Replace(result, @"(?<=\.)[^元]\.", "");
            // 删除掉所有“.”。
            result = Regex.Replace(result, @"\.", "");
            // 如果字符串最后以“元”结束，就换成“元整”。
            result = Regex.Replace(result, @"(元)$", "$1整");
            // 用匿名方法作代理，将每个数字替换成汉字形式。
            result = Regex.Replace(result, @"\d",
                                   m => "零壹贰叁肆伍陆柒捌玖"[m.Value[0] - '0'].ToString());

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void FormatFloatToPercent(object sender, ConvertEventArgs e)
        {
            if (e == null)
            {
                throw new ArgumentNullException("e", @"e cannot be a null reference");
            }

            if (e.DesiredType == typeof(string) && e.Value != null && !String.IsNullOrEmpty(e.Value.ToString()))
            {
                double result;
                bool isOk = Double.TryParse(e.Value.ToString(), out result);
                if (isOk)
                {
                    e.Value = (result * 100) + "%";
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public static string GetExcelCurr(string currency)
        {
            if ("CNY" == currency)
            {
                return "￥#,##0.00";
            }
            return "[$" + currency + "] #,##0.00";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public static string GetExcelCurrency(string currency)
        {
            return "[$" + currency + "] #,##0.00";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void ParsePercentToFloat(object sender, ConvertEventArgs e)
        {
            if (e == null)
            {
                throw new ArgumentNullException("e", @"e cannot be a null reference");
            }

            if ((e.DesiredType == typeof(double) || e.DesiredType == typeof(double?)) && e.Value != null &&
                !String.IsNullOrEmpty(e.Value.ToString()))
            {
                double result;
                bool isOk = Double.TryParse(e.Value.ToString(), out result);
                if (isOk)
                {
                    e.Value = result / 100;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public static string ToPrintCurrency(string currency)
        {
            if ("CNY".Equals(currency))
            {
                return "RMB";
            }
            return currency;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public static string ToPrintCurrencyChinese(string currency)
        {
            if ("CNY".Equals(currency))
            {
                return "人民币";
            }
            else if ("USD".Equals(currency))
            {
                return "美元";
            }
            return currency;
        }

        public static bool GreaterThan(decimal? left, decimal? right)
        {
            if (left.HasValue == false && right.HasValue == false)
            {
                return false;
            }
            if (left.HasValue == true && right.HasValue == false)
            {
                return true;
            }
            if(left.HasValue==false&&right.HasValue==true)
            {
                return false;
            }
            decimal diff = new decimal(0.01);
            if (left - right > diff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool LessThan(decimal? left, decimal? right)
        {
            if (left.HasValue == false && right.HasValue == false)
            {
                return false;
            }
            if (left.HasValue == true && right.HasValue == false)
            {
                return false;
            }
            if (left.HasValue == false && right.HasValue == true)
            {
                return true;
            }
            decimal diff = new decimal(-0.01);
            if (left - right < diff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EqualThan(decimal? left, decimal? right)
        {
            if (left.HasValue == false && right.HasValue == false)
            {
                return false;
            }
            if (left.HasValue == true && right.HasValue == false)
            {
                return false;
            }
            if (left.HasValue == false && right.HasValue == true)
            {
                return false;
            }
            decimal diff = new decimal(0.01);
            decimal minusdiff= new decimal(-0.01);
            if ((left - right < diff)&&(left-right>minusdiff))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}