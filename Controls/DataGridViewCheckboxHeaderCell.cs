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
    //���崥�������¼���ί�� 
    internal delegate void DataGridViewCheckboxHeaderEventHander(object sender, DataGridViewCheckboxHeaderEventArgs e);

    //���������ͷcheckboxѡ��״̬�Ĳ����� 
    internal class DataGridViewCheckboxHeaderEventArgs : EventArgs
    {
        public bool CheckedState { get; set; }
    }


    //����̳���DataGridViewColumnHeaderCell���࣬���ڻ���checkbox������checkbox��굥���¼�
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
        /// �����ͷcheckbox�����¼� 
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

                //��ȡ��ͷcheckbox��ѡ��״̬ 
                var ex = new DataGridViewCheckboxHeaderEventArgs {CheckedState = _checked};

                var sender = new object(); //�˴�������ѡ�����ͷcheckbox��ֻ����Ϊ�������ݡ�Ӧ����ͷcheckbox�ǻ��Ƴ����ģ��޷��������ʵ��

                if (OnCheckBoxClicked != null)
                {
                    OnCheckBoxClicked(sender, ex); //���������¼� 
                    DataGridView.InvalidateCell(this);
                }
            }
            base.OnMouseClick(e);
        }

        //������ͷcheckbox 
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
                  (cellBounds.Width/2) - (s.Width/2) - 1; //��ͷcheckbox��X���� 
            p.Y = cellBounds.Location.Y +
                  (cellBounds.Height/2) - (s.Height/2); //��ͷcheckbox��Y���� 
            _cellLocation = cellBounds.Location;
            _checkBoxLocation = p;
            _checkBoxSize = s;
            _cbState = _checked ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal;
            CheckBoxRenderer.DrawCheckBox
                (graphics, _checkBoxLocation, _cbState);
        }
    }
}