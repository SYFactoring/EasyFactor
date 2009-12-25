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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.btnFinanceBatchQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbFinanceBatchNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFinanceBatchNo = new DevComponents.DotNetBar.LabelX();
            this.dgvFinanceBatch = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinanceBatch.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinanceBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFinanceBatch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFinanceBatch.Location = new System.Drawing.Point(0, 35);
            this.dgvFinanceBatch.Name = "dgvFinanceBatch";
            this.dgvFinanceBatch.ReadOnly = true;
            this.dgvFinanceBatch.Size = new System.Drawing.Size(569, 402);
            this.dgvFinanceBatch.TabIndex = 1;
            this.dgvFinanceBatch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectFinanceBatch);
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
    }
}
