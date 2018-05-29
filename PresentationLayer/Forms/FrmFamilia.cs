using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class FrmFamilia : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        BindingList<Familia> FamiliaDataSource = new BindingList<Familia>();


        public FrmFamilia()
        {
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();
            CargarComboReglaFamilia();
            CargarGridFamilia();

        }

        private void CargarGridFamilia()
        {
            FamiliaDataSource = new BindingList<Familia>(FamiliaBL.GetFamilias());
            dataGridView1.DataSource = FamiliaDataSource;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.AjustColumnsWidthForGridWidth();
            dataGridView1.Columns[4].Width = 500;

            //txtDescrpcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataGridView1.DataSource, "Descripcion", true));
        }

        private void FrmFamilia_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            formHeader2.Select();
        }

        private void FrmFamilia_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }


        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                List<Familia> lFami = new List<Familia>();
                Familia Fami = new Familia();

                switch (labelNoMouse1.Text.Trim())
                {
                    case "Agregar":
                        Fami.Codigo = txtCodigo.Text.Trim();
                        Fami.Descripcion = txtDescrpcion.Text.Trim();
                        Fami.Estado = materialCheckBox1.Checked ? 1 : 0;
                        lFami.Add(Fami);
                        FamiliaBL.InsertFamilias(lFami);
                        break;
                    case "Actualizar":
                        Fami.id = Convert.ToInt32(dataGridView1[2, dataGridView1.CurrentRow.Index].Value);
                        Fami.Codigo = txtCodigo.Text.Trim();
                        Fami.Descripcion = txtDescrpcion.Text.Trim();
                        Fami.Estado = materialCheckBox1.Checked ? 1 : 0;
                        lFami.Add(Fami);
                        FamiliaBL.UpdateFamilias(lFami);
                        break;
                }
            }
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroComboBox2_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["Codigo"].ToString().Trim() + " - " + r["Descripcion"];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += metroComboBox2.SelectedValue.ToString().Trim();
            txtDescrpcion.Text += " " + ((DataRowView)metroComboBox2.SelectedItem).Row["Descripcion"];
            txtCodigo.Focus();
            txtCodigo.SelectionStart = txtCodigo.Text.Length;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            labelNoMouse1.Text = "Agregar";
            btnNuevo.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indice = dataGridView1.SelectedRows[0].Index;
                CargarCampos(indice);
            }
        }

        private void CargarComboReglaFamilia()
        {
            //DataTable DT = new DataTable().ListToDataTable(ReglasFamiliaBL.GetReglasFamilia());
            metroComboBox2.DataSource = new DataTable().ListToDataTable(ReglasFamiliaBL.GetReglasFamilia());
            metroComboBox2.DisplayMember = "Descripcion";
            metroComboBox2.ValueMember = "Codigo";

            metroComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            metroComboBox2.SelectedIndex = 0;
        }

        private void CargarCampos(int nRow)
        {
            labelNoMouse1.Text = "Actualizar";
            btnNuevo.Enabled = true;

            txtCodigo.Text = Convert.ToString(dataGridView1.Rows[nRow].Cells[3].Value);
            txtDescrpcion.Text = Convert.ToString(dataGridView1.Rows[nRow].Cells[4].Value);
            materialCheckBox1.Checked = dataGridView1.Rows[nRow].Cells[5].Value.ToString() == "1" ? true : false;
            // txtRango.Text = string.Format("{0:#,0.00###}", dataItems.Rows[nRow].Cells[3].Value);
        }

        private bool ValidarCampos()
        {
            bool Valido = true;

            if (txtCodigo.Text == string.Empty)
            {
                errorIcono.SetError(txtCodigo, "Ingrese un Metodo");
                Valido = false;
            }
            else if (txtDescrpcion.Text == string.Empty)
            {
                errorIcono.SetError(txtDescrpcion, "Ingrese una Unidad de Medida");
                Valido = false;
            }

            return Valido;
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
            formHeader2.ParentContainer = this;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            btnAgregar.Parent = panel2;
            btnNuevo.Parent = panel3;
            materialFlatButton3.Parent = panel4;
            labelNoMouse1.Parent = btnAgregar;
            labelNoMouse2.Parent = btnNuevo;
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


    }

}