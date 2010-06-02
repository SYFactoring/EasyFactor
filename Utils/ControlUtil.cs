//-----------------------------------------------------------------------
// <copyright file="ControlUtil.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace CMBC.EasyFactor.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public static class ControlUtil
    {


        //?Public?Methods?(4)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="btn"></param>
        public static void AddEnterListenersForQuery(Control.ControlCollection controls, IButtonControl btn)
        {
            if (controls == null)
            {
                return;
            }

            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    control.KeyDown += delegate(object sender, KeyEventArgs e)
                                           {
                                               if (e.KeyCode == Keys.Enter)
                                               {
                                                   btn.PerformClick();
                                               }
                                           };
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comp"></param>
        public static void SetComponetDefault(Control comp)
        {
            var textControl = comp as TextBoxBase;
            if (textControl != null)
            {
                textControl.Text = string.Empty;
                return;
            }

            var comboControl = comp as ComboBox;
            if (comboControl != null)
            {
                comboControl.SelectedIndex = -1;
                return;
            }

            var treeControl = comp as ComboTree;
            if (treeControl != null)
            {
                treeControl.SelectedIndex = -1;
                return;
            }

            var timePickerControl = comp as DateTimePicker;
            if (timePickerControl != null)
            {
                timePickerControl.Value = default(DateTime);
                return;
            }

            var timeInputControl = comp as DateTimeInput;
            if (timeInputControl != null)
            {
                timeInputControl.Value = default(DateTime);
                return;
            }

            var listBoxControl = comp as CheckedListBox;
            if (listBoxControl != null)
            {
                listBoxControl.ClearSelected();
                for (int i = 0; i < listBoxControl.Items.Count; i++)
                {
                    listBoxControl.SetItemChecked(i, false);
                }

                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comp"></param>
        /// <param name="isEditable"></param>
        public static void SetComponetEditable(Control comp, bool isEditable)
        {
            if (comp == null)
            {
                return;
            }

            var textControl = comp as TextBoxBase;
            if (textControl != null)
            {
                textControl.ReadOnly = !isEditable;
                return;
            }

            var comboControl = comp as ComboBox;
            if (comboControl != null)
            {
                comboControl.Enabled = isEditable;
                return;
            }

            var treeControl = comp as ComboTree;
            if (treeControl != null)
            {
                treeControl.Enabled = isEditable;
                return;
            }

            var timePickerControl = comp as DateTimePicker;
            if (timePickerControl != null)
            {
                timePickerControl.Enabled = isEditable;
                return;
            }

            var timeInputControl = comp as DateTimeInput;
            if (timeInputControl != null)
            {
                timeInputControl.Enabled = isEditable;
                return;
            }

            var listBoxControl = comp as CheckedListBox;
            if (listBoxControl != null)
            {
                listBoxControl.Enabled = isEditable;
                return;
            }

            var checkBoxControl = comp as CheckBoxX;
            if (checkBoxControl != null)
            {
                checkBoxControl.Enabled = isEditable;
                return;
            }
        }

        /// <summary>
        /// set instance non-public property with name "DoubleBuffered" to true
        /// </summary>
        /// <param name="control"></param>
        public static void SetDoubleBuffered(Control control)
        {
            typeof (Control).InvokeMember("DoubleBuffered",
                                          BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                                          null, control, new object[] {true}, CultureInfo.CurrentCulture);
        }
    }
}