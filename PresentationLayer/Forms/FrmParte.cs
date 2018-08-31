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
using System.IO;

namespace PresentationLayer.Forms
{
    public partial class FrmParte : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        public int IdIetmSearch { get; set; }
        Item ItemEntidad = new Item();
        Item ItemEntidadInicial = new Item();
        ItemCosto CostoEntidad = new ItemCosto();
        List<ItemCosto> ListCostoEntidad = new List<ItemCosto>();
        private string CodigoInicial;
        double ValorCostoEditado = 0;
        bool bControlActive = false;
        string pathImagen = "";
        private FrmPrincipalPanel formPrincipal;

        public FrmParte(FrmPrincipalPanel FormP = null)
        {
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();
            CargarCombos();
            CargarGridsCostos();
            FormatearGridsCostos();
            CargarGridListadoItem();
            EnlazarCampos();
            LimpiarCampos();

            metroComboBox3.SelectedIndex = 0;
            panel3.Visible = false;

            metroTabControl1.SelectedIndex = 0;
            materialCheckBox1.Checked = true;
            this.InitializeClickHandlers();
            formPrincipal = FormP;

        }

        #region EVENTOS

        private void FrmItemSimple_Load(object sender, EventArgs e)
        {
            txtCodigo.Select();
            metroTabPage1.Select();
            if (this.IdIetmSearch > 0)
                CargarDatosItem(this.IdIetmSearch);
            if (formPrincipal != null) formPrincipal.VisualizarLabel(false);
            this.BringToFront();
            txtCodigo.Focus();
            this.ActiveControl = txtCodigo;
            CheckForIllegalCrossThreadCalls = false;
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
            txtCodigo.Text += metroComboBox2.SelectedValue.ToString().Trim() + "P-";
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
                        txtTotCosPro.Text = (Convert.ToDouble(txtCostoProc.Text) + Convert.ToDouble(txtCostoAcero.Text)).ToString();//double.Parse(txtCostoProc.Text, System.Globalization.CultureInfo.InvariantCulture).ToString();
                        break;
                    case "dgvCostoAcero":
                        txtCostoAcero.Text = SumaColumnaDoubleDT((DataTable)dgvActual.DataSource, "Cantidad", "Valor").ToString();
                        txtTotCosPro.Text = (Convert.ToDouble(txtCostoProc.Text) + Convert.ToDouble(txtCostoAcero.Text)).ToString();
                        break;
                }
                txtTotalCostos.Text = (Convert.ToDouble(txtTotCosCom.Text) + Convert.ToDouble(txtCostoAcero.Text) +
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
            Control TxtActual = (Control)sender;
            txtTotalCostos.Text = (Convert.ToDouble(txtTotCosCom.Text) + Convert.ToDouble(txtCostoAcero.Text) +
                                   Convert.ToDouble(txtCostoProc.Text) + Convert.ToDouble(txtCostoRRHH.Text)).ToString();
            try
            {
                if ((txtEspesor.Text.ToDecimal() ?? 0) > 0 && (txtAncho.Text.ToDecimal() ?? 0) > 0 && (txtLargo.Text.ToDecimal() ?? 0) > 0)
                {
                    string CalcPeso = Math.Round(((Convert.ToDouble(txtEspesor.Text) * Convert.ToDouble(txtAncho.Text) * Convert.ToDouble(txtLargo.Text)) * 0.000008), 2).ToString();
                    if (Convert.ToDouble(txtPeso.Text) == 0 || txtPeso.Text.Trim() != CalcPeso.Trim())
                        txtPeso.Text = CalcPeso;
                }
            }
            catch { }
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

        private void CargarDatosItem(int ItemId)
        {
            LimpiarCampos();
            CargarCampos(ItemId);
            CargarGridsCostos();
            FormatearGridsCostos();

            txtCostoRRHH.Text = SumaColumnaDoubleDT((DataTable)dgvCostoRRHH.DataSource, "Cantidad", "Valor").ToString();
            txtTotCosRRHH.Text = txtCostoRRHH.Text;
            txtCostoProc.Text = SumaColumnaDoubleDT((DataTable)dgvCostoProc.DataSource, "Cantidad", "Valor").ToString();
            txtTotCosPro.Text = (Convert.ToDouble(txtCostoProc.Text) + Convert.ToDouble(txtCostoAcero.Text)).ToString();
            txtCostoAcero.Text = SumaColumnaDoubleDT((DataTable)dgvCostoAcero.DataSource, "Cantidad", "Valor").ToString();
            txtTotCosPro.Text = (Convert.ToDouble(txtCostoProc.Text) + Convert.ToDouble(txtCostoAcero.Text)).ToString();
            txtTotalCostos.Text = (Convert.ToDouble(txtTotCosCom.Text) + Convert.ToDouble(txtCostoAcero.Text) +
                                   Convert.ToDouble(txtCostoProc.Text) + Convert.ToDouble(txtCostoRRHH.Text)).ToString();
            txtDirectFact.Text = (Math.Round((txtTotalCostos.Text.ToDouble() * nFactor ?? 0), 2)).ToString();
            errorCodigo.SetErrorWithCount(txtCodigo, "");
            errorDescr.SetErrorWithCount(txtCodigo, "");
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
            LimpiarCampos();
            panel3.Visible = false;
            labelNoMouse1.Text = "Agregar";
            CargarGridsCostos();
            CargarGridListadoItem();
            FormatearGridsCostos();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 3;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Title = "Seleccionar Imagen";
            oFD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            pathImagen = "";

            try
            {
                if (oFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pathImagen = oFD.FileName;
                    pictureBox1.BackgroundImage = new Bitmap(@pathImagen);

                    byte[] byteimg = ImageExtensions.imageToByteArray(pictureBox1.BackgroundImage);
                    ItemEntidad.Imagen = byteimg;
                    //pictureBox1.BackgroundImage.Dispose();
                    //pictureBox1.BackgroundImage = null;

                    //MessageBox.Show("Conversion");

                    //Image nImg =  ImageExtensions.byteArrayToImage(byteimg);

                    //pictureBox1.BackgroundImage = nImg;
                }
            }
            catch { }
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox3.SelectedIndex)
            {
                case 0:
                    nFactor = 1.409;
                    break;
                case 1:
                    nFactor = 1.857;
                    break;
            }

            double Direct = Convert.ToDouble(txtTotalCostos.Text);
            txtDirectFact.Text = Math.Round(Direct * nFactor,2).ToString();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (labelNoMouse1.Text.Trim() != "Actualizar" && CodigoInicial != txtCodigo.Text.Trim() && txtCodigo.Text.Trim().Length > 0)
                VerificarCodigoItem();

            if (ValidarCampos())
            {
                CargarEntidadItem();
                switch (labelNoMouse1.Text.Trim())
                {
                    case "Agregar":
                        ItemsBL.InsertItem(ItemEntidad);
                        CargarEntidadCosto(ItemEntidad);
                        ItemCostoBL.InsertItemCostos(ListCostoEntidad);
                        labelNoMouse1.Text = "Actualizar";
                        panel3.Visible = true;
                        MostrarMensajeRegistro("Parte '" + ItemEntidad.Codigo.Trim() + "' Registrada", Color.FromArgb(129, 152, 48));
                        break;
                    case "Actualizar":
                        ItemsBL.UpdateItem(ItemEntidad);
                        ItemsBL.UpdateItemCostoTotalRelacionados(ItemEntidad.Id);
                        CargarEntidadCosto(ItemEntidad);
                        List<ItemCosto> CostosUpdate = ListCostoEntidad.Where(r => r.Id != 0).ToList();
                        List<ItemCosto> CostosInsert = ListCostoEntidad.Where(r => r.Id == 0).ToList();
                        ItemCostoBL.InsertItemCostos(CostosInsert);
                        ItemCostoBL.UpdateItemCostos(CostosUpdate);
                        MostrarMensajeRegistro("Parte '" + ItemEntidad.Codigo.Trim() + "' Modificada", Color.FromArgb(0, 174, 219));
                        break;
                }
                CargarGridListadoItem();
                CargarGridsCostos();
                FormatearGridsCostos();
            }
        }


