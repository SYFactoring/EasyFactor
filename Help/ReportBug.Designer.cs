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

            if (this._mail != null)
            {
                this._mail.Dispose();
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
            this.tbTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
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
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lblMailCC = new DevComponents.DotNetBar.LabelX();
            this.tbMailCC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelBug.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBug
            // 
            this.panelBug.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBug.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelBug.Controls.Add(this.tbMailCC);
            this.panelBug.Controls.Add(this.lblMailCC);
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
            this.panelBug.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelBug.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBug.Location = new System.Drawing.Point(0, 0);
            this.panelBug.Name = "panelBug";
            this.panelBug.Size = new System.Drawing.Size(506, 224);
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
            this.panelBug.Style.CornerDiameter = 4;
            this.panelBug.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelBug.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.panelBug.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBug.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.panelBug.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelBug.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.panelBug.TabIndex = 0;
            // 
            // tbTitle
            // 
            // 
            // 
            // 
            this.tbTitle.Border.Class = "TextBoxBorder";
            this.tbTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTitle.Location = new System.Drawing.Point(71, 5);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(420, 21);
            this.tbTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitle.Location = new System.Drawing.Point(34, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(31, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "题目";
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
            this.cbBugType.Location = new System.Drawing.Point(225, 193);
            this.cbBugType.Name = "cbBugType";
            this.cbBugType.Size = new System.Drawing.Size(101, 20);
            this.cbBugType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbBugType.TabIndex = 10;
            // 
            // lblBugType
            // 
            this.lblBugType.AutoSize = true;
            this.lblBugType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblBugType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBugType.Location = new System.Drawing.Point(166, 195);
            this.lblBugType.Name = "lblBugType";
            this.lblBugType.Size = new System.Drawing.Size(56, 18);
            this.lblBugType.TabIndex = 9;
            this.lblBugType.Text = "反馈类型";
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFileSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFileSelect.Location = new System.Drawing.Point(302, 167);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(24, 21);
            this.btnFileSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.tbAttachment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbAttachment.Location = new System.Drawing.Point(71, 167);
            this.tbAttachment.Name = "tbAttachment";
            this.tbAttachment.ReadOnly = true;
            this.tbAttachment.Size = new System.Drawing.Size(225, 21);
            this.tbAttachment.TabIndex = 5;
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblAttachment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAttachment.Location = new System.Drawing.Point(34, 170);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(31, 18);
            this.lblAttachment.TabIndex = 4;
            this.lblAttachment.Text = "附件";
            // 
            // tbSubmitPerson
            // 
            // 
            // 
            // 
            this.tbSubmitPerson.Border.Class = "TextBoxBorder";
            this.tbSubmitPerson.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbSubmitPerson.Location = new System.Drawing.Point(71, 193);
            this.tbSubmitPerson.Name = "tbSubmitPerson";
            this.tbSubmitPerson.Size = new System.Drawing.Size(86, 21);
            this.tbSubmitPerson.TabIndex = 8;
            // 
            // lblSubmitPerson
            // 
            this.lblSubmitPerson.AutoSize = true;
            this.lblSubmitPerson.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblSubmitPerson.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSubmitPerson.Location = new System.Drawing.Point(21, 194);
            this.lblSubmitPerson.Name = "lblSubmitPerson";
            this.lblSubmitPerson.Size = new System.Drawing.Size(44, 18);
            this.lblSubmitPerson.TabIndex = 7;
            this.lblSubmitPerson.Text = "提交者";
            // 
            // tbBug
            // 
            // 
            // 
            // 
            this.tbBug.Border.Class = "TextBoxBorder";
            this.tbBug.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbBug.Location = new System.Drawing.Point(71, 29);
            this.tbBug.Multiline = true;
            this.tbBug.Name = "tbBug";
            this.tbBug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbBug.Size = new System.Drawing.Size(420, 132);
            this.tbBug.TabIndex = 3;
            // 
            // lblBug
            // 
            this.lblBug.AutoSize = true;
            this.lblBug.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblBug.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBug.Location = new System.Drawing.Point(9, 29);
            this.lblBug.Name = "lblBug";
            this.lblBug.Size = new System.Drawing.Size(56, 18);
            this.lblBug.TabIndex = 2;
            this.lblBug.Text = "问题描述";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSubmit.Location = new System.Drawing.Point(85, 230);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 21);
            this.btnSubmit.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.Click += new System.EventHandler(this.SubmitBug);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerDoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerRunWorkerCompleted);
            // 
            // lblMailCC
            // 
            this.lblMailCC.AutoSize = true;
            this.lblMailCC.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblMailCC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMailCC.Location = new System.Drawing.Point(332, 194);
            this.lblMailCC.Name = "lblMailCC";
            this.lblMailCC.Size = new System.Drawing.Size(56, 18);
            this.lblMailCC.TabIndex = 11;
            this.lblMailCC.Text = "回信地址";
            // 
            // tbMailCC
            // 
            // 
            // 
            // 
            this.tbMailCC.Border.Class = "TextBoxBorder";
            this.tbMailCC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbMailCC.Location = new System.Drawing.Point(394, 192);
            this.tbMailCC.Name = "tbMailCC";
            this.tbMailCC.Size = new System.Drawing.Size(97, 21);
            this.tbMailCC.TabIndex = 12;
            // 
            // ReportBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 252);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panelBug);
            this.Name = "ReportBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "问题反馈";
            this.panelBug.ResumeLayout(false);
            this.panelBug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbMailCC;
        private DevComponents.DotNetBar.LabelX lblMailCC;
    }
}