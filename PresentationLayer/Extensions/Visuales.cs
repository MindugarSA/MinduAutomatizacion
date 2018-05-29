using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PresentationLayer
{
    public class Visuales
    {
        public static void FondoDegradado(Form formulario, PaintEventArgs e) 
        {
         //Fondo Degradado
        Rectangle Rect = new Rectangle(0, 0, formulario.Width, formulario.Height);
        LinearGradientBrush LinearBrush =
           new LinearGradientBrush(Rect, Color.White, Color.LightGray,
           LinearGradientMode.Vertical);
        Graphics g = e.Graphics;
        g.FillRectangle(LinearBrush, 0, 0, formulario.Width, formulario.Height);

        }

        public static void LineaCabecera(Form formulario, PaintEventArgs e)
        {
            SolidBrush Col = new SolidBrush(ColorTranslator.FromHtml("#FCB712"));
            e.Graphics.FillRectangle(Col, 0, 0, formulario.Width, 5);
        }
        
        
    }
}