        #endregion

        /// <summary>
        ///  METODOS //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        #region METODOS

        private void MostrarMensajeRegistro(string Mensaje, Color TextColor)
        {
            label26.ForeColor = TextColor;
            label26.Text = Mensaje;
            label26.Visible = true;
            timer1.Start();
        }
        private void CargarCombos()
        {
            //Combox Familia
            DataTable DTFam = new DataTable().ListToDataTable(FamiliaBL.GetFamilias());
            DataTable DTFam2 = new DataTable().ListToDataTable(FamiliaBL.GetFamilias());
            DataRow row = DTFam.NewRow();
            row["Id"] = 0;
            row["Codigo"] = "";
            row["Descripcion"] = "";
            DTFam.Rows.InsertAt(row, 0);
            DataRow row2 = DTFam2.NewRow();
            row2["Id"] = 0;
            row2["Codigo"] = "";
            row2["Descripcion"] = "";
            DTFam2.Rows.InsertAt(row2, 0);

            metroComboBox2.DataSource = DTFam;
            metroComboBox2.DisplayMember = "Descripcion";
            metroComboBox2.ValueMember = "Codigo";

            metroComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            metroComboBox2.SelectedIndex = 1;

            metroComboBox1.DataSource = DTFam2;
            metroComboBox1.DisplayMember = "Descripcion";
            metroComboBox1.ValueMember = "Codigo";

            metroComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            metroComboBox1.SelectedIndex = 0;

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
            DataTable dtCostosAcero = dtItemCostos.AsEnumerable()
                            .Where(r => r.Field<string>("Categoria") == "AC")
                            .CopyToDataTable();
            dgvCostoAcero.DataSource = dtCostosAcero;

            //Costos Procesos
            DataTable dtCostosPro = dtItemCostos.AsEnumerable()
                            .Where(r => r.Field<string>("Categoria") == "PR")
                            .CopyToDataTable();
            dgvCostoProc.DataSource = dtCostosPro;
        }

