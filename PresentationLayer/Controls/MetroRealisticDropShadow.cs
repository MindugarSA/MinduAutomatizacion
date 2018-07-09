using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public class MetroRealisticDropShadow : MetroShadowBase
    {
        public MetroRealisticDropShadow(Form targetForm) : base(targetForm, 15, 0x8080020)
        {
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
            return (Bitmap)this.DrawOutsetShadow(0, 0, 40, 1, Color.Black, new Rectangle(1, 1, base.ClientRectangle.Width, base.ClientRectangle.Height));
        }

        private Image DrawOutsetShadow(int hShadow, int vShadow, int blur, int spread, Color color, Rectangle shadowCanvasArea)
        {
            Rectangle rectangle = shadowCanvasArea;
            Rectangle rect = shadowCanvasArea;
            rect.Offset(hShadow, vShadow);
            rect.Inflate(-blur, -blur);
            rectangle.Inflate(spread, spread);
            rectangle.Offset(hShadow, vShadow);
            Rectangle rectangle3 = rectangle;
            Bitmap image = new Bitmap(rectangle3.Width, rectangle3.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(image);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            int cornerRadius = 0;
            do
            {
                double num2 = ((double)(rectangle.Height - rect.Height)) / ((double)((blur * 2) + (spread * 2)));
                Color fillColor = Color.FromArgb((int)(200.0 * (num2 * num2)), color);
                Rectangle bounds = rect;
                bounds.Offset(-rectangle3.Left, -rectangle3.Top);
                this.DrawRoundedRectangle(g, bounds, cornerRadius, Pens.Transparent, fillColor);
                rect.Inflate(1, 1);
                cornerRadius = (int)(blur * (1.0 - (num2 * num2)));
            }
            while (rectangle.Contains(rect));
            g.Flush();
            g.Dispose();
            return image;
        }

        private void DrawRoundedRectangle(Graphics g, Rectangle bounds, int cornerRadius, Pen drawPen, Color fillColor)
        {
            int num = Convert.ToInt32(Math.Ceiling((double)drawPen.Width));
            bounds = Rectangle.Inflate(bounds, -num, -num);
            GraphicsPath path = new GraphicsPath();
            if (cornerRadius > 0)
            {
                path.AddArc(bounds.X, bounds.Y, cornerRadius, cornerRadius, 180f, 90f);
                path.AddArc((bounds.X + bounds.Width) - cornerRadius, bounds.Y, cornerRadius, cornerRadius, 270f, 90f);
                path.AddArc((bounds.X + bounds.Width) - cornerRadius, (bounds.Y + bounds.Height) - cornerRadius, cornerRadius, cornerRadius, 0f, 90f);
                path.AddArc(bounds.X, (bounds.Y + bounds.Height) - cornerRadius, cornerRadius, cornerRadius, 90f, 90f);
            }
            else
            {
                path.AddRectangle(bounds);
            }
            path.CloseAllFigures();
            if (cornerRadius > 5)
            {
                using (SolidBrush brush = new SolidBrush(fillColor))
                {
                    g.FillPath(brush, path);
                }
            }
            if (drawPen != Pens.Transparent)
            {
                using (Pen pen = new Pen(drawPen.Color))
                {
                    pen.EndCap = pen.StartCap = LineCap.Round;
                    g.DrawPath(pen, path);
                }
            }
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
