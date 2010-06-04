//-----------------------------------------------------------------------
// <copyright file="ClientMgr.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    /// <summary>
    /// Client Management User Interface Designer
    /// </summary>
    public partial class ClientMgr
    {
		#region?Fields?(37)?

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbClientType;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsContractSigned;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLocation;
        private System.Windows.Forms.ContextMenuStrip cmuClientMgr;
        private System.ComponentModel.IContainer components;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvClients;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblLocation;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientCreditLineNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientExport;
        private System.Windows.Forms.ToolStripMenuItem menuItemContractNew;
        private DevComponents.DotNetBar.PanelEx pnlQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientEDICode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPM;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		#endregion?Fields?

		#region?Methods?(1)?

		//?Protected?Methods?(1)?

        /// <summary> 
        /// ������������ʹ�õ���Դ��
        /// </summary>
        /// <param name="disposing">���Ӧ�ͷ��й���Դ��Ϊ true������Ϊ false��</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

		#endregion?Methods?



        #region �����������ɵĴ���

        /// <summary> 
        /// �����֧������ķ��� - ��Ҫ
        /// ʹ�ô���༭���޸Ĵ˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevComponents.DotNetBar.LabelX lblClientType;
            DevComponents.DotNetBar.LabelX lblClientNo;
            DevComponents.DotNetBar.LabelX lblClientName;
            DevComponents.DotNetBar.LabelX lblRM;
            DevComponents.DotNetBar.LabelX lblPM;
            DevComponents.DotNetBar.LabelX lblCaseType;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmuClientMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemClientSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClientDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemClientNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClientCreditLineNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContractNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClientDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemClientExport = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlQuery = new DevComponents.DotNetBar.PanelEx();
            this.cbLocation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblLocation = new DevComponents.DotNetBar.LabelX();
            this.cbCaseType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.cbIsContractSigned = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.cbClientType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbClientEDICode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbRM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbPM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvClients = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clientEDICodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientCoreNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameENColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressENColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryNameCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndustryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblClientType = new DevComponents.DotNetBar.LabelX();
            lblClientNo = new DevComponents.DotNetBar.LabelX();
            lblClientName = new DevComponents.DotNetBar.LabelX();
            lblRM = new DevComponents.DotNetBar.LabelX();
            lblPM = new DevComponents.DotNetBar.LabelX();
            lblCaseType = new DevComponents.DotNetBar.LabelX();
            this.cmuClientMgr.SuspendLayout();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientType
            // 
            lblClientType.AutoSize = true;
            // 
            // 
            // 
            lblClientType.BackgroundStyle.Class = "";
            lblClientType.Location = new System.Drawing.Point(340, 7);
            lblClientType.Name = "lblClientType";
            lblClientType.Size = new System.Drawing.Size(56, 16);
            lblClientType.TabIndex = 4;
            lblClientType.Text = "�ͻ�����";
            lblClientType.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblClientNo
            // 
            lblClientNo.AutoSize = true;
            // 
            // 
            // 
            lblClientNo.BackgroundStyle.Class = "";
            lblClientNo.Location = new System.Drawing.Point(3, 7);
            lblClientNo.Name = "lblClientNo";
            lblClientNo.Size = new System.Drawing.Size(56, 16);
            lblClientNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblClientNo.TabIndex = 0;
            lblClientNo.Text = "�������";
            lblClientNo.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            // 
            // 
            // 
            lblClientName.BackgroundStyle.Class = "";
            lblClientName.Location = new System.Drawing.Point(170, 7);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new System.Drawing.Size(56, 16);
            lblClientName.TabIndex = 2;
            lblClientName.Text = "�ͻ�����";
            lblClientName.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            // 
            // 
            // 
            lblRM.BackgroundStyle.Class = "";
            lblRM.Location = new System.Drawing.Point(340, 33);
            lblRM.Name = "lblRM";
            lblRM.Size = new System.Drawing.Size(56, 16);
            lblRM.TabIndex = 11;
            lblRM.Text = "�ͻ�����";
            lblRM.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblPM
            // 
            lblPM.AutoSize = true;
            // 
            // 
            // 
            lblPM.BackgroundStyle.Class = "";
            lblPM.Location = new System.Drawing.Point(170, 33);
            lblPM.Name = "lblPM";
            lblPM.Size = new System.Drawing.Size(56, 16);
            lblPM.TabIndex = 9;
            lblPM.Text = "��Ʒ����";
            lblPM.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblCaseType
            // 
            lblCaseType.AutoSize = true;
            // 
            // 
            // 
            lblCaseType.BackgroundStyle.Class = "";
            lblCaseType.Location = new System.Drawing.Point(509, 9);
            lblCaseType.Name = "lblCaseType";
            lblCaseType.Size = new System.Drawing.Size(56, 16);
            lblCaseType.TabIndex = 16;
            lblCaseType.Text = "��������";
            lblCaseType.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cmuClientMgr
            // 
            this.cmuClientMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemClientSelect,
            this.menuItemClientDetail,
            this.toolStripSeparator,
            this.menuItemClientNew,
            this.menuItemClientCreditLineNew,
            this.menuItemContractNew,
            this.menuItemClientDelete,
            this.toolStripSeparator1,
            this.menuItemClientExport});
            this.cmuClientMgr.Name = "contextMenuClientMgr";
            this.cmuClientMgr.Size = new System.Drawing.Size(147, 170);
            // 
            // menuItemClientSelect
            // 
            this.menuItemClientSelect.Name = "menuItemClientSelect";
            this.menuItemClientSelect.Size = new System.Drawing.Size(146, 22);
            this.menuItemClientSelect.Text = "ѡ���ͻ�";
            this.menuItemClientSelect.Click += new System.EventHandler(this.SelectClient);
            // 
            // menuItemClientDetail
            // 
            this.menuItemClientDetail.Name = "menuItemClientDetail";
            this.menuItemClientDetail.Size = new System.Drawing.Size(146, 22);
            this.menuItemClientDetail.Text = "��ϸ��Ϣ";
            this.menuItemClientDetail.Click += new System.EventHandler(this.DetailClient);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // menuItemClientNew
            // 
            this.menuItemClientNew.Name = "menuItemClientNew";
            this.menuItemClientNew.Size = new System.Drawing.Size(146, 22);
            this.menuItemClientNew.Text = "�½��ͻ�";
            this.menuItemClientNew.Click += new System.EventHandler(this.NewClient);
            // 
            // menuItemClientCreditLineNew
            // 
            this.menuItemClientCreditLineNew.Name = "menuItemClientCreditLineNew";
            this.menuItemClientCreditLineNew.Size = new System.Drawing.Size(146, 22);
            this.menuItemClientCreditLineNew.Text = "�½������Ϣ";
            this.menuItemClientCreditLineNew.Click += new System.EventHandler(this.NewClientCreditLine);
            // 
            // menuItemContractNew
            // 
            this.menuItemContractNew.Name = "menuItemContractNew";
            this.menuItemContractNew.Size = new System.Drawing.Size(146, 22);
            this.menuItemContractNew.Text = "�½������ͬ";
            this.menuItemContractNew.Click += new System.EventHandler(this.NewContract);
            // 
            // menuItemClientDelete
            // 
            this.menuItemClientDelete.Name = "menuItemClientDelete";
            this.menuItemClientDelete.Size = new System.Drawing.Size(146, 22);
            this.menuItemClientDelete.Text = "ɾ���ͻ�";
            this.menuItemClientDelete.Click += new System.EventHandler(this.DeleteClient);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // menuItemClientsExport
            // 
            this.menuItemClientExport.Name = "menuItemClientsExport";
            this.menuItemClientExport.Size = new System.Drawing.Size(146, 22);
            this.menuItemClientExport.Text = "�������пͻ�";
            this.menuItemClientExport.Click += new System.EventHandler(this.ExportClients);
            // 
            // pnlQuery
            // 
            this.pnlQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlQuery.Controls.Add(this.cbLocation);
            this.pnlQuery.Controls.Add(this.lblLocation);
            this.pnlQuery.Controls.Add(this.cbCaseType);
            this.pnlQuery.Controls.Add(lblCaseType);
            this.pnlQuery.Controls.Add(this.btnReset);
            this.pnlQuery.Controls.Add(this.cbIsContractSigned);
            this.pnlQuery.Controls.Add(this.lblCount);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Controls.Add(this.cbClientType);
            this.pnlQuery.Controls.Add(lblClientType);
            this.pnlQuery.Controls.Add(this.tbClientEDICode);
            this.pnlQuery.Controls.Add(lblClientNo);
            this.pnlQuery.Controls.Add(this.tbClientName);
            this.pnlQuery.Controls.Add(lblClientName);
            this.pnlQuery.Controls.Add(this.tbRM);
            this.pnlQuery.Controls.Add(lblRM);
            this.pnlQuery.Controls.Add(this.tbPM);
            this.pnlQuery.Controls.Add(lblPM);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 0);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(937, 61);
            this.pnlQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlQuery.Style.GradientAngle = 90;
            this.pnlQuery.TabIndex = 1;
            // 
            // cbLocation
            // 
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.ItemHeight = 14;
            this.cbLocation.Location = new System.Drawing.Point(59, 34);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(101, 20);
            this.cbLocation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLocation.TabIndex = 25;
            // 
            // lblLocation
            // 
            // 
            // 
            // 
            this.lblLocation.BackgroundStyle.Class = "";
            this.lblLocation.Location = new System.Drawing.Point(3, 31);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(59, 23);
            this.lblLocation.TabIndex = 24;
            this.lblLocation.Text = "ҵ�����";
            // 
            // cbCaseType
            // 
            this.cbCaseType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseType.ItemHeight = 14;
            this.cbCaseType.Items.AddRange(new object[] {
            "ȫ��",
            "���ڱ���",
            "���ڱ���",
            "���ڱ���"});
            this.cbCaseType.Location = new System.Drawing.Point(566, 7);
            this.cbCaseType.Name = "cbCaseType";
            this.cbCaseType.Size = new System.Drawing.Size(100, 20);
            this.cbCaseType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseType.TabIndex = 17;
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Location = new System.Drawing.Point(672, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 23);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "���";
            this.btnReset.Click += new System.EventHandler(this.Reset);
            // 
            // cbIsContractSigned
            // 
            this.cbIsContractSigned.AutoSize = true;
            // 
            // 
            // 
            this.cbIsContractSigned.BackgroundStyle.Class = "";
            this.cbIsContractSigned.Location = new System.Drawing.Point(509, 34);
            this.cbIsContractSigned.Name = "cbIsContractSigned";
            this.cbIsContractSigned.Size = new System.Drawing.Size(126, 16);
            this.cbIsContractSigned.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsContractSigned.TabIndex = 6;
            this.cbIsContractSigned.Text = "�Ƿ�ǩ�������ͬ";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(738, 37);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 15;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(672, 7);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(60, 22);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 13;
            this.btnQuery.Text = "��ѯ";
            this.btnQuery.Click += new System.EventHandler(this.QueryClients);
            // 
            // cbClientType
            // 
            this.cbClientType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientType.ItemHeight = 14;
            this.cbClientType.Items.AddRange(new object[] {
            "ȫ��",
            "����",
            "��Ӫ",
            "����"});
            this.cbClientType.Location = new System.Drawing.Point(397, 7);
            this.cbClientType.Name = "cbClientType";
            this.cbClientType.Size = new System.Drawing.Size(100, 20);
            this.cbClientType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbClientType.TabIndex = 5;
            // 
            // tbClientEDICode
            // 
            // 
            // 
            // 
            this.tbClientEDICode.Border.Class = "TextBoxBorder";
            this.tbClientEDICode.Location = new System.Drawing.Point(60, 7);
            this.tbClientEDICode.Name = "tbClientEDICode";
            this.tbClientEDICode.Size = new System.Drawing.Size(100, 20);
            this.tbClientEDICode.TabIndex = 1;
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Location = new System.Drawing.Point(227, 7);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 20);
            this.tbClientName.TabIndex = 3;
            // 
            // tbRM
            // 
            // 
            // 
            // 
            this.tbRM.Border.Class = "TextBoxBorder";
            this.tbRM.Location = new System.Drawing.Point(397, 33);
            this.tbRM.Name = "tbRM";
            this.tbRM.Size = new System.Drawing.Size(100, 20);
            this.tbRM.TabIndex = 12;
            // 
            // tbPM
            // 
            // 
            // 
            // 
            this.tbPM.Border.Class = "TextBoxBorder";
            this.tbPM.Location = new System.Drawing.Point(227, 33);
            this.tbPM.Name = "tbPM";
            this.tbPM.Size = new System.Drawing.Size(100, 20);
            this.tbPM.TabIndex = 10;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientEDICodeColumn,
            this.ClientCoreNoColumn,
            this.ClientNameCNColumn,
            this.ClientNameENColumn,
            this.AddressCNColumn,
            this.AddressENColumn,
            this.CountryNameCNColumn,
            this.colClientType,
            this.GroupNoColumn,
            this.IndustryColumn,
            this.DepartmentCodeColumn,
            this.DepartmentColumn,
            this.PMNameColumn});
            this.dgvClients.ContextMenuStrip = this.cmuClientMgr;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvClients.Location = new System.Drawing.Point(0, 61);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClients.RowTemplate.Height = 23;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(937, 539);
            this.dgvClients.TabIndex = 2;
            this.dgvClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvClients.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvClientsRowPostPaint);
            // 
            // clientEDICodeColumn
            // 
            this.clientEDICodeColumn.DataPropertyName = "ClientEDICode";
            this.clientEDICodeColumn.FillWeight = 81.40282F;
            this.clientEDICodeColumn.HeaderText = "�������";
            this.clientEDICodeColumn.Name = "clientEDICodeColumn";
            this.clientEDICodeColumn.ReadOnly = true;
            // 
            // ClientCoreNoColumn
            // 
            this.ClientCoreNoColumn.DataPropertyName = "ClientCoreNo";
            this.ClientCoreNoColumn.FillWeight = 81.40282F;
            this.ClientCoreNoColumn.HeaderText = "�ͻ���";
            this.ClientCoreNoColumn.Name = "ClientCoreNoColumn";
            this.ClientCoreNoColumn.ReadOnly = true;
            // 
            // ClientNameCNColumn
            // 
            this.ClientNameCNColumn.DataPropertyName = "ClientNameCN";
            this.ClientNameCNColumn.FillWeight = 304.5686F;
            this.ClientNameCNColumn.HeaderText = "�ͻ�����(��)";
            this.ClientNameCNColumn.Name = "ClientNameCNColumn";
            this.ClientNameCNColumn.ReadOnly = true;
            // 
            // ClientNameENColumn
            // 
            this.ClientNameENColumn.DataPropertyName = "ClientNameEN";
            this.ClientNameENColumn.FillWeight = 81.40282F;
            this.ClientNameENColumn.HeaderText = "�ͻ�����(Ӣ)";
            this.ClientNameENColumn.Name = "ClientNameENColumn";
            this.ClientNameENColumn.ReadOnly = true;
            // 
            // AddressCNColumn
            // 
            this.AddressCNColumn.DataPropertyName = "AddressCN";
            this.AddressCNColumn.FillWeight = 81.40282F;
            this.AddressCNColumn.HeaderText = "��ַ(��)";
            this.AddressCNColumn.Name = "AddressCNColumn";
            this.AddressCNColumn.ReadOnly = true;
            // 
            // AddressENColumn
            // 
            this.AddressENColumn.DataPropertyName = "AddressEN";
            this.AddressENColumn.FillWeight = 81.40282F;
            this.AddressENColumn.HeaderText = "��ַ(Ӣ)";
            this.AddressENColumn.Name = "AddressENColumn";
            this.AddressENColumn.ReadOnly = true;
            // 
            // CountryNameCNColumn
            // 
            this.CountryNameCNColumn.DataPropertyName = "CountryCode";
            this.CountryNameCNColumn.FillWeight = 81.40282F;
            this.CountryNameCNColumn.HeaderText = "����";
            this.CountryNameCNColumn.Name = "CountryNameCNColumn";
            this.CountryNameCNColumn.ReadOnly = true;
            // 
            // colClientType
            // 
            this.colClientType.DataPropertyName = "ClientType";
            this.colClientType.FillWeight = 81.40282F;
            this.colClientType.HeaderText = "�ͻ�����";
            this.colClientType.Name = "colClientType";
            this.colClientType.ReadOnly = true;
            // 
            // GroupNoColumn
            // 
            this.GroupNoColumn.DataPropertyName = "GroupEDICode";
            this.GroupNoColumn.FillWeight = 81.40282F;
            this.GroupNoColumn.HeaderText = "�������ſͻ���";
            this.GroupNoColumn.Name = "GroupNoColumn";
            this.GroupNoColumn.ReadOnly = true;
            // 
            // IndustryColumn
            // 
            this.IndustryColumn.DataPropertyName = "Industry";
            this.IndustryColumn.FillWeight = 81.40282F;
            this.IndustryColumn.HeaderText = "������ҵ";
            this.IndustryColumn.Name = "IndustryColumn";
            this.IndustryColumn.ReadOnly = true;
            // 
            // DepartmentCodeColumn
            // 
            this.DepartmentCodeColumn.DataPropertyName = "BranchCode";
            this.DepartmentCodeColumn.HeaderText = "������������";
            this.DepartmentCodeColumn.Name = "DepartmentCodeColumn";
            this.DepartmentCodeColumn.ReadOnly = true;
            this.DepartmentCodeColumn.Visible = false;
            // 
            // DepartmentColumn
            // 
            this.DepartmentColumn.DataPropertyName = "Department";
            this.DepartmentColumn.FillWeight = 81.40282F;
            this.DepartmentColumn.HeaderText = "��������";
            this.DepartmentColumn.Name = "DepartmentColumn";
            this.DepartmentColumn.ReadOnly = true;
            // 
            // PMNameColumn
            // 
            this.PMNameColumn.DataPropertyName = "PMName";
            this.PMNameColumn.FillWeight = 81.40282F;
            this.PMNameColumn.HeaderText = "��Ʒ����";
            this.PMNameColumn.Name = "PMNameColumn";
            this.PMNameColumn.ReadOnly = true;
            // 
            // ClientMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.pnlQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "ClientMgr";
            this.Size = new System.Drawing.Size(937, 600);
            this.cmuClientMgr.ResumeLayout(false);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn clientEDICodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientCoreNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameENColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressENColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryNameCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndustryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMNameColumn;
    }
}