        private void CargarGridListadoItem()
        {
            //Listado de Items
            dgvListaItems.DataSource = ItemsBL.GetItemsTipo("P").Select(c =>
                                                                {
                                                                    c.TipoItem = c.TipoPieza == "K" ? c.TipoItem : c.TipoItem + c.TipoPieza ?? "";
                                                                    return c;
                                                                }).ToList();
            //dgvListaItems.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvListaItems.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvListaItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            List<int> visibleColumns = new List<int> { 1, 2, 3, 5, 6, 7, 8, 9, 17, 18 };
            if (materialCheckBox3.Checked) visibleColumns = new List<int> { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 13, 14, 15, 17, 18 };
            foreach (DataGridViewColumn col in dgvListaItems.Columns)
            {
                if (!visibleColumns.Contains(col.Index))
                    col.Visible = false;
                else
                    col.Visible = true;
                col.ReadOnly = true;
            }
            dgvListaItems.AjustColumnsWidthForGridWidth();

            ((DataGridViewImageColumn)dgvListaItems.Columns[18]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvListaItems.Columns[13].HeaderText = "CostoEXT";

            List<int> NumericColumns = new List<int> { 6, 7, 8, 9, 10, 11, 13, 14, 15, 17 };
            foreach (DataGridViewColumn col in dgvListaItems.Columns)
            {
                if (NumericColumns.Contains(col.Index))
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    col.DefaultCellStyle.Format = "#,0.00###";
                }
            }

            if (materialCheckBox2.Checked)
                foreach (DataGridViewRow row in dgvListaItems.Rows)
                {
                    row.Height = 60;
                    dgvListaItems.Columns[18].Width = 150;
                }
            else
                foreach (DataGridViewRow row in dgvListaItems.Rows)
                {
                    row.Height = 22;
                    dgvListaItems.Columns[18].Width = 50;
                }

            dgvListaItems.AllowUserToResizeColumns = true;

        }

