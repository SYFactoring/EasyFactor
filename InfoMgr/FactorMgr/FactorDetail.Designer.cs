namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    partial class FactorDetail
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabItemFactor = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelFactor = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemCreditLine = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelCreditLine = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemAccount = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelAccount = new DevComponents.DotNetBar.TabControlPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabPanelFactor);
            this.tabControl1.Controls.Add(this.tabPanelCreditLine);
            this.tabControl1.Controls.Add(this.tabPanelAccount);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 415);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItemFactor);
            this.tabControl1.Tabs.Add(this.tabItemCreditLine);
            this.tabControl1.Tabs.Add(this.tabItemAccount);
            this.tabControl1.Text = "tabControl";
            // 
            // tabItemFactor
            // 
            this.tabItemFactor.AttachedControl = this.tabPanelFactor;
            this.tabItemFactor.Name = "tabItemFactor";
            this.tabItemFactor.Text = "基本信息";
            // 
            // tabPanelFactor
            // 
            this.tabPanelFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelFactor.Location = new System.Drawing.Point(0, 26);
            this.tabPanelFactor.Name = "tabPanelFactor";
            this.tabPanelFactor.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelFactor.Size = new System.Drawing.Size(449, 389);
            this.tabPanelFactor.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelFactor.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelFactor.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelFactor.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelFactor.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelFactor.Style.GradientAngle = 90;
            this.tabPanelFactor.TabIndex = 1;
            this.tabPanelFactor.TabItem = this.tabItemFactor;
            // 
            // tabItemCreditLine
            // 
            this.tabItemCreditLine.AttachedControl = this.tabPanelCreditLine;
            this.tabItemCreditLine.Name = "tabItemCreditLine";
            this.tabItemCreditLine.Text = "额度信息";
            // 
            // tabPanelCreditLine
            // 
            this.tabPanelCreditLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelCreditLine.Location = new System.Drawing.Point(0, 26);
            this.tabPanelCreditLine.Name = "tabPanelCreditLine";
            this.tabPanelCreditLine.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelCreditLine.Size = new System.Drawing.Size(449, 389);
            this.tabPanelCreditLine.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelCreditLine.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelCreditLine.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelCreditLine.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelCreditLine.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelCreditLine.Style.GradientAngle = 90;
            this.tabPanelCreditLine.TabIndex = 2;
            this.tabPanelCreditLine.TabItem = this.tabItemCreditLine;
            // 
            // tabItemAccount
            // 
            this.tabItemAccount.AttachedControl = this.tabPanelAccount;
            this.tabItemAccount.Name = "tabItemAccount";
            this.tabItemAccount.Text = "账户信息";
            // 
            // tabPanelAccount
            // 
            this.tabPanelAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelAccount.Location = new System.Drawing.Point(0, 26);
            this.tabPanelAccount.Name = "tabPanelAccount";
            this.tabPanelAccount.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelAccount.Size = new System.Drawing.Size(449, 389);
            this.tabPanelAccount.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelAccount.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelAccount.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelAccount.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelAccount.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelAccount.Style.GradientAngle = 90;
            this.tabPanelAccount.TabIndex = 3;
            this.tabPanelAccount.TabItem = this.tabItemAccount;
            // 
            // FactorDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 415);
            this.Controls.Add(this.tabControl1);
            this.Name = "FactorDetail";
            this.Text = "合作机构详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabPanelFactor;
        private DevComponents.DotNetBar.TabItem tabItemFactor;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCreditLine;
        private DevComponents.DotNetBar.TabItem tabItemCreditLine;
        private DevComponents.DotNetBar.TabControlPanel tabPanelAccount;
        private DevComponents.DotNetBar.TabItem tabItemAccount;
    }
}
