namespace CMBC.EasyFactor.ARMgr
{
    partial class ARPoolBasic
    {
		#region?Fields?(16)?

        private DevComponents.DotNetBar.ButtonX btnClientQuery;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.LabelX lblCashOutstanding;
        private DevComponents.DotNetBar.LabelX lblFinanceOustanding;
        private DevComponents.DotNetBar.LabelX lblTotalAssignOutstanding;
        private DevComponents.DotNetBar.LabelX lblValuedAssignOutstanding;
        private DevComponents.DotNetBar.ExpandablePanel panelClient;
        private DevComponents.DotNetBar.PanelEx panelPool;
        private DevComponents.DotNetBar.ExpandablePanel panelPoolBasic;
        private DevComponents.DotNetBar.ExpandablePanel panelPoolOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPoolCashOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientEDICode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPoolFinanceOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPoolTotalAssignOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPoolValuedAssignOutstanding;

		#endregion?Fields?

		#region?Methods?(1)?

		//?Protected?Methods?(1)?

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

		#endregion?Methods?



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevComponents.DotNetBar.LabelX lblClient;
            this.panelPoolBasic = new DevComponents.DotNetBar.ExpandablePanel();
            this.panelPoolOutstanding = new DevComponents.DotNetBar.ExpandablePanel();
            this.tbPoolTotalAssignOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblTotalAssignOutstanding = new DevComponents.DotNetBar.LabelX();
            this.lblValuedAssignOutstanding = new DevComponents.DotNetBar.LabelX();
            this.tbPoolValuedAssignOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbPoolFinanceOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCashOutstanding = new DevComponents.DotNetBar.LabelX();
            this.lblFinanceOustanding = new DevComponents.DotNetBar.LabelX();
            this.tbPoolCashOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelClient = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnClientQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbClientEDICode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelPool = new DevComponents.DotNetBar.PanelEx();
            lblClient = new DevComponents.DotNetBar.LabelX();
            this.panelPoolBasic.SuspendLayout();
            this.panelPoolOutstanding.SuspendLayout();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            // 
            // 
            // 
            lblClient.BackgroundStyle.Class = "";
            lblClient.Location = new System.Drawing.Point(41, 28);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(31, 16);
            lblClient.TabIndex = 36;
            lblClient.Text = "客户";
            // 
            // panelPoolBasic
            // 
            this.panelPoolBasic.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelPoolBasic.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelPoolBasic.Controls.Add(this.panelPoolOutstanding);
            this.panelPoolBasic.Controls.Add(this.panelClient);
            this.panelPoolBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPoolBasic.Location = new System.Drawing.Point(0, 0);
            this.panelPoolBasic.Name = "panelPoolBasic";
            this.panelPoolBasic.Size = new System.Drawing.Size(730, 86);
            this.panelPoolBasic.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelPoolBasic.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelPoolBasic.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelPoolBasic.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelPoolBasic.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelPoolBasic.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelPoolBasic.Style.GradientAngle = 90;
            this.panelPoolBasic.TabIndex = 8;
            this.panelPoolBasic.TitleHeight = 5;
            this.panelPoolBasic.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelPoolBasic.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelPoolBasic.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelPoolBasic.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelPoolBasic.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelPoolBasic.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelPoolBasic.TitleStyle.GradientAngle = 90;
            // 
            // panelPoolOutstanding
            // 
            this.panelPoolOutstanding.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelPoolOutstanding.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.panelPoolOutstanding.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelPoolOutstanding.Controls.Add(this.tbPoolTotalAssignOutstanding);
            this.panelPoolOutstanding.Controls.Add(this.lblTotalAssignOutstanding);
            this.panelPoolOutstanding.Controls.Add(this.lblValuedAssignOutstanding);
            this.panelPoolOutstanding.Controls.Add(this.tbPoolValuedAssignOutstanding);
            this.panelPoolOutstanding.Controls.Add(this.tbPoolFinanceOutstanding);
            this.panelPoolOutstanding.Controls.Add(this.lblCashOutstanding);
            this.panelPoolOutstanding.Controls.Add(this.lblFinanceOustanding);
            this.panelPoolOutstanding.Controls.Add(this.tbPoolCashOutstanding);
            this.panelPoolOutstanding.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPoolOutstanding.ExpandOnTitleClick = true;
            this.panelPoolOutstanding.Location = new System.Drawing.Point(225, 5);
            this.panelPoolOutstanding.Name = "panelPoolOutstanding";
            this.panelPoolOutstanding.Size = new System.Drawing.Size(382, 81);
            this.panelPoolOutstanding.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelPoolOutstanding.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelPoolOutstanding.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelPoolOutstanding.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelPoolOutstanding.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelPoolOutstanding.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelPoolOutstanding.Style.GradientAngle = 90;
            this.panelPoolOutstanding.TabIndex = 7;
            this.panelPoolOutstanding.TitleHeight = 20;
            this.panelPoolOutstanding.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelPoolOutstanding.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelPoolOutstanding.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelPoolOutstanding.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelPoolOutstanding.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelPoolOutstanding.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelPoolOutstanding.TitleStyle.GradientAngle = 90;
            this.panelPoolOutstanding.TitleText = "余额信息";
            // 
            // tbPoolTotalAssignOutstanding
            // 
            // 
            // 
            // 
            this.tbPoolTotalAssignOutstanding.Border.Class = "TextBoxBorder";
            this.tbPoolTotalAssignOutstanding.Location = new System.Drawing.Point(87, 24);
            this.tbPoolTotalAssignOutstanding.Name = "tbPoolTotalAssignOutstanding";
            this.tbPoolTotalAssignOutstanding.ReadOnly = true;
            this.tbPoolTotalAssignOutstanding.Size = new System.Drawing.Size(100, 20);
            this.tbPoolTotalAssignOutstanding.TabIndex = 7;
            // 
            // lblTotalAssignOutstanding
            // 
            this.lblTotalAssignOutstanding.AutoSize = true;
            // 
            // 
            // 
            this.lblTotalAssignOutstanding.BackgroundStyle.Class = "";
            this.lblTotalAssignOutstanding.Location = new System.Drawing.Point(13, 25);
            this.lblTotalAssignOutstanding.Name = "lblTotalAssignOutstanding";
            this.lblTotalAssignOutstanding.Size = new System.Drawing.Size(68, 16);
            this.lblTotalAssignOutstanding.TabIndex = 6;
            this.lblTotalAssignOutstanding.Text = "总账款余额";
            // 
            // lblValuedAssignOutstanding
            // 
            this.lblValuedAssignOutstanding.AutoSize = true;
            // 
            // 
            // 
            this.lblValuedAssignOutstanding.BackgroundStyle.Class = "";
            this.lblValuedAssignOutstanding.Location = new System.Drawing.Point(193, 25);
            this.lblValuedAssignOutstanding.Name = "lblValuedAssignOutstanding";
            this.lblValuedAssignOutstanding.Size = new System.Drawing.Size(68, 16);
            this.lblValuedAssignOutstanding.TabIndex = 0;
            this.lblValuedAssignOutstanding.Text = "账款池余额";
            // 
            // tbPoolValuedAssignOutstanding
            // 
            // 
            // 
            // 
            this.tbPoolValuedAssignOutstanding.Border.Class = "TextBoxBorder";
            this.tbPoolValuedAssignOutstanding.Location = new System.Drawing.Point(267, 24);
            this.tbPoolValuedAssignOutstanding.Name = "tbPoolValuedAssignOutstanding";
            this.tbPoolValuedAssignOutstanding.ReadOnly = true;
            this.tbPoolValuedAssignOutstanding.Size = new System.Drawing.Size(100, 20);
            this.tbPoolValuedAssignOutstanding.TabIndex = 1;
            // 
            // tbPoolFinanceOutstanding
            // 
            // 
            // 
            // 
            this.tbPoolFinanceOutstanding.Border.Class = "TextBoxBorder";
            this.tbPoolFinanceOutstanding.Location = new System.Drawing.Point(267, 46);
            this.tbPoolFinanceOutstanding.Name = "tbPoolFinanceOutstanding";
            this.tbPoolFinanceOutstanding.ReadOnly = true;
            this.tbPoolFinanceOutstanding.Size = new System.Drawing.Size(100, 20);
            this.tbPoolFinanceOutstanding.TabIndex = 5;
            // 
            // lblCashOutstanding
            // 
            this.lblCashOutstanding.AutoSize = true;
            // 
            // 
            // 
            this.lblCashOutstanding.BackgroundStyle.Class = "";
            this.lblCashOutstanding.Location = new System.Drawing.Point(13, 48);
            this.lblCashOutstanding.Name = "lblCashOutstanding";
            this.lblCashOutstanding.Size = new System.Drawing.Size(68, 16);
            this.lblCashOutstanding.TabIndex = 2;
            this.lblCashOutstanding.Text = "现金池余额";
            // 
            // lblFinanceOustanding
            // 
            this.lblFinanceOustanding.AutoSize = true;
            // 
            // 
            // 
            this.lblFinanceOustanding.BackgroundStyle.Class = "";
            this.lblFinanceOustanding.Location = new System.Drawing.Point(193, 48);
            this.lblFinanceOustanding.Name = "lblFinanceOustanding";
            this.lblFinanceOustanding.Size = new System.Drawing.Size(68, 16);
            this.lblFinanceOustanding.TabIndex = 4;
            this.lblFinanceOustanding.Text = "融资池余额";
            // 
            // tbPoolCashOutstanding
            // 
            // 
            // 
            // 
            this.tbPoolCashOutstanding.Border.Class = "TextBoxBorder";
            this.tbPoolCashOutstanding.Location = new System.Drawing.Point(87, 46);
            this.tbPoolCashOutstanding.Name = "tbPoolCashOutstanding";
            this.tbPoolCashOutstanding.ReadOnly = true;
            this.tbPoolCashOutstanding.Size = new System.Drawing.Size(100, 20);
            this.tbPoolCashOutstanding.TabIndex = 3;
            // 
            // panelClient
            // 
            this.panelClient.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelClient.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.panelClient.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelClient.Controls.Add(this.btnClientQuery);
            this.panelClient.Controls.Add(this.tbClientEDICode);
            this.panelClient.Controls.Add(lblClient);
            this.panelClient.Controls.Add(this.tbClientName);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelClient.ExpandOnTitleClick = true;
            this.panelClient.Location = new System.Drawing.Point(0, 5);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(225, 81);
            this.panelClient.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelClient.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelClient.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelClient.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelClient.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelClient.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelClient.Style.GradientAngle = 90;
            this.panelClient.TabIndex = 6;
            this.panelClient.TitleHeight = 20;
            this.panelClient.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelClient.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelClient.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelClient.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelClient.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelClient.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelClient.TitleStyle.GradientAngle = 90;
            this.panelClient.TitleText = "基本信息";
            // 
            // btnClientQuery
            // 
            this.btnClientQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientQuery.Location = new System.Drawing.Point(3, 27);
            this.btnClientQuery.Name = "btnClientQuery";
            this.btnClientQuery.Size = new System.Drawing.Size(32, 29);
            this.btnClientQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientQuery.TabIndex = 35;
            this.btnClientQuery.Text = "...";
            this.btnClientQuery.Click += new System.EventHandler(this.SelectClient);
            // 
            // tbClientEDICode
            // 
            // 
            // 
            // 
            this.tbClientEDICode.Border.Class = "TextBoxBorder";
            this.tbClientEDICode.Location = new System.Drawing.Point(78, 24);
            this.tbClientEDICode.Name = "tbClientEDICode";
            this.tbClientEDICode.ReadOnly = true;
            this.tbClientEDICode.Size = new System.Drawing.Size(136, 20);
            this.tbClientEDICode.TabIndex = 37;
            this.tbClientEDICode.DoubleClick += new System.EventHandler(this.DetailClient);
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Location = new System.Drawing.Point(78, 46);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.ReadOnly = true;
            this.tbClientName.Size = new System.Drawing.Size(136, 20);
            this.tbClientName.TabIndex = 38;
            this.tbClientName.DoubleClick += new System.EventHandler(this.DetailClient);
            // 
            // panelPool
            // 
            this.panelPool.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelPool.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelPool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPool.Location = new System.Drawing.Point(0, 86);
            this.panelPool.Name = "panelPool";
            this.panelPool.Size = new System.Drawing.Size(730, 112);
            this.panelPool.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelPool.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelPool.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelPool.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelPool.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelPool.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelPool.Style.GradientAngle = 90;
            this.panelPool.TabIndex = 9;
            // 
            // ARPoolBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPool);
            this.Controls.Add(this.panelPoolBasic);
            this.Name = "ARPoolBasic";
            this.Size = new System.Drawing.Size(730, 198);
            this.panelPoolBasic.ResumeLayout(false);
            this.panelPoolOutstanding.ResumeLayout(false);
            this.panelPoolOutstanding.PerformLayout();
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
