using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using Be.MiniClock.config;
using Be.MiniClock.helper;

namespace Be.MiniClock.gui
{
    public partial class CtlStyles : UserControl
    {
        #region Member variables
        private Config m_config;
        #endregion


        #region Properties
        public ConfigStyle CurrentStyle
        {
            get
            {
                return m_config.Styles[lstStyles.SelectedIndex];
            }
        }
        #endregion


        #region Constructor
        public CtlStyles(ref Config config)
        {
            InitializeComponent();
            m_config = config;

            FontFamily[] Schriftarten = FontFamily.Families;
            cmbFontname.DisplayMember = "Name";
            cmbFontname.DataSource = Schriftarten;
            cmbFontname.SelectedIndexChanged += cmbFontname_SelectedIndexChanged;

            object dummy = m_config.CurrentStyle;
            UpdateList();
            lstStyles.SelectedIndex = 0;
            UpdateInputs();
        }
        #endregion


        #region Overriden Functions
        #endregion


        #region Events
        private void butAdd_Click(object sender, EventArgs e)
        {
            ConfigStyle style = new ConfigStyle("neu");
            m_config.Styles.Add(style);
            lstStyles.SelectedIndex = lstStyles.Items.Add(style);
            txtName.Focus();
            txtName.SelectAll();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            m_config.Styles.RemoveAt(lstStyles.SelectedIndex);
            lstStyles.Items.RemoveAt(lstStyles.SelectedIndex);
        }


        private void lstStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStyles.SelectedIndex == -1)
            {
                if (lstStyles.Items.Count == 0)
                    lstStyles.Items.Add(m_config.CurrentStyle);
                lstStyles.SelectedIndex = 0;
                return;
            }
            UpdateInputs();
        }



        private void txtName_TextChanged(object sender, EventArgs e)
        {
            CurrentStyle.Name = txtName.Text;
            lstStyles.SelectedIndexChanged -= lstStyles_SelectedIndexChanged;
            lstStyles.Items[lstStyles.SelectedIndex] = lstStyles.Items[lstStyles.SelectedIndex];
            lstStyles.SelectedIndexChanged += lstStyles_SelectedIndexChanged;
        }

        private void txtFormat_TextChanged(object sender, EventArgs e)
        {
            CurrentStyle.TimeFormat = txtFormat.Text;
        }

        private void cmbFontname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_config == null) return;

            CurrentStyle.FontName = cmbFontname.Text;
        }

        private void numFontSize_ValueChanged(object sender, EventArgs e)
        {
            CurrentStyle.FontSize = Convert.ToSingle(numFontSize.Value);
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            CurrentStyle.Bold = chkBold.Checked;
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            CurrentStyle.Underline = chkUnderline.Checked;
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            CurrentStyle.Italic = chkItalic.Checked;
        }

        private void chkStrikeout_CheckedChanged(object sender, EventArgs e)
        {
            CurrentStyle.Strikeout = chkStrikeout.Checked;
        }

        private void picColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = (sender as PictureBox).BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
                (sender as PictureBox).BackColor = colorDialog.Color;

            CurrentStyle.FontColor = picFontColor.BackColor;
            CurrentStyle.ShadowColor = picShadowColor.BackColor;
        }

        private void radTL_CheckedChanged(object sender, EventArgs e)
        {
            CurrentStyle.HAlign = StringAlignment.Near;
            CurrentStyle.VAlign = StringAlignment.Near;
        }

        private void radT_CheckedChanged(object sender, EventArgs e)
        {
            CurrentStyle.HAlign = StringAlignment.Center;
            CurrentStyle.VAlign = StringAlignment.Near;
        }

        private void radTR_CheckedChanged(object sender, EventArgs e)
        {
            CurrentStyle.HAlign = StringAlignment.Far;
            CurrentStyle.VAlign = StringAlignment.Near;
        }

        private void radL_CheckedChanged(object sender, EventArgs e)
        {
            CurrentStyle.HAlign = StringAlignment.Near;
            CurrentStyle.VAlign = StringAlignment.Center;
        }

        private void radC_CheckedChanged(object sender, EventArgs e)
        {
            CurrentStyle.HAlign = StringAlignment.Center;
            CurrentStyle.VAlign = StringAlignment.Center;
        }

        private void radR_CheckedChanged(object sender, EventArgs e)
        {
            CurrentStyle.HAlign = StringAlignment.Far;
            CurrentStyle.VAlign = StringAlignment.Center;
        }

        private void radBL_CheckedChanged(object sender, EventArgs e)
        {
            CurrentStyle.HAlign = StringAlignment.Near;
            CurrentStyle.VAlign = StringAlignment.Far;
        }

        private void radB_CheckedChanged(object sender, EventArgs e)
        {
            CurrentStyle.HAlign = StringAlignment.Center;
            CurrentStyle.VAlign = StringAlignment.Far;
        }

        private void radBR_CheckedChanged(object sender, EventArgs e)
        {
            CurrentStyle.HAlign = StringAlignment.Far;
            CurrentStyle.VAlign = StringAlignment.Far;
        }

        private void numShadowStrength_ValueChanged(object sender, EventArgs e)
        {
            CurrentStyle.ShadowStrength = Convert.ToInt32(numShadowStrength.Value);
        }

        private void numShadowWidth_ValueChanged(object sender, EventArgs e)
        {
            CurrentStyle.ShadowWidth = Convert.ToInt32(numShadowWidth.Value);
        }
        #endregion


        #region Private Functions
        private void UpdateList()
        {
            foreach (ConfigStyle style in m_config.Styles)
            {
                lstStyles.Items.Add(style);
            }
        }

        private void UpdateInputs()
        {
            txtName.Text = CurrentStyle.Name;
            txtFormat.Text = CurrentStyle.TimeFormat;
            cmbFontname.Text = CurrentStyle.FontName;
            numFontSize.Value = Convert.ToDecimal(CurrentStyle.FontSize);
            chkBold.Checked = CurrentStyle.Bold;
            chkUnderline.Checked = CurrentStyle.Underline;
            chkItalic.Checked = CurrentStyle.Italic;
            chkStrikeout.Checked = CurrentStyle.Strikeout;
            picFontColor.BackColor = CurrentStyle.FontColor;

            switch (CurrentStyle.HAlign)
            {
                case StringAlignment.Near:
                    switch (CurrentStyle.VAlign)
                    {
                        case StringAlignment.Near:
                            radTL.Checked = true;
                            break;
                        case StringAlignment.Center:
                            radL.Checked = true;
                            break;
                        case StringAlignment.Far:
                            radBL.Checked = true;
                            break;
                    }
                    break;
                case StringAlignment.Center:
                    switch (CurrentStyle.VAlign)
                    {
                        case StringAlignment.Near:
                            radT.Checked = true;
                            break;
                        case StringAlignment.Center:
                            radC.Checked = true;
                            break;
                        case StringAlignment.Far:
                            radB.Checked = true;
                            break;
                    }
                    break;
                case StringAlignment.Far:
                    switch (CurrentStyle.VAlign)
                    {
                        case StringAlignment.Near:
                            radTR.Checked = true;
                            break;
                        case StringAlignment.Center:
                            radR.Checked = true;
                            break;
                        case StringAlignment.Far:
                            radBR.Checked = true;
                            break;
                    }
                    break;
            }

            numShadowStrength.Value = CurrentStyle.ShadowStrength;
            numShadowWidth.Value = CurrentStyle.ShadowWidth;
            picShadowColor.BackColor = CurrentStyle.ShadowColor;
        }
        #endregion
    }
}
