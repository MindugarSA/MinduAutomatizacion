using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmFamilia : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);

            Brush aGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(50, 0), Color.Gray, Color.White);
            Pen pencil = new Pen(Color.LightGray, 5);
            e.Graphics.DrawRectangle(pencil, rect);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        public FrmFamilia()
        {
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();
            
        }

        private void FrmFamilia_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            formHeader2.Select();
        }

        private void FrmFamilia_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }


        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            txtDescrpcion.Text += "Click, ";
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopUp_MouseEnter(object sender, EventArgs e)
        {
            var Obj = (dynamic)sender;
            Obj.Left = Obj.Left - 3;
            Obj.Top = Obj.Top - 3;
            Obj.Height = Obj.Height + 6;
            Obj.Width = Obj.Width + 6;
        }
        private void PopUp_MouseLeave(object sender, EventArgs e)
        {
            var Obj = (dynamic)sender;
            Obj.Left = Obj.Left + 3;
            Obj.Top = Obj.Top + 3;
            Obj.Height = Obj.Height - 6;
            Obj.Width = Obj.Width - 6;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var Obj = (dynamic)sender;
            Obj.Parent.Left = Obj.Parent.Left - 3;
            Obj.Parent.Top = Obj.Parent.Top - 3;
            Obj.Parent.Height = Obj.Parent.Height + 6;
            Obj.Parent.Width = Obj.Parent.Width + 6;
            foreach (Control c in Obj.Controls)
            {
                try
                {
                    if (c.GetType().Name == "LabelNoMouse")
                    {
                        Rectangle parentRect = c.Parent.ClientRectangle;
                        c.Left = (parentRect.Width - c.Width) / 2;
                        c.Top = (parentRect.Height - c.Height) / 2;
                    }
                }
                catch { }
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var Obj = (dynamic)sender;
            Obj.Parent.Left = Obj.Parent.Left + 3;
            Obj.Parent.Top = Obj.Parent.Top + 3;
            Obj.Parent.Height = Obj.Parent.Height - 6;
            Obj.Parent.Width = Obj.Parent.Width - 6;
            foreach (Control c in Obj.Controls)
            {
                try
                {
                    if (c.GetType().Name == "LabelNoMouse")
                    {
                        Rectangle parentRect = c.Parent.ClientRectangle;
                        c.Left = (parentRect.Width - c.Width) / 2;
                        c.Top = (parentRect.Height - c.Height) / 2;
                    }
                }
                catch { }
            }
        }

        private void SetearControles()
        {
            formHeader2.ParentContainer = this;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            materialFlatButton1.Parent = panel2;
            materialFlatButton2.Parent = panel3;
            materialFlatButton3.Parent = panel4;
            labelNoMouse1.Parent = materialFlatButton1;
            labelNoMouse2.Parent = materialFlatButton2;
            labelNoMouse3.Parent = materialFlatButton3;
        }

        ////        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        ////        private static extern IntPtr CreateRoundRectRgn
        ////(
        ////int nLeftRect, // x-coordinate of upper-left corner
        ////int nTopRect, // y-coordinate of upper-left corner
        ////int nRightRect, // x-coordinate of lower-right corner
        ////int nBottomRect, // y-coordinate of lower-right corner
        ////int nWidthEllipse, // height of ellipse
        ////int nHeightEllipse // width of ellipse
        ////);

        ////        [DllImport("dwmapi.dll")]
        ////        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        ////        [DllImport("dwmapi.dll")]
        ////        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        ////        [DllImport("dwmapi.dll")]
        ////        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        ////        private bool m_aeroEnabled;                     // variables for box shadow
        ////        private const int CS_DROPSHADOW = 0x00020000;
        ////        private const int WM_NCPAINT = 0x0085;
        ////        private const int WM_ACTIVATEAPP = 0x001C;

        ////        public struct MARGINS                           // struct for box shadow
        ////        {
        ////            public int leftWidth;
        ////            public int rightWidth;
        ////            public int topHeight;
        ////            public int bottomHeight;
        ////        }

        ////        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        ////        private const int HTCLIENT = 0x1;
        ////        private const int HTCAPTION = 0x2;

        ////        protected override CreateParams CreateParams
        ////        {
        ////            get
        ////            {
        ////                m_aeroEnabled = CheckAeroEnabled();

        ////                CreateParams cp = base.CreateParams;
        ////                if (!m_aeroEnabled)
        ////                    cp.ClassStyle |= CS_DROPSHADOW;

        ////                return cp;
        ////            }
        ////        }

        ////        private bool CheckAeroEnabled()
        ////        {
        ////            if (Environment.OSVersion.Version.Major >= 6)
        ////            {
        ////                int enabled = 0;
        ////                DwmIsCompositionEnabled(ref enabled);
        ////                return (enabled == 1) ? true : false;
        ////            }
        ////            return false;
        ////        }

        ////        protected override void WndProc(ref Message m)
        ////        {
        ////            switch (m.Msg)
        ////            {
        ////                case WM_NCPAINT:                        // box shadow
        ////                    if (m_aeroEnabled)
        ////                    {
        ////                        var v = 2;
        ////                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
        ////                        MARGINS margins = new MARGINS()
        ////                        {
        ////                            bottomHeight = 1,
        ////                            leftWidth = 1,
        ////                            rightWidth = 1,
        ////                            topHeight = 1
        ////                        };
        ////                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

        ////                    }
        ////                    break;
        ////                default:
        ////                    break;
        ////            }
        ////            base.WndProc(ref m);

        ////            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
        ////                m.Result = (IntPtr)HTCAPTION;

        //private bool Drag;
        //private int MouseX;
        //private int MouseY;

        //private const int WM_NCHITTEST = 0x84;
        //private const int HTCLIENT = 0x1;
        //private const int HTCAPTION = 0x2;

        //private bool m_aeroEnabled;

        //private const int CS_DROPSHADOW = 0x00020000;
        //private const int WM_NCPAINT = 0x0085;
        //private const int WM_ACTIVATEAPP = 0x001C;

        //[System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        //public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        //[System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        //public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        //[System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        //public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        //[System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn(
        //    int nLeftRect,
        //    int nTopRect,
        //    int nRightRect,
        //    int nBottomRect,
        //    int nWidthEllipse,
        //    int nHeightEllipse
        //    );

        //public struct MARGINS
        //{
        //    public int leftWidth;
        //    public int rightWidth;
        //    public int topHeight;
        //    public int bottomHeight;
        //}
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        m_aeroEnabled = CheckAeroEnabled();
        //        CreateParams cp = base.CreateParams;
        //        if (!m_aeroEnabled)
        //            cp.ClassStyle |= CS_DROPSHADOW; return cp;
        //    }
        //}
        //private bool CheckAeroEnabled()
        //{
        //    if (Environment.OSVersion.Version.Major >= 6)
        //    {
        //        int enabled = 0; DwmIsCompositionEnabled(ref enabled);
        //        return (enabled == 1) ? true : false;
        //    }
        //    return false;
        //}
        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case WM_NCPAINT:
        //            if (m_aeroEnabled)
        //            {
        //                var v = 2;
        //                DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
        //                MARGINS margins = new MARGINS()
        //                {
        //                    bottomHeight = 1,
        //                    leftWidth = 0,
        //                    rightWidth = 0,
        //                    topHeight = 0
        //                }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
        //            }
        //            break;
        //        default: break;
        //    }
        //    base.WndProc(ref m);
        //    if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        //}
        //private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Drag = true;
        //    MouseX = Cursor.Position.X - this.Left;
        //    MouseY = Cursor.Position.Y - this.Top;
        //}
        //private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (Drag)
        //    {
        //        this.Top = Cursor.Position.Y - MouseY;
        //        this.Left = Cursor.Position.X - MouseX;
        //    }
        //}
        //private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }


    }
    
}