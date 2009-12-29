namespace CMBC.EasyFactor.ARMgr
{
    partial class FinanceBatchMgr
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.btnFinanceBatchQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbFinanceBatchNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFinanceBatchNo = new DevComponents.DotNetBar.LabelX();
            this.dgvFinanceBatch = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colFinanceBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinancePeriodBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinancePeriodEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinnaceRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterestType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.btnFinanceBatchQuery);
            this.panelQuery.Controls.Add(this.tbFinanceBatchNo);
            this.panelQuery.Controls.Add(this.lblFinanceBatchNo);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(569, 35);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 0;
            // 
            // btnFinanceBatchQuery
            // 
            this.btnFinanceBatchQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchQuery.Location = new System.Drawing.Point(171, 6);
            this.btnFinanceBatchQuery.Name = "btnFinanceBatchQuery";
            this.btnFinanceBatchQuery.Size = new System.Drawing.Size(75, 23);
            this.btnFinanceBatchQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinanceBatchQuery.TabIndex = 2;
            this.btnFinanceBatchQuery.Text = "查询";
            this.btnFinanceBatchQuery.Click += new System.EventHandler(this.QueryFinanceBatch);
            // 
            // tbFinanceBatchNo
            // 
            // 
            // 
            // 
            this.tbFinanceBatchNo.Border.Class = "TextBoxBorder";
            this.tbFinanceBatchNo.Location = new System.Drawing.Point(65, 6);
            this.tbFinanceBatchNo.Name = "tbFinanceBatchNo";
            this.tbFinanceBatchNo.Size = new System.Drawing.Size(100, 20);
            this.tbFinanceBatchNo.TabIndex = 1;
            // 
            // lblFinanceBatchNo
            // 
            this.lblFinanceBatchNo.AutoSize = true;
            // 
            // 
            // 
            this.lblFinanceBatchNo.BackgroundStyle.Class = "";
            this.lblFinanceBatchNo.Location = new System.Drawing.Point(3, 10);
            this.lblFinanceBatchNo.Name = "lblFinanceBatchNo";
            this.lblFinanceBatchNo.Size = new System.Drawing.Size(56, 16);
            this.lblFinanceBatchNo.TabIndex = 0;
            this.lblFinanceBatchNo.Text = "融资编号";
            // 
            // dgvFinanceBatch
            // 
            this.dgvFinanceBatch.AllowUserToAddRows = false;
            this.dgvFinanceBatch.AllowUserToDeleteRows = false;
            this.dgvFinanceBatch.AllowUserToOrderColumns = true;
            this.dgvFinanceBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinanceBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFinanceBatchNo,
            this.colFinanceType,
            this.colBatchCurrency,
            this.colFinanceAmount,
            this.colFinancePeriodBegin,
            this.colFinancePeriodEnd,
            this.colFinnaceRate,
            this.colInterestType,
            this.colFactor,
            this.colCostRate,
            this.colCreateUserName,
            this.colComment});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinanceBatch.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFinanceBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFinanceBatch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFinanceBatch.Location = new System.Drawing.Point(0, 35);
            this.dgvFinanceBatch.Name = "dgvFinanceBatch";
            this.dgvFinanceBatch.ReadOnly = true;
            this.dgvFinanceBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinanceBatch.Size = new System.Drawing.Size(569, 402);
            this.dgvFinanceBatch.TabIndex = 1;
            this.dgvFinanceBatch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectFinanceBatch);
            // 
            // colFinanceBatchNo
            // 
            this.colFinanceBatchNo.DataPropertyName = "FinanceBatchNo";
            this.colFinanceBatchNo.HeaderText = "融资批号";
            this.colFinanceBatchNo.Name = "colFinanceBatchNo";
            this.colFinanceBatchNo.ReadOnly = true;
            // 
            // colFinanceType
            // 
            this.colFinanceType.DataPropertyName = "FinanceType";
            this.colFinanceType.HeaderText = "融资类型";
            this.colFinanceType.Name = "colFinanceType";
            this.colFinanceType.ReadOnly = true;
            // 
            // colBatchCurrency
            // 
            this.colBatchCurrency.DataPropertyName = "BatchCurrency";
            this.colBatchCurrency.HeaderText = "批次币种";
            this.colBatchCurrency.Name = "colBatchCurrency";
            this.colBatchCurrency.ReadOnly = true;
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle1.Format = "N2";
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.colFinanceAmount.HeaderText = "融资金额";
            this.colFinanceAmount.Name = "colFinanceAmount";
            this.colFinanceAmount.ReadOnly = true;
            // 
            // colFinancePeriodBegin
            // 
            this.colFinancePeriodBegin.DataPropertyName = "FinancePeriodBegin";
            dataGridViewCellStyle2.Format = "d";
            this.colFinancePeriodBegin.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFinancePeriodBegin.HeaderText = "融资期限(起)";
            this.colFinancePeriodBegin.Name = "colFinancePeriodBegin";
            this.colFinancePeriodBegin.ReadOnly = true;
            this.colFinancePeriodBegin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFinancePeriodBegin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colFinancePeriodEnd
            // 
            this.colFinancePeriodEnd.DataPropertyName = "FinancePeriodEnd";
            dataGridViewCellStyle3.Format = "d";
            this.colFinancePeriodEnd.DefaultCellStyle = dataGridViewCellStyle3;
            this.colFinancePeriodEnd.HeaderText = "融资期限(终)";
            this.colFinancePeriodEnd.Name = "colFinancePeriodEnd";
            this.colFinancePeriodEnd.ReadOnly = true;
            this.colFinancePeriodEnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFinancePeriodEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colFinnaceRate
            // 
            this.colFinnaceRate.DataPropertyName = "FinnaceRate";
            dataGridViewCellStyle4.Format = "p";
            dataGridViewCellStyle4.NullValue = null;
            this.colFinnaceRate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colFinnaceRate.HeaderText = "融资利率";
            this.colFinnaceRate.Name = "colFinnaceRate";
            this.colFinnaceRate.ReadOnly = true;
            // 
            // colInterestType
            // 
            this.colInterestType.DataPropertyName = "InterestType";
            this.colInterestType.HeaderText = "计息方式";
            this.colInterestType.Name = "colInterestType";
            this.colInterestType.ReadOnly = true;
            // 
            // colFactor
            // 
            this.colFactor.DataPropertyName = "Factor";
            this.colFactor.HeaderText = "代付行";
            this.colFactor.Name = "colFactor";
            this.colFactor.ReadOnly = true;
            // 
            // colCostRate
            // 
            this.colCostRate.DataPropertyName = "CostRate";
            dataGridViewCellStyle5.Format = "p";
            this.colCostRate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCostRate.HeaderText = "代付费率";
            this.colCostRate.Name = "colCostRate";
            this.colCostRate.ReadOnly = true;
            // 
            // colCreateUserName
            // 
            this.colCreateUserName.DataPropertyName = "CreateUserName";
            this.colCreateUserName.HeaderText = "经办人";
            this.colCreateUserName.Name = "colCreateUserName";
            this.colCreateUserName.ReadOnly = true;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            // 
            // FinanceBatchMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvFinanceBatch);
            this.Controls.Add(this.panelQuery);
            this.Name = "FinanceBatchMgr";
            this.Size = new System.Drawing.Size(569, 437);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceBatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceBatchNo;
        private DevComponents.DotNetBar.LabelX lblFinanceBatchNo;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFinanceBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinancePeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinancePeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinnaceRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterestType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
    }
}
