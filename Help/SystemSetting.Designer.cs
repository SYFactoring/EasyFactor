namespace CMBC.EasyFactor.Help
{
    partial class SystemSetting
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBug = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbReportPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblReportPath = new DevComponents.DotNetBar.LabelX();
            this.btnLegerPathSelect = new DevComponents.DotNetBar.ButtonX();
            this.tbLegerPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblLegerPath = new DevComponents.DotNetBar.LabelX();
            this.btnReportPathSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.panelBug.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBug
            // 
            this.panelBug.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBug.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelBug.Controls.Add(this.btnReportPathSelect);
            this.panelBug.Controls.Add(this.tbReportPath);
            this.panelBug.Controls.Add(this.lblReportPath);
            this.panelBug.Controls.Add(this.btnLegerPathSelect);
            this.panelBug.Controls.Add(this.tbLegerPath);
            this.panelBug.Controls.Add(this.lblLegerPath);
            this.panelBug.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBug.Location = new System.Drawing.Point(0, 0);
            this.panelBug.Name = "panelBug";
            this.panelBug.Size = new System.Drawing.Size(344, 230);
            // 
            // 
            // 
            this.panelBug.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBug.Style.BackColorGradientAngle = 90;
            this.panelBug.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBug.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelBug.Style.BorderBottomWidth = 1;
            this.panelBug.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBug.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelBug.Style.BorderLeftWidth = 1;
            this.panelBug.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelBug.Style.BorderRightWidth = 1;
            this.panelBug.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelBug.Style.BorderTopWidth = 1;
            this.panelBug.Style.Class = "";
            this.panelBug.Style.CornerDiameter = 4;
            this.panelBug.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelBug.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.panelBug.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBug.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.panelBug.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.panelBug.StyleMouseOver.Class = "";
            this.panelBug.TabIndex = 1;
            // 
            // tbReportPath
            // 
            // 
            // 
            // 
            this.tbReportPath.Border.Class = "TextBoxBorder";
            this.tbReportPath.Location = new System.Drawing.Point(96, 8);
            this.tbReportPath.Name = "tbReportPath";
            this.tbReportPath.ReadOnly = true;
            this.tbReportPath.Size = new System.Drawing.Size(200, 20);
            this.tbReportPath.TabIndex = 1;
            // 
            // lblReportPath
            // 
            this.lblReportPath.AutoSize = true;
            this.lblReportPath.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblReportPath.BackgroundStyle.Class = "";
            this.lblReportPath.Location = new System.Drawing.Point(9, 8);
            this.lblReportPath.Name = "lblReportPath";
            this.lblReportPath.Size = new System.Drawing.Size(81, 16);
            this.lblReportPath.TabIndex = 0;
            this.lblReportPath.Text = "报表保存路径";
            // 
            // btnLegerPathSelect
            // 
            this.btnLegerPathSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLegerPathSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLegerPathSelect.Location = new System.Drawing.Point(302, 32);
            this.btnLegerPathSelect.Name = "btnLegerPathSelect";
            this.btnLegerPathSelect.Size = new System.Drawing.Size(24, 23);
            this.btnLegerPathSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLegerPathSelect.TabIndex = 6;
            this.btnLegerPathSelect.Text = "...";
            this.btnLegerPathSelect.Click += new System.EventHandler(this.SelectLegerPath);
            // 
            // tbLegerPath
            // 
            // 
            // 
            // 
            this.tbLegerPath.Border.Class = "TextBoxBorder";
            this.tbLegerPath.Location = new System.Drawing.Point(96, 34);
            this.tbLegerPath.Name = "tbLegerPath";
            this.tbLegerPath.ReadOnly = true;
            this.tbLegerPath.Size = new System.Drawing.Size(200, 20);
            this.tbLegerPath.TabIndex = 5;
            // 
            // lblLegerPath
            // 
            this.lblLegerPath.AutoSize = true;
            this.lblLegerPath.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblLegerPath.BackgroundStyle.Class = "";
            this.lblLegerPath.Location = new System.Drawing.Point(9, 39);
            this.lblLegerPath.Name = "lblLegerPath";
            this.lblLegerPath.Size = new System.Drawing.Size(81, 16);
            this.lblLegerPath.TabIndex = 4;
            this.lblLegerPath.Text = "台帐保存路径";
            // 
            // btnReportPathSelect
            // 
            this.btnReportPathSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReportPathSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReportPathSelect.Location = new System.Drawing.Point(302, 5);
            this.btnReportPathSelect.Name = "btnReportPathSelect";
            this.btnReportPathSelect.Size = new System.Drawing.Size(24, 23);
            this.btnReportPathSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReportPathSelect.TabIndex = 11;
            this.btnReportPathSelect.Text = "...";
            this.btnReportPathSelect.Click += new System.EventHandler(this.SelectReportPath);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(99, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.SaveSetting);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(180, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.CancelSetting);
            // 
            // SystemSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 268);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelBug);
            this.DoubleBuffered = true;
            this.Name = "SystemSetting";
            this.Text = "系统配置";
            this.panelBug.ResumeLayout(false);
            this.panelBug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel panelBug;
        private DevComponents.DotNetBar.ButtonX btnReportPathSelect;
        private DevComponents.DotNetBar.Controls.TextBoxX tbReportPath;
        private DevComponents.DotNetBar.LabelX lblReportPath;
        private DevComponents.DotNetBar.ButtonX btnLegerPathSelect;
        private DevComponents.DotNetBar.Controls.TextBoxX tbLegerPath;
        private DevComponents.DotNetBar.LabelX lblLegerPath;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
    }
}