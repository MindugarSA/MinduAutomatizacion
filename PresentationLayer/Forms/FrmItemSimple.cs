using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entities;
using BusinessLayer;

namespace PresentationLayer.Forms
{
    public partial class FrmItemSimple : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        String ModoPantalla = "";
        ItemCosto Entidad = new ItemCosto();


        public FrmItemSimple()
        {
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();
            CargarCombos();
            CargarGrids();
            metroComboBox3.SelectedIndex = 1;

            ModoPantalla = "Crear";
            panel3.Visible = false;

            Entidad.Id = 0;
            Entidad.IdItem = 0;
        }

        private void FrmItemSimple_Load(object sender, EventArgs e)
        {
            txtCodigo.Select();
        }

       



        #region Aplicar Modificaciones Visuales a Form
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);

            Brush aGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(50, 0), Color.Gray, Color.White);
            Pen pencil = new Pen(Color.LightGray, 5);
            e.Graphics.DrawRectangle(pencil, rect);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        #region Aplicar Acciones Visuales a Controles
        private void SetearControles()
        {
            formHeader1.ParentContainer = this;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            materialFlatButton1.Parent = panel2;
            materialFlatButton2.Parent = panel3;
            materialFlatButton3.Parent = panel4;
            labelNoMouse1.Parent = materialFlatButton1;
            labelNoMouse2.Parent = materialFlatButton2;
            labelNoMouse3.Parent = materialFlatButton3;
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

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var Obj = (dynamic)sender;
            Obj.Parent.Left = Obj.Parent.Left - 3;
            Obj.Parent.Top = Obj.Parent.Top - 3;
            Obj.Parent.Height = Obj.Parent.Height + 6;
            Obj.Parent.Width = Obj.Parent.Width + 6;
            foreach (Control c in Obj.Controls)
            {
                try
                {
                    if (c.GetType().Name == "LabelNoMouse")
                    {
                        Rectangle parentRect = c.Parent.ClientRectangle;
                        c.Left = (parentRect.Width - c.Width) / 2;
                        c.Top = (parentRect.Height - c.Height) / 2;
                    }
                }
                catch { }
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var Obj = (dynamic)sender;
            Obj.Parent.Left = Obj.Parent.Left + 3;
            Obj.Parent.Top = Obj.Parent.Top + 3;
            Obj.Parent.Height = Obj.Parent.Height - 6;
            Obj.Parent.Width = Obj.Parent.Width - 6;
            foreach (Control c in Obj.Controls)
            {
                try
                {
                    if (c.GetType().Name == "LabelNoMouse")
                    {
                        Rectangle parentRect = c.Parent.ClientRectangle;
                        c.Left = (parentRect.Width - c.Width) / 2;
                        c.Top = (parentRect.Height - c.Height) / 2;
                    }
                }
                catch { }
            }
        }





        #endregion

        private void metroComboBox2_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["Codigo"].ToString().Trim().Replace("-","") + " - " + r["Descripcion"].ToString().Trim();
        }

        private void metroComboBox4_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["Codigo"].ToString().Trim() + " - " + r["Descripcion"].ToString().Trim();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += metroComboBox2.SelectedValue.ToString().Trim();
            //txtDescrpcion.Text += " " + ((DataRowView)metroComboBox2.SelectedItem).Row["Descripcion"];
            txtCodigo.Focus();
            txtCodigo.SelectionStart = txtCodigo.Text.Length;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "P-";
            txtCodigo.Focus();
            txtCodigo.SelectionStart = txtCodigo.Text.Length;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += metroComboBox4.SelectedValue.ToString().Trim();
            //txtDescrpcion.Text += " " + ((DataRowView)metroComboBox2.SelectedItem).Row["Descripcion"];
            txtCodigo.Focus();
            txtCodigo.SelectionStart = txtCodigo.Text.Length;
        }

        private void CargarCombos()
        {
            //Combox Familia
            metroComboBox2.DataSource = new DataTable().ListToDataTable(FamiliaBL.GetFamilias());
            metroComboBox2.DisplayMember = "Descripcion";
            metroComboBox2.ValueMember = "Codigo";

            metroComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            metroComboBox2.SelectedIndex = 0;

            //Combox Familia
            metroComboBox4.DataSource = new DataTable().ListToDataTable(PropiedadesBL.GetPropiedades());
            metroComboBox4.DisplayMember = "Descripcion";
            metroComboBox4.ValueMember = "Codigo";

            metroComboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            metroComboBox4.SelectedIndex = 0;

            //Combox Unidades
            metroComboBox1.DataSource = new DataTable().ListToDataTable(UnidadesBL.GetUnidades());
            metroComboBox1.DisplayMember = "Codigo";
            metroComboBox1.ValueMember = "Codigo";

            metroComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            metroComboBox1.SelectedIndex = 0;

        }

        private void CargarGrids()
        {
            dgvCostoRRHH.DataSource = ItemCostoBL.GetItemCostosId(Convert.ToInt32(Entidad.IdItem));
        }
    }
}