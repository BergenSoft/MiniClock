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
    public partial class FrmConfig : Form
    {
        #region Member variables
        private Config m_configOld;
        private Config m_config;
        private FrmClock m_clock;
        private CtlStyles m_ctlStyles;
        private CtlPositions m_ctlPositions;
        #endregion


        #region Properties
        public Config CurrentConfig
        {
            get
            {
                return m_config;
            }
        }
        #endregion


        #region Constructor
        public FrmConfig(Config config, FrmClock clock)
        {
            InitializeComponent();
            m_configOld = config;
            m_config = config.Clone() as Config;
            m_clock = clock;

            m_ctlStyles = new CtlStyles(ref m_config);
            tabStyles.Controls.Add(m_ctlStyles);
            m_ctlStyles.Dock = DockStyle.Fill;

            m_ctlPositions = new CtlPositions(ref m_config, ref clock);
            tabPositions.Controls.Add(m_ctlPositions);
            m_ctlPositions.Dock = DockStyle.Fill;
        }
        #endregion


        #region Events
        private void butApply_Click(object sender, EventArgs e)
        {
            CurrentConfig.X = m_clock.CurrentConfig.X;
            CurrentConfig.Y = m_clock.CurrentConfig.Y;

            m_clock.CurrentConfig = CurrentConfig.Clone() as Config;
            m_clock.CurrentConfig.Save();
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            butApply_Click(butApply, EventArgs.Empty);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            m_config = m_configOld;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}
