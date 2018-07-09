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

        public static void InitializeClickHandlers(this Control parent)
        {
            if(parent is Form) parent.MouseClick += new MouseEventHandler(ControlsClick);

            foreach (Control child in parent.Controls)
            {
                child.Click += new EventHandler(ControlsClick);
                if (child is TextBox )
                       child.TextChanged += new EventHandler(ControlsClick);
                //child.MouseClick += new MouseEventHandler(ControlsClick);
                InitializeClickHandlers(child);
            }
        }

        private static void ControlsClick(object sender, EventArgs e)
        {
            try
            {
                //if((((Control)sender).FindForm()) != Form.ActiveForm)
                    (((Control)sender).FindForm()).BringToFront();
                    (((Control)sender).FindForm()).Activate();
            }
            catch {}
        }

        public static async void FadeIn(this Form o, int interval = 80)
        {
            //Object is not fully invisible. Fade it in
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = 1; //make fully visible       
        }

        public static async void FadeOut(this Form o, int interval = 80, bool closeForm = true)
        {
            //Object is fully visible. Fade it out
            while (o.Opacity > 0.0)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0; //make fully invisible      

            if (closeForm)
                o.Close();
        }
    }
    
}
