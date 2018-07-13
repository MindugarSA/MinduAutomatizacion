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
    public partial class FrmProducto : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        Item ItemEntidad = new Item();
        ItemCosto CostoEntidad = new ItemCosto();
        List<ItemCosto> ListCostoEntidad = new List<ItemCosto>();
        ItemDetalle ItemDetalleEntidad = new ItemDetalle();
        List<ItemDetalle> ListItemDetalleEntidad = new List<ItemDetalle>();
        List<ItemDetalle> ListItemDetalleDelete = new List<ItemDetalle>();
        DataTable dtItemDetalle = new DataTable();
        private string CodigoInicial;
        double ValorCostoEditado = 0;
        double ValorDetalleEditado = 0;
        bool bControlActive = false;
        bool bAgregandoRow = false;
        private FrmPrincipalPanel formPrincipal;


        public FrmProducto(FrmPrincipalPanel FormP = null)
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
            LimpiarCamposItem();

            panel3.Visible = false;
            label3.Visible = false;
            label20.Visible = false;
            txtTotCosPro.Visible = false;
            txtCostoProc.Visible = false;
            dgvCostoProc.Visible = false;

            metroTab1.SelectedIndex = 0;
            materialCheckBox1.Checked = true;
            this.InitializeClickHandlers();
            formPrincipal = FormP;
        }

        /// <summary>
        /// EVENTOS    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void FrmItemSimple_Load(object sender, EventArgs e)
        {
            txtCodigo.Select();
            metroTabPage1.Select();
            formPrincipal.VisualizarLabel(false);
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

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvDetalleItemAmp_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            MetroFramework.Controls.MetroGrid dgvActual = (MetroFramework.Controls.MetroGrid)sender;
            ValorDetalleEditado = Convert.ToDouble(dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[9].Value);
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
                txtTotalCostos.Text = (Convert.ToDouble(txtTotCosPiezas.Text) +
                                       Convert.ToDouble(txtCostoProc.Text) + Convert.ToDouble(txtCostoRRHH.Text)).ToString();

            }
        }

        private void dgvDetalleItemAmp_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MetroFramework.Controls.MetroGrid dgvActual = (MetroFramework.Controls.MetroGrid)sender;

            if (dgvActual.CurrentRow.Index == -1 || bAgregandoRow)
                return;

            if (dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[9].Value.ToString().Length == 0)
                dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[9].Value = "0,00";
            else if (ValorDetalleEditado != Convert.ToDouble(dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[9].Value))
            {
                dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[11].Value = Convert.ToDecimal(dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[9].Value) *
                                                                                Convert.ToDecimal(dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[10].Value);

                txtTotCosPiezas.Text = SumaColumnaDoubleDT((DataTable)dgvActual.DataSource, "Cantidad", "CostoUnitario").ToString();
                txtCostPiezasD.Text = txtTotCosPiezas.Text;
                textBox1.Text = txtTotCosPiezas.Text;
                txtTotalCostos.Text = (Convert.ToDouble(txtTotCosPiezas.Text) +
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
            TextBox TxtActual = (TextBox)sender;
            txtTotalCostos.Text = (Convert.ToDouble(txtTotCosPiezas.Text) +
                                   Convert.ToDouble(txtCostoProc.Text) + Convert.ToDouble(txtCostoRRHH.Text)).ToString();

            try
            {
                if ((txtEspesor.Text.ToDecimal() ?? 0) > 0 && (txtAncho.Text.ToDecimal() ?? 0) > 0 && (txtLargo.Text.ToDecimal() ?? 0) > 0)
                {
                    string CalcPeso = Math.Round(((Convert.ToDouble(txtEspesor.Text) * Convert.ToDouble(txtAncho.Text) * Convert.ToDouble(txtLargo.Text)) * 0.000008), 2).ToString();
                    if (Convert.ToDouble(txtPeso.Text) == 0)
                        txtPeso.Text = CalcPeso;
                }
            }
            catch { }
        }

        private void dgvListaItems_DoubleClick(object sender, EventArgs e)
        {
            int ItemId = Convert.ToInt32(dgvListaItems.Rows[dgvListaItems.CurrentCell.RowIndex].Cells[0].Value);
            CargarDatosItem(ItemId);
            CargarCamposItemDetalle(ItemsBL.GetItemId(Convert.ToInt32(dgvDetalleItemAmp.Rows[0].Cells[4].Value)).FirstOrDefault());
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            int ItemId = Convert.ToInt32(dgvListaItems.Rows[dgvListaItems.CurrentCell.RowIndex].Cells[0].Value);
            CargarDatosItem(ItemId);
            CargarCamposItemDetalle(ItemsBL.GetItemId(Convert.ToInt32(dgvDetalleItemAmp.Rows[0].Cells[4].Value)).FirstOrDefault());
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
            panel3.Visible = false;
            labelNoMouse1.Text = "Agregar";
            CargarGridsCostos();
            FormatearGridsCostos();
            CargarGridsDetalleItem(0);
            metroTab1.SelectedIndex = 0;
            LimpiarCamposItemDetalle();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            metroTab1.SelectedIndex = 3;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtEncabezado.Text = (txtCodigo.Text + " : " + txtDescrpcion.Text).Trim();
            txtEncabezado2.Text = txtEncabezado.Text;
            if (txtCodigo.Text.Trim().Length > 0 && errorCodigo.HasErrors())
                errorCodigo.SetErrorWithCount(txtCodigo, "");
        }

        private void txtDescrpcion_TextChanged(object sender, EventArgs e)
        {
            txtEncabezado.Text = (txtCodigo.Text + " : " + txtDescrpcion.Text).Trim();
            txtEncabezado2.Text = txtEncabezado.Text;
            if (txtDescrpcion.Text.Trim().Length > 0 && errorDescr.HasErrors())
                errorDescr.SetErrorWithCount(txtDescrpcion, "");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            metroTab1.SelectedIndex = 1;
        }

        private void dgvDetalleItemAmp_SelectionChanged(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroGrid dgvActual = (MetroFramework.Controls.MetroGrid)sender;

            try
            {
                if (!bAgregandoRow)
                {
                    int ItemId = Convert.ToInt32(dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[4].Value);
                    Item ItemConsulta = ItemsBL.GetItemId(ItemId).FirstOrDefault();

                    if (dgvActual.Name == "dgvDetalleItemAmp") CargarCamposItemDetalle(ItemConsulta);

                    try
                    {
                        dgvActual.CurrentCell = dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[9];
                        //dgvDetalleItemAmp[9, dgvDetalleItemAmp.CurrentRow.Index].Selected = true;
                        dgvActual.BeginEdit(true);
                    }
                    catch (Exception) { }
                }
            }
            catch { }

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (labelNoMouse1.Text.Trim() != "Actualizar" && CodigoInicial != txtCodigo.Text.Trim())
                VerificarCodigoItem();

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
                        panel3.Visible = true;
                        break;
                    case "Actualizar":
                        ItemsBL.UpdateItem(ItemEntidad);
                        CargarEntidadItemDetalle(ItemEntidad);
                        List<ItemDetalle> DetalleUpdate = ListItemDetalleEntidad.Where(r => r.Id != 0).ToList();
                        List<ItemDetalle> DetallesInsert = ListItemDetalleEntidad.Where(r => r.Id == 0).ToList();
                        ItemDetalleBL.InsertItemDetalle(DetallesInsert);
                        ItemDetalleBL.UpdateItemDetalle(DetalleUpdate);
                        ItemDetalleBL.DeleteItemDetalle(ListItemDetalleDelete);
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
                CargarGridListadoItem();
            }
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
            string TipoPieza = dgvDetalleItemAmp.Rows[dgvDetalleItemAmp.CurrentCell.RowIndex].Cells[8].Value.ToString();
            FrmPrincipalPanel frmParentForm = (FrmPrincipalPanel)Application.OpenForms["FrmPrincipalPanel"];

            if (IdDetalle > 0)
            {
                if (TipoPieza.Trim() == "K")
                {
                    FrmKit Frmkit = new FrmKit();
                    Frmkit.IdIetmSearch = IdDetalle;
                    frmParentForm.AbrirFormulario(Frmkit, 370, 230);

                }
                else
                {
                    FrmParte FrmParte = new FrmParte();
                    FrmParte.IdIetmSearch = IdDetalle;
                    frmParentForm.AbrirFormulario(FrmParte, 370, 230);
                }

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FrmBusquedaItem FrmBuscar = new FrmBusquedaItem();
            FrmBuscar.MdiParent = this.MdiParent;
            FrmBuscar.EnviarEvento += new FrmBusquedaItem.EnvEvent(AgregarDetalleItem);
            FrmBuscar.ShowDialog();
        }

        private void dgvListaItems_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int ItemId = Convert.ToInt32(dgvListaItems.Rows[dgvListaItems.CurrentCell.RowIndex].Cells[0].Value);
                Item ItemConsulta = ItemsBL.GetItemId(ItemId).FirstOrDefault();

                CargarCamposListaKit(ItemConsulta);
            }
            catch { }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (dgvDetalleItemAmp.SelectedRows.Count > 0)
            {
                bAgregandoRow = true;
                DataGridViewRow dRow = dgvDetalleItemAmp.Rows[dgvDetalleItemAmp.CurrentCell.RowIndex];
                CargarItemDetalleDelete(dRow);
                dgvDetalleItemAmp.Rows.RemoveAt(dgvDetalleItemAmp.CurrentCell.RowIndex);
                if (dgvDetalleItemAmp.Rows.Count > 0)
                    foreach (DataGridViewRow row in dgvDetalleItemAmp.Rows)
                    {
                        row.Cells["Linea"].Value = row.Index + 1;
                    }
                txtTotCosPiezas.Text = SumaColumnaDoubleDT((DataTable)dgvDetalleItemAmp.DataSource, "Cantidad", "CostoUnitario").ToString();
                txtCostPiezasD.Text = txtTotCosPiezas.Text;
                textBox1.Text = txtTotCosPiezas.Text;
                txtTotalCostos.Text = (Convert.ToDouble(txtTotCosPiezas.Text) +
                                       Convert.ToDouble(txtCostoProc.Text) + Convert.ToDouble(txtCostoRRHH.Text)).ToString();
                bAgregandoRow = false;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (dgvDetalleItemAmp.CurrentCell.RowIndex > 0)
            {
                bAgregandoRow = true;
                int RowAct = dgvDetalleItemAmp.CurrentCell.RowIndex;
                ((DataTable)dgvDetalleItemAmp.DataSource).SwapRows(RowAct, RowAct - 1);
                dgvDetalleItemAmp.CurrentCell = dgvDetalleItemAmp.Rows[RowAct - 1].Cells[9];
                dgvDetalleItemAmp[9, RowAct - 1].Selected = true;
                dgvDetalleItemAmp.BeginEdit(true);
                bAgregandoRow = false;

            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (dgvDetalleItemAmp.CurrentCell.RowIndex < (dgvDetalleItemAmp.RowCount - 1))
            {
                bAgregandoRow = true;
                int RowAct = dgvDetalleItemAmp.CurrentCell.RowIndex;
                ((DataTable)dgvDetalleItemAmp.DataSource).SwapRows(RowAct, RowAct + 1);
                dgvDetalleItemAmp.CurrentCell = dgvDetalleItemAmp.Rows[RowAct + 1].Cells[9];
                dgvDetalleItemAmp[9, RowAct + 1].Selected = true;
                dgvDetalleItemAmp.BeginEdit(true);
                bAgregandoRow = false;
            }
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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (txtBuscarItem.Text.Trim().Length > 0)
            {
                var result = ItemsBL.GetItems()
                             .Where(s => (!String.IsNullOrEmpty(s.Codigo)
                                             && s.Codigo.ToUpper().Contains(txtBuscarItem.Text.Trim().ToUpper()))
                                             || (!String.IsNullOrEmpty(s.Descripcion)
                                                 && s.Descripcion.ToUpper().Contains(txtBuscarItem.Text.Trim().ToUpper())))
                             .FirstOrDefault();
                if (result != null)
                    AgregarDetalleItem(result.Id);
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
            dgvListaItems.DataSource = ItemsBL.GetItemsTipo("T").Select(c =>
                                                                {
                                                                    c.TipoItem = c.TipoPieza == "K" ? c.TipoItem : c.TipoItem + c.TipoPieza ?? "";
                                                                    return c;
                                                                }).ToList();
            //dgvListaItems.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvListaItems.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListaItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List<int> visibleColumns = new List<int> { 1, 2, 3, 5, 6, 7, 8, 9 };
            foreach (DataGridViewColumn col in dgvListaItems.Columns)
            {
                if (!visibleColumns.Contains(col.Index))
                    col.Visible = false;
            }
            ((DataGridViewImageColumn)dgvListaItems.Columns[18]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgvListaItems.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListaItems.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListaItems.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListaItems.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvListaItems.Columns[6].DefaultCellStyle.Format = "#,0.00###";
            dgvListaItems.Columns[7].DefaultCellStyle.Format = "#,0.00###";
            dgvListaItems.Columns[8].DefaultCellStyle.Format = "#,0.00###";
            dgvListaItems.Columns[9].DefaultCellStyle.Format = "#,0.00###";

        }

        private void CargarGridsDetalleItem(int itemId)
        {
            dtItemDetalle = ItemDetalleBL.GetItemDetalleId(itemId);
            bAgregandoRow = true;
            if (dtItemDetalle.Rows.Count >= 0)
            {
                dgvDetalleItemAmp.DataSource = dtItemDetalle;
                dgvDetalleItem.DataSource = dtItemDetalle;

                MetroFramework.Controls.MetroGrid[] ArrDgv = { dgvDetalleItem, dgvDetalleItemAmp };

                foreach (MetroFramework.Controls.MetroGrid dgvActual in ArrDgv)
                {
                    List<int> visibleColumns = new List<int> { 5, 6, 8, 9, 10, 11 };
                    foreach (DataGridViewColumn col in dgvActual.Columns)
                    {
                        if (!visibleColumns.Contains(col.Index))
                            col.Visible = false;
                        col.ReadOnly = true;
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

                    if (dgvDetalleItemAmp.Rows.Count > 0) dgvDetalleItemAmp.CurrentCell = dgvDetalleItemAmp.Rows[0].Cells[9];
                }
            }
            bAgregandoRow = false;

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
            CodigoInicial = ItemEntidad.Codigo;
            EnlazarCampos();
            metroTab1.SelectedIndex = 0;
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
            txtTotCosPiezas.Text = "0,00";
            txtTotCosPro.Text = "0,00";
            txtTotCosRRHH.Text = "0,00";
            txtTotalCostos.Text = "0,00";
            txtCostoProc.Text = "0,00";
            txtCostoRRHH.Text = "0,00";
            txtDirectFact.Text = "0,00";
            pictureBox1.BackgroundImage = Properties.Resources.ImagenBlank;
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

        private void CargarEntidadItem()
        {
            ItemEntidad.Codigo = txtCodigo.Text.Trim();
            ItemEntidad.Descripcion = txtDescrpcion.Text;
            ItemEntidad.Nombre = txtNombre.Text;
            ItemEntidad.TipoPieza = "";
            ItemEntidad.Familia = metroComboBox2.SelectedItem == null ? 0 : Convert.ToInt32(((DataRowView)metroComboBox2.SelectedItem)[0].ToString());
            ItemEntidad.TipoItem = "T";
            ItemEntidad.Espesor = Convert.ToDecimal(txtEspesor.Text);
            ItemEntidad.Ancho = Convert.ToDecimal(txtAncho.Text);
            ItemEntidad.Largo = Convert.ToDecimal(txtLargo.Text);
            ItemEntidad.Diametro = Convert.ToDecimal(txtDiametro.Text);
            ItemEntidad.Volumen = Convert.ToDecimal(txtVolumen.Text);
            ItemEntidad.Peso = Convert.ToDecimal(txtPeso.Text);
            ItemEntidad.CostoCM = Convert.ToDecimal(txtTotCosPiezas.Text);
            ItemEntidad.CostoPR = Convert.ToDecimal(txtTotCosPro.Text);
            ItemEntidad.CostoRH = Convert.ToDecimal(txtTotCosRRHH.Text);
            ItemEntidad.CostoTotal = Convert.ToDecimal(txtTotalCostos.Text);
            ItemEntidad.CostoAC = 0;
            if (pictureBox1.BackgroundImage != null) ItemEntidad.Imagen = ImageExtensions.imageToByteArray(pictureBox1.BackgroundImage);
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
                ItemDetalleEntidad.Id = Convert.ToInt32(row["Id"] is DBNull ? 0 : row["Id"]);
                ListItemDetalleEntidad.Add(ItemDetalleEntidad);
                Linea += 1;
            }

        }

        private void CargarItemDetalleDelete(DataGridViewRow Row)
        {
            if (Convert.ToInt32(Row.Cells["Id"].Value is DBNull ? 0 : Row.Cells["Id"].Value) > 0)
            {
                ItemDetalleEntidad = new ItemDetalle();
                ItemDetalleEntidad.IdItem = Convert.ToInt32(Row.Cells["IdC"].Value);
                ItemDetalleEntidad.IdDetalle = Convert.ToInt32(Row.Cells["IdDetalle"].Value);
                ItemDetalleEntidad.Linea = Convert.ToInt32(Row.Cells["Linea"].Value);
                ItemDetalleEntidad.Cantidad = Convert.ToDecimal(Row.Cells["Cantidad"].Value);
                ItemDetalleEntidad.CostoUnitario = Convert.ToDecimal(Row.Cells["CostoUnitario"].Value);
                ItemDetalleEntidad.Total = Convert.ToDecimal(Row.Cells["Total"].Value);
                ItemDetalleEntidad.Id = Convert.ToInt32(Row.Cells["Id"].Value);
                ListItemDetalleDelete.Add(ItemDetalleEntidad);
            }
        }

        private bool ValidarCampos()
        {
            bool Valido = true;

            if (errorCodigo.HasErrors() || errorDescr.HasErrors() || errorDetalle.HasErrors())
                Valido = false;
            else if (txtCodigo.Text == string.Empty)
            {
                metroTab1.SelectedIndex = 0;
                errorCodigo.SetErrorWithCount(txtCodigo, "Ingrese un Codigo");
                Valido = false;
            }
            else if (txtDescrpcion.Text == string.Empty)
            {
                metroTab1.SelectedIndex = 0;
                errorDescr.SetErrorWithCount(txtDescrpcion, "Ingrese una Descripción");
                Valido = false;
            }
            else if (dgvDetalleItemAmp.RowCount == 0)
            {
                metroTab1.SelectedIndex = 1;
                errorDetalle.SetErrorWithCount(dgvDetalleItemAmp, "Ingrese un Detalle");
                Valido = false;
            }

            return Valido;
        }

        private void CargarDatosItem(int ItemId)
        {
            LimpiarCamposItem();
            CargarCampos(ItemId);
            LimpiarCamposItemDetalle();
            CargarGridsDetalleItem(ItemId);
            //if(ItemId == 0) LimpiarCamposItemDetalle();
            CargarGridsCostos();
            FormatearGridsCostos();
            ListItemDetalleDelete.Clear();

            txtCostoRRHH.Text = SumaColumnaDoubleDT((DataTable)dgvCostoRRHH.DataSource, "Cantidad", "Valor").ToString();
            txtTotCosRRHH.Text = txtCostoRRHH.Text;
            txtCostoProc.Text = SumaColumnaDoubleDT((DataTable)dgvCostoProc.DataSource, "Cantidad", "Valor").ToString();
            txtTotCosPro.Text = Convert.ToDouble(txtCostoProc.Text).ToString();
            txtTotCosPiezas.Text = SumaColumnaDoubleDT((DataTable)dgvDetalleItem.DataSource, "Cantidad", "CostoUnitario").ToString();
            txtCostPiezasD.Text = txtTotCosPiezas.Text;
            textBox1.Text = txtTotCosPiezas.Text;
            txtTotalCostos.Text = (Convert.ToDouble(txtTotCosPiezas.Text) +
                                   Convert.ToDouble(txtCostoProc.Text) + Convert.ToDouble(txtCostoRRHH.Text)).ToString();
            errorCodigo.SetErrorWithCount(txtCodigo, "");
        }

        private void AgregarDetalleItem(int IdDetalle = 0)
        {

            bAgregandoRow = true;
            Item ItemDet = ItemsBL.GetItemId(IdDetalle).FirstOrDefault();
            DataTable dt = (DataTable)dgvDetalleItemAmp.DataSource;
            DataRow row = dt.NewRow();
            row[4] = IdDetalle;
            row[5] = ItemDet.Codigo;
            row[6] = ItemDet.Descripcion;
            row[7] = dgvDetalleItemAmp.Rows.Count + 1;
            row[8] = ItemDet.TipoPieza == "K" ? ItemDet.TipoItem : ItemDet.TipoItem + ItemDet.TipoPieza;
            row[9] = 0;
            row[10] = ItemDet.CostoTotal ?? 0;
            row[11] = 0;
            dt.Rows.Add(row);
            errorDetalle.SetErrorWithCount(dgvDetalleItemAmp, "");
            CargarCamposItemDetalle(ItemDet);
            //dgvDetalleItemAmp.Rows[dgvDetalleItemAmp.Rows.Count - 1].Selected = true;
            dgvDetalleItemAmp.CurrentCell = dgvDetalleItemAmp.Rows[dgvDetalleItemAmp.Rows.Count - 1].Cells[9];
            dgvDetalleItemAmp[9, dgvDetalleItemAmp.Rows.Count - 1].Selected = true;
            dgvDetalleItemAmp.BeginEdit(true);
            bAgregandoRow = false;
        }

        private void CargarCamposItemDetalle(Item ItemConsulta)
        {
            txtCodigoC.Text = ItemConsulta.Codigo;
            txtDescripcionC.Text = ItemConsulta.Descripcion;
            txtNombreC.Text = ItemConsulta.Nombre;
            txtEspesorC.Text = ItemConsulta.Espesor.ToString();
            txtAnchoC.Text = ItemConsulta.Ancho.ToString();
            txtLargoC.Text = ItemConsulta.Largo.ToString();
            txtDiametroC.Text = ItemConsulta.Diametro.ToString();
            txtVolumenC.Text = ItemConsulta.Volumen.ToString();
            txtPesoC.Text = ItemConsulta.Peso.ToString();
            txtTotalCostoC.Text = ItemConsulta.CostoTotal.ToString();
            pictureBox10.BackgroundImage = null;
            if (ItemConsulta.Imagen != null)
                pictureBox10.BackgroundImage = ImageExtensions.byteArrayToImage(ItemConsulta.Imagen);
        }

        private void CargarCamposListaKit(Item ItemConsulta)
        {
            txtCodigoK.Text = ItemConsulta.Codigo;
            txtDescripcionK.Text = ItemConsulta.Descripcion;
            txtNombreK.Text = ItemConsulta.Nombre;
            txtEspesorK.Text = ItemConsulta.Espesor.ToString();
            txtAnchoK.Text = ItemConsulta.Ancho.ToString();
            txtLargoK.Text = ItemConsulta.Largo.ToString();
            txtDiametroK.Text = ItemConsulta.Diametro.ToString();
            txtVolumenK.Text = ItemConsulta.Volumen.ToString();
            txtPesoK.Text = ItemConsulta.Peso.ToString();
            txtCostoTotalK.Text = ItemConsulta.CostoTotal.ToString();
            pictureBox15.BackgroundImage = null;
            if (ItemConsulta.Imagen != null)
                pictureBox15.BackgroundImage = ImageExtensions.byteArrayToImage(ItemConsulta.Imagen);
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

        #region Aplicar Modificaciones Visuales a Form
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);

            Brush aGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(50, 0), Color.Gray, Color.White);
            Pen pencil = new Pen(Color.LightGray, 5);
            e.Graphics.DrawRectangle(pencil, rect);
        }

        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        private int currentMouseOverRow;
        private int currentMouseOverCol;

        protected override void WndProc(ref Message m)
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

        private void txtBuscarItem_Enter(object sender, EventArgs e)
        {
            txtBuscarItem.SelectAll();
            txtBuscarItem.Focus();
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
                contextMenuStrip1.Items[0].Enabled = false;
            else
                contextMenuStrip1.Items[0].Enabled = true;
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTotalCostos_TextChanged(object sender, EventArgs e)
        {
            if (!txtTotalCostos.Focused)
                try
                {
                    if (txtTotalCostos.Text == string.Empty) txtTotalCostos.Text = "0,00";
                    txtTotalCostos.Text = string.Format("{0:#,0.00###}", Convert.ToDecimal(txtTotalCostos.Text));
                    txtDirectFact.Text = (Math.Round((txtTotalCostos.Text.ToDouble() * 1.752 ?? 0),2)).ToString();
                }
                catch { }
        }

        private void OpenImegeForm(Image Img)
        {
            FrmPrincipalPanel frmParentForm = (FrmPrincipalPanel)Application.OpenForms["FrmPrincipalPanel"];
            FrmViewPicture form = new FrmViewPicture();//MetroFramework.Forms.MetroForm();
            form.Imagen = Img;
            form.AutoSize = true;
            frmParentForm.AbrirFormulario(form, 0, 0, true);
        }

        private void pictureBox15_DoubleClick(object sender, EventArgs e)
        {
            OpenImegeForm(pictureBox15.BackgroundImage);
        }

        private void pictureBox10_DoubleClick(object sender, EventArgs e)
        {
            OpenImegeForm(pictureBox10.BackgroundImage);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenImegeForm(pictureBox1.BackgroundImage);
        }

        private void copiarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvListaItems.CopyContentToClipboard();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dgvListaItems[currentMouseOverCol, currentMouseOverRow].Value.ToString());
        }

        private void dgvListaItems_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right )
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
                    pictureBox1.BackgroundImage = image;
                }

            }
            else if ((data.GetDataPresent(DataFormats.Bitmap) || data.GetDataPresent(DataFormats.Dib)))
            {
                Bitmap bmp = null;

                Image img = ((Image)data.GetData("Bitmap", false));
                bmp = new Bitmap(img);
                pictureBox1.BackgroundImage = bmp;

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox1.BackgroundImage);
        }

        private void MostrarDetalleKitProducto(object sender, DataGridViewCellMouseEventArgs e)
        {
            MetroFramework.Controls.MetroGrid dgvActual = (MetroFramework.Controls.MetroGrid)sender;

            FrmDetalleKit FrmDetalle = new FrmDetalleKit();
            var cellRectangle = dgvActual.GetCellDisplayRectangle(5, e.RowIndex, false);
            FrmDetalle.StartPosition = FormStartPosition.Manual;
            FrmDetalle.Location = dgvActual.PointToScreen(dgvActual.GetCellDisplayRectangle(6, e.RowIndex, false).Location);
            FrmDetalle.Location = new Point(FrmDetalle.Location.X, FrmDetalle.Location.Y + cellRectangle.Height);
            FrmDetalle.itemIdDet = Convert.ToInt32(dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[4].Value);
            FrmDetalle.Show();
        }

        private void dgvDetalleItemAmp_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MostrarDetalleKitProducto(sender, e);
        }

        private void dgvDetalleItem_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MostrarDetalleKitProducto(sender, e);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (txtBuscarItem.Text.Trim().Length > 0)
            {
                var result = ItemsBL.GetItemsTipo("T")
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
                var result = ItemsBL.GetItemsTipo("T")
                            .Select(c =>
                            {
                                c.TipoItem = c.TipoPieza == "K" ? c.TipoItem : c.TipoItem + c.TipoPieza ?? "";
                                return c;
                            }).ToList();

                if (result != null)
                    dgvListaItems.DataSource = result;
            }
        }
    }
}