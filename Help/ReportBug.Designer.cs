namespace CMBC.EasyFactor.Help
{
    /// <summary>
    /// 
    /// </summary>
    partial class ReportBug
    {
		#region?Fields?(15)?

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private DevComponents.DotNetBar.ButtonX btnFileSelect;
        private DevComponents.DotNetBar.ButtonX btnSubmit;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbBugType;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.LabelX lblAttachment;
        private DevComponents.DotNetBar.LabelX lblBug;
        private DevComponents.DotNetBar.LabelX lblBugType;
        private DevComponents.DotNetBar.LabelX lblSubmitPerson;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private DevComponents.DotNetBar.Controls.GroupPanel panelBug;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAttachment;
        private DevComponents.DotNetBar.Controls.TextBoxX tbBug;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSubmitPerson;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTitle;

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

            if (this.mail != null)
            {
                this.mail.Dispose();
            }

            base.Dispose(disposing);
        }

		#endregion?Methods?



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBug = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbBugType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblBugType = new DevComponents.DotNetBar.LabelX();
            this.btnFileSelect = new DevComponents.DotNetBar.ButtonX();
            this.tbAttachment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAttachment = new DevComponents.DotNetBar.LabelX();
            this.tbSubmitPerson = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSubmitPerson = new DevComponents.DotNetBar.LabelX();
            this.tbBug = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblBug = new DevComponents.DotNetBar.LabelX();
            this.btnSubmit = new DevComponents.DotNetBar.ButtonX();
            this.tbTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panelBug.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBug
            // 
            this.panelBug.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBug.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelBug.Controls.Add(this.tbTitle);
            this.panelBug.Controls.Add(this.lblTitle);
            this.panelBug.Controls.Add(this.cbBugType);
            this.panelBug.Controls.Add(this.lblBugType);
            this.panelBug.Controls.Add(this.btnFileSelect);
            this.panelBug.Controls.Add(this.tbAttachment);
            this.panelBug.Controls.Add(this.lblAttachment);
            this.panelBug.Controls.Add(this.tbSubmitPerson);
            this.panelBug.Controls.Add(this.lblSubmitPerson);
            this.panelBug.Controls.Add(this.tbBug);
            this.panelBug.Controls.Add(this.lblBug);
            this.panelBug.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBug.Location = new System.Drawing.Point(0, 0);
            this.panelBug.Name = "panelBug";
            this.panelBug.Size = new System.Drawing.Size(341, 230);
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
            this.panelBug.TabIndex = 0;
            // 
            // cbBugType
            // 
            this.cbBugType.DisplayMember = "Text";
            this.cbBugType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBugType.FormattingEnabled = true;
            this.cbBugType.ItemHeight = 14;
            this.cbBugType.Items.AddRange(new object[] {
            "Bug",
            "意见"});
            this.cbBugType.Location = new System.Drawing.Point(225, 202);
            this.cbBugType.Name = "cbBugType";
            this.cbBugType.Size = new System.Drawing.Size(101, 20);
            this.cbBugType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbBugType.TabIndex = 10;
            // 
            // lblBugType
            // 
            this.lblBugType.AutoSize = true;
            this.lblBugType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblBugType.BackgroundStyle.Class = "";
            this.lblBugType.Location = new System.Drawing.Point(166, 204);
            this.lblBugType.Name = "lblBugType";
            this.lblBugType.Size = new System.Drawing.Size(56, 16);
            this.lblBugType.TabIndex = 9;
            this.lblBugType.Text = "反馈类型";
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFileSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFileSelect.Location = new System.Drawing.Point(302, 177);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(24, 23);
            this.btnFileSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFileSelect.TabIndex = 6;
            this.btnFileSelect.Text = "...";
            this.btnFileSelect.Click += new System.EventHandler(this.SelectFile);
            // 
            // tbAttachment
            // 
            // 
            // 
            // 
            this.tbAttachment.Border.Class = "TextBoxBorder";
            this.tbAttachment.Location = new System.Drawing.Point(71, 178);
            this.tbAttachment.Name = "tbAttachment";
            this.tbAttachment.ReadOnly = true;
            this.tbAttachment.Size = new System.Drawing.Size(225, 20);
            this.tbAttachment.TabIndex = 5;
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblAttachment.BackgroundStyle.Class = "";
            this.lblAttachment.Location = new System.Drawing.Point(34, 180);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(31, 16);
            this.lblAttachment.TabIndex = 4;
            this.lblAttachment.Text = "附件";
            // 
            // tbSubmitPerson
            // 
            // 
            // 
            // 
            this.tbSubmitPerson.Border.Class = "TextBoxBorder";
            this.tbSubmitPerson.Location = new System.Drawing.Point(71, 201);
            this.tbSubmitPerson.Name = "tbSubmitPerson";
            this.tbSubmitPerson.Size = new System.Drawing.Size(86, 20);
            this.tbSubmitPerson.TabIndex = 8;
            // 
            // lblSubmitPerson
            // 
            this.lblSubmitPerson.AutoSize = true;
            this.lblSubmitPerson.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblSubmitPerson.BackgroundStyle.Class = "";
            this.lblSubmitPerson.Location = new System.Drawing.Point(21, 202);
            this.lblSubmitPerson.Name = "lblSubmitPerson";
            this.lblSubmitPerson.Size = new System.Drawing.Size(44, 16);
            this.lblSubmitPerson.TabIndex = 7;
            this.lblSubmitPerson.Text = "提交者";
            // 
            // tbBug
            // 
            // 
            // 
            // 
            this.tbBug.Border.Class = "TextBoxBorder";
            this.tbBug.Location = new System.Drawing.Point(71, 31);
            this.tbBug.Multiline = true;
            this.tbBug.Name = "tbBug";
            this.tbBug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbBug.Size = new System.Drawing.Size(255, 143);
            this.tbBug.TabIndex = 3;
            // 
            // lblBug
            // 
            this.lblBug.AutoSize = true;
            this.lblBug.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblBug.BackgroundStyle.Class = "";
            this.lblBug.Location = new System.Drawing.Point(9, 31);
            this.lblBug.Name = "lblBug";
            this.lblBug.Size = new System.Drawing.Size(56, 16);
            this.lblBug.TabIndex = 2;
            this.lblBug.Text = "问题描述";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSubmit.Location = new System.Drawing.Point(85, 236);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.Click += new System.EventHandler(this.SubmitBug);
            // 
            // tbTitle
            // 
            // 
            // 
            // 
            this.tbTitle.Border.Class = "TextBoxBorder";
            this.tbTitle.Location = new System.Drawing.Point(71, 8);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(255, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.Class = "";
            this.lblTitle.Location = new System.Drawing.Point(34, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(31, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "题目";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // ReportBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 262);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panelBug);
            this.DoubleBuffered = true;
            this.Name = "ReportBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "问题反馈";
            this.panelBug.ResumeLayout(false);
            this.panelBug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}