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
using BunifuAnimatorNS;

namespace PresentationLayer
{
    public partial class FrmPrincipalPanel : Form
    {
        public string TipoAcceso { get; set; }
        public string AccesoActual { get; set; }
        public string AccesoBloqueo { get; set; }
        public string labelUsser;
        //public string comboBox1;
        //public string comboBox2;
        //public string comboBox3;
        //public string txbuscarItem;
        //public string l49;
        //public string l4;

        //FrmReportesGrid gr = new FrmReportesGrid();
        
        
        public FrmPrincipalPanel()
        {
            InitializeComponent();

            MenuWidthMax = pnlMenu.Width;
            //MenuWidthMin = 74;

            formHeader1.ParentContainer = this;
            
            panel4.Visible = false;
            panel12.Visible = false;
         

            //label3.Equals(labelUsser);
            
            //metroComboBox1 = metroComboBox1.ToString();
            //metroComboBox2 = metroComboBox2.ToString();
            //metroComboBox3 = metroComboBox3.ToString();
            //txtBuscarItem = txtBuscarItem.ToString();          
            
        }

        int MenuWidthMax;
        //int MenuWidthMin;
        bool MenuOculto = false;
        //int Level1Opt1Top = 169;
        int Level1Separation = 54;
        bool Opt1Open = false;
        private BunifuAnimatorNS.AnimationType AnimationType = (AnimationType)10;


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
            MetroProgressSpinner1.Visible = false;
            Control.CheckForIllegalCrossThreadCalls = false;
            CheckForIllegalCrossThreadCalls = false;
            pictureBox4.Visible = false;
            label3.Visible = false;
            panel10.BackgroundImage = PresentationLayer.Properties.Resources.FondoAutoM2;