        private void FormatearGridsCostos()
        {
            MetroFramework.Controls.MetroGrid[] ArrDgv = { dgvCostoRRHH, dgvCostoProc, dgvCostoAcero };

            foreach (MetroFramework.Controls.MetroGrid dgvActual in ArrDgv)
            {
                dgvActual.Columns[0].Visible = false;
                dgvActual.Columns[1].Visible = false;
                dgvActual.Columns[2].Visible = false;
                dgvActual.Columns[3].Visible = false;
                dgvActual.Columns[9].Visible = false;

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
            ItemEntidadInicial = Functions.DeepCopy<Item>(ItemEntidad);
            CodigoInicial = ItemEntidad.Codigo;
            EnlazarCampos();
            metroTabControl1.SelectedIndex = 0;
            labelNoMouse1.Text = "Actualizar";
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
            txtTotCosCom.DataBindings.Clear();
            txtTotCosPro.DataBindings.Clear();
            txtTotCosRRHH.DataBindings.Clear();
            txtTotalCostos.DataBindings.Clear();

            txtCodigo.DataBindings.Add("Text", ItemEntidad, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDescrpcion.DataBindings.Add("Text", ItemEntidad, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNombre.DataBindings.Add("Text", ItemEntidad, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtEspesor.DataBindings.Add("Text", ItemEntidad, "Espesor", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAncho.DataBindings.Add("Text", ItemEntidad, "Ancho", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLargo.DataBindings.Add("Text", ItemEntidad, "Largo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDiametro.DataBindings.Add("Text", ItemEntidad, "Diametro", true, DataSourceUpdateMode.OnPropertyChanged);
            txtVolumen.DataBindings.Add("Text", ItemEntidad, "Volumen", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPeso.DataBindings.Add("Text", ItemEntidad, "Peso", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTotCosCom.DataBindings.Add("Text", ItemEntidad, "CostoCM", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTotCosPro.DataBindings.Add("Text", ItemEntidad, "CostoPR", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTotCosRRHH.DataBindings.Add("Text", ItemEntidad, "CostoRH", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTotalCostos.DataBindings.Add("Text", ItemEntidad, "CostoTotal", true, DataSourceUpdateMode.OnPropertyChanged);

            materialCheckBox1.Checked = ItemEntidad.Estatus == 1 ? true : false;
            if (ItemEntidad.Imagen != null) pictureBox1.BackgroundImage = ImageExtensions.byteArrayToImage(ItemEntidad.Imagen);

            if(ItemEntidad.TipoPieza != null) metroComboBox3.SelectedIndex = ItemEntidad.TipoPieza.Trim() == "E" ? 1 : 0;

            txtCostoAcero.Text = "";
            txtCostoProc.Text = "";
            txtCostoRRHH.Text = "";

        }

        private void LimpiarCampos()
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
            txtCostoAcero.Text = "0,00";
            txtCostoProc.Text = "0,00";
            txtCostoRRHH.Text = "0,00";
            txtDirectFact.Text = "0,00";

            pictureBox1.BackgroundImage = Properties.Resources.ImagenBlank;
            metroComboBox2.SelectedIndex = -1;
            metroComboBox3.SelectedIndex = 0;
            metroComboBox4.SelectedIndex = -1;
            materialCheckBox1.Checked = true;

        }

        private void CargarEntidadItem()
        {
            ItemEntidad.Codigo = txtCodigo.Text.Trim();
            ItemEntidad.Descripcion = txtDescrpcion.Text;
            ItemEntidad.Nombre = txtNombre.Text;
            ItemEntidad.TipoPieza = metroComboBox3.SelectedIndex == 0 ? "I" : "E";
            ItemEntidad.Familia = metroComboBox2.SelectedItem == null ? 0 : Convert.ToInt32(((DataRowView)metroComboBox2.SelectedItem)[0].ToString());
            ItemEntidad.TipoItem = "P";
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
            ItemEntidad.CostoAC = Convert.ToDecimal(txtCostoAcero.Text);
            ItemEntidad.Imagen = ImageExtensions.imageToByteArray(pictureBox1.BackgroundImage);
            ItemEntidad.Estatus = materialCheckBox1.Checked ? 1 : 0;
            ItemEntidad.Autorizado = 1 ;

            if (labelNoMouse1.Text.Trim() == "Agregar") ItemEntidad.FechaCreacion = DateTime.Now; else ItemEntidad.FechaModificacion = DateTime.Now;

        }

        private void CargarEntidadCosto(Item ItemEnti)
        {
            DataTable dtCostosItem = new DataTable();

            dtCostosItem.Merge((DataTable)dgvCostoRRHH.DataSource);
            dtCostosItem.Merge((DataTable)dgvCostoAcero.DataSource);
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

        private bool ValidarCampos()
        {
            bool Valido = true;

            if (errorCodigo.HasErrors() || errorDescr.HasErrors())
                Valido = false;
            else if (txtCodigo.Text == string.Empty)
            {
                errorCodigo.SetErrorWithCount(txtCodigo, "Ingrese un Codigo");
                Valido = false;
            }
            else if (txtDescrpcion.Text == string.Empty)
            {
                errorDescr.SetErrorWithCount(txtDescrpcion, "Ingrese una Descripción");
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
            Pen pencil = new Pen(Color.FromArgb(128, 211, 211, 211), 7);
            e.Graphics.DrawRectangle(pencil, rect);

        }

        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x84)
        //    {
        //        Point pos = new Point(m.LParam.ToInt32());
        //        pos = this.PointToClient(pos);
        //        if (pos.Y < cCaption)
        //        {
        //            m.Result = (IntPtr)2;
        //            return;
        //        }
        //        if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
        //        {
        //            m.Result = (IntPtr)17;
        //            return;
        //        }
        //    }
        //    base.WndProc(ref m);
        //}

        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        private int currentMouseOverRow;
        private int currentMouseOverCol;
        private double nFactor;

        protected override void WndProc(ref Message m)
        {
            try
            {
                switch (m.Msg)
                {
                    case WM_NCHITTEST:
                        base.WndProc(ref m);
                        var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                        if (sizeGripRectangle.Contains(hitPoint))
                            m.Result = new IntPtr(HTBOTTOMRIGHT);
                        break;
                    default:
                        base.WndProc(ref m);
                        break;
                }
            }
            catch { }

        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            //this.panelPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.Transparent);
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
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

        private void InitializeClickHandlers(Control parent, bool bChilds = true)
        {
            foreach (Control child in parent.Controls)
            {
                child.MouseClick += new MouseEventHandler(ControlsClick);
                InitializeClickHandlers(child);
            }
        }

        private void ControlsClick(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void FrmPieza_DragDrop(object sender, DragEventArgs e)
        {
            //TAKE DROPPED ITEMS AND STORE IN ARRAY
            string[] droppedfiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            //LOOP THRU ALL DROPPED ITEMS AND DISPLAY THEM
            foreach (string file in droppedfiles)
            {
                //GET FILENAME
                string filename = Path.GetFileNameWithoutExtension(file);
                // SET IMAGE
                pictureBox1.BackgroundImage = Image.FromFile(file);
            }
            // GET FILENAME

        }

        private void FrmPieza_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if ((labelNoMouse1.Text.Trim() == "Agregar" && txtCodigo.Text.Trim() != "") ||
                (labelNoMouse1.Text.Trim() != "Agregar" && CodigoInicial != txtCodigo.Text.Trim()))
            {
                VerificarCodigoItem();
            }
        }

        private void VerificarCodigoItem()
        {
            var result = ItemsBL.GetItems()
                             .Where(s => s.Codigo.ToUpper() == txtCodigo.Text.Trim().ToUpper())
                             .FirstOrDefault();
            if (result != null)
                errorCodigo.SetErrorWithCount(txtCodigo, "El Codigo Ya Existe en la Base de Datos");
            else
                errorCodigo.SetErrorWithCount(txtCodigo, "");
        }



        private void FrmPieza_Shown(object sender, EventArgs e)
        {
            this.Activate();
            this.BringToFront();
        }

        private void FrmPieza_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //try
                //{
                //    this.contextMenuStrip1.Show(this, new Point(e.X, e.Y));
                //    this.contextMenuStrip1.Show(Cursor.Position);
                //}
                //catch { }
            }
        }

        private void duplicarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodigoInicial = "";
            panel3.Visible = false;
            labelNoMouse1.Text = "Agregar";
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (labelNoMouse1.Text.Trim() != "Actualizar")
            {
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[2].Enabled = false;
            }
            else
            {
                contextMenuStrip1.Items[0].Enabled = true;
                contextMenuStrip1.Items[1].Enabled = true;
                contextMenuStrip1.Items[2].Enabled = true;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (txtBuscarItem.Text.Trim().Length > 0)
            {
                var result = ItemsBL.GetItemsTipo("P")
                            .Select(c =>
                                    {
                                        c.TipoItem = c.TipoPieza == "K" ? c.TipoItem : c.TipoItem + c.TipoPieza ?? "";
                                        return c;
                                    })
                            .Where(s => (s.Codigo.ToUpper().Contains(txtBuscarItem.Text.Trim().ToUpper())
                                        || s.Descripcion.ToUpper().Contains(txtBuscarItem.Text.Trim().ToUpper()))).ToList();

                if (result != null)
                    dgvListaItems.DataSource = result;
            }
            else
            {
                var result = ItemsBL.GetItemsTipo("P")
                            .Select(c =>
                            {
                                c.TipoItem = c.TipoPieza == "K" ? c.TipoItem : c.TipoItem + c.TipoPieza ?? "";
                                return c;
                            }).ToList();

                if (result != null)
                    dgvListaItems.DataSource = result;
            }
        }

        private void materialCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox2.Checked)
                foreach (DataGridViewRow row in dgvListaItems.Rows)
                {
                    row.Height = 60;
                    dgvListaItems.Columns[18].Width = 150;
                }
            else
                foreach (DataGridViewRow row in dgvListaItems.Rows)
                {
                    row.Height = 22;
                    dgvListaItems.Columns[18].Width = 50;
                }
        }

        private void materialCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            CargarGridListadoItem();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim().Length > 0 && errorCodigo.HasErrors())
                errorCodigo.SetErrorWithCount(txtCodigo, "");
        }

        private void txtDescrpcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescrpcion.Text.Trim().Length > 0 && errorDescr.HasErrors())
                errorDescr.SetErrorWithCount(txtDescrpcion, "");
        }

        private void txtTotalCostos_TextChanged(object sender, EventArgs e)
        {
            txtDirectFact.Text = (txtTotalCostos.Text.ToDouble() * nFactor).ToString();
        }

        private void OpenImegeForm(Image Img)
        {
            FrmPrincipalPanel frmParentForm = (FrmPrincipalPanel)Application.OpenForms["FrmPrincipalPanel"];
            FrmViewPicture form = new FrmViewPicture();//MetroFramework.Forms.MetroForm();
            form.Imagen = Img;
            form.AutoSize = true;
            frmParentForm.AbrirFormulario(form, 0, 0, true);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenImegeForm(pictureBox1.BackgroundImage);
        }

        private void copiarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string dgvToHTMLTable = dgvListaItems.ConvertDataGridViewToHTMLWithFormatting();
            //Clipboard.SetText(dgvToHTMLTable);
            dgvListaItems.CopyContentToClipboard();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dgvListaItems[currentMouseOverCol, currentMouseOverRow].Value.ToString());
        }

        private void dgvListaItems_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentMouseOverRow = e.RowIndex;
                currentMouseOverCol = e.ColumnIndex;
                if (currentMouseOverCol > -1)
                    try
                    {
                        dgvListaItems.CurrentCell = dgvListaItems[currentMouseOverCol, currentMouseOverRow < 0 ? 0 : currentMouseOverRow];
                        dgvListaItems.Rows[(currentMouseOverRow)].Selected = true;
                    }
                    catch { }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox1.BackgroundImage);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            IDataObject data = Clipboard.GetDataObject();
            if (data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = ((string[])(data.GetData("FileDrop", false)));
                FileInfo FInfo = new FileInfo(files[0]);
                if (((FInfo.Extension.ToLower() == ".jpg")
                            || ((FInfo.Extension.ToLower() == ".bmp")
                            || (FInfo.Extension.ToLower() == ".png"))))
                {
                    Bitmap image = new Bitmap(FInfo.FullName);
                    pictureBox1.BackgroundImage = (Bitmap)image;
                }

            }
            else if ((data.GetDataPresent(DataFormats.Bitmap) || data.GetDataPresent(DataFormats.Dib)))
            {
                Bitmap bmp = null;

                Image img = ((Image)data.GetData("Bitmap", false));
                bmp = new Bitmap(img);
                pictureBox1.BackgroundImage = (Bitmap)bmp;

            }

            //if (Clipboard.GetImage() != null) //Excel 2007
            //{
            //    //pictureBox1.Width = Clipboard.GetImage().Width;
            //    //pictureBox1.Height = Clipboard.GetImage().Height;
            //    pictureBox1.BackgroundImage = Clipboard.GetImage();
            //    //...
            //}
            //else if (Clipboard.GetDataObject().GetDataPresent("PNG")) //Excel 2003
            //{
            //    Clipboard.GetDataObject().GetFormats();
            //    IDataObject data = Clipboard.GetDataObject();
            //    MemoryStream ms = (MemoryStream)data.GetData("PNG");

            //    //pictureBox1.Width = Image.FromStream(ms).Width;
            //    //pictureBox1.Height = Image.FromStream(ms).Height;
            //    pictureBox1.BackgroundImage = Image.FromStream(ms);
            //    //...
            //}
        }

        private void txtTotalCostos_TextChanged_1(object sender, EventArgs e)
        {
            if (!txtTotalCostos.Focused)
                try
                {
                    if (txtTotalCostos.Text == string.Empty) txtTotalCostos.Text = "0,00";
                    txtTotalCostos.Text = string.Format("{0:#,0.00###}", Convert.ToDecimal(txtTotalCostos.Text));
                    txtDirectFact.Text = (Math.Round((txtTotalCostos.Text.ToDouble() * nFactor ?? 0), 2)).ToString();
                }
                catch (Exception)
                {
                    //throw;
                }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.ImagenBlank;
        }

        private void dgvListaItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridViewColumn objDG = this.dgvListaItems.Columns[e.ColumnIndex];
            string sTextoMensaje;
            sTextoMensaje = "Error en la columna: " + objDG.DataPropertyName + "\n" +
            e.Exception.Message;
            MessageBox.Show(sTextoMensaje, "Error de Carga", MessageBoxButtons.OK);
            // si después del mensaje quieres dejar la celda en su estado original realizas la siguiente asignación
            e.Cancel = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label26.Visible = false;
            timer1.Stop();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            var result = ItemsBL.GetItemsTipo("P")
            .Select(c =>
            {
                c.TipoItem = c.TipoPieza == "K" ? c.TipoItem : c.TipoItem + c.TipoPieza ?? "";
                return c;
            }).ToList();

            if (result != null)
                dgvListaItems.DataSource = result;
        }

