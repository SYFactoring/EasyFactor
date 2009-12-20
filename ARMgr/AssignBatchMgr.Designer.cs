namespace CMBC.EasyFactor.ARMgr
{
    partial class AssignBatchMgr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.btnAssignBatchQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbAssignBatchNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAssignBatchNo = new DevComponents.DotNetBar.LabelX();
            this.dgvAssignBatch = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.AssignBatchNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelQuery.Size = new System.Drawing.Size(467, 36);
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
            this.dgvAssignBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignBatchNoColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignBatch.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssignBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignBatch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvAssignBatch.Location = new System.Drawing.Point(0, 36);
            this.dgvAssignBatch.MultiSelect = false;
            this.dgvAssignBatch.Name = "dgvAssignBatch";
            this.dgvAssignBatch.ReadOnly = true;
            this.dgvAssignBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignBatch.Size = new System.Drawing.Size(467, 293);
            this.dgvAssignBatch.TabIndex = 1;
            this.dgvAssignBatch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectAssignBatch);
            // 
            // AssignBatchNoColumn
            // 
            this.AssignBatchNoColumn.DataPropertyName = "AssignBatchNo";
            this.AssignBatchNoColumn.HeaderText = "转让批号";
            this.AssignBatchNoColumn.Name = "AssignBatchNoColumn";
            this.AssignBatchNoColumn.ReadOnly = true;
            // 
            // AssignBatchMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAssignBatch);
            this.Controls.Add(this.panelQuery);
            this.Name = "AssignBatchMgr";
            this.Size = new System.Drawing.Size(467, 329);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignBatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.LabelX lblAssignBatchNo;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAssignBatchNo;
        private DevComponents.DotNetBar.ButtonX btnAssignBatchQuery;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvAssignBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignBatchNoColumn;
    }
}
