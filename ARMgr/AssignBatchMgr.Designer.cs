namespace CMBC.EasyFactor.ARMgr
{
    partial class AssignBatchMgr
    {
        #region Fields (7)

        private DevComponents.DotNetBar.ButtonX btnAssignBatchQuery;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvAssignBatch;
        private DevComponents.DotNetBar.LabelX lblAssignBatchNo;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAssignBatchNo;

        #endregion Fields

        #region Methods (1)

        // Protected Methods (1) 

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

        #endregion Methods



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.btnAssignBatchQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbAssignBatchNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAssignBatchNo = new DevComponents.DotNetBar.LabelX();
            this.dgvAssignBatch = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.btnAssignBatchQuery);
            this.panelQuery.Controls.Add(this.tbAssignBatchNo);
            this.panelQuery.Controls.Add(this.lblAssignBatchNo);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(424, 36);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 0;
            // 
            // btnAssignBatchQuery
            // 
            this.btnAssignBatchQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAssignBatchQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAssignBatchQuery.Location = new System.Drawing.Point(186, 3);
            this.btnAssignBatchQuery.Name = "btnAssignBatchQuery";
            this.btnAssignBatchQuery.Size = new System.Drawing.Size(75, 23);
            this.btnAssignBatchQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAssignBatchQuery.TabIndex = 2;
            this.btnAssignBatchQuery.Text = "Q";
            this.btnAssignBatchQuery.Click += new System.EventHandler(this.QueryAssignBatch);
            // 
            // tbAssignBatchNo
            // 
            // 
            // 
            // 
            this.tbAssignBatchNo.Border.Class = "TextBoxBorder";
            this.tbAssignBatchNo.Location = new System.Drawing.Point(69, 3);
            this.tbAssignBatchNo.Name = "tbAssignBatchNo";
            this.tbAssignBatchNo.Size = new System.Drawing.Size(100, 20);
            this.tbAssignBatchNo.TabIndex = 1;
            // 
            // lblAssignBatchNo
            // 
            this.lblAssignBatchNo.AutoSize = true;
            // 
            // 
            // 
            this.lblAssignBatchNo.BackgroundStyle.Class = "";
            this.lblAssignBatchNo.Location = new System.Drawing.Point(4, 4);
            this.lblAssignBatchNo.Name = "lblAssignBatchNo";
            this.lblAssignBatchNo.Size = new System.Drawing.Size(59, 16);
            this.lblAssignBatchNo.TabIndex = 0;
            this.lblAssignBatchNo.Text = "转让批号:";
            // 
            // dgvAssignBatch
            // 
            this.dgvAssignBatch.AllowUserToAddRows = false;
            this.dgvAssignBatch.AllowUserToDeleteRows = false;
            this.dgvAssignBatch.AllowUserToOrderColumns = true;
            this.dgvAssignBatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignBatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssignBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAssignBatchNo,
            this.colBatchCurrency,
            this.colBatchDate,
            this.colCreateUserName,
            this.colComment});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignBatch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAssignBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignBatch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvAssignBatch.Location = new System.Drawing.Point(0, 36);
            this.dgvAssignBatch.MultiSelect = false;
            this.dgvAssignBatch.Name = "dgvAssignBatch";
            this.dgvAssignBatch.ReadOnly = true;
            this.dgvAssignBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignBatch.Size = new System.Drawing.Size(424, 173);
            this.dgvAssignBatch.TabIndex = 1;
            this.dgvAssignBatch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectAssignBatch);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AssignBatchNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "转让批号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BatchCurrency";
            this.dataGridViewTextBoxColumn2.HeaderText = "批次币种";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BatchDate";
            dataGridViewCellStyle4.Format = "d";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.HeaderText = "转让日期";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CreateUserName";
            this.dataGridViewTextBoxColumn4.HeaderText = "经办人";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn5.HeaderText = "备注";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // colAssignBatchNo
            // 
            this.colAssignBatchNo.DataPropertyName = "AssignBatchNo";
            this.colAssignBatchNo.HeaderText = "转让批号";
            this.colAssignBatchNo.Name = "colAssignBatchNo";
            this.colAssignBatchNo.ReadOnly = true;
            // 
            // colBatchCurrency
            // 
            this.colBatchCurrency.DataPropertyName = "BatchCurrency";
            this.colBatchCurrency.HeaderText = "批次币种";
            this.colBatchCurrency.Name = "colBatchCurrency";
            this.colBatchCurrency.ReadOnly = true;
            // 
            // colBatchDate
            // 
            this.colBatchDate.DataPropertyName = "BatchDate";
            dataGridViewCellStyle2.Format = "d";
            this.colBatchDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colBatchDate.HeaderText = "转让日期";
            this.colBatchDate.Name = "colBatchDate";
            this.colBatchDate.ReadOnly = true;
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
            // AssignBatchMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAssignBatch);
            this.Controls.Add(this.panelQuery);
            this.Name = "AssignBatchMgr";
            this.Size = new System.Drawing.Size(424, 209);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignBatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
