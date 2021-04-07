namespace Be.MiniClock.gui
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.butOk = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabStyles = new System.Windows.Forms.TabPage();
            this.tabPositions = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butApply = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontDialog
            // 
            this.fontDialog.ShowColor = true;
            // 
            // butOk
            // 
            this.butOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butOk.Location = new System.Drawing.Point(403, 11);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 8;
            this.butOk.Text = "&OK";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butCancel
            // 
            this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(485, 11);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 9;
            this.butCancel.Text = "&Abbrechen";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabStyles);
            this.tab.Controls.Add(this.tabPositions);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(574, 307);
            this.tab.TabIndex = 10;
            // 
            // tabStyles
            // 
            this.tabStyles.Location = new System.Drawing.Point(4, 22);
            this.tabStyles.Name = "tabStyles";
            this.tabStyles.Padding = new System.Windows.Forms.Padding(3);
            this.tabStyles.Size = new System.Drawing.Size(566, 281);
            this.tabStyles.TabIndex = 0;
            this.tabStyles.Text = "Styles";
            this.tabStyles.UseVisualStyleBackColor = true;
            // 
            // tabPositions
            // 
            this.tabPositions.Location = new System.Drawing.Point(4, 22);
            this.tabPositions.Name = "tabPositions";
            this.tabPositions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPositions.Size = new System.Drawing.Size(566, 385);
            this.tabPositions.TabIndex = 1;
            this.tabPositions.Text = "Positionen";
            this.tabPositions.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.butCancel);
            this.panel1.Controls.Add(this.butApply);
            this.panel1.Controls.Add(this.butOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 46);
            this.panel1.TabIndex = 8;
            // 
            // butApply
            // 
            this.butApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butApply.Location = new System.Drawing.Point(312, 11);
            this.butApply.Name = "butApply";
            this.butApply.Size = new System.Drawing.Size(85, 23);
            this.butApply.TabIndex = 8;
            this.butApply.Text = "Ü&bernehmen";
            this.butApply.UseVisualStyleBackColor = true;
            this.butApply.Click += new System.EventHandler(this.butApply_Click);
            // 
            // FrmConfig
            // 
            this.AcceptButton = this.butOk;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(574, 353);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-300, 300);
            this.MinimumSize = new System.Drawing.Size(284, 391);
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniClock - Einstellungen";
            this.tab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabStyles;
        private System.Windows.Forms.TabPage tabPositions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butApply;







    }
}