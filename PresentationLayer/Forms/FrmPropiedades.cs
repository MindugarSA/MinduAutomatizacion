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

namespace PresentationLayer
{
    public partial class FrmPropiedades : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;
        BindingList<Propiedades> PropiedadesDataSource = new BindingList<Propiedades>();

        public FrmPropiedades()
        {
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();
            CargarGridPropiedades();
            this.InitializeClickHandlers();
        }

        private void CargarGridPropiedades()
        {
            PropiedadesDataSource = new BindingList<Propiedades>(PropiedadesBL.GetPropiedades());
            dataGridView1.DataSource = PropiedadesDataSource;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Activo"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.AjustColumnsWidthForGridWidth();
            //dataGridView1.Columns[2].Width = 300;

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
            btnAgregar.Parent = panel2;
            btnNuevo.Parent = panel3;
            btnCerrar.Parent = panel4;
            labelNoMouse1.Parent = btnAgregar;
            labelNoMouse2.Parent = btnNuevo;
            labelNoMouse3.Parent = btnCerrar;
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indice = dataGridView1.SelectedRows[0].Index;
                CargarCampos(indice);
            }
        }

        private void CargarCampos(int nRow)
        {
            labelNoMouse1.Text = "Actualizar";
            btnNuevo.Enabled = true;

            txtCodigo.Text = Convert.ToString(dataGridView1.Rows[nRow].Cells[1].Value);
            txtDescrpcion.Text = Convert.ToString(dataGridView1.Rows[nRow].Cells[2].Value);
            materialCheckBox1.Checked = dataGridView1.Rows[nRow].Cells[3].Value.ToString() == "1" ? true : false;

        }

        private void LimpiarCampos(int nRow)
        {
            txtCodigo.Text = "";
            txtDescrpcion.Text = "";
            materialCheckBox1.Checked =  true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            labelNoMouse1.Text = "Agregar";
            btnNuevo.Enabled = false;

            txtCodigo.Text = "";
            txtDescrpcion.Text = "";
            materialCheckBox1.Checked = true;
        }

        private bool ValidarCampos()
        {
            bool Valido = true;

            if (txtCodigo.Text == string.Empty)
            {
                errorIcono.SetError(txtCodigo, "Ingrese un Codigo");
                Valido = false;
            }
            else if (txtDescrpcion.Text == string.Empty)
            {
                errorIcono.SetError(txtDescrpcion, "Ingrese una Descripcion");
                Valido = false;
            }
            return Valido;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            TextBox cControl = (TextBox)sender;

            if (cControl.Text.Trim().Length != 0)
                errorIcono.SetError(cControl, "");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                List<Propiedades> lpropi = new List<Propiedades>();
                Propiedades Propi = new Propiedades();

                Propi.Codigo = txtCodigo.Text;
                Propi.Descripcion = txtDescrpcion.Text;
                Propi.Activo = materialCheckBox1.Checked ? 1 : 0;

                switch (labelNoMouse1.Text.Trim())
                {

                    case "Agregar":
                        lpropi.Add(Propi);
                        PropiedadesBL.InserPropiedades(lpropi);

                        CargarGridPropiedades();
                        // LimpiarCampos();
                        dataGridView1.Rows[(dataGridView1.RowCount - 1)].Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                        dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2];

                        CargarCampos(dataGridView1.RowCount - 1);
                        break;
                    case "Actualizar":
                        Propi.id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                        lpropi.Add(Propi);
                        PropiedadesBL.UpdatePropiedades(lpropi);

                        int nRow = dataGridView1.CurrentRow.Index;
                        CargarGridPropiedades();

                        dataGridView1.Rows[nRow].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2];
                        break;
                }

            }
        }

    }
}
