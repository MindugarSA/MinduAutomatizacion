namespace PresentationLayer
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    internal static class WinApi
    {
        public const byte AC_SRC_ALPHA = 1;
        public const byte AC_SRC_OVER = 0;
        public const int AlwaysOnTop = 2;
        public const int Autohide = 1;
        public const int GW_CHILD = 5;
        public const int GW_HWNDFIRST = 0;
        public const int GW_HWNDLAST = 1;
        public const int GW_HWNDNEXT = 2;
        public const int GW_HWNDPREV = 3;
        public const int GW_OWNER = 4;
        public const int GWL_WNDPROC = -4;
        public const int HC_ACTION = 0;
        public const int MfByposition = 0x400;
        public const int MfRemove = 0x1000;
        public const int TCM_HITTEST = 0x1313;
        public const int ULW_ALPHA = 2;
        public const int ULW_COLORKEY = 1;
        public const int ULW_OPAQUE = 4;
        public const int WH_CALLWNDPROC = 4;

        [DllImport("gdi32.dll", SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);
        [DllImport("gdi32.dll", SetLastError = true, ExactSpelling = true)]
        public static extern Bool DeleteDC(IntPtr hdc);
        [DllImport("gdi32.dll", SetLastError = true, ExactSpelling = true)]
        public static extern Bool DeleteObject(IntPtr hObject);
        [DllImport("user32.dll")]
        public static extern bool DrawMenuBar(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassName(IntPtr hwnd, char[] className, int maxCount);
        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern int GetClientRect(IntPtr hwnd, ref RECT lpRect);
        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern int GetClientRect(IntPtr hwnd, [In, Out] ref Rectangle rect);
        [DllImport("user32.dll", SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr GetDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern IntPtr GetDCEx(IntPtr hwnd, IntPtr hrgnclip, uint fdwOptions);
        [DllImport("user32.dll")]
        public static extern int GetMenuItemCount(IntPtr hMenu);
        [DllImport("user32.dll")]
        public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindow(IntPtr hwnd, int uCmd);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowDC(IntPtr handle);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool GetWindowRect(IntPtr hWnd, [In, Out] ref Rectangle rect);
        public static int HiWord(int dwValue)
        {
            return ((dwValue >> 0x10) & 0xffff);
        }

        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern bool InvalidateRect(IntPtr hwnd, ref Rectangle rect, bool bErase);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool IsWindowVisible(IntPtr hwnd);
        public static int LoWord(int dwValue)
        {
            return (dwValue & 0xffff);
        }

        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern bool MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr ReleaseDC(IntPtr handle, IntPtr hDC);
        [DllImport("user32.dll")]
        public static extern bool RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);
        [DllImport("gdi32.dll", ExactSpelling = true)]
        public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr wnd, int msg, bool param, int lparam);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern IntPtr SetCapture(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);
        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int W, int H, uint uFlags);
        [DllImport("shell32.dll", SetLastError = true)]
        public static extern IntPtr SHAppBarMessage(ABM dwMessage, [In] ref APPBARDATA pData);
        [DllImport("user32.dll")]
        public static extern bool ShowScrollBar(IntPtr hWnd, int bar, int cmd);
        [DllImport("user32.dll", SetLastError = true, ExactSpelling = true)]
        public static extern Bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref POINT pptDst, ref SIZE psize, IntPtr hdcSrc, ref POINT pprSrc, int crKey, ref BLENDFUNCTION pblend, int dwFlags);
        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern bool UpdateWindow(IntPtr hwnd);
        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern bool ValidateRect(IntPtr hwnd, ref Rectangle rect);

        public enum ABE : uint
        {
            Bottom = 3,
            Left = 0,
            Right = 2,
            Top = 1
        }

        public enum ABM : uint
        {
            Activate = 6,
            GetAutoHideBar = 7,
            GetState = 4,
            GetTaskbarPos = 5,
            New = 0,
            QueryPos = 2,
            Remove = 1,
            SetAutoHideBar = 8,
            SetPos = 3,
            SetState = 10,
            WindowPosChanged = 9
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct APPBARDATA
        {
            public uint cbSize;
            public IntPtr hWnd;
            public uint uCallbackMessage;
            public WinApi.ABE uEdge;
            public WinApi.RECT rc;
            public int lParam;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct ARGB
        {
            public byte Blue;
            public byte Green;
            public byte Red;
            public byte Alpha;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;
        }

        public enum Bool
        {
            False,
            True
        }

        public enum HitTest
        {
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 0x10,
            HTBOTTOMRIGHT = 0x11,
            HTCAPTION = 2,
            HTCLIENT = 1,
            HTGROWBOX = 4,
            HTLEFT = 10,
            HTMAXBUTTON = 9,
            HTMINBUTTON = 8,
            HTNOWHERE = 0,
            HTREDUCE = 8,
            HTRIGHT = 11,
            HTSIZE = 4,
            HTSIZEFIRST = 10,
            HTSIZELAST = 0x11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTTRANSPARENT = -1,
            HTZOOM = 9
        }

        public enum Messages : uint
        {
            SC_MAXIMIZE = 0xf030,
            SC_MINIMIZE = 0xf020,
            SC_MOVE = 0xf010,
            SC_RESTORE = 0xf120,
            WM_ACTIVATE = 6,
            WM_ACTIVATEAPP = 0x1c,
            WM_AFXFIRST = 0x360,
            WM_AFXLAST = 0x37f,
            WM_APP = 0x8000,
            WM_APPCOMMAND = 0x319,
            WM_ASKCBFORMATNAME = 780,
            WM_CANCELJOURNAL = 0x4b,
            WM_CANCELMODE = 0x1f,
            WM_CAPTURECHANGED = 0x215,
            WM_CHANGECBCHAIN = 0x30d,
            WM_CHANGEUISTATE = 0x127,
            WM_CHAR = 0x102,
            WM_CHARTOITEM = 0x2f,
            WM_CHILDACTIVATE = 0x22,
            WM_CLEAR = 0x303,
            WM_CLOSE = 0x10,
            WM_COMMAND = 0x111,
            WM_COMMNOTIFY = 0x44,
            WM_COMPACTING = 0x41,
            WM_COMPAREITEM = 0x39,
            WM_CONTEXTMENU = 0x7b,
            WM_COPY = 0x301,
            WM_COPYDATA = 0x4a,
            WM_CREATE = 1,
            WM_CTLCOLOR = 0x19,
            WM_CTLCOLORBTN = 0x135,
            WM_CTLCOLORDLG = 310,
            WM_CTLCOLOREDIT = 0x133,
            WM_CTLCOLORLISTBOX = 0x134,
            WM_CTLCOLORMSGBOX = 0x132,
            WM_CTLCOLORSCROLLBAR = 0x137,
            WM_CTLCOLORSTATIC = 0x138,
            WM_CUT = 0x300,
            WM_DEADCHAR = 0x103,
            WM_DELETEITEM = 0x2d,
            WM_DESTROY = 2,
            WM_DESTROYCLIPBOARD = 0x307,
            WM_DEVICECHANGE = 0x219,
            WM_DEVMODECHANGE = 0x1b,
            WM_DISPLAYCHANGE = 0x7e,
            WM_DRAWCLIPBOARD = 0x308,
            WM_DRAWITEM = 0x2b,
            WM_DROPFILES = 0x233,
            WM_DWMCOMPOSITIONCHANGED = 0x31e,
            WM_ENABLE = 10,
            WM_ENDSESSION = 0x16,
            WM_ENTERIDLE = 0x121,
            WM_ENTERMENULOOP = 0x211,
            WM_ENTERSIZEMOVE = 0x231,
            WM_ERASEBKGND = 20,
            WM_EXITMENULOOP = 530,
            WM_EXITSIZEMOVE = 0x232,
            WM_FONTCHANGE = 0x1d,
            WM_GETDLGCODE = 0x87,
            WM_GETFONT = 0x31,
            WM_GETHOTKEY = 0x33,
            WM_GETICON = 0x7f,
            WM_GETMINMAXINFO = 0x24,
            WM_GETOBJECT = 0x3d,
            WM_GETTEXT = 13,
            WM_GETTEXTLENGTH = 14,
            WM_HANDHELDFIRST = 0x358,
            WM_HANDHELDLAST = 0x35f,
            WM_HELP = 0x53,
            WM_HOTKEY = 0x312,
            WM_HSCROLL = 0x114,
            WM_HSCROLLCLIPBOARD = 0x30e,
            WM_ICONERASEBKGND = 0x27,
            WM_IME_CHAR = 0x286,
            WM_IME_COMPOSITION = 0x10f,
            WM_IME_COMPOSITIONFULL = 0x284,
            WM_IME_CONTROL = 0x283,
            WM_IME_ENDCOMPOSITION = 270,
            WM_IME_KEYDOWN = 0x290,
            WM_IME_KEYLAST = 0x10f,
            WM_IME_KEYUP = 0x291,
            WM_IME_NOTIFY = 0x282,
            WM_IME_REQUEST = 0x288,
            WM_IME_SELECT = 0x285,
            WM_IME_SETCONTEXT = 0x281,
            WM_IME_STARTCOMPOSITION = 0x10d,
            WM_INITDIALOG = 0x110,
            WM_INITMENU = 0x116,
            WM_INITMENUPOPUP = 0x117,
            WM_INPUT = 0xff,
            WM_INPUTLANGCHANGE = 0x51,
            WM_INPUTLANGCHANGEREQUEST = 80,
            WM_KEYDOWN = 0x100,
            WM_KEYFIRST = 0x100,
            WM_KEYLAST = 0x108,
            WM_KEYUP = 0x101,
            WM_KILLFOCUS = 8,
            WM_LBUTTONDBLCLK = 0x203,
            WM_LBUTTONDOWN = 0x201,
            WM_LBUTTONUP = 0x202,
            WM_MBUTTONDBLCLK = 0x209,
            WM_MBUTTONDOWN = 0x207,
            WM_MBUTTONUP = 520,
            WM_MDIACTIVATE = 0x222,
            WM_MDICASCADE = 0x227,
            WM_MDICREATE = 0x220,
            WM_MDIDESTROY = 0x221,
            WM_MDIGETACTIVE = 0x229,
            WM_MDIICONARRANGE = 0x228,
            WM_MDIMAXIMIZE = 0x225,
            WM_MDINEXT = 0x224,
            WM_MDIREFRESHMENU = 0x234,
            WM_MDIRESTORE = 0x223,
            WM_MDISETMENU = 560,
            WM_MDITILE = 550,
            WM_MEASUREITEM = 0x2c,
            WM_MENUCHAR = 0x120,
            WM_MENUCOMMAND = 0x126,
            WM_MENUDRAG = 0x123,
            WM_MENUGETOBJECT = 0x124,
            WM_MENURBUTTONUP = 290,
            WM_MENUSELECT = 0x11f,
            WM_MOUSEACTIVATE = 0x21,
            WM_MOUSEFIRST = 0x200,
            WM_MOUSEHOVER = 0x2a1,
            WM_MOUSELAST = 0x20d,
            WM_MOUSELEAVE = 0x2a3,
            WM_MOUSEMOVE = 0x200,
            WM_MOUSEWHEEL = 0x20a,
            WM_MOVE = 3,
            WM_MOVING = 0x216,
            WM_NCACTIVATE = 0x86,
            WM_NCCALCSIZE = 0x83,
            WM_NCCREATE = 0x81,
            WM_NCDESTROY = 130,
            WM_NCHITTEST = 0x84,
            WM_NCLBUTTONDBLCLK = 0xa3,
            WM_NCLBUTTONDOWN = 0xa1,
            WM_NCLBUTTONUP = 0xa2,
            WM_NCMBUTTONDBLCLK = 0xa9,
            WM_NCMBUTTONDOWN = 0xa7,
            WM_NCMBUTTONUP = 0xa8,
            WM_NCMOUSELEAVE = 0x2a2,
            WM_NCMOUSEMOVE = 160,
            WM_NCPAINT = 0x85,
            WM_NCRBUTTONDBLCLK = 0xa6,
            WM_NCRBUTTONDOWN = 0xa4,
            WM_NCRBUTTONUP = 0xa5,
            WM_NCXBUTTONDBLCLK = 0xad,
            WM_NCXBUTTONDOWN = 0xab,
            WM_NCXBUTTONUP = 0xac,
            WM_NEXTDLGCTL = 40,
            WM_NEXTMENU = 0x213,
            WM_NOTIFY = 0x4e,
            WM_NOTIFYFORMAT = 0x55,
            WM_NULL = 0,
            WM_PAINT = 15,
            WM_PAINTCLIPBOARD = 0x309,
            WM_PAINTICON = 0x26,
            WM_PALETTECHANGED = 0x311,
            WM_PALETTEISCHANGING = 0x310,
            WM_PARENTNOTIFY = 0x210,
            WM_PASTE = 770,
            WM_PENWINFIRST = 0x380,
            WM_PENWINLAST = 0x38f,
            WM_POWER = 0x48,
            WM_POWERBROADCAST = 0x218,
            WM_PRINT = 0x317,
            WM_PRINTCLIENT = 0x318,
            WM_QUERYDRAGICON = 0x37,
            WM_QUERYENDSESSION = 0x11,
            WM_QUERYNEWPALETTE = 0x30f,
            WM_QUERYOPEN = 0x13,
            WM_QUERYUISTATE = 0x129,
            WM_QUEUESYNC = 0x23,
            WM_QUIT = 0x12,
            WM_RBUTTONDBLCLK = 0x206,
            WM_RBUTTONDOWN = 0x204,
            WM_RBUTTONUP = 0x205,
            WM_REFLECT = 0x2000,
            WM_RENDERALLFORMATS = 0x306,
            WM_RENDERFORMAT = 0x305,
            WM_SETCURSOR = 0x20,
            WM_SETFOCUS = 7,
            WM_SETFONT = 0x30,
            WM_SETHOTKEY = 50,
            WM_SETICON = 0x80,
            WM_SETREDRAW = 11,
            WM_SETTEXT = 12,
            WM_SETTINGCHANGE = 0x1a,
            WM_SHOWWINDOW = 0x18,
            WM_SIZE = 5,
            WM_SIZECLIPBOARD = 0x30b,
            WM_SIZING = 0x214,
            WM_SPOOLERSTATUS = 0x2a,
            WM_STYLECHANGED = 0x7d,
            WM_STYLECHANGING = 0x7c,
            WM_SYNCPAINT = 0x88,
            WM_SYSCHAR = 0x106,
            WM_SYSCOLORCHANGE = 0x15,
            WM_SYSCOMMAND = 0x112,
            WM_SYSDEADCHAR = 0x107,
            WM_SYSKEYDOWN = 260,
            WM_SYSKEYUP = 0x105,
            WM_TABLET_FIRST = 0x2c0,
            WM_TABLET_LAST = 0x2df,
            WM_TCARD = 0x52,
            WM_THEMECHANGED = 0x31a,
            WM_TIMECHANGE = 30,
            WM_TIMER = 0x113,
            WM_UNDO = 0x304,
            WM_UNICHAR = 0x109,
            WM_UNINITMENUPOPUP = 0x125,
            WM_UPDATEUISTATE = 0x128,
            WM_USER = 0x400,
            WM_USERCHANGED = 0x54,
            WM_VKEYTOITEM = 0x2e,
            WM_VSCROLL = 0x115,
            WM_VSCROLLCLIPBOARD = 0x30a,
            WM_WINDOWPOSCHANGED = 0x47,
            WM_WINDOWPOSCHANGING = 70,
            WM_WININICHANGE = 0x1a,
            WM_WTSSESSION_CHANGE = 0x2b1,
            WM_XBUTTONDBLCLK = 0x20d,
            WM_XBUTTONDOWN = 0x20b,
            WM_XBUTTONUP = 0x20c
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MINMAXINFO
        {
            public WinApi.POINT ptReserved;
            public WinApi.POINT ptMaxSize;
            public WinApi.POINT ptMaxPosition;
            public WinApi.POINT ptMinTrackSize;
            public WinApi.POINT ptMaxTrackSize;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NCCALCSIZE_PARAMS
        {
            public WinApi.RECT rect0;
            public WinApi.RECT rect1;
            public WinApi.RECT rect2;
            public IntPtr lppos;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;
            public POINT(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
            public RECT(Rectangle rc)
            {
                this.Left = rc.Left;
                this.Top = rc.Top;
                this.Right = rc.Right;
                this.Bottom = rc.Bottom;
            }

            public Rectangle ToRectangle()
            {
                return Rectangle.FromLTRB(this.Left, this.Top, this.Right, this.Bottom);
            }
        }

        public enum ScrollBar
        {
            SB_HORZ,
            SB_VERT,
            SB_CTL,
            SB_BOTH
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SIZE
        {
            public int cx;
            public int cy;
            public SIZE(int cx, int cy)
            {
                this.cx = cx;
                this.cy = cy;
            }
        }

        public enum TabControlHitTest
        {
            TCHT_NOWHERE = 1
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct TCHITTESTINFO
        {
            public Point pt;
            public uint flags;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WindowPos
        {
            public int hwnd;
            public int hWndInsertAfter;
            public int x;
            public int y;
            public int cx;
            public int cy;
            public int flags;
        }
    }
}


