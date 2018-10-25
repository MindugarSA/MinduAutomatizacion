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
    public partial class FrmValoresCostos : Form
    {
        bool bControlActive = false;
        private const int cGrip = 16;
        private const int cCaption = 32;
        BindingList<Costos> CostosDataSource = new BindingList<Costos>();
        private string TipoPantalla { get; set; }

        public FrmValoresCostos(string pTipoPantalla)
        {
            TipoPantalla = pTipoPantalla;
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();
            CargarGridCostos();
            CargarCombos();
            this.InitializeClickHandlers();
        }


        private void FrmValoresCostos_Load(object sender, EventArgs e)
        {
            if (TipoPantalla == "Factores")
            {
                formHeader1.HeaderText = "Tasas / Factores";
                cmbUnidad.Visible = false;
                label4.Visible = false;
                cmbTipo.Items.Clear();
                cmbTipo.Items.Add("Tasa");
                cmbTipo.Items.Add("Factor");
            }
            FormatearCategoria();
            dataGridView1.Refresh();

            if (dataGridView1.Rows.Count > 0)
                cmbTipo.Text = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value).Trim();
            else
                LimpiarCampos();
            this.BringToFront();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {

            TextBox TxtActual = (TextBox)sender;
            Funciones.Formato_Decimal(TxtActual, e);
            if (e.KeyChar == Convert.ToChar(13))
            {
                SendKeys.Send("{TAB}");
                //textBox4.Text = string.Format("{0:#,0.00###}", Convert.ToDecimal(textBox4.Text));
            }
        }

        private void txtValor_Validated(object sender, EventArgs e)
        {
            TextBox TxtActual = (TextBox)sender;
            try
            {
                if (TxtActual.Text == string.Empty) TxtActual.Text = "0,00";
                TxtActual.Text = string.Format("{0:#,0.00###}", Convert.ToDecimal(TxtActual.Text));
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void TxtValor_Click(object sender, EventArgs e)
        {
            if (!bControlActive)
            {
                bControlActive = true;
                txtValor.SelectAll();
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            bControlActive = false;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indice = dataGridView1.SelectedRows[0].Index;
                CargarCampos(indice);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                List<Costos> lcosto = new List<Costos>();
                Costos Cost = new Costos();
                string Categ = "";

                switch (cmbTipo.Text.Trim())
                {
                    case "RR.HH.":
                        Categ = "HH";
                        break;
                    case "Procesos":
                        Categ = "PR";
                        break;
                    case "Aceros":
                        Categ = "AC";
                        break;
                    case "Tasa":
                        Categ = "TM";
                        break;
                    case "Factor":
                        Categ = "FR";
                        break;
                }

                Cost.Categoria = Categ;
                Cost.Tipo = txtDescripcion.Text.Trim();
                Cost.Unidad = cmbUnidad.Text.Trim();
                Cost.Estado = materialCheckBox1.Checked ? 1 : 0;
                Cost.Valor = Convert.ToDecimal(txtValor.Text);

                switch (labelNoMouse1.Text.Trim())
                {

                    case "Agregar":
                        lcosto.Add(Cost);
                        CostosBL.InserCostos(lcosto);

                        CargarGridCostos();
                        // LimpiarCampos();
                        dataGridView1.Rows[(dataGridView1.RowCount - 1)].Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                        dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3];

                        CargarCampos(dataGridView1.RowCount - 1);
                        FormatearCategoria();
                        break;
                    case "Actualizar":
                        Cost.Id = Convert.ToInt32(dataGridView1[1, dataGridView1.CurrentRow.Index].Value);
                        lcosto.Add(Cost);
                        CostosBL.UpdateCostos(lcosto);
                        ItemCostoBL.UpdateItemCostosID(Cost.Id);

                        int nRow = dataGridView1.CurrentRow.Index;
                        CargarGridCostos();
                        FormatearCategoria();

                        dataGridView1.Rows[nRow].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3];
                        break;
                }
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim() != string.Empty)
                errorIcono.SetError(txtDescripcion, "");
        }

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cControl = (ComboBox)sender;

            if (cControl.SelectedIndex != -1)
                errorIcono.SetError(cControl, "");
        }


        #region METODOS
        private void CargarGridCostos()
        {
            var CostosFiltro = new[] { "" };

            if (TipoPantalla == "Costos")
                CostosFiltro = new[] { "PR", "HH", "AC" };
            else
                CostosFiltro = new[] { "TM", "FR" };


            CostosDataSource = new BindingList<Costos>(CostosBL.GetCostos().Where(x => CostosFiltro.Contains(x.Categoria)).ToList());
            dataGridView1.DataSource = CostosDataSource;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Estado"].Visible = false;
            dataGridView1.Columns["Categoria"].Visible = false;
            if (TipoPantalla == "Factores") dataGridView1.Columns["Unidad"].Visible = false;

            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,0.00###";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.AjustColumnsWidthForGridWidth();
            //dataGridView1.Columns[3].Width = 200;

        }

        private void FormatearCategoria()
        {
            string Categ = "";

            foreach (DataGridViewRow Fila in dataGridView1.Rows)
            {
                switch (Fila.Cells[2].Value.ToString())
                {
                    case "HH":
                        Categ = "RR.HH.";
                        break;
                    case "PR":
                        Categ = "Procesos";
                        break;
                    case "AC":
                        Categ = "Aceros";
                        break;
                    case "TM":
                        Categ = "Tasa";
                        break;
                    case "FR":
                        Categ = "Factor";
                        break;
                }
                Fila.Cells["Categoria_"].Value = Categ;
            }
        }

        private void CargarCombos()
        {
            //Combox Unidades
            cmbUnidad.DataSource = new DataTable().ListToDataTable(UnidadesBL.GetUnidades());
            cmbUnidad.DisplayMember = "Codigo";
            cmbUnidad.ValueMember = "Codigo";

            cmbUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidad.SelectedIndex = 0;
        }

        private void CargarCampos(int nRow)
        {
            labelNoMouse1.Text = "Actualizar";
            btnNuevo.Enabled = true;

            var Tipo = Convert.ToString(dataGridView1.Rows[nRow].Cells[0].Value).Trim();
            cmbTipo.Text = Convert.ToString(dataGridView1.Rows[nRow].Cells[0].Value).Trim();
            //cmbUnidad.Text = Convert.ToString(dataGridView1.Rows[nRow].Cells[4].Value);
            if (TipoPantalla == "Costos") cmbUnidad.SelectedValue = Convert.ToString(dataGridView1.Rows[nRow].Cells[4].Value);
            txtDescripcion.Text = Convert.ToString(dataGridView1.Rows[nRow].Cells[3].Value);
            materialCheckBox1.Checked = dataGridView1.Rows[nRow].Cells[6].Value.ToString() == "1" ? true : false;
            txtValor.Text = string.Format("{0:#,0.00###}", dataGridView1.Rows[nRow].Cells[5].Value);

            // txtRango.Text = string.Format("{0:#,0.00###}", dataItems.Rows[nRow].Cells[3].Value);
        }

        private void LimpiarCampos()
        {
            labelNoMouse1.Text = "Agregar";
            btnNuevo.Enabled = false;

            cmbTipo.SelectedIndex = -1;
            cmbUnidad.SelectedIndex = -1;
            txtDescripcion.Text = "";
            materialCheckBox1.Checked = true;
            txtValor.Text = string.Format("{0:#,0.00###}", 0);

            // txtRango.Text = string.Format("{0:#,0.00###}", dataItems.Rows[nRow].Cells[3].Value);
        }

        private bool ValidarCampos()
        {
            bool Valido = true;

            if (cmbTipo.Text == "")
            {
                errorIcono.SetError(cmbTipo, "Ingrese un Tipo");
                Valido = false;
            }
            else if (cmbUnidad.Text == "" && TipoPantalla == "Costos")
            {
                errorIcono.SetError(cmbUnidad, "Ingrese una Unidad de Medida");
                Valido = false;
            }
            else if (txtDescripcion.Text == string.Empty)
            {
                errorIcono.SetError(txtDescripcion, "Ingrese una Descripcion");
                Valido = false;
            }
            return Valido;
        }

        #endregion

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
            BtnCerrar.Parent = panel4;
            labelNoMouse1.Parent = btnAgregar;
            labelNoMouse2.Parent = btnNuevo;
            labelNoMouse3.Parent = BtnCerrar;
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
