using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormHeader : UserControl
    {

        public Form ParentContainer { get; set; }

       [Description("Header text displayed"), Category("Data")]
        public string HeaderText
        {
            get { return this.label1.Text; }
            set { this.label1.Text = value; }
        }

        [Description("Header BackColor displayed"), Category("Data")]
        public Color HeaderBackColor
        {
            get { return this.panel3.BackColor; }
            set { this.panel3.BackColor = value; }
        }

        [Description("Header ControlBoxBackColor displayed"), Category("Data")]
        public Color ControlBoxBackColor
        {
            get { return this.panel1.BackColor; }
            set { this.panel1.BackColor = value; }
        }
        public FormHeader()
        {
            InitializeComponent();
            label1.Parent = panel3;
            label1.BackColor = Color.Transparent;
        }

        public void CerrarContenedor(Form oForm)
        {
            oForm.Close();
        }

        public void MaximizarContenedor(Form oForm)
        {
            if (oForm.WindowState != FormWindowState.Maximized)
                oForm.WindowState = FormWindowState.Maximized;
        }

        public void RestaurarContenedor(Form oForm)
        {
            if (oForm.WindowState != FormWindowState.Normal)
                oForm.WindowState = FormWindowState.Normal;
        }

        public void MinizarContenedor(Form oForm)
        {
            if (oForm.WindowState != FormWindowState.Minimized)
                oForm.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CerrarContenedor(ParentContainer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ParentContainer.WindowState != FormWindowState.Maximized)
            {
                MaximizarContenedor(ParentContainer);
                button2.BackgroundImage = Properties.Resources.Restore_32px;
            }
            else
            {
                RestaurarContenedor(ParentContainer);
                button2.BackgroundImage = Properties.Resources.Maximize_32px;
            }
            label1.Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ParentContainer.WindowState != FormWindowState.Minimized)
            {
                //ParentContainer.FormBorderStyle = FormBorderStyle.Sizable;
                MinizarContenedor(ParentContainer);
                button2.BackgroundImage = Properties.Resources.Restore_32px;
                label1.Select();
            }
            else
            {
                //ParentContainer.FormBorderStyle = FormBorderStyle.None;
                RestaurarContenedor(ParentContainer);
                button2.BackgroundImage = Properties.Resources.Minimize_32px;
            }
        }

        public void TextoEncabezado(string Texto)
        {
            label1.Text = Texto;
        }

        public void ColorEncabezado(Color cColor)
        {
            panel3.BackColor = cColor;
        }

        private void panel3_DoubleClick(object sender, EventArgs e)
        {
            if (ParentContainer.WindowState != FormWindowState.Maximized)
            {
                MaximizarContenedor(ParentContainer);
                button2.BackgroundImage = Properties.Resources.Restore_32px;
            }
            else
            {
                RestaurarContenedor(ParentContainer);
                button2.BackgroundImage = Properties.Resources.Maximize_32px;
            }
            label1.Select();
        }


    }
    
}
