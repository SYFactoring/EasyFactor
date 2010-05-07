//-----------------------------------------------------------------------
// <copyright file="DataGridViewCheckboxHeaderCell.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Controls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    //���崥�������¼���ί�� 
    delegate void DataGridViewCheckboxHeaderEventHander(object sender, DataGridViewCheckboxHeaderEventArgs e);

    //���������ͷcheckboxѡ��״̬�Ĳ����� 
    class DataGridViewCheckboxHeaderEventArgs : EventArgs
    {
		#region?Properties?(1)?

        public bool CheckedState
        {
            get;
            set;
        }

		#endregion?Properties?
    }


    //����̳���DataGridViewColumnHeaderCell���࣬���ڻ���checkbox������checkbox��굥���¼�
    class DataGridViewCheckboxHeaderCell : DataGridViewColumnHeaderCell
    {
		#region?Fields?(5)?

        System.Windows.Forms.VisualStyles.CheckBoxState _cbState =
            System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal;
        Point _cellLocation = new Point();
        bool _checked = false;
        Point checkBoxLocation;
        Size checkBoxSize;

		#endregion?Fields?

		#region?Delegates?and?Events?(1)?

		//?Events?(1)?

        public event DataGridViewCheckboxHeaderEventHander OnCheckBoxClicked;

		#endregion?Delegates?and?Events?

		#region?Methods?(2)?

		//?Protected?Methods?(2)?

        /// <summary> 
        /// �����ͷcheckbox�����¼� 
        /// </summary> 
        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            if (e == null)
            {
                throw new ArgumentNullException("DataGridViewCellMouseEventArgs");
            }

            Point p = new Point(e.X + _cellLocation.X, e.Y + _cellLocation.Y);
            if (p.X >= checkBoxLocation.X && p.X <=
                checkBoxLocation.X + checkBoxSize.Width
            && p.Y >= checkBoxLocation.Y && p.Y <=
                checkBoxLocation.Y + checkBoxSize.Height)
            {
                _checked = !_checked;

                //��ȡ��ͷcheckbox��ѡ��״̬ 
                DataGridViewCheckboxHeaderEventArgs ex = new DataGridViewCheckboxHeaderEventArgs();
                ex.CheckedState = _checked;

                object sender = new object();//�˴�������ѡ�����ͷcheckbox��ֻ����Ϊ�������ݡ�Ӧ����ͷcheckbox�ǻ��Ƴ����ģ��޷��������ʵ��

                if (OnCheckBoxClicked != null)
                {
                    OnCheckBoxClicked(sender, ex);//���������¼� 
                    this.DataGridView.InvalidateCell(this);
                }
            }
            base.OnMouseClick(e);
        }

        //������ͷcheckbox 
        protected override void Paint(System.Drawing.Graphics graphics,
          System.Drawing.Rectangle clipBounds,
          System.Drawing.Rectangle cellBounds,
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
            Point p = new Point();
            Size s = CheckBoxRenderer.GetGlyphSize(graphics,
            System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            p.X = cellBounds.Location.X +
                (cellBounds.Width / 2) - (s.Width / 2) - 1;//��ͷcheckbox��X���� 
            p.Y = cellBounds.Location.Y +
                (cellBounds.Height / 2) - (s.Height / 2);//��ͷcheckbox��Y���� 
            _cellLocation = cellBounds.Location;
            checkBoxLocation = p;
            checkBoxSize = s;
            if (_checked)
                _cbState = System.Windows.Forms.VisualStyles.
                    CheckBoxState.CheckedNormal;
            else
                _cbState = System.Windows.Forms.VisualStyles.
                    CheckBoxState.UncheckedNormal;
            CheckBoxRenderer.DrawCheckBox
            (graphics, checkBoxLocation, _cbState);
        }

		#endregion?Methods?
    }
}
