using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PresentationLayer
{
    /// <summary>
    /// A component which raise a ripple effect whith registered control
    /// when against click event
    /// </summary>
    public partial class ClickEffect : Component
    {
        /// <summary>
        /// Control to Register
        /// </summary>
        [Browsable(true)]
        public Control ClickControl 
        { 
            get{return _ClickControl;}
            set
            {
                 UnRegisterControl();
                _ClickControl = value;
                RegisterControl();
            }
        }
        private Control _ClickControl;
        private int step = 0;
        private int _speed=10;
        private Point startPoint;
        public ClickEffect()
        {
            InitializeComponent();
           
        }
        public int Speed 
        {
            get { return _speed; }
            set { _speed = value; }
        }
        public ClickEffect(IContainer container)
        {
            container.Add(this);
            InitializeComponent();


        }
     
        /// <summary>
        /// Here we will register control or subscribe its event
        /// in order to control it.
        /// </summary>
        private void  RegisterControl()
        {
            // Subscribe paint Event in order to show bubble
            _ClickControl.Paint += new PaintEventHandler(control_Paint);
            //_ClickControl.MouseMove += new MouseEventHandler(_ClickControl_MouseMove);
            // subscribe the click event
            _ClickControl.Click += new EventHandler(control_Click);
            SetDoubleBuffered(_ClickControl);
        }

        
        /// <summary>
        /// if User subscribe new control then we should un-register old or current control events
        /// </summary>
        private void UnRegisterControl() 
        {
            if (_ClickControl != null) 
            {
                //unbind paint event
                _ClickControl.Paint -= new PaintEventHandler(control_Paint);
                //unbind click event
                _ClickControl.Click -= new EventHandler(control_Click);
            }
        }
        

        void effectTimer_Tick(object sender, EventArgs e)
        {
            //increase step basically step is logically radius of circle 
            //whic expands circl from click point
            step++;

            if (_ClickControl != null)
            {
                //raise paint event 
                _ClickControl.Invalidate();
            }
            // we have to expand the circle un-till it crosess control its boundry
            if (  startPoint.X < step * (_speed/2)  && startPoint.Y < step * (_speed/2)  &&  _ClickControl.Width  < step * (_speed/2) && _ClickControl.Height  < step * (_speed/2)) 
            {
            
                //disable timer now
                this.effectTimer.Enabled = false;
                 //set to zero
                step = 0;
            }
        }
        public static void SetDoubleBuffered(System.Windows.Forms.Control control)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                return;
            }
            System.Reflection.PropertyInfo propertyInfo =typeof(System.Windows.Forms.Control).GetProperty( "DoubleBuffered", System.Reflection.BindingFlags.NonPublic |  System.Reflection.BindingFlags.Instance);
            propertyInfo.SetValue(control, true, null);
        }
     
        /// <summary>
        /// event raised when user click on a control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void control_Click(object sender, EventArgs e)
        {
            //enable the timer 
            this.effectTimer.Enabled = true;
            //get the mouse click point or orign of Ellipse
            startPoint = _ClickControl.PointToClient(Cursor.Position);
            //set radius  to zero
            step = 0;
        }
        /// <summary>
        /// Draw Ellipse   on paint event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void control_Paint(object sender, PaintEventArgs e)
        {
            //here we are getting color from ARGB where A is the alpha transparency  which is 128 and rest color R,G,B with 255  produces White color
            using (Brush brush = new SolidBrush(Color.FromArgb(128, 255, 255, 255)))
            {
                e.Graphics.FillEllipse(brush, startPoint.X - (step * _speed/2), startPoint.Y - (step * _speed / 2), step * _speed, step * _speed);
            }
        }
    }
}
