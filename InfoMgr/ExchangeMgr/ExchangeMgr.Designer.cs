//-----------------------------------------------------------------------
// <copyright file="ExchangeMgr.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ExchangeMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ExchangeMgr
    {
        #region Fields (5)

        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvExchange;

        #endregion Fields

        #region Methods (1)

        // Protected Methods (1) 

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #endregion Methods

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvExchange = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colFromCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExchangeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchange)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExchange
            // 
            this.dgvExchange.AllowUserToAddRows = false;
            this.dgvExchange.AllowUserToDeleteRows = false;
            this.dgvExchange.AllowUserToOrderColumns = true;
            this.dgvExchange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExchange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFromCurr,
            this.colToCurr,
            this.colExchangeRate,
            this.colLastModifiedDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExchange.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExchange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExchange.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvExchange.Location = new System.Drawing.Point(0, 0);
            this.dgvExchange.Name = "dgvExchange";
            this.dgvExchange.ReadOnly = true;
            this.dgvExchange.Size = new System.Drawing.Size(580, 360);
            this.dgvExchange.TabIndex = 0;
            // 
            // colFromCurr
            // 
            this.colFromCurr.DataPropertyName = "FromCurr";
            this.colFromCurr.HeaderText = "币别";
            this.colFromCurr.Name = "colFromCurr";
            this.colFromCurr.ReadOnly = true;
            // 
            // colToCurr
            // 
            this.colToCurr.DataPropertyName = "ToCurr";
            this.colToCurr.HeaderText = "币别";
            this.colToCurr.Name = "colToCurr";
            this.colToCurr.ReadOnly = true;
            // 
            // colExchangeRate
            // 
            this.colExchangeRate.DataPropertyName = "ExchangeRate";
            this.colExchangeRate.HeaderText = "汇率";
            this.colExchangeRate.Name = "colExchangeRate";
            this.colExchangeRate.ReadOnly = true;
            // 
            // colLastModifiedDate
            // 
            this.colLastModifiedDate.DataPropertyName = "LastModifiedDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.colLastModifiedDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colLastModifiedDate.HeaderText = "更新日期";
            this.colLastModifiedDate.Name = "colLastModifiedDate";
            this.colLastModifiedDate.ReadOnly = true;
            // 
            // ExchangeMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvExchange);
            this.Name = "ExchangeMgr";
            this.Size = new System.Drawing.Size(580, 360);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colFromCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExchangeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastModifiedDate;
    }
}
