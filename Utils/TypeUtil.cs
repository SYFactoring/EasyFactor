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
                    "#�'.'#Ǫ#��#ʰ#��'.'#Ǫ#��#ʰ#��'.'#Ǫ#��#ʰ#��'.'#Ǫ#��#ʰ#��'.'#Ǫ#��#ʰ#��'.'#Ǫ#��#ʰ#��'.'#Ǫ#��#ʰ#Ԫ.0��0��;��#�'.'#Ǫ#��#ʰ#��'.'#Ǫ#��#ʰ#��'.'#Ǫ#��#ʰ#��'.'#Ǫ#��#ʰ#��'.'#Ǫ#��#ʰ#��'.'#Ǫ#��#ʰ#��'.'#Ǫ#��#ʰ#Ԫ.0��0��;��Ԫ");
            // ���ַ�����࿪ʼ�滻���ַ������������֡��㡱���߰��������� 0 - 9���滻�ͽ�����
            // �滻�����ǲ����� $1���ò������ʾ 0 ���� 1 �����ַ��������ĺ��֡�����
            result = Regex.Replace(result, @"^(��?)[^��\d]*", "$1");
            // �滻�ַ�������һ�� 0 ��ͷ�����һ���ַ���������ϵ�������
            // ��Ϊ�϶������������������������������������Ժ���ַ�ȷ��Ϊ���֡�
            // �涨�ú��ֲ�����ƥ�人�֡�Ԫ����Ҳ������ƥ���Ҳ����.���ĺ��֣����ⵥλ����
            // �������ҵ���ƥ���滻Ϊ��0����ע�⣺������ܻ������0���������������
            result = Regex.Replace(result, @"(0[^Ԫ](?!\.))+", "0");
            // ɾ���ַ������Ҳ�ģ����Ҳ����.���ĺ������ģ�һ��������0����������
            // �������ⵥλ���Ҳ����.�������硰�|�����f����Ԫ�����Ᵽ֤���Ͼ䲻���滻���ǡ�
            result = Regex.Replace(result, @"0+(\D\.|$)", "$1");
            // �滻�����ԡ�.����ͷ�ģ�һ�����ֺ�һ����.������ϣ��������ⵥλ���ĸ�ʮ��ǧλ���� 0 ��ɵġ�
            // ����ɾ�������ⵥλ���ַ���������һ����0����һ�����ֵ���ϣ�����ϻ������ɾ�������ⵥλ�ĺ��塣
            result = Regex.Replace(result, @"(?<=\.)[^Ԫ]\.", "");
            // ɾ�������С�.����
            result = Regex.Replace(result, @"\.", "");
            // ����ַ�������ԡ�Ԫ���������ͻ��ɡ�Ԫ������
            result = Regex.Replace(result, @"(Ԫ)$", "$1��");
            // ������������������ÿ�������滻�ɺ�����ʽ��
            result = Regex.Replace(result, @"\d",
                                   m => "��Ҽ��������½��ƾ�"[m.Value[0] - '0'].ToString());

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
                return "��#,##0.00";
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
                return "�����";
            }
            return currency;
        }
    }
}