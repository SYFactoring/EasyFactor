using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.Utils
{
    class ControlUtil
    {
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
            else if (comp is ButtonX)
            {
                (comp as ButtonX).Enabled = isEditable;
            }
            else if (comp is Button)
            {
                (comp as Button).Enabled = isEditable;
            }
            else if (comp is ComboBoxEx)
            {
                (comp as ComboBoxEx).Enabled = isEditable;
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
