﻿
namespace CMBC.EasyFactor.Utils
{
    using System.Windows.Forms;
    using DevComponents.DotNetBar.Controls;
    using DevComponents.DotNetBar;
    using System;
    using System.Reflection;

    /// <summary>
    /// 
    /// </summary>
    public class ControlUtil
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="comp"></param>
        public static void SetComponetDefault(Control comp)
        {
            if (comp is TextBoxX)
            {
                (comp as TextBoxX).Text = string.Empty;
            }
            else if (comp is TextBox)
            {
                (comp as TextBox).Text = string.Empty;
            }
            else if (comp is ComboBoxEx)
            {
                (comp as ComboBoxEx).SelectedIndex = -1;
            }
            else if (comp is ComboTree)
            {
                (comp as ComboTree).SelectedIndex = -1;
            }
            else if (comp is ComboBox)
            {
                (comp as ComboBox).SelectedIndex = -1;
            }
            else if (comp is DateTimePicker)
            {
                (comp as DateTimePicker).Value = DateTime.Now;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comp"></param>
        /// <param name="isEditable"></param>
        public static void SetComponetEditable(Control comp, bool isEditable)
        {
            if (comp is TextBoxX)
            {
                (comp as TextBoxX).ReadOnly = !isEditable;
            }
            else if (comp is TextBox)
            {
                (comp as TextBox).ReadOnly = !isEditable;
            }
            //else if (comp is ButtonX)
            //{
            //    (comp as ButtonX).Enabled = isEditable;
            //}
            //else if (comp is Button)
            //{
            //    (comp as Button).Enabled = isEditable;
            //}
            else if (comp is ComboBoxEx)
            {
                (comp as ComboBoxEx).Enabled = isEditable;
            }
            else if (comp is ComboTree)
            {
                (comp as ComboTree).Enabled = isEditable;
            }
            else if (comp is ComboBox)
            {
                (comp as ComboBox).Enabled = isEditable;
            }
            else if (comp is DateTimePicker)
            {
                (comp as DateTimePicker).Enabled = isEditable;
            }
        }

        /// <summary>
        /// set instance non-public property with name "DoubleBuffered" to true
        /// </summary>
        /// <param name="control"></param>
        public static void SetDoubleBuffered(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, control, new object[] { true });
        }

    }
}
