namespace Be.MiniClock.gui
{
    partial class CtlPositions
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
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstPositions = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butCurrentPosition = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butDelete = new System.Windows.Forms.Button();
            this.btnTestPosition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontDialog
            // 
            this.fontDialog.ShowColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "X:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstPositions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(567, 259);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 8;
            // 
            // lstPositions
            // 
            this.lstPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPositions.FormattingEnabled = true;
            this.lstPositions.Location = new System.Drawing.Point(0, 0);
            this.lstPositions.Name = "lstPositions";
            this.lstPositions.Size = new System.Drawing.Size(190, 259);
            this.lstPositions.TabIndex = 7;
            this.lstPositions.SelectedIndexChanged += new System.EventHandler(this.lstPositions_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTestPosition);
            this.panel2.Controls.Add(this.butCurrentPosition);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.numY);
            this.panel2.Controls.Add(this.numX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 259);
            this.panel2.TabIndex = 21;
            // 
            // butCurrentPosition
            // 
            this.butCurrentPosition.Location = new System.Drawing.Point(47, 81);
            this.butCurrentPosition.Name = "butCurrentPosition";
            this.butCurrentPosition.Size = new System.Drawing.Size(103, 23);
            this.butCurrentPosition.TabIndex = 0;
            this.butCurrentPosition.Text = "Aktuelle Position";
            this.butCurrentPosition.UseVisualStyleBackColor = true;
            this.butCurrentPosition.Click += new System.EventHandler(this.butCurrentPosition_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(47, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(323, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(47, 55);
            this.numY.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numY.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(71, 20);
            this.numY.TabIndex = 9;
            this.numY.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numY.ValueChanged += new System.EventHandler(this.numY_ValueChanged);
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(47, 29);
            this.numX.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numX.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(71, 20);
            this.numX.TabIndex = 9;
            this.numX.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numX.ValueChanged += new System.EventHandler(this.numX_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 29);
            this.panel1.TabIndex = 8;
            // 
            // butDelete
            // 
            this.butDelete.Image = global::Be.MiniClock.Properties.Resources.delete;
            this.butDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDelete.Location = new System.Drawing.Point(3, 3);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(83, 23);
            this.butDelete.TabIndex = 0;
            this.butDelete.Text = "Entfernen";
            this.butDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // btnTestPosition
            // 
            this.btnTestPosition.Location = new System.Drawing.Point(47, 110);
            this.btnTestPosition.Name = "btnTestPosition";
            this.btnTestPosition.Size = new System.Drawing.Size(103, 23);
            this.btnTestPosition.TabIndex = 14;
            this.btnTestPosition.Text = "Position testen";
            this.btnTestPosition.UseVisualStyleBackColor = true;
            this.btnTestPosition.Click += new System.EventHandler(this.btnTestPosition_Click);
            // 
            // CtlPositions
            // 
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(-300, 300);
            this.Name = "CtlPositions";
            this.Size = new System.Drawing.Size(567, 288);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstPositions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butCurrentPosition;
        private System.Windows.Forms.Button btnTestPosition;
    }
}