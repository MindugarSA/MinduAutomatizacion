using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public static class FormExtensions
    {
        public static IEnumerable<Control> GetAllControlList(this Control parent)
        {
            List<Control> controls = new List<Control>();

            foreach (Control child in parent.Controls)
            {
                controls.AddRange(GetAllControlList(child));
            }

            controls.Add(parent);

            return controls;
        }
    }
}
