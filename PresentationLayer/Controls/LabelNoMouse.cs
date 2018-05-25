using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Controls
{
    public class LabelNoMouse : Label
    {
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x0084;
            const int HTTRANSPARENT = (-1);
            const int WM_MOUSEHOVER = 0x2A1;

            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEHOVER)
            {
                m.Result = (IntPtr)HTTRANSPARENT;
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
