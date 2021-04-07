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
    public partial class FrmInput : Form
    {
        #region Properties
        public string Value { get { return txtValue.Text; } }
        #endregion


        #region Constructor
        public FrmInput(string text, string title, string defaultValue = null)
        {
            InitializeComponent();

            int heightOffset = this.Height - lblText.Height;

            lblText.Text = text;
            this.Text = title;
            if (Value != null)
                txtValue.Text = Value;

            this.Height = heightOffset + lblText.Height;
            this.Width = lblText.Width + lblText.Left * 2;
        }
        #endregion


        public static string GetInput(string text, string title, string defaultValue = null, Form parent = null)
        {
            FrmInput frm = new FrmInput(text, title, defaultValue);

            if (frm.ShowDialog(parent) == DialogResult.OK)
                return frm.Value;

            return null;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmInput_Shown(object sender, EventArgs e)
        {
            txtValue.SelectAll();
        }
    }
}
