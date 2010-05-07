//-----------------------------------------------------------------------
// <copyright file="ControlUtil.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Utils
{
    using System;
    using System.Reflection;
    using System.Windows.Forms;
    using DevComponents.DotNetBar.Controls;
    using DevComponents.Editors.DateTimeAdv;
    using System.Globalization;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ControlUtil
    {
		#region?Constructors?(1)?

        private ControlUtil()
        {
        }

		#endregion?Constructors?

		#region?Methods?(4)?

		//?Public?Methods?(4)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="btn"></param>
        public static void AddEnterListenersForQuery(Control.ControlCollection controls, IButtonControl btn)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox || control is TextBoxX)
                {
                    control.KeyDown += new KeyEventHandler(delegate(object sender, KeyEventArgs e)
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            btn.PerformClick();
                        }
                    });
                }
            }
        }

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
                (comp as DateTimePicker).Value = default(DateTime);
            }
            else if (comp is DateTimeInput)
            {
                (comp as DateTimeInput).Value = default(DateTime);
            }
            else if (comp is CheckedListBox)
            {
                (comp as CheckedListBox).ClearSelected();
                for (int i = 0; i < (comp as CheckedListBox).Items.Count; i++)
                {
                    (comp as CheckedListBox).SetItemChecked(i, false);
                }
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
            else if (comp is CheckBoxX)
            {
                (comp as CheckBoxX).Enabled = isEditable;
            }
            else if (comp is DateTimePicker)
            {
                (comp as DateTimePicker).Enabled = isEditable;
            }
            else if (comp is DateTimeInput)
            {
                (comp as DateTimeInput).Enabled = isEditable;
            }
            else if (comp is CheckedListBox)
            {
                (comp as CheckedListBox).Enabled = isEditable;
            }
        }

        /// <summary>
        /// set instance non-public property with name "DoubleBuffered" to true
        /// </summary>
        /// <param name="control"></param>
        public static void SetDoubleBuffered(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, control, new object[] { true }, CultureInfo.CurrentCulture);
        }

		#endregion?Methods?
    }
}
