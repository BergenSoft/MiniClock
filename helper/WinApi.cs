using System;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Be.MiniClock.helper
{
    public static class WinApi
    {



        #region Consts
        // Windows Messages
        public const int WM_ERASEBKGND = 0x14;
        public const int WM_PARENTNOTIFY = 0x210;
        public const int WM_MOUSEACTIVATE = 0x21;
        public const int WM_CONTEXTMENU = 0x7b;
        public const int WM_RBUTTONDOWN = 0x204;
        public const int WM_NOTIFY = 0x204e;
        public const int WM_PAINT = 0x000F;


        // ListView
        private const int LVM_FIRST = 0x1000;
        public const int LVM_SCROLL = (LVM_FIRST + 20);
        public const int LVM_GETHEADER = (LVM_FIRST + 31);
        public const int LVM_SETCOLUMN = (LVM_FIRST + 96);

        private const int HDM_FIRST = 0x1200;
        public const int HDM_GETITEM = (HDM_FIRST + 11);
        public const int HDM_SETITEM = (HDM_FIRST + 12);
        public const int HDM_GETITEMRECT = (HDM_FIRST + 7);

        public const int LVN_COLUMNDROPDOWN = -164;
        public const int LVCF_FMT = 1;
        public const int LVCFMT_SPLITBUTTON = 0x1000000;




        // ScrollBar
        public const int SB_HORZ = 0x0;
        public const uint SIF_POS = 0x4;


        // ProgressBar
        public const int WM_USER = 0x400;
        public const int PBM_SETSTATE = WM_USER + 16;


        // Aero
        public const int WM_DWMCOMPOSITIONCHANGED = 0x031E;



        // Splash Screen
        public const byte AC_SRC_OVER = 0x00;
        public const byte AC_SRC_ALPHA = 0x01;
        public const Int32 ULW_ALPHA = 0x00000002;


        /// <summary>
        /// Die AnimateWindowStyles (ohne Hide und Activate)
        /// </summary>
        [Flags]
        public enum AnimateWindowStyle
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }


        // SetWindowPos
        public static int HWND_TOPMOST = -1;
        public static int SWP_NOMOVE = 0x0002;
        public static int SWP_NOSIZE = 0x0001;
        public static int SWP_NOACTIVATE = 0x0010;
        #endregion











        #region Declarations
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        public extern static int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, ref LVCOLUMN lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, out RECT lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, ref HDITEM lParam);



        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetScrollInfo(IntPtr hwnd, int fnBar, ref SCROLLINFO lpsi);

        [DllImport("dwmapi.dll", PreserveSig = false)]
        public static extern IntPtr DwmIsCompositionEnabled(out bool AeroEnabled);

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS m);




        // Splash Screen
        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pprSrc, Int32 crKey, ref BLENDFUNCTION pblend, Int32 dwFlags);


        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

        [DllImport("user32.dll", ExactSpelling = true)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern bool DeleteDC(IntPtr hdc);


        [DllImport("gdi32.dll", ExactSpelling = true)]
        public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern bool DeleteObject(IntPtr hObject);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);
        #endregion











        #region Structs
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct LVCOLUMN
        {
            public uint mask;
            public int fmt;
            public int cx;
            public string pszText;
            public int cchTextMax;
            public int iSubItem;
            public int iImage;
            public int iOrder;
            public int cxMin;
            public int cxDefault;
            public int cxIdeal;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct POINT
        {
            public int x;
            public int y;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct RECT
        {
            public RECT(int l, int t, int r, int b)
            {
                left = l;
                top = t;
                right = r;
                bottom = b;
            }

            public int left;
            public int top;
            public int right;
            public int bottom;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct NMHDR
        {
            public IntPtr hwndFrom;
            public IntPtr idFrom;
            public int code;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct NMLISTVIEW
        {
            public NMHDR hdr;
            public int iItem;
            public int iSubItem;
            public uint uNewState;
            public uint uOldState;
            public uint uChanged;
            public POINT ptAction;
            public IntPtr lParam;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct HDITEM
        {
            public Mask mask;
            public int cxy;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string pszText;
            public IntPtr hbm;
            public int cchTextMax;
            public Format fmt;
            public IntPtr lParam;
            public int iImage;
            public int iOrder;
            public uint type;
            public IntPtr pvFilter;
            public uint state;

            [Flags]
            public enum Mask
            {
                HDI_FORMAT = 0x4,
                HDI_HEIGHT = 0x1,
            };

            [Flags]
            public enum Format
            {
                HDF_SORTDOWN = 0x200,
                HDF_SORTUP = 0x400,
            };
        };

        [Serializable, StructLayout(LayoutKind.Sequential)]
        public struct SCROLLINFO
        {
            public uint cbSize;
            public uint fMask;
            public int nMin;
            public int nMax;
            public uint nPage;
            public int nPos;
            public int nTrackPos;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int LeftWidth;
            public int RightWidth;
            public int TopHeight;
            public int BottomHeight;
        };

        // Splash Screen
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;
        }

        #endregion

    }
}