            Functions.ConfigurarMaterialSkinManagerInicio();
            FrmLogin Login = new FrmLogin();
            Login.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TipoAcceso != "LECTURA")
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
            FrmValoresCostos FrmCost = new FrmValoresCostos("Costos");
            AbrirFormulario(FrmCost, 360, 210);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmValoresCostos FrmCost = new FrmValoresCostos("Factores");
            AbrirFormulario(FrmCost, 360, 210);
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            await CargaAsync();
            FrmParte FormParte = new FrmParte(this);
            FormParte.TipoAcceso = TipoAcceso;
            AbrirFormulario(FormParte, 470, 230);
        }

        private async Task CargaAsync()
        {
            await Task.Run(() => VisualizarLabel(true));

        }

        private async void button3_ClickAsync(object sender, EventArgs e)
        {
            await CargaAsync();
            FrmKit FrmKits = new FrmKit(this);
            FrmKits.TipoAcceso = TipoAcceso;
            AbrirFormulario(FrmKits, 450, 100);

        }

        private async void button5_ClickAsync(object sender, EventArgs e)
        {
            await CargaAsync();
            FrmProducto FrmProd = new FrmProducto(this);
            FrmProd.TipoAcceso = TipoAcceso;
            AbrirFormulario(FrmProd, 470, 120);
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

        public void AsignarNombreUsuario(string UserName)
        {
            label3.Visible = true;
            label3.Text = UserName;
        }

        public void ConfigurarMenuAcceso()
        {
            switch (TipoAcceso)
            {
                case "VENTAS":
                    Opt1Open = true;
                    AbrirSubMenu(1);
                    MenuAccesoVentas();
                    break;
                case "ADMIN":
                    MenuAccesoAdmin();
                    break;
                case "LECTURA":
                    Opt1Open = true;
                    AbrirSubMenu(1);
                    MenuAccesoAdmin();
                    break;
            }

            if (AccesoBloqueo != AccesoActual)
            {
                List<Form> lform = new List<Form>();

                foreach (Form OpenForm in Application.OpenForms)
                {
                    if (OpenForm.Name != "FrmPrincipalPanel")
                        lform.Add(OpenForm);
                }

                foreach (Form f in lform)
                {
                    f.Close();
                }
            }

        }

        private void MenuAccesoVentas()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel3.Visible = false;
            button6.Location = new Point(11, 115);
           
            btnGlosario.Top = button6.Top + Level1Separation; //SEPARACION AUTOMATICA
            panel17.Top = btnGlosario.Top;
            panel11.Location = new Point(0, 115);

            //MOSTRAR LISTA COSTOS


            //metroComboBox1.Visible = false;
            //label42.Visible = false;
            //metroComboBox2.Visible = true;
            //label3.Visible = false;
            //txtBuscarItem.Visible = false;
            //label4.Visible = false;
            //metroComboBox3.Visible = false;


        }

        private void MenuAccesoAdmin()
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel3.Visible = true;
            button6.Location = new Point(12, 331);
           // btnGlosario.Location = new Point(20, 215); //PRUEBA BOTON GLOSARIO
            panel11.Location = new Point(2, 331);

        }

        public void AbrirFormulario(Form oForm, int X, int Y, bool Modal = false)
        {
            oForm.StartPosition = FormStartPosition.Manual;
            if (X == 0 && Y == 0)
            {
                oForm.Left = (panel10.Width - oForm.Width) / 2;
                oForm.Top = (panel10.Height - oForm.Height) / 2;
            }
            else
                oForm.Location = new Point(X, Y);


            if (Modal)
            {
                oForm.ShowDialog();
            }
            else
            {
                oForm.MdiParent = this;
                oForm.TopLevel = false;
                panel10.Controls.Add(oForm);
                oForm.Show();
            }
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
                        button6.Top = button5.Top + Level1Separation;
                        panel11.Top = button6.Top;
                        //btnGlosario.Location = new Point(20, 215); //PRUEBA BOTON GLOSARIO
                        btnGlosario.Top = button6.Top + Level1Separation; //SEPARACION AUTOMÁTICA
                        panel17.Top = btnGlosario.Top;
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
                        button6.Top = button5.Top + Level1Separation;
                        panel11.Top = button6.Top;
                        btnGlosario.Top = button6.Top + Level1Separation;//SEPARACION AUTOMÁTICA
                        panel17.Top = btnGlosario.Top;

                        Opt1Open = false;
                    }
                    break;
            }

        }

        private void PopUp_MouseEnter(object sender, EventArgs e)
        {
            var Obj = (dynamic)sender;
            Obj.Left = Obj.Left - 3;
            Obj.Top = Obj.Top - 3;
            Obj.Height = Obj.Height + 6;
            Obj.Width = Obj.Width + 6;
        }
        private void PopUp_MouseLeave(object sender, EventArgs e)
        {
            var Obj = (dynamic)sender;
            Obj.Left = Obj.Left + 3;
            Obj.Top = Obj.Top + 3;
            Obj.Height = Obj.Height - 6;
            Obj.Width = Obj.Width - 6;
        }

        public void SetBackGroundImage()
        {
            if (panel10.BackgroundImage != null)
                panel10.BackgroundImage = null;
            else
                panel10.BackgroundImage = PresentationLayer.Properties.Resources.FondoAutoM2;
        }

        public void Animate_BackLogo()
        {

            if (pictureBox4.Visible == true)
                BunifuTransition1.HideSync(pictureBox4);

            pictureBox4.Visible = false;
            //pictureBox4.BringToFront();

            BunifuTransition1.AnimationType = AnimationType;
            BunifuTransition1.ShowSync(pictureBox4);

            if (AnimationType == (AnimationType)13)
                AnimationType = (AnimationType)1;
            else
                AnimationType += 1;
        }


        public void VisualizarLabel(bool Visible)
        {
            this.label1.BringToFront();
            this.label1.Visible = Visible;
            //this.MetroProgressSpinner1.Visible = Visible;

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.SendToBack();
            Animate_BackLogo();
        }

        private void panel10_Resize(object sender, EventArgs e)
        {
            pictureBox4.Top = (panel10.Height / 2) - (pictureBox4.Height / 2);
            pictureBox4.Left = (panel10.Width / 2) - (pictureBox4.Width / 2);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipalPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AccesoBloqueo = AccesoActual;

            pictureBox4.Visible = false;
            label3.Visible = false;
            SetBackGroundImage();
            Functions.ConfigurarMaterialSkinManagerInicio();
            FrmLogin Login = new FrmLogin();
            Login.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FrmReportesGrid FrmReportes = new FrmReportesGrid(this);
            FrmReportes.TipoAcceso = TipoAcceso;
            AbrirFormulario(FrmReportes, 0, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmAprobacion FrmAutorizacion = new FrmAprobacion(this);
            AbrirFormulario(FrmAutorizacion, 0, 0);
        }

        private void btnGlosario_Click(object sender, EventArgs e)
        {
            FrmGlosario FrmGlo = new FrmGlosario(this);
            AbrirFormulario(FrmGlo, 0, 0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmGlosarioGest FrmGlo = new FrmGlosarioGest(this);
            AbrirFormulario(FrmGlo, 0, 0);
        }
    }
}
