using MetroFramework.Native;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public class MetroFlatDropShadow : MetroShadowBase
    {
        private Point Offset;

        public MetroFlatDropShadow(Form targetForm) : base(targetForm, 6, 0x8080020)
        {
            this.Offset = new Point(-6, -6);
        }

        protected override void ClearShadow()
        {
            Bitmap image = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(image);
            graphics.Clear(Color.Transparent);
            graphics.Flush();
            graphics.Dispose();
            this.SetBitmap(image, 0xff);
            image.Dispose();
        }

        private Bitmap DrawBlurBorder()
        {
            return (Bitmap)this.DrawOutsetShadow(Color.Black, new Rectangle(0, 0, base.ClientRectangle.Width, base.ClientRectangle.Height));
        }

        private Image DrawOutsetShadow(Color color, Rectangle shadowCanvasArea)
        {
            Rectangle rect = shadowCanvasArea;
            Rectangle rectangle2 = new Rectangle(shadowCanvasArea.X + (-this.Offset.X - 1), shadowCanvasArea.Y + (-this.Offset.Y - 1), shadowCanvasArea.Width - ((-this.Offset.X * 2) - 1), shadowCanvasArea.Height - ((-this.Offset.Y * 2) - 1));
            Bitmap image = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(image);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            using (Brush brush = new SolidBrush(Color.FromArgb(30, Color.Black)))
            {
                graphics.FillRectangle(brush, rect);
            }
            using (Brush brush2 = new SolidBrush(Color.FromArgb(60, Color.Black)))
            {
                graphics.FillRectangle(brush2, rectangle2);
            }
            graphics.Flush();
            graphics.Dispose();
            return image;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.PaintShadow();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.Visible = true;
            this.PaintShadow();
        }

        protected override void PaintShadow()
        {
            using (Bitmap bitmap = this.DrawBlurBorder())
            {
                this.SetBitmap(bitmap, 0xff);
            }
        }

        [SecuritySafeCritical]
        private void SetBitmap(Bitmap bitmap, byte opacity)
        {
            if (bitmap.PixelFormat != PixelFormat.Format32bppArgb)
            {
                throw new ApplicationException("The bitmap must be 32ppp with alpha-channel.");
            }
            IntPtr dC = WinApi.GetDC(IntPtr.Zero);
            IntPtr hDC = WinApi.CreateCompatibleDC(dC);
            IntPtr zero = IntPtr.Zero;
            IntPtr hObject = IntPtr.Zero;
            try
            {
                zero = bitmap.GetHbitmap(Color.FromArgb(0));
                hObject = WinApi.SelectObject(hDC, zero);
                WinApi.SIZE psize = new WinApi.SIZE(bitmap.Width, bitmap.Height);
                WinApi.POINT pprSrc = new WinApi.POINT(0, 0);
                WinApi.POINT pptDst = new WinApi.POINT(base.Left, base.Top);
                WinApi.BLENDFUNCTION pblend = new WinApi.BLENDFUNCTION
                {
                    BlendOp = 0,
                    BlendFlags = 0,
                    SourceConstantAlpha = opacity,
                    AlphaFormat = 1
                };
                WinApi.UpdateLayeredWindow(base.Handle, dC, ref pptDst, ref psize, hDC, ref pprSrc, 0, ref pblend, 2);
            }
            finally
            {
                WinApi.ReleaseDC(IntPtr.Zero, dC);
                if (zero != IntPtr.Zero)
                {
                    WinApi.SelectObject(hDC, hObject);
                    WinApi.DeleteObject(zero);
                }
                WinApi.DeleteDC(hDC);
            }
        }
    }
}
