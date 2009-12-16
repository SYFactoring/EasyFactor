namespace CMBC.EasyFactor.CaseMgr.ContractMgr
{
    partial class ContractDetail
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
            this.components = new System.ComponentModel.Container();
            DevComponents.DotNetBar.LabelX lblContractCode;
            DevComponents.DotNetBar.LabelX lblClient;
            DevComponents.DotNetBar.LabelX lblContractDueDate;
            DevComponents.DotNetBar.LabelX lblContractValueDate;
            DevComponents.DotNetBar.LabelX lblContractStatus;
            DevComponents.DotNetBar.LabelX lblCreateUserName;
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbContractCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbClientEDICode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tpContractDueDate = new System.Windows.Forms.DateTimePicker();
            this.tpContractValueDate = new System.Windows.Forms.DateTimePicker();
            this.tbContractStatus = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanelContract = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnClientQuery = new DevComponents.DotNetBar.ButtonX();
            this.btnContractUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnContractSave = new DevComponents.DotNetBar.ButtonX();
            this.btnContractClose = new DevComponents.DotNetBar.ButtonX();
            lblContractCode = new DevComponents.DotNetBar.LabelX();
            lblClient = new DevComponents.DotNetBar.LabelX();
            lblContractDueDate = new DevComponents.DotNetBar.LabelX();
            lblContractValueDate = new DevComponents.DotNetBar.LabelX();
            lblContractStatus = new DevComponents.DotNetBar.LabelX();
            lblCreateUserName = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            this.groupPanelContract.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContractCode
            // 
            lblContractCode.AutoSize = true;
            lblContractCode.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblContractCode.BackgroundStyle.Class = "";
            lblContractCode.Location = new System.Drawing.Point(15, 20);
            lblContractCode.Name = "lblContractCode";
            lblContractCode.Size = new System.Drawing.Size(72, 16);
            lblContractCode.TabIndex = 1;
            lblContractCode.Text = "主合同编号:";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblClient.BackgroundStyle.Class = "";
            lblClient.Location = new System.Drawing.Point(51, 48);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(34, 16);
            lblClient.TabIndex = 2;
            lblClient.Text = "客户:";
            // 
            // lblContractDueDate
            // 
            lblContractDueDate.AutoSize = true;
            lblContractDueDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblContractDueDate.BackgroundStyle.Class = "";
            lblContractDueDate.Location = new System.Drawing.Point(4, 103);
            lblContractDueDate.Name = "lblContractDueDate";
            lblContractDueDate.Size = new System.Drawing.Size(84, 16);
            lblContractDueDate.TabIndex = 5;
            lblContractDueDate.Text = "主合同到期日:";
            // 
            // lblContractValueDate
            // 
            lblContractValueDate.AutoSize = true;
            lblContractValueDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblContractValueDate.BackgroundStyle.Class = "";
            lblContractValueDate.Location = new System.Drawing.Point(4, 77);
            lblContractValueDate.Name = "lblContractValueDate";
            lblContractValueDate.Size = new System.Drawing.Size(84, 16);
            lblContractValueDate.TabIndex = 7;
            lblContractValueDate.Text = "主合同生效日:";
            // 
            // lblContractStatus
            // 
            lblContractStatus.AutoSize = true;
            lblContractStatus.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblContractStatus.BackgroundStyle.Class = "";
            lblContractStatus.Location = new System.Drawing.Point(27, 128);
            lblContractStatus.Name = "lblContractStatus";
            lblContractStatus.Size = new System.Drawing.Size(59, 16);
            lblContractStatus.TabIndex = 9;
            lblContractStatus.Text = "合同状态:";
            // 
            // lblCreateUserName
            // 
            lblCreateUserName.AutoSize = true;
            lblCreateUserName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCreateUserName.BackgroundStyle.Class = "";
            lblCreateUserName.Location = new System.Drawing.Point(39, 152);
            lblCreateUserName.Name = "lblCreateUserName";
            lblCreateUserName.Size = new System.Drawing.Size(47, 16);
            lblCreateUserName.TabIndex = 11;
            lblCreateUserName.Text = "经办人:";
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Contract);
            // 
            // tbContractCode
            // 
            // 
            // 
            // 
            this.tbContractCode.Border.Class = "TextBoxBorder";
            this.tbContractCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ContractCode", true));
            this.tbContractCode.Location = new System.Drawing.Point(99, 17);
            this.tbContractCode.Name = "tbContractCode";
            this.tbContractCode.Size = new System.Drawing.Size(100, 20);
            this.tbContractCode.TabIndex = 2;
            // 
            // tbClientEDICode
            // 
            // 
            // 
            // 
            this.tbClientEDICode.Border.Class = "TextBoxBorder";
            this.tbClientEDICode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ClientEDICode", true));
            this.tbClientEDICode.Location = new System.Drawing.Point(99, 41);
            this.tbClientEDICode.Name = "tbClientEDICode";
            this.tbClientEDICode.Size = new System.Drawing.Size(100, 20);
            this.tbClientEDICode.TabIndex = 3;
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ClientEDICode", true));
            this.tbClientName.Location = new System.Drawing.Point(205, 41);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(217, 20);
            this.tbClientName.TabIndex = 4;
            // 
            // tpContractDueDate
            // 
            this.tpContractDueDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "ContractDueDate", true));
            this.tpContractDueDate.Location = new System.Drawing.Point(99, 97);
            this.tpContractDueDate.Name = "tpContractDueDate";
            this.tpContractDueDate.Size = new System.Drawing.Size(200, 20);
            this.tpContractDueDate.TabIndex = 6;
            // 
            // tpContractValueDate
            // 
            this.tpContractValueDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "ContractValueDate", true));
            this.tpContractValueDate.Location = new System.Drawing.Point(99, 71);
            this.tpContractValueDate.Name = "tpContractValueDate";
            this.tpContractValueDate.Size = new System.Drawing.Size(200, 20);
            this.tpContractValueDate.TabIndex = 8;
            // 
            // tbContractStatus
            // 
            // 
            // 
            // 
            this.tbContractStatus.Border.Class = "TextBoxBorder";
            this.tbContractStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ContractStatus", true));
            this.tbContractStatus.Location = new System.Drawing.Point(99, 125);
            this.tbContractStatus.Name = "tbContractStatus";
            this.tbContractStatus.Size = new System.Drawing.Size(100, 20);
            this.tbContractStatus.TabIndex = 10;
            // 
            // tbCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "CreateUserName", true));
            this.tbCreateUserName.Location = new System.Drawing.Point(99, 149);
            this.tbCreateUserName.Name = "tbCreateUserName";
            this.tbCreateUserName.Size = new System.Drawing.Size(100, 20);
            this.tbCreateUserName.TabIndex = 12;
            // 
            // groupPanelContract
            // 
            this.groupPanelContract.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelContract.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelContract.Controls.Add(this.btnClientQuery);
            this.groupPanelContract.Controls.Add(lblContractCode);
            this.groupPanelContract.Controls.Add(lblCreateUserName);
            this.groupPanelContract.Controls.Add(this.tbContractCode);
            this.groupPanelContract.Controls.Add(this.tbCreateUserName);
            this.groupPanelContract.Controls.Add(this.tbClientEDICode);
            this.groupPanelContract.Controls.Add(lblContractStatus);
            this.groupPanelContract.Controls.Add(lblClient);
            this.groupPanelContract.Controls.Add(this.tbContractStatus);
            this.groupPanelContract.Controls.Add(this.tbClientName);
            this.groupPanelContract.Controls.Add(lblContractValueDate);
            this.groupPanelContract.Controls.Add(this.tpContractDueDate);
            this.groupPanelContract.Controls.Add(this.tpContractValueDate);
            this.groupPanelContract.Controls.Add(lblContractDueDate);
            this.groupPanelContract.Location = new System.Drawing.Point(-2, 1);
            this.groupPanelContract.Name = "groupPanelContract";
            this.groupPanelContract.Size = new System.Drawing.Size(465, 184);
            // 
            // 
            // 
            this.groupPanelContract.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelContract.Style.BackColorGradientAngle = 90;
            this.groupPanelContract.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelContract.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelContract.Style.BorderBottomWidth = 1;
            this.groupPanelContract.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelContract.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelContract.Style.BorderLeftWidth = 1;
            this.groupPanelContract.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelContract.Style.BorderRightWidth = 1;
            this.groupPanelContract.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelContract.Style.BorderTopWidth = 1;
            this.groupPanelContract.Style.Class = "";
            this.groupPanelContract.Style.CornerDiameter = 4;
            this.groupPanelContract.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelContract.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelContract.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelContract.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelContract.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelContract.StyleMouseOver.Class = "";
            this.groupPanelContract.TabIndex = 13;
            // 
            // btnClientQuery
            // 
            this.btnClientQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientQuery.Location = new System.Drawing.Point(428, 38);
            this.btnClientQuery.Name = "btnClientQuery";
            this.btnClientQuery.Size = new System.Drawing.Size(21, 23);
            this.btnClientQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientQuery.TabIndex = 15;
            this.btnClientQuery.Text = "Q";
            // 
            // btnContractUpdate
            // 
            this.btnContractUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractUpdate.Location = new System.Drawing.Point(111, 189);
            this.btnContractUpdate.Name = "btnContractUpdate";
            this.btnContractUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnContractUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractUpdate.TabIndex = 14;
            this.btnContractUpdate.Text = "更新";
            this.btnContractUpdate.Click += new System.EventHandler(this.ContractUpdate);
            // 
            // btnContractSave
            // 
            this.btnContractSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractSave.Location = new System.Drawing.Point(192, 189);
            this.btnContractSave.Name = "btnContractSave";
            this.btnContractSave.Size = new System.Drawing.Size(75, 23);
            this.btnContractSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractSave.TabIndex = 15;
            this.btnContractSave.Text = "保存";
            this.btnContractSave.Click += new System.EventHandler(this.ContractSave);
            // 
            // btnContractClose
            // 
            this.btnContractClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractClose.Location = new System.Drawing.Point(273, 189);
            this.btnContractClose.Name = "btnContractClose";
            this.btnContractClose.Size = new System.Drawing.Size(75, 23);
            this.btnContractClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractClose.TabIndex = 16;
            this.btnContractClose.Text = "关闭";
            this.btnContractClose.Click += new System.EventHandler(this.ContractClose);
            // 
            // ContractDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 220);
            this.Controls.Add(this.btnContractClose);
            this.Controls.Add(this.btnContractSave);
            this.Controls.Add(this.btnContractUpdate);
            this.Controls.Add(this.groupPanelContract);
            this.DoubleBuffered = true;
            this.Name = "ContractDetail";
            this.Text = "合同详细信息";
            this.Leave += new System.EventHandler(this.ContractDetail_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            this.groupPanelContract.ResumeLayout(false);
            this.groupPanelContract.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource contractBindingSource;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContractCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientEDICode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private System.Windows.Forms.DateTimePicker tpContractDueDate;
        private System.Windows.Forms.DateTimePicker tpContractValueDate;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContractStatus;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreateUserName;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelContract;
        private DevComponents.DotNetBar.ButtonX btnClientQuery;
        private DevComponents.DotNetBar.ButtonX btnContractUpdate;
        private DevComponents.DotNetBar.ButtonX btnContractSave;
        private DevComponents.DotNetBar.ButtonX btnContractClose;
    }
}