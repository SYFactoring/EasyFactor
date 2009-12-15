using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using System;

namespace CMBC.EasyFactor.Utils
{
    class ControlUtil
    {
        public static void setComponetDefault(Control comp)
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

        public static void setComponetEditable(Control comp, bool isEditable)
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
    }
}
