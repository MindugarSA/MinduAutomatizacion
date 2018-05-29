using PresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmPrincipal : Form
    {
        int MenuWidthMax;
        //int MenuWidthMin;
        bool MenuOculto = false;
        //int Level1Opt1Top = 169;
        int Level1Separation = 54;
        bool Opt1Open = false;

        public FrmPrincipal()
        {
            InitializeComponent();

            MenuWidthMax = pnlMenu.Width;
            //MenuWidthMin = 74;

            formHeader1.ParentContainer = this;

            panel4.Visible = false;

            
        }

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

            this.WindowState = FormWindowState.Maximized;

            this.ControlBox = false;
            this.Text = String.Empty;
           // pictureBox3.SendToBack();
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmFamilia FrmFami = new FrmFamilia();
            FrmFami.MdiParent = this;
            FrmFami.Show();
            FrmFami.Location = new Point(300, 150);
           // pnlMenu.SendToBack();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmPropiedades FrmProp = new FrmPropiedades();
            FrmProp.TopLevel = false;
            FrmProp.MdiParent = this;
            //panel2.Controls.Add(FrmProp);
            //panel2.Tag = FrmProp;
            FrmProp.WindowState = FormWindowState.Normal;
            FrmProp.Show();
            FrmProp.Location = new Point(340, 190);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmTipos FrmTipos = new FrmTipos();
            FrmTipos.TopLevel = false;
            FrmTipos.MdiParent = this;
            //panel2.Controls.Add(FrmTipos);
            //panel2.Tag = FrmTipos;
            FrmTipos.WindowState = FormWindowState.Normal;
            FrmTipos.Show();
            FrmTipos.Location = new Point(320, 170);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmValoresCostos FrmCost = new FrmValoresCostos();
            FrmCost.MdiParent = this;
            FrmCost.Show();
            FrmCost.Location = new Point(360, 210);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmItemSimple FrmItem = new FrmItemSimple();
            FrmItem.MdiParent = this;
            FrmItem.Show();
            FrmItem.Location = new Point(370, 230);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmItemCompuesto FrmCompu = new FrmItemCompuesto();
            FrmCompu.MdiParent = this;
            FrmCompu.Show();
            FrmCompu.Location = new Point(390, 250);
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
                pnlMenu.Width = pnlMenu.Width - 20;
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 6);
                pictureBox2.Location = new Point(pictureBox2.Location.X-1, pictureBox2.Location.Y);
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
                        Opt1Open = false;
                    }
                    break;
            }

        }

       
    }
}