        private void txtBuscarItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pictureBox8_Click(pictureBox8, null);
        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = ItemsBL.GetItemsDependencias(ItemEntidad.Id);
            FrmPrincipalPanel frmParentForm = (FrmPrincipalPanel)Application.OpenForms["FrmPrincipalPanel"];

            if (dt.Rows.Count == 0)
            {
                if (MetroFramework.MetroMessageBox.Show(frmParentForm, "Confirmar la Eliminación de la Parte '" + ItemEntidad.Codigo + "', Esta Acción es Irreversible.",
                                           "Eliminacion de Registro",
                                           MessageBoxButtons.OKCancel,
                                           MessageBoxIcon.Question,
                                           370) == DialogResult.OK)
                {
                    ItemsBL.DeleteItem(ItemEntidad);
                    CargarGridListadoItem();
                    materialFlatButton2.PerformClick();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(frmParentForm, "Esta Parte esta Relacionada con un Kit / Producto, No se Puede Eliminar.",
                                           "Eliminacion de Registro",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation,
                                           370);
            }
        }

        private void verDependientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = ItemsBL.GetItemsDependencias(ItemEntidad.Id);
            FrmPrincipalPanel frmParentForm = (FrmPrincipalPanel)Application.OpenForms["FrmPrincipalPanel"];

