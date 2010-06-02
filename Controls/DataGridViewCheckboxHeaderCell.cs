//-----------------------------------------------------------------------
// <copyright file="DataGridViewCheckboxHeaderCell.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CMBC.EasyFactor.Controls
{
    //定义触发单击事件的委托 
    internal delegate void DataGridViewCheckboxHeaderEventHander(object sender, DataGridViewCheckboxHeaderEventArgs e);

    //定义包含列头checkbox选择状态的参数类 
    internal class DataGridViewCheckboxHeaderEventArgs : EventArgs
    {
        public bool CheckedState { get; set; }
    }


    //定义继承于DataGridViewColumnHeaderCell的类，用于绘制checkbox，定义checkbox鼠标单击事件
    internal class DataGridViewCheckboxHeaderCell : DataGridViewColumnHeaderCell
    {
        private CheckBoxState _cbState =
            CheckBoxState.UncheckedNormal;

        private Point _cellLocation;
        private bool _checked;
        private Point _checkBoxLocation;
        private Size _checkBoxSize;


        //?Events?(1)?
        public event DataGridViewCheckboxHeaderEventHander OnCheckBoxClicked;


        //?Protected?Methods?(2)?
        /// <summary> 
        /// 点击列头checkbox单击事件 
        /// </summary> 
        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            var p = new Point(e.X + _cellLocation.X, e.Y + _cellLocation.Y);
            if (p.X >= _checkBoxLocation.X && p.X <=
                                             _checkBoxLocation.X + _checkBoxSize.Width
                && p.Y >= _checkBoxLocation.Y && p.Y <=
                _checkBoxLocation.Y + _checkBoxSize.Height)
            {
                _checked = !_checked;

                //获取列头checkbox的选择状态 
                var ex = new DataGridViewCheckboxHeaderEventArgs {CheckedState = _checked};

                var sender = new object(); //此处不代表选择的列头checkbox，只是作为参数传递。应该列头checkbox是绘制出来的，无法获得它的实例

                if (OnCheckBoxClicked != null)
                {
                    OnCheckBoxClicked(sender, ex); //触发单击事件 
                    DataGridView.InvalidateCell(this);
                }
            }
            base.OnMouseClick(e);
        }

        //绘制列头checkbox 
        protected override void Paint(Graphics graphics,
                                      Rectangle clipBounds,
                                      Rectangle cellBounds,
                                      int rowIndex,
                                      DataGridViewElementStates dataGridViewElementState,
                                      object value,
                                      object formattedValue,
                                      string errorText,
                                      DataGridViewCellStyle cellStyle,
                                      DataGridViewAdvancedBorderStyle advancedBorderStyle,
                                      DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                       dataGridViewElementState, value,
                       formattedValue, errorText, cellStyle,
                       advancedBorderStyle, paintParts);
            var p = new Point();
            Size s = CheckBoxRenderer.GetGlyphSize(graphics,
                                                   CheckBoxState.UncheckedNormal);
            p.X = cellBounds.Location.X +
                  (cellBounds.Width/2) - (s.Width/2) - 1; //列头checkbox的X坐标 
            p.Y = cellBounds.Location.Y +
                  (cellBounds.Height/2) - (s.Height/2); //列头checkbox的Y坐标 
            _cellLocation = cellBounds.Location;
            _checkBoxLocation = p;
            _checkBoxSize = s;
            _cbState = _checked ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal;
            CheckBoxRenderer.DrawCheckBox
                (graphics, _checkBoxLocation, _cbState);
        }
    }
}