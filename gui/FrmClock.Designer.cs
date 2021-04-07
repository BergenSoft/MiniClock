namespace Be.MiniClock.gui
{
    partial class FrmClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClock));
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuPositions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPositionAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPositionSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuStyles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrShow = new System.Windows.Forms.Timer(this.components);
            this.tmrHide = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 17);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "08:12:30";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTime.Visible = false;
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 50;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.menu;
            this.notify.Text = "Mini Clock";
            this.notify.Visible = true;
            this.notify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseClick);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPositions,
            this.mnuStyles,
            this.toolStripMenuItem3,
            this.mnuSettings,
            this.toolStripMenuItem1,
            this.mnuQuit});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(146, 104);
            // 
            // mnuPositions
            // 
            this.mnuPositions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPositionAdd,
            this.mnuPositionSave,
            this.toolStripMenuItem2});
            this.mnuPositions.Image = global::Be.MiniClock.Properties.Resources.move;
            this.mnuPositions.Name = "mnuPositions";
            this.mnuPositions.Size = new System.Drawing.Size(145, 22);
            this.mnuPositions.Text = "Positon";
            // 
            // mnuPositionAdd
            // 
            this.mnuPositionAdd.Image = global::Be.MiniClock.Properties.Resources.add;
            this.mnuPositionAdd.Name = "mnuPositionAdd";
            this.mnuPositionAdd.Size = new System.Drawing.Size(152, 22);
            this.mnuPositionAdd.Text = "Hinzufügen";
            this.mnuPositionAdd.Click += new System.EventHandler(this.mnuPositionAdd_Click);
            // 
            // mnuPositionSave
            // 
            this.mnuPositionSave.Image = global::Be.MiniClock.Properties.Resources.save;
            this.mnuPositionSave.Name = "mnuPositionSave";
            this.mnuPositionSave.Size = new System.Drawing.Size(152, 22);
            this.mnuPositionSave.Text = "Speichern";
            this.mnuPositionSave.Click += new System.EventHandler(this.mnuPositionSave_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuStyles
            // 
            this.mnuStyles.Image = global::Be.MiniClock.Properties.Resources.style;
            this.mnuStyles.Name = "mnuStyles";
            this.mnuStyles.Size = new System.Drawing.Size(145, 22);
            this.mnuStyles.Text = "Styles";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuSettings
            // 
            this.mnuSettings.Image = global::Be.MiniClock.Properties.Resources.settings;
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(145, 22);
            this.mnuSettings.Text = "Einstellungen";
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuQuit
            // 
            this.mnuQuit.Image = global::Be.MiniClock.Properties.Resources.door;
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.Size = new System.Drawing.Size(145, 22);
            this.mnuQuit.Text = "Beenden";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // tmrShow
            // 
            this.tmrShow.Interval = 10;
            this.tmrShow.Tick += new System.EventHandler(this.tmrShow_Tick);
            // 
            // tmrHide
            // 
            this.tmrHide.Interval = 10;
            this.tmrHide.Tick += new System.EventHandler(this.tmrHide_Tick);
            // 
            // FrmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(116, 41);
            this.Controls.Add(this.lblTime);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Name = "FrmClock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TelegramViewer Splash";
            this.TopMost = true;
            this.Move += new System.EventHandler(this.FrmClock_Move);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.ToolStripMenuItem mnuPositions;
        private System.Windows.Forms.ToolStripMenuItem mnuPositionSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuPositionAdd;
        private System.Windows.Forms.Timer tmrShow;
        private System.Windows.Forms.Timer tmrHide;
        private System.Windows.Forms.ToolStripMenuItem mnuStyles;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;







    }
}