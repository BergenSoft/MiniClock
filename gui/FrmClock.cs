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
    public partial class FrmClock : Form
    {
        #region Member variables
        private Config m_config;

        private double m_opacity = 1;
        #endregion


        #region Properties
        public Config CurrentConfig
        {
            get
            {
                return m_config;
            }

            set
            {
                m_config = value;

                lblTime.Left = CurrentStyle.ShadowWidth;
                lblTime.Top = lblTime.Left;
                lblTime.Font = new System.Drawing.Font(CurrentStyle.FontName, CurrentStyle.FontSize, (CurrentStyle.Bold ? FontStyle.Bold : FontStyle.Regular) | (CurrentStyle.Underline ? FontStyle.Underline : FontStyle.Regular) | (CurrentStyle.Italic ? FontStyle.Italic : FontStyle.Regular) | (CurrentStyle.Strikeout ? FontStyle.Strikeout : FontStyle.Regular));
                lblTime.ForeColor = CurrentStyle.FontColor;

                AnchorPoint = new Point(m_config.X, m_config.Y);

                while (mnuPositions.DropDownItems.Count > 3)
                    mnuPositions.DropDownItems.RemoveAt(3);

                foreach (ConfigPosition loc in m_config.Positions)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem(loc.Name);
                    item.Click += mnuPositions_Click;
                    item.Tag = loc;
                    mnuPositions.DropDownItems.Add(item);

                    if (loc.X == AnchorPoint.X && loc.Y == AnchorPoint.Y)
                        mnuPositionSave.Tag = item;

                    if (mnuPositionSave.Tag != null && (item.Tag as ConfigPosition).Name == ((mnuPositionSave.Tag as ToolStripMenuItem).Tag as ConfigPosition).Name)
                        item.Checked = true;
                }

                mnuStyles.DropDownItems.Clear();

                foreach (ConfigStyle style in m_config.Styles)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem(style.Name);
                    item.Click += mnuStyles_Click;
                    item.Tag = style;
                    mnuStyles.DropDownItems.Add(item);

                    if (m_config.Styles.IndexOf(style) == m_config.LastStyle)
                        item.Checked = true;
                }

            }
        }

        public ConfigStyle CurrentStyle
        {
            get
            {
                return m_config.CurrentStyle;
            }
        }

        public Point AnchorPoint { get; set; }
        #endregion


        #region Constructor
        public FrmClock()
        {
            InitializeComponent();
            ReloadConfig();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            notify.Icon = this.Icon;
        }
        #endregion


        #region Events
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            WinApi.SetWindowPos(Handle, WinApi.HWND_TOPMOST, 0, 0, 0, 0, WinApi.SWP_NOMOVE | WinApi.SWP_NOSIZE | WinApi.SWP_NOACTIVATE);

            try
            {
                lblTime.Text = DateTime.Now.ToString(CurrentStyle.TimeFormatUse);
            }
            catch (Exception ex)
            {
                lblTime.Text = ex.Message;
            }
            this.Width = lblTime.Width + 2 * lblTime.Left;
            this.Height = lblTime.Height + 2 * lblTime.Top;

            this.Move -= FrmClock_Move;

            switch (CurrentStyle.HAlign)
            {
                case StringAlignment.Near:
                    switch (CurrentStyle.VAlign)
                    {
                        case StringAlignment.Near:
                            Location = new Point(AnchorPoint.X, AnchorPoint.Y);
                            break;
                        case StringAlignment.Center:
                            Location = new Point(AnchorPoint.X, AnchorPoint.Y - this.Height / 2);
                            break;
                        case StringAlignment.Far:
                            Location = new Point(AnchorPoint.X, AnchorPoint.Y - this.Height);
                            break;
                    }
                    break;
                case StringAlignment.Center:
                    switch (CurrentStyle.VAlign)
                    {
                        case StringAlignment.Near:
                            Location = new Point(AnchorPoint.X - this.Width / 2, AnchorPoint.Y);
                            break;
                        case StringAlignment.Center:
                            Location = new Point(AnchorPoint.X - this.Width / 2, AnchorPoint.Y - this.Height / 2);
                            break;
                        case StringAlignment.Far:
                            Location = new Point(AnchorPoint.X - this.Width / 2, AnchorPoint.Y - this.Height);
                            break;
                    }
                    break;
                case StringAlignment.Far:
                    switch (CurrentStyle.VAlign)
                    {
                        case StringAlignment.Near:
                            Location = new Point(AnchorPoint.X - this.Width, AnchorPoint.Y);
                            break;
                        case StringAlignment.Center:
                            Location = new Point(AnchorPoint.X - this.Width, AnchorPoint.Y - this.Height / 2);
                            break;
                        case StringAlignment.Far:
                            Location = new Point(AnchorPoint.X - this.Width, AnchorPoint.Y - this.Height);
                            break;
                    }
                    break;
            }
            this.Move += FrmClock_Move;


            UpdateForm(BackgroundImage);
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            tmrTime.Enabled = true;
            tmrHide.Enabled = false;
            this.Visible = true;

            if (m_opacity < 1)
                m_opacity += 0.05;

            if (m_opacity > 1)
                m_opacity = 1;

            if (m_opacity == 1)
                tmrShow.Enabled = false;
        }

        private void tmrHide_Tick(object sender, EventArgs e)
        {
            tmrShow.Enabled = false;

            if (m_opacity > 0)
                m_opacity -= 0.05;

            if (m_opacity < 0)
                m_opacity = 0;

            if (m_opacity == 0)
            {
                tmrTime.Enabled = false;
                tmrHide.Enabled = false;
                this.Visible = false;
            }
        }


        private void mnuSettings_Click(object sender, EventArgs e)
        {
            FrmConfig frm = new FrmConfig(CurrentConfig, this);
            frm.Show();
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuPositionAdd_Click(object sender, EventArgs e)
        {
            string name = FrmInput.GetInput("Geben Sie eine Bezeichnung ein:", "Bezeichnung eingeben", null, this);

            if (name != null)
            {
                foreach (ToolStripItem itemOther in mnuPositions.DropDownItems)
                {
                    if (itemOther is ToolStripMenuItem)
                    {
                        if ((itemOther as ToolStripMenuItem).Checked)
                        {
                            (itemOther as ToolStripMenuItem).Checked = false;
                            break;
                        }
                    }
                }

                ConfigPosition loc = new ConfigPosition(name, Left, Top);
                CurrentConfig.Positions.Add(loc);
                CurrentConfig.Save();

                ToolStripMenuItem item = new ToolStripMenuItem(name);
                item.Click += mnuPositions_Click;
                item.Tag = loc;
                item.Checked = true;
                mnuPositions.DropDownItems.Add(item);

                mnuPositionSave.Tag = item;
            }
        }

        private void mnuPositionSave_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            if (item.Tag == null) return;

            ToolStripMenuItem posItem = item.Tag as ToolStripMenuItem;
            ConfigPosition pos = posItem.Tag as ConfigPosition;

            pos.X = Left;
            pos.Y = Top;

            CurrentConfig.Save();
        }

        private void mnuPositions_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            ConfigPosition pos = item.Tag as ConfigPosition;

            this.Location = new Point(pos.X, pos.Y);

            foreach (ToolStripItem itemOther in mnuPositions.DropDownItems)
            {
                if (itemOther is ToolStripMenuItem)
                {
                    if ((itemOther as ToolStripMenuItem).Checked)
                    {
                        (itemOther as ToolStripMenuItem).Checked = false;
                        break;
                    }
                }
            }

            mnuPositionSave.Enabled = true;
            mnuPositionSave.Tag = item;
            item.Checked = true;
        }

        private void mnuStyles_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            ConfigStyle style = item.Tag as ConfigStyle;

            m_config.LastStyle = m_config.Styles.IndexOf(style);
            CurrentConfig = CurrentConfig;
            CurrentConfig.Save();
        }


        private void notify_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (!this.Visible || tmrHide.Enabled)
                {
                    tmrHide.Enabled = false;
                    tmrShow.Enabled = true;
                    notify.Icon = MiniClock.Properties.Resources.clock_48;
                }
                else
                {
                    tmrHide.Enabled = true;
                    tmrShow.Enabled = false;
                    notify.Icon = MiniClock.Properties.Resources.clock_off_48;
                }
            }
        }


        private void FrmClock_Move(object sender, EventArgs e)
        {
            switch (CurrentStyle.HAlign)
            {
                case StringAlignment.Near:
                    switch (CurrentStyle.VAlign)
                    {
                        case StringAlignment.Near:
                            AnchorPoint = new Point(Left, Top);
                            break;
                        case StringAlignment.Center:
                            AnchorPoint = new Point(Left, Top + Height / 2);
                            break;
                        case StringAlignment.Far:
                            AnchorPoint = new Point(Left, Top + Height);
                            break;
                    }
                    break;
                case StringAlignment.Center:
                    switch (CurrentStyle.VAlign)
                    {
                        case StringAlignment.Near:
                            AnchorPoint = new Point(Left + Width / 2, Top);
                            break;
                        case StringAlignment.Center:
                            AnchorPoint = new Point(Left + Width / 2, Top + Height / 2);
                            break;
                        case StringAlignment.Far:
                            AnchorPoint = new Point(Left + Width / 2, Top + Height);
                            break;
                    }
                    break;
                case StringAlignment.Far:
                    switch (CurrentStyle.VAlign)
                    {
                        case StringAlignment.Near:
                            AnchorPoint = new Point(Left + Width, Top);
                            break;
                        case StringAlignment.Center:
                            AnchorPoint = new Point(Left + Width, Top + Height / 2);
                            break;
                        case StringAlignment.Far:
                            AnchorPoint = new Point(Left + Width, Top + Height);
                            break;
                    }
                    break;
            }

            CurrentConfig.X = AnchorPoint.X;
            CurrentConfig.Y = AnchorPoint.Y;
            CurrentConfig.Save();
        }
        #endregion


        #region Overriden Functions
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00080000;
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            bool doWndProc = true;

            const int WM_MOUSEACTIVATE = 0x21;
            const int MA_NOACTIVATE = 0x0003;
            const int WM_NCHITTEST = 0x84;
            const int WM_NCRBUTTONDOWN = 0xa4;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020;

            switch (m.Msg)
            {
                case WM_MOUSEACTIVATE:
                    m.Result = (IntPtr)MA_NOACTIVATE;
                    break;

                case WM_NCHITTEST:
                    m.Result = new IntPtr(2);
                    doWndProc = false;
                    break;

                case WM_NCRBUTTONDOWN:
                    menu.Show(Cursor.Position);
                    break;

                case WM_SYSCOMMAND:
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MINIMIZE)
                        return;
                    break;
            }

            if (doWndProc)
                base.WndProc(ref m);
        }
        #endregion


        #region Private Functions
        private void ReloadConfig()
        {
            CurrentConfig = Config.Load();
        }

        private void UpdateForm(Image backgroundImage)
        {
            IntPtr screenDc = WinApi.GetDC(IntPtr.Zero);
            IntPtr memDc = WinApi.CreateCompatibleDC(screenDc);
            IntPtr hBitmap = IntPtr.Zero;
            IntPtr oldBitmap = IntPtr.Zero;

            try
            {
                //Display-image
                Bitmap bmp = new Bitmap(this.Width, this.Height);
                Graphics g = Graphics.FromImage(bmp);

                g.TextRenderingHint = TextRenderingHint.AntiAlias;

                DrawString(g, lblTime);

                hBitmap = bmp.GetHbitmap(Color.FromArgb(0));  //Set the fact that background is transparent
                oldBitmap = WinApi.SelectObject(memDc, hBitmap);

                //Display-rectangle
                Size size = bmp.Size;
                Point pointSource = new Point(0, 0);
                Point topPos = new Point(this.Left, this.Top);

                //Set up blending options
                WinApi.BLENDFUNCTION blend = new WinApi.BLENDFUNCTION();
                blend.BlendOp = WinApi.AC_SRC_OVER;
                blend.BlendFlags = 0;
                blend.SourceConstantAlpha = 255;
                blend.AlphaFormat = WinApi.AC_SRC_ALPHA;

                WinApi.UpdateLayeredWindow(this.Handle, screenDc, ref topPos, ref size, memDc, ref pointSource, 0, ref blend, WinApi.ULW_ALPHA);

                //Clean-up
                bmp.Dispose();
                WinApi.ReleaseDC(IntPtr.Zero, screenDc);
                if (hBitmap != IntPtr.Zero)
                {
                    WinApi.SelectObject(memDc, oldBitmap);
                    WinApi.DeleteObject(hBitmap);
                }
                WinApi.DeleteDC(memDc);
            }
            catch { }
        }

        private void DrawString(Graphics graphic, Label label)
        {
            StringFormat format = new StringFormat();
            int x0 = 0;

            format.Alignment = CurrentStyle.HAlign;

            switch (CurrentStyle.HAlign)
            {
                case StringAlignment.Center:
                    x0 = label.Width / 2;
                    break;

                case StringAlignment.Far:
                    x0 = label.Width;
                    break;
            }



            // Draw the text a lots of times around the target position
            using (Brush b = new SolidBrush(Color.FromArgb(Convert.ToInt32(CurrentStyle.ShadowStrength * m_opacity), CurrentStyle.ShadowColor)))
            {
                for (int offX = -CurrentStyle.ShadowWidth; offX <= CurrentStyle.ShadowWidth; offX++)
                    for (int offY = -CurrentStyle.ShadowWidth; offY <= CurrentStyle.ShadowWidth; offY++)
                    {
                        if (Math.Sqrt(Math.Pow(Math.Abs(offX), 2) + Math.Pow(Math.Abs(offY), 2)) <= CurrentStyle.ShadowWidth)
                            graphic.DrawString(label.Text, label.Font, b, x0 + label.Left + offX, label.Top + offY, format);
                    }
            }

            // Draw the regular Text
            using (Brush brushFore = new SolidBrush(Color.FromArgb(Convert.ToInt32(255 * m_opacity), label.ForeColor)))
            {
                graphic.DrawString(label.Text, label.Font, brushFore, x0 + label.Left, label.Top, format);
            }
        }
        #endregion
    }
}
