using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace CMBC.EasyFactor.Help
{
    /// <summary>
    /// Summary description for Confirm.
    /// </summary>
    public class ConfirmForm : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (7)

        private AutoUpdater autoUpdater;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private LabelX label1;
        private LabelX label2;
        private ButtonX buttonX1;
        private ButtonX buttonX2;
        private TextBoxX latestChangesTextBox;

        #endregion Fields

        #region Constructors (1)

        public ConfirmForm(AutoUpdater autoUpdater)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            this.autoUpdater = autoUpdater;
        }

        #endregion Constructors

        #region Methods (4)

        // Protected Methods (1) 

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        // Private Methods (3) 

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void Confirm_Activated(object sender, System.EventArgs e)
        {
            this.latestChangesTextBox.Text = this.autoUpdater.LatestConfigChanges;
        }

        #endregion Methods



        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new DevComponents.DotNetBar.LabelX();
            this.label2 = new DevComponents.DotNetBar.LabelX();
            this.latestChangesTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label1.BackgroundStyle.Class = "";
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "已有新版本，是否执行更新程序？";
            this.label1.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label2.BackgroundStyle.Class = "";
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "最新更新：";
            // 
            // latestChangesTextBox
            // 
            // 
            // 
            // 
            this.latestChangesTextBox.Border.Class = "";
            this.latestChangesTextBox.Location = new System.Drawing.Point(26, 73);
            this.latestChangesTextBox.Multiline = true;
            this.latestChangesTextBox.Name = "latestChangesTextBox";
            this.latestChangesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.latestChangesTextBox.Size = new System.Drawing.Size(221, 100);
            this.latestChangesTextBox.TabIndex = 4;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(51, 193);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 5;
            this.buttonX1.Text = "Yes";
            this.buttonX1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(132, 193);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 6;
            this.buttonX2.Text = "No";
            this.buttonX2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConfirmForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(274, 232);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.latestChangesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "是否确认";
            this.Activated += new System.EventHandler(this.Confirm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
