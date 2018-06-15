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
    public partial class FrmKit : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        private string ModoPantalla = "";
        Item ItemEntidad = new Item();
        ItemCosto CostoEntidad = new ItemCosto();
        List<ItemCosto> ListCostoEntidad = new List<ItemCosto>();
        ItemDetalle ItemDetalleEntidad = new ItemDetalle();
        List<ItemDetalle> ListItemDetalleEntidad = new List<ItemDetalle>();
        DataTable dtItemDetalle = new DataTable();
        double ValorCostoEditado = 0;
        bool bControlActive = false;


        public FrmKit()
        {
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();
            CargarCombos();
            CargarGridsCostos();
            FormatearGridsCostos();
            CargarGridListadoItem();
            CargarGridsDetalleItem(0);
            EnlazarCampos();

            ModoPantalla = "Crear";
            panel3.Visible = false;

            metroGrid1.SelectedIndex = 0;
            this.InitializeClickHandlers();
        }

        /// <summary>
        /// EVENTOS    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void FrmItemSimple_Load(object sender, EventArgs e)
        {
            txtCodigo.Select();
            metroTabPage1.Select();
        }

        private void metroComboBox2_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["Codigo"].ToString().Trim().Replace("-", "") + " - " + r["Descripcion"].ToString().Trim();
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
            txtCodigo.Text += "K-";
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

        private void dgvCostoValidar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MetroFramework.Controls.MetroGrid dgvActual = (MetroFramework.Controls.MetroGrid)sender;
            if (e.RowIndex == -1)
                return;
            else if (dgvActual.SelectedRows.Count == 1)
            {
                try
                {
                    dgvActual.CurrentCell = dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[7];
                    //dgvActual[7, dgvActual.CurrentRow.Index].Style.BackColor = Color.White;
                    dgvActual[7, dgvActual.CurrentRow.Index].Selected = true;
                    dgvActual.BeginEdit(true);
                }
                catch (Exception) { }
            }

        }

        private void dgvItemDetalleValidar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MetroFramework.Controls.MetroGrid dgvActual = (MetroFramework.Controls.MetroGrid)sender;
            if (e.RowIndex == -1)
                return;
            else if (dgvActual.SelectedRows.Count == 1)
            {
                try
                {
                    dgvActual.CurrentCell = dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[9];
                    //dgvActual[7, dgvActual.CurrentRow.Index].Style.BackColor = Color.White;
                    dgvActual[9, dgvActual.CurrentRow.Index].Selected = true;
                    dgvActual.BeginEdit(true);
                }
                catch (Exception) { }
            }

        }

        private void dgvCostoValidar_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            MetroFramework.Controls.MetroGrid dgvActual = (MetroFramework.Controls.MetroGrid)sender;
            if (dgvActual.CurrentRow.Index == -1)
                return;
            else if (dgvActual.CurrentCell.ColumnIndex == 7)
            {
                e.Control.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            }
        }

        private void dgvItemDetalleValidar_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            MetroFramework.Controls.MetroGrid dgvActual = (MetroFramework.Controls.MetroGrid)sender;
            if (dgvActual.CurrentRow.Index == -1)
                return;
            else if (dgvActual.CurrentCell.ColumnIndex == 8)
            {
                e.Control.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            }
        }

        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TxtActual = (TextBox)sender;
            if (TxtActual.SelectedText == TxtActual.Text)
                TxtActual.Text = "";
            Funciones.Formato_Decimal(TxtActual, e);
        }

        private void dgvCostoValidar_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            MetroFramework.Controls.MetroGrid dgvActual = (MetroFramework.Controls.MetroGrid)sender;
            ValorCostoEditado = Convert.ToDouble(dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[7].Value);
        }

        private void dgvValidar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MetroFramework.Controls.MetroGrid dgvActual = (MetroFramework.Controls.MetroGrid)sender;

            if (dgvActual.CurrentRow.Index == -1)
                return;

            if (dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[7].Value.ToString().Length == 0)
                dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[7].Value = "0,00";
            else if (ValorCostoEditado != Convert.ToDouble(dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[7].Value))
            {
                dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[8].Value = Convert.ToDecimal(dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[6].Value) *
                                                                                Convert.ToDecimal(dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[7].Value);
                switch (dgvActual.Name)
                {
                    case "dgvCostoRRHH":
                        txtCostoRRHH.Text = SumaColumnaDoubleDT((DataTable)dgvActual.DataSource, "Cantidad", "Valor").ToString();
                        txtTotCosRRHH.Text = txtCostoRRHH.Text;
                        break;
                    case "dgvCostoProc":
                        txtCostoProc.Text = SumaColumnaDoubleDT((DataTable)dgvActual.DataSource, "Cantidad", "Valor").ToString();
                        txtTotCosPro.Text = (Convert.ToDouble(txtCostoProc.Text)).ToString();//double.Parse(txtCostoProc.Text, System.Globalization.CultureInfo.InvariantCulture).ToString();
                        break;
                        //case "dgvCostoAcero":
                        //    txtCostoAcero.Text = SumaColumnaDoubleDT((DataTable)dgvActual.DataSource, "Cantidad", "Valor").ToString();
                        //    txtTotCosPro.Text = (Convert.ToDouble(txtCostoProc.Text) + Convert.ToDouble(txtCostoAcero.Text)).ToString();
                        //    break;
                }
                txtTotalCostos.Text = (Convert.ToDouble(txtTotCosCom.Text) +
                                       Convert.ToDouble(txtCostoProc.Text) + Convert.ToDouble(txtCostoRRHH.Text)).ToString();

            }
        }

        private void TxtValidar_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TxtActual = (TextBox)sender;
            Funciones.Formato_Decimal(TxtActual, e);
            if (e.KeyChar == Convert.ToChar(13))
            {
                SendKeys.Send("{TAB}");
                //textBox4.Text = string.Format("{0:#,0.00###}", Convert.ToDecimal(textBox4.Text));
            }
        }

        private void txtValidar_Validated(object sender, EventArgs e)
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

        private void TxtValidar_Click(object sender, EventArgs e)
        {
            TextBox TxtActual = (TextBox)sender;
            if (!bControlActive)
            {
                bControlActive = true;
                TxtActual.SelectAll();
            }
        }

        private void txtValidar_Leave(object sender, EventArgs e)
        {
            bControlActive = false;
            txtTotalCostos.Text = (Convert.ToDouble(txtTotCosCom.Text) +
                                   Convert.ToDouble(txtCostoProc.Text) + Convert.ToDouble(txtCostoRRHH.Text)).ToString(); ;
        }

        private void dgvListaItems_DoubleClick(object sender, EventArgs e)
        {
            int ItemId = Convert.ToInt32(dgvListaItems.Rows[dgvListaItems.CurrentCell.RowIndex].Cells[0].Value);
            CargarDatosItem(ItemId);
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            int ItemId = Convert.ToInt32(dgvListaItems.Rows[dgvListaItems.CurrentCell.RowIndex].Cells[0].Value);
            CargarDatosItem(ItemId);
        }

        private void txtValidar_TextChanged(object sender, EventArgs e)
        {
            TextBox TxtActual = (TextBox)sender;
            if (!TxtActual.Focused)
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

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            LimpiarCamposItem();
            ModoPantalla = "Crear";
            panel3.Visible = false;
            labelNoMouse1.Text = "Agregar";
            CargarGridsCostos();
            FormatearGridsCostos();
            CargarGridsDetalleItem(0);
            metroGrid1.SelectedIndex = 0;
            LimpiarCamposItemDetalle();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            metroGrid1.SelectedIndex = 3;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtEncabezado.Text = (txtCodigo.Text + " : " + txtDescrpcion.Text).Trim();
            txtEncabezado2.Text = txtEncabezado.Text;
        }

        private void txtDescrpcion_TextChanged(object sender, EventArgs e)
        {
            txtEncabezado.Text = (txtCodigo.Text + " : " + txtDescrpcion.Text).Trim();
            txtEncabezado2.Text = txtEncabezado.Text;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            metroGrid1.SelectedIndex = 1;
        }

        private void dgvDetalleItemAmp_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int ItemId = Convert.ToInt32(dgvDetalleItemAmp.Rows[dgvDetalleItemAmp.CurrentCell.RowIndex].Cells[4].Value);
                Item ItemConsulta = ItemsBL.GetItemId(ItemId).FirstOrDefault();

                txtCodigoC.Text = ItemConsulta.Codigo;
                txtDescripcionC.Text = ItemConsulta.Descripcion;
                txtNombreC.Text = ItemConsulta.Nombre;
                txtEspesor.Text = ItemConsulta.Espesor.ToString();
                txtAncho.Text = ItemConsulta.Ancho.ToString();
                txtLargo.Text = ItemConsulta.Largo.ToString();
                txtDiametro.Text = ItemConsulta.Diametro.ToString();
                txtVolumen.Text = ItemConsulta.Volumen.ToString();
                txtPeso.Text = ItemConsulta.Peso.ToString();
                txtTotalCostoC.Text = ItemConsulta.CostoTotal.ToString();
                pictureBox10.BackgroundImage = null;
                if (ItemConsulta.Imagen != null)
                    pictureBox10.BackgroundImage = ImageExtensions.byteArrayToImage(ItemConsulta.Imagen);
                
            }
            catch { }

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                CargarEntidadItem();
                switch (labelNoMouse1.Text.Trim())
                {
                    case "Agregar":
                        ItemsBL.InsertItem(ItemEntidad);
                        CargarEntidadItemDetalle(ItemEntidad);
                        ItemDetalleBL.InsertItemDetalle(ListItemDetalleEntidad);
                        CargarEntidadCosto(ItemEntidad);
                        ItemCostoBL.InsertItemCostos(ListCostoEntidad);
                        labelNoMouse1.Text = "Actualizar";
                        ModoPantalla = "Modificar";
                        panel3.Visible = true;
                        break;
                    case "Actualizar":
                        ItemsBL.UpdateItem(ItemEntidad);
                        CargarEntidadItemDetalle(ItemEntidad);
                        List<ItemDetalle> DetalleUpdate = ListItemDetalleEntidad.Where(r => r.Id != 0).ToList();
                        List<ItemDetalle> DetallesInsert = ListItemDetalleEntidad.Where(r => r.Id == 0).ToList();
                        ItemDetalleBL.InsertItemDetalle(DetallesInsert);
                        ItemDetalleBL.UpdateItemDetalle(DetalleUpdate);
                        CargarEntidadCosto(ItemEntidad);
                        List<ItemCosto> CostosUpdate = ListCostoEntidad.Where(r => r.Id != 0).ToList();
                        List<ItemCosto> CostosInsert = ListCostoEntidad.Where(r => r.Id == 0).ToList();
                        ItemCostoBL.InsertItemCostos(CostosInsert);
                        ItemCostoBL.UpdateItemCostos(CostosUpdate);
                        break;
                }
                CargarGridsCostos();
                FormatearGridsCostos();
                CargarGridsDetalleItem(ItemEntidad.Id);
            }
        }
        /// <summary>
        /// METODOS /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void CargarCombos()
        {
            //Combox Familia
            DataTable DTFam = new DataTable().ListToDataTable(FamiliaBL.GetFamilias());
            DataRow row = DTFam.NewRow();
            row["Id"] = 0;
            row["Codigo"] = "";
            row["Descripcion"] = "";
            DTFam.Rows.InsertAt(row, 0);

            metroComboBox2.DataSource = DTFam;
            metroComboBox2.DisplayMember = "Descripcion";
            metroComboBox2.ValueMember = "Codigo";

            metroComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            metroComboBox2.SelectedIndex = 1;

            //Combox Familia
            metroComboBox4.DataSource = new DataTable().ListToDataTable(PropiedadesBL.GetPropiedades());
            metroComboBox4.DisplayMember = "Descripcion";
            metroComboBox4.ValueMember = "Codigo";

            metroComboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            metroComboBox4.SelectedIndex = 0;
        }

        private void CargarGridsCostos()
        {

            DataTable dtItemCostos = ItemCostoBL.GetItemCostosId(ItemEntidad.Id);
            //Costos RRHH
            DataTable dtCostosRRHH = dtItemCostos.AsEnumerable()
                            .Where(r => r.Field<string>("Categoria") == "HH")
                            .CopyToDataTable();
            dgvCostoRRHH.DataSource = dtCostosRRHH;

            //Costos Procesos
            DataTable dtCostosPro = dtItemCostos.AsEnumerable()
                            .Where(r => r.Field<string>("Categoria") == "PR")
                            .CopyToDataTable();
            dgvCostoProc.DataSource = dtCostosPro;

        }

        private void CargarGridListadoItem()
        {
            //Listado de Items
            dgvListaItems.DataSource = ItemsBL.GetItemsTipo("K");
            //dgvListaItems.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvListaItems.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListaItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List<int> visibleColumns = new List<int> { 1, 2, 3, 4, 6, 7, 8, 9 };
            foreach (DataGridViewColumn col in dgvListaItems.Columns)
            {
                if (!visibleColumns.Contains(col.Index))
                    col.Visible = false;
            }
        }

        private void CargarGridsDetalleItem(int itemId)
        {
            dtItemDetalle = ItemDetalleBL.GetItemDetalleId(itemId);

            dgvDetalleItemAmp.DataSource = dtItemDetalle;
            dgvDetalleItem.DataSource = dtItemDetalle;

            MetroFramework.Controls.MetroGrid[] ArrDgv = { dgvDetalleItem, dgvDetalleItemAmp };

            foreach (MetroFramework.Controls.MetroGrid dgvActual in ArrDgv)
            {
                List<int> visibleColumns = new List<int> { 5, 6, 7, 9, 10, 11 };
                foreach (DataGridViewColumn col in dgvActual.Columns)
                {
                    if (!visibleColumns.Contains(col.Index))
                        col.Visible = false;
                }

                dgvActual.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvActual.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvActual.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvActual.Columns[9].DefaultCellStyle.Format = "#,0.00###";
                dgvActual.Columns[10].DefaultCellStyle.Format = "#,0.00###";
                dgvActual.Columns[11].DefaultCellStyle.Format = "#,0.00###";

                dgvActual.Columns[9].ReadOnly = false;

                dgvActual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvActual.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvActual.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvActual.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if(dgvDetalleItemAmp.Rows.Count > 0) dgvDetalleItemAmp.CurrentCell = dgvDetalleItemAmp.Rows[0].Cells[9];
            }

        }

        private void FormatearGridsCostos()
        {
            //GRID COSTOS
            MetroFramework.Controls.MetroGrid[] ArrDgv = { dgvCostoRRHH, dgvCostoProc };

            foreach (MetroFramework.Controls.MetroGrid dgvActual in ArrDgv)
            {
                dgvActual.Columns[0].Visible = false;
                dgvActual.Columns[1].Visible = false;
                dgvActual.Columns[2].Visible = false;
                dgvActual.Columns[3].Visible = false;

                dgvActual.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvActual.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvActual.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvActual.Columns[6].DefaultCellStyle.Format = "#,0.00###";
                dgvActual.Columns[7].DefaultCellStyle.Format = "#,0.00###";
                dgvActual.Columns[8].DefaultCellStyle.Format = "#,0.00###";

                dgvActual.Columns[6].ReadOnly = false;

                dgvActual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvActual.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvActual.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private double SumaColumnaDoubleDT(DataTable dt, string sCol1, string sCol2)
        {
            var Total = dt.AsEnumerable()
                        .Sum(r => (r.Field<decimal>(sCol1) * r.Field<decimal>(sCol2)));
            return Convert.ToDouble(Total);
        }

        private void CargarCampos(int itemId)
        {

            ItemEntidad = ItemsBL.GetItemId(itemId).FirstOrDefault();
            EnlazarCampos();
            metroGrid1.SelectedIndex = 0;
            labelNoMouse1.Text = "Actualizar";
            ModoPantalla = "Modificar";
            panel3.Visible = true;

            DataTable dt = (DataTable)metroComboBox2.DataSource;

            var dFami = ((DataTable)metroComboBox2.DataSource).AsEnumerable()
                                    .Where(r => r.Field<int>("Id") == ItemEntidad.Familia)
                                    .FirstOrDefault();

            if (dFami[1] != null) metroComboBox2.SelectedValue = dFami[1]; else metroComboBox2.SelectedIndex = 0;
        }

        private void EnlazarCampos()
        {

            txtCodigo.DataBindings.Clear();
            txtDescrpcion.DataBindings.Clear();
            txtNombre.DataBindings.Clear();
            txtEspesor.DataBindings.Clear();
            txtAncho.DataBindings.Clear();
            txtLargo.DataBindings.Clear();
            txtDiametro.DataBindings.Clear();
            txtVolumen.DataBindings.Clear();
            txtPeso.DataBindings.Clear();

            txtCodigo.DataBindings.Add("Text", ItemEntidad, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDescrpcion.DataBindings.Add("Text", ItemEntidad, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNombre.DataBindings.Add("Text", ItemEntidad, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtEspesor.DataBindings.Add("Text", ItemEntidad, "Espesor", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAncho.DataBindings.Add("Text", ItemEntidad, "Ancho", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLargo.DataBindings.Add("Text", ItemEntidad, "Largo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDiametro.DataBindings.Add("Text", ItemEntidad, "Diametro", true, DataSourceUpdateMode.OnPropertyChanged);
            txtVolumen.DataBindings.Add("Text", ItemEntidad, "Volumen", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPeso.DataBindings.Add("Text", ItemEntidad, "Peso", true, DataSourceUpdateMode.OnPropertyChanged);

            if (ItemEntidad.Imagen != null) pictureBox1.BackgroundImage = ImageExtensions.byteArrayToImage(ItemEntidad.Imagen);

        }

        private void LimpiarCamposItem()
        {
            ItemEntidad = new Item();

            txtCodigo.Text = "";
            txtDescrpcion.Text = "";
            txtNombre.Text = "";
            txtEspesor.Text = "0,00";
            txtAncho.Text = "0,00";
            txtLargo.Text = "0,00";
            txtDiametro.Text = "0,00";
            txtVolumen.Text = "0,00";
            txtPeso.Text = "0,00";
            txtTotCosCom.Text = "0,00";
            txtTotCosPro.Text = "0,00";
            txtTotCosRRHH.Text = "0,00";
            txtTotalCostos.Text = "0,00";
            txtCostoProc.Text = "0,00";
            txtCostoRRHH.Text = "0,00";
            pictureBox1.BackgroundImage = null;
            metroComboBox2.SelectedIndex = -1;
            metroComboBox4.SelectedIndex = -1;
            materialCheckBox1.Checked = true;


        }

        private void LimpiarCamposItemDetalle()
        {
            txtCodigoC.Text = "";
            txtDescripcionC.Text = "";
            txtNombreC.Text = "";
            txtEspesorC.Text = "0,00";
            txtAnchoC.Text = "0,00";
            txtLargoC.Text = "0,00";
            txtDiametroC.Text = "0,00";
            txtVolumenC.Text = "0,00";
            txtPesoC.Text = "0,00";
            txtTotalCostoC.Text = "0,00";
            pictureBox10.BackgroundImage = null;
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
            materialFlatButton4.Parent = panel1;
            labelNoMouse1.Parent = materialFlatButton1;
            labelNoMouse2.Parent = materialFlatButton2;
            labelNoMouse3.Parent = materialFlatButton3;
            labelNoMouse4.Parent = materialFlatButton4;
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

        

        private void CargarEntidadItem()
        {
            ItemEntidad.Codigo = txtCodigo.Text.Trim();
            ItemEntidad.Descripcion = txtDescrpcion.Text;
            ItemEntidad.Nombre = txtNombre.Text;
            ItemEntidad.TipoPieza ="" ;
            ItemEntidad.Familia = Convert.ToInt32(((DataRowView)metroComboBox2.SelectedItem)[0].ToString());
            ItemEntidad.TipoItem = "K";
            ItemEntidad.Espesor = Convert.ToDecimal(txtEspesor.Text);
            ItemEntidad.Ancho = Convert.ToDecimal(txtAncho.Text);
            ItemEntidad.Largo = Convert.ToDecimal(txtLargo.Text);
            ItemEntidad.Diametro = Convert.ToDecimal(txtDiametro.Text);
            ItemEntidad.Volumen = Convert.ToDecimal(txtVolumen.Text);
            ItemEntidad.Peso = Convert.ToDecimal(txtPeso.Text);
            ItemEntidad.CostoCM = Convert.ToDecimal(txtTotCosCom.Text);
            ItemEntidad.CostoPR = Convert.ToDecimal(txtTotCosPro.Text);
            ItemEntidad.CostoRH = Convert.ToDecimal(txtTotCosRRHH.Text);
            ItemEntidad.CostoTotal = Convert.ToDecimal(txtTotalCostos.Text);
            ItemEntidad.CostoAC = 0;
            if(pictureBox1.BackgroundImage != null) ItemEntidad.Imagen = ImageExtensions.imageToByteArray(pictureBox1.BackgroundImage);
            ItemEntidad.Estatus = materialCheckBox1.Checked ? 1 : 0;
            if (labelNoMouse1.Text.Trim() == "Agregar") ItemEntidad.FechaCreacion = DateTime.Now; else ItemEntidad.FechaModificacion = DateTime.Now;

        }

        private void CargarEntidadCosto(Item ItemEnti)
        {
            DataTable dtCostosItem = new DataTable();

            dtCostosItem.Merge((DataTable)dgvCostoRRHH.DataSource);
            dtCostosItem.Merge((DataTable)dgvCostoProc.DataSource);

            ListCostoEntidad = new List<ItemCosto>();

            foreach (DataRow row in dtCostosItem.Rows)
            {
                CostoEntidad = new ItemCosto();
                CostoEntidad.IdItem = ItemEnti.Id;
                CostoEntidad.IdCosto = Convert.ToInt32(row["IdCosto"]);
                CostoEntidad.Unidad = row["Unidad"].ToString();
                CostoEntidad.Valor = Convert.ToDecimal(row["Valor"]);
                CostoEntidad.Cantidad = Convert.ToDecimal(row["Cantidad"]);
                CostoEntidad.Total = Convert.ToDecimal(row["Total"]);
                CostoEntidad.Id = Convert.ToInt32(row["Id"]);
                ListCostoEntidad.Add(CostoEntidad);
            }

        }

        private void CargarEntidadItemDetalle(Item ItemEnti)
        {
            DataTable dtItemDetalle = new DataTable();

            dtItemDetalle.Merge((DataTable)dgvDetalleItemAmp.DataSource);


            ListItemDetalleEntidad = new List<ItemDetalle>();
            int Linea = 1;

            foreach (DataRow row in dtItemDetalle.Rows)
            {
                ItemDetalleEntidad = new ItemDetalle();
                ItemDetalleEntidad.IdItem = ItemEnti.Id;
                ItemDetalleEntidad.IdDetalle = Convert.ToInt32(row["IdDetalle"]);
                ItemDetalleEntidad.Linea = Linea;
                ItemDetalleEntidad.Cantidad = Convert.ToDecimal(row["Cantidad"]);
                ItemDetalleEntidad.CostoUnitario = Convert.ToDecimal(row["CostoUnitario"]);
                ItemDetalleEntidad.Total = Convert.ToDecimal(row["Total"]);
                ItemDetalleEntidad.Id = Convert.ToInt32(row["Id"]);
                ListItemDetalleEntidad.Add(ItemDetalleEntidad);
                Linea += 1;
            }

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
                errorIcono.SetError(txtDescrpcion, "Ingrese una Descripción");
                Valido = false;
            }

            return Valido;
        }

        private void CargarDatosItem(int ItemId)
        {
            LimpiarCamposItem();
            CargarCampos(ItemId);
            CargarGridsDetalleItem(ItemId);
            //if(ItemId == 0) LimpiarCamposItemDetalle();
            CargarGridsCostos();
            FormatearGridsCostos();

            txtCostoRRHH.Text = SumaColumnaDoubleDT((DataTable)dgvCostoRRHH.DataSource, "Cantidad", "Valor").ToString();
            txtTotCosRRHH.Text = txtCostoRRHH.Text;
            txtCostoProc.Text = SumaColumnaDoubleDT((DataTable)dgvCostoProc.DataSource, "Cantidad", "Valor").ToString();
            txtTotCosPro.Text = Convert.ToDouble(txtCostoProc.Text).ToString();
            txtTotalCostos.Text = (Convert.ToDouble(txtTotCosCom.Text) + Convert.ToDouble(txtCostoProc.Text) +
                                   Convert.ToDouble(txtCostoRRHH.Text)).ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Title = "Seleccionar Imagen";
            oFD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            string pathImagen = "";

            try
            {
                if (oFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pathImagen = oFD.FileName;
                    pictureBox1.BackgroundImage = new Bitmap(@pathImagen);

                    byte[] byteimg = ImageExtensions.imageToByteArray(pictureBox1.BackgroundImage);
                    ItemEntidad.Imagen = byteimg;
                   
                }
            }
            catch { }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            int IdDetalle = Convert.ToInt32(dgvDetalleItemAmp.Rows[dgvDetalleItemAmp.CurrentCell.RowIndex].Cells[4].Value);
            if (IdDetalle > 0)
            {
                FrmPieza FrmParte = new FrmPieza();
                FrmParte.MdiParent = this.MdiParent;
                FrmParte.IdIetmSearch = IdDetalle;
                FrmParte.StartPosition = FormStartPosition.Manual;
                FrmParte.Location = new Point(370, 230);
                FrmParte.Show();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FrmBusquedaItem FrmBuscar = new FrmBusquedaItem();
            FrmBuscar.MdiParent = this.MdiParent;
            FrmBuscar.StartPosition = FormStartPosition.Manual;
            FrmBuscar.Location = new Point(300, 150);
            //panel10.Controls.Add(FrmFami);
            FrmBuscar.ShowDialog();
        }
    }
}