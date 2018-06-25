using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entities;
using BusinessLayer;
using PresentationLayer.Forms;

namespace PresentationLayer
{
    public partial class FrmPrincipalPanel : Form
    {
        public FrmPrincipalPanel()
        {
            InitializeComponent();

            MenuWidthMax = pnlMenu.Width;
            //MenuWidthMin = 74;

            formHeader1.ParentContainer = this;

            panel4.Visible = false;
        }

        int MenuWidthMax;
        //int MenuWidthMin;
        bool MenuOculto = false;
        //int Level1Opt1Top = 169;
        int Level1Separation = 54;
        bool Opt1Open = false;

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
        //    //System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
        //    //this.MaximizedBounds = Screen.GetWorkingArea(this);
        //}

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                try
                {
                    if (c is MdiClient)
                        c.BackColor = this.BackColor;
                }
                catch { }
            }

            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;

            this.ControlBox = false;
            this.Text = String.Empty;
            label1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmFamilia FrmFami = new FrmFamilia();
            AbrirFormulario(FrmFami, 300, 150);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmPropiedades FrmProp = new FrmPropiedades();
            AbrirFormulario(FrmProp, 340, 190);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmTipos FrmTipos = new FrmTipos();
            AbrirFormulario(FrmTipos, 320, 170);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmValoresCostos FrmCost = new FrmValoresCostos();
            AbrirFormulario(FrmCost, 360, 210);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VisualizarLabel(true);
            FrmPieza FrmParte = new FrmPieza(this);
            AbrirFormulario(FrmParte, 470, 230);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VisualizarLabel(true);
            FrmKit FrmKits = new FrmKit(this);
            AbrirFormulario(FrmKits, 450, 100);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            VisualizarLabel(true);
            FrmProducto FrmKits = new FrmProducto(this);
            AbrirFormulario(FrmKits, 470, 120);
        }



        private void tmrOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width <= 80)
            {
                tmrOcultarMenu.Enabled = false;
                MenuOculto = true;
            }
            else
            {
                pnlMenu.Width -= 20;
                panel10.Width += 20;
                panel10.Left -= 20;
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 6);
                pictureBox2.Location = new Point(pictureBox2.Location.X - 1, pictureBox2.Location.Y);
            }
        }

        private void tmrMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width >= MenuWidthMax)
            {
                tmrMostrarMenu.Enabled = false;
                MenuOculto = false;
            }
            else
            {
                pnlMenu.Width = pnlMenu.Width + 20;
                panel10.Width -= 20;
                panel10.Left += 20;
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 6);
                pictureBox2.Location = new Point(pictureBox2.Location.X + 1, pictureBox2.Location.Y);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!MenuOculto)
                tmrOcultarMenu.Enabled = true;
            else
                tmrMostrarMenu.Enabled = true;

        }

        public void AbrirFormulario(Form oForm, int X, int Y)
        {
            oForm.TopLevel = false;
            oForm.StartPosition = FormStartPosition.Manual;
            oForm.Location = new Point(X, Y);
            panel10.Controls.Add(oForm);
            oForm.Show();
        }

        private void AbrirSubMenu(int iNivel)
        {
            switch (iNivel)
            {
                case 1:
                    if (!Opt1Open)
                    {
                        tmrMostrarMenu.Enabled = true;
                        panel4.Location = new Point(30, 157);
                        button2.Top = panel4.Top + panel4.Height;
                        panel6.Top = button2.Top;
                        button3.Top = button2.Top + Level1Separation;
                        panel7.Top = button3.Top;
                        button5.Top = button3.Top + Level1Separation;
                        panel3.Top = button5.Top;
                        panel4.Visible = true;
                        Opt1Open = true;
                    }
                    else
                    {
                        panel4.Visible = false;
                        button2.Top = button1.Top + Level1Separation;
                        panel6.Top = button2.Top;
                        button3.Top = button2.Top + Level1Separation;
                        panel7.Top = button3.Top;
                        button5.Top = button3.Top + Level1Separation;
                        panel3.Top = button5.Top;
                        Opt1Open = false;
                    }
                    break;
            }

        }

        public void VisualizarLabel(bool Visible)
        {
             this.label1.Visible = Visible;
        }

        private void FrmPrincipalPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void FrmPrincipalPanel_Shown(object sender, EventArgs e)
        {
            pictureBox4.Top = (panel10.Height / 2) - (pictureBox4.Height / 2);
            pictureBox4.Left = (panel10.Width / 2) - (pictureBox4.Width / 2);
        }
    }
}