            if (dt.Rows.Count > 0)
            {
                FrmDetalleKit FrmDetalle = new FrmDetalleKit();
                FrmDetalle.Origen = "Dependencia";
                FrmDetalle.itemIdDet = Convert.ToInt32(ItemEntidad.Id);
                FrmDetalle.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(frmParentForm, "La Parte '" + ItemEntidad.Codigo + "' , No Está Relacionada a Ningun Registro",
                                           "Relación de Dependencia",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning,
                                           370);
            }
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (metroTabControl1.SelectedIndex)
                {
                    case 3:
                        if (ItemEntidadInicial.Codigo.Trim().Length > 0)
                        {
                            CargarEntidadItem();
                            ItemEntidadInicial.CostoCM = ItemEntidad.CostoCM;
                            ItemEntidadInicial.FechaModificacion = ItemEntidad.FechaModificacion;
                            if (!Functions.Compare<Item>(ItemEntidad, ItemEntidadInicial))
                            {
                                FrmPrincipalPanel frmParentForm = (FrmPrincipalPanel)Application.OpenForms["FrmPrincipalPanel"];

                                if (MetroFramework.MetroMessageBox.Show(frmParentForm, "La Parte '" + ItemEntidad.Codigo + "', Presenta Modificaciones.¿Desea Registrar los Cambios?",
                                           "Modificacion de Registro",
                                           MessageBoxButtons.OKCancel,
                                           MessageBoxIcon.Question,
                                           370) == DialogResult.OK)
                                {
                                    materialFlatButton1.PerformClick();
                                    ItemEntidadInicial = Functions.DeepCopy<Item>(ItemEntidad);
                                }
                            }
                        }
                        break;
                }
            }
            catch (Exception) { }
        }
    }

}