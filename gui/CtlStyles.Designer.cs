namespace Be.MiniClock.gui
{
    partial class CtlStyles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtlStyles));
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkStrikeout = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.cmbFontname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radTL = new System.Windows.Forms.RadioButton();
            this.radT = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstStyles = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numShadowWidth = new System.Windows.Forms.NumericUpDown();
            this.numShadowStrength = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radBR = new System.Windows.Forms.RadioButton();
            this.radR = new System.Windows.Forms.RadioButton();
            this.radTR = new System.Windows.Forms.RadioButton();
            this.radBL = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.radL = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.picShadowColor = new System.Windows.Forms.PictureBox();
            this.picFontColor = new System.Windows.Forms.PictureBox();
            this.butDelete = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShadowWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShadowStrength)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShadowColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFontColor)).BeginInit();
            this.SuspendLayout();
            // 
            // fontDialog
            // 
            this.fontDialog.ShowColor = true;
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(52, 29);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(120, 20);
            this.txtFormat.TabIndex = 1;
            this.txtFormat.Text = "hh:mm:ss";
            this.txtFormat.TextChanged += new System.EventHandler(this.txtFormat_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Format:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Schrift:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Breite:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stärke:";
            // 
            // chkUnderline
            // 
            this.chkUnderline.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnderline.Location = new System.Drawing.Point(75, 111);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(24, 23);
            this.chkUnderline.TabIndex = 12;
            this.chkUnderline.Text = "U";
            this.chkUnderline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // chkStrikeout
            // 
            this.chkStrikeout.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkStrikeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStrikeout.Location = new System.Drawing.Point(121, 111);
            this.chkStrikeout.Name = "chkStrikeout";
            this.chkStrikeout.Size = new System.Drawing.Size(24, 23);
            this.chkStrikeout.TabIndex = 11;
            this.chkStrikeout.Text = "D";
            this.chkStrikeout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkStrikeout.UseVisualStyleBackColor = true;
            this.chkStrikeout.CheckedChanged += new System.EventHandler(this.chkStrikeout_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.Location = new System.Drawing.Point(98, 111);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(24, 23);
            this.chkItalic.TabIndex = 11;
            this.chkItalic.Text = "K";
            this.chkItalic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.Location = new System.Drawing.Point(52, 111);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(24, 23);
            this.chkBold.TabIndex = 10;
            this.chkBold.Text = "F";
            this.chkBold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // numFontSize
            // 
            this.numFontSize.Location = new System.Drawing.Point(52, 85);
            this.numFontSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(93, 20);
            this.numFontSize.TabIndex = 9;
            this.numFontSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numFontSize.ValueChanged += new System.EventHandler(this.numFontSize_ValueChanged);
            // 
            // cmbFontname
            // 
            this.cmbFontname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFontname.FormattingEnabled = true;
            this.cmbFontname.Location = new System.Drawing.Point(52, 55);
            this.cmbFontname.Name = "cmbFontname";
            this.cmbFontname.Size = new System.Drawing.Size(315, 21);
            this.cmbFontname.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Schatten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Farbe:";
            // 
            // radTL
            // 
            this.radTL.Appearance = System.Windows.Forms.Appearance.Button;
            this.radTL.Checked = true;
            this.radTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTL.Image = ((System.Drawing.Image)(resources.GetObject("radTL.Image")));
            this.radTL.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radTL.Location = new System.Drawing.Point(186, 82);
            this.radTL.Name = "radTL";
            this.radTL.Size = new System.Drawing.Size(27, 27);
            this.radTL.TabIndex = 18;
            this.radTL.TabStop = true;
            this.radTL.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radTL.UseVisualStyleBackColor = true;
            this.radTL.CheckedChanged += new System.EventHandler(this.radTL_CheckedChanged);
            // 
            // radT
            // 
            this.radT.Appearance = System.Windows.Forms.Appearance.Button;
            this.radT.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radT.Image = ((System.Drawing.Image)(resources.GetObject("radT.Image")));
            this.radT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radT.Location = new System.Drawing.Point(212, 82);
            this.radT.Name = "radT";
            this.radT.Size = new System.Drawing.Size(27, 27);
            this.radT.TabIndex = 19;
            this.radT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radT.UseVisualStyleBackColor = true;
            this.radT.CheckedChanged += new System.EventHandler(this.radT_CheckedChanged);
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
            this.splitContainer1.Panel1.Controls.Add(this.lstStyles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(574, 248);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 8;
            // 
            // lstStyles
            // 
            this.lstStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStyles.FormattingEnabled = true;
            this.lstStyles.Location = new System.Drawing.Point(0, 0);
            this.lstStyles.Name = "lstStyles";
            this.lstStyles.Size = new System.Drawing.Size(190, 248);
            this.lstStyles.TabIndex = 7;
            this.lstStyles.SelectedIndexChanged += new System.EventHandler(this.lstStyles_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.radBR);
            this.panel2.Controls.Add(this.radR);
            this.panel2.Controls.Add(this.radTR);
            this.panel2.Controls.Add(this.radBL);
            this.panel2.Controls.Add(this.radB);
            this.panel2.Controls.Add(this.radL);
            this.panel2.Controls.Add(this.radC);
            this.panel2.Controls.Add(this.radTL);
            this.panel2.Controls.Add(this.radT);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.picShadowColor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtFormat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.chkUnderline);
            this.panel2.Controls.Add(this.cmbFontname);
            this.panel2.Controls.Add(this.chkStrikeout);
            this.panel2.Controls.Add(this.picFontColor);
            this.panel2.Controls.Add(this.chkItalic);
            this.panel2.Controls.Add(this.numShadowWidth);
            this.panel2.Controls.Add(this.numShadowStrength);
            this.panel2.Controls.Add(this.numFontSize);
            this.panel2.Controls.Add(this.chkBold);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 248);
            this.panel2.TabIndex = 21;
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
            this.txtName.Location = new System.Drawing.Point(52, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // numShadowWidth
            // 
            this.numShadowWidth.Location = new System.Drawing.Point(52, 196);
            this.numShadowWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numShadowWidth.Name = "numShadowWidth";
            this.numShadowWidth.Size = new System.Drawing.Size(54, 20);
            this.numShadowWidth.TabIndex = 9;
            this.numShadowWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numShadowWidth.ValueChanged += new System.EventHandler(this.numShadowWidth_ValueChanged);
            // 
            // numShadowStrength
            // 
            this.numShadowStrength.Location = new System.Drawing.Point(52, 170);
            this.numShadowStrength.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numShadowStrength.Name = "numShadowStrength";
            this.numShadowStrength.Size = new System.Drawing.Size(54, 20);
            this.numShadowStrength.TabIndex = 9;
            this.numShadowStrength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numShadowStrength.ValueChanged += new System.EventHandler(this.numShadowStrength_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butDelete);
            this.panel1.Controls.Add(this.butAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 29);
            this.panel1.TabIndex = 8;
            // 
            // radBR
            // 
            this.radBR.Appearance = System.Windows.Forms.Appearance.Button;
            this.radBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBR.Image = ((System.Drawing.Image)(resources.GetObject("radBR.Image")));
            this.radBR.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.radBR.Location = new System.Drawing.Point(238, 134);
            this.radBR.Name = "radBR";
            this.radBR.Size = new System.Drawing.Size(27, 27);
            this.radBR.TabIndex = 20;
            this.radBR.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.radBR.UseVisualStyleBackColor = true;
            this.radBR.CheckedChanged += new System.EventHandler(this.radBR_CheckedChanged);
            // 
            // radR
            // 
            this.radR.Appearance = System.Windows.Forms.Appearance.Button;
            this.radR.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radR.Image = ((System.Drawing.Image)(resources.GetObject("radR.Image")));
            this.radR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radR.Location = new System.Drawing.Point(238, 108);
            this.radR.Name = "radR";
            this.radR.Size = new System.Drawing.Size(27, 27);
            this.radR.TabIndex = 20;
            this.radR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radR.UseVisualStyleBackColor = true;
            this.radR.CheckedChanged += new System.EventHandler(this.radR_CheckedChanged);
            // 
            // radTR
            // 
            this.radTR.Appearance = System.Windows.Forms.Appearance.Button;
            this.radTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTR.Image = ((System.Drawing.Image)(resources.GetObject("radTR.Image")));
            this.radTR.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.radTR.Location = new System.Drawing.Point(238, 82);
            this.radTR.Name = "radTR";
            this.radTR.Size = new System.Drawing.Size(27, 27);
            this.radTR.TabIndex = 20;
            this.radTR.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.radTR.UseVisualStyleBackColor = true;
            this.radTR.CheckedChanged += new System.EventHandler(this.radTR_CheckedChanged);
            // 
            // radBL
            // 
            this.radBL.Appearance = System.Windows.Forms.Appearance.Button;
            this.radBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBL.Image = ((System.Drawing.Image)(resources.GetObject("radBL.Image")));
            this.radBL.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radBL.Location = new System.Drawing.Point(186, 134);
            this.radBL.Name = "radBL";
            this.radBL.Size = new System.Drawing.Size(27, 27);
            this.radBL.TabIndex = 18;
            this.radBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radBL.UseVisualStyleBackColor = true;
            this.radBL.CheckedChanged += new System.EventHandler(this.radBL_CheckedChanged);
            // 
            // radB
            // 
            this.radB.Appearance = System.Windows.Forms.Appearance.Button;
            this.radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radB.Image = ((System.Drawing.Image)(resources.GetObject("radB.Image")));
            this.radB.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radB.Location = new System.Drawing.Point(212, 134);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(27, 27);
            this.radB.TabIndex = 19;
            this.radB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radB.UseVisualStyleBackColor = true;
            this.radB.CheckedChanged += new System.EventHandler(this.radB_CheckedChanged);
            // 
            // radL
            // 
            this.radL.Appearance = System.Windows.Forms.Appearance.Button;
            this.radL.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radL.Image = ((System.Drawing.Image)(resources.GetObject("radL.Image")));
            this.radL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radL.Location = new System.Drawing.Point(186, 108);
            this.radL.Name = "radL";
            this.radL.Size = new System.Drawing.Size(27, 27);
            this.radL.TabIndex = 18;
            this.radL.UseVisualStyleBackColor = true;
            this.radL.CheckedChanged += new System.EventHandler(this.radL_CheckedChanged);
            // 
            // radC
            // 
            this.radC.Appearance = System.Windows.Forms.Appearance.Button;
            this.radC.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radC.Image = ((System.Drawing.Image)(resources.GetObject("radC.Image")));
            this.radC.Location = new System.Drawing.Point(212, 108);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(27, 27);
            this.radC.TabIndex = 19;
            this.radC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radC.UseVisualStyleBackColor = true;
            this.radC.CheckedChanged += new System.EventHandler(this.radC_CheckedChanged);
            // 
            // picShadowColor
            // 
            this.picShadowColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShadowColor.Location = new System.Drawing.Point(52, 222);
            this.picShadowColor.Name = "picShadowColor";
            this.picShadowColor.Size = new System.Drawing.Size(21, 21);
            this.picShadowColor.TabIndex = 7;
            this.picShadowColor.TabStop = false;
            this.picShadowColor.Click += new System.EventHandler(this.picColor_Click);
            // 
            // picFontColor
            // 
            this.picFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFontColor.Location = new System.Drawing.Point(150, 85);
            this.picFontColor.Name = "picFontColor";
            this.picFontColor.Size = new System.Drawing.Size(21, 21);
            this.picFontColor.TabIndex = 7;
            this.picFontColor.TabStop = false;
            this.picFontColor.Click += new System.EventHandler(this.picColor_Click);
            // 
            // butDelete
            // 
            this.butDelete.Image = global::Be.MiniClock.Properties.Resources.delete;
            this.butDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDelete.Location = new System.Drawing.Point(62, 3);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(83, 23);
            this.butDelete.TabIndex = 0;
            this.butDelete.Text = "Entfernen";
            this.butDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butAdd
            // 
            this.butAdd.Image = global::Be.MiniClock.Properties.Resources.add;
            this.butAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butAdd.Location = new System.Drawing.Point(3, 3);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(53, 23);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "Neu";
            this.butAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // CtlStyles
            // 
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(-300, 300);
            this.Name = "CtlStyles";
            this.Size = new System.Drawing.Size(574, 277);
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShadowWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShadowStrength)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShadowColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFontColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.PictureBox picFontColor;
        private System.Windows.Forms.ComboBox cmbFontname;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkStrikeout;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picShadowColor;
        private System.Windows.Forms.RadioButton radTR;
        private System.Windows.Forms.RadioButton radT;
        private System.Windows.Forms.RadioButton radTL;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstStyles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numShadowWidth;
        private System.Windows.Forms.NumericUpDown numShadowStrength;
        private System.Windows.Forms.RadioButton radBR;
        private System.Windows.Forms.RadioButton radR;
        private System.Windows.Forms.RadioButton radBL;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radL;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butAdd;







    }
}