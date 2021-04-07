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
    public partial class CtlPositions : UserControl
    {
        #region Member variables
        private Config m_config;

        private FrmClock m_clock;
        #endregion


        #region Properties
        public ConfigPosition CurrentPosition
        {
            get
            {
                return m_config.Positions[lstPositions.SelectedIndex];
            }
        }
        #endregion


        #region Constructor
        public CtlPositions(ref Config config, ref FrmClock clock)
        {
            InitializeComponent();
            m_config = config;
            m_clock = clock;

            UpdateList();
            if (lstPositions.Items.Count != 0)
                lstPositions.SelectedIndex = 0;
        }
        #endregion


        #region Events
        private void butDelete_Click(object sender, EventArgs e)
        {
            m_config.Positions.RemoveAt(lstPositions.SelectedIndex);
            lstPositions.Items.RemoveAt(lstPositions.SelectedIndex);
        }


        private void lstPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPositions.SelectedIndex != -1)
                UpdateInputs();
        }



        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (lstPositions.SelectedIndex == -1) return;

            CurrentPosition.Name = txtName.Text;
            lstPositions.SelectedIndexChanged -= lstPositions_SelectedIndexChanged;
            lstPositions.Items[lstPositions.SelectedIndex] = lstPositions.Items[lstPositions.SelectedIndex];
            lstPositions.SelectedIndexChanged += lstPositions_SelectedIndexChanged;
        }

        private void numX_ValueChanged(object sender, EventArgs e)
        {
            if (lstPositions.SelectedIndex == -1) return;

            CurrentPosition.X = Convert.ToInt32(numX.Value);
        }

        private void numY_ValueChanged(object sender, EventArgs e)
        {
            if (lstPositions.SelectedIndex == -1) return;

            CurrentPosition.Y = Convert.ToInt32(numY.Value);
        }


        private void butCurrentPosition_Click(object sender, EventArgs e)
        {
            numX.Value = m_clock.AnchorPoint.X;
            numY.Value = m_clock.AnchorPoint.Y;
        }

        private void btnTestPosition_Click(object sender, EventArgs e)
        {
            m_clock.AnchorPoint = new Point(Convert.ToInt32(numX.Value), Convert.ToInt32(numY.Value));
        }
        #endregion


        #region Private Functions
        private void UpdateList()
        {
            foreach (ConfigPosition pos in m_config.Positions)
            {
                lstPositions.Items.Add(pos);
            }
        }

        private void UpdateInputs()
        {
            txtName.Text = CurrentPosition.Name;
            numX.Value = CurrentPosition.X;
            numY.Value = CurrentPosition.Y;
        }
        #endregion
    }
}
