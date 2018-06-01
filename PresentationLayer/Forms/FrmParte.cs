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
    public partial class FrmParte : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        private string ModoPantalla = "";
        Item ItemEntidad = new Item();
        ItemCosto Entidad = new ItemCosto();
        double ValorCostoEditado = 0;
        bool bControlActive = false;
        string pathImagen = "";


        public FrmParte()
        {
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();
            CargarCombos();
            CargarGrids();
            FormatearGrids();
            EnlazarCampos();

            metroComboBox3.SelectedIndex = 0;

            ModoPantalla = "Crear";
            panel3.Visible = false;

            metroTabControl1.SelectedIndex = 0;
        }

        private void FrmItemSimple_Load(object sender, EventArgs e)
        {
            txtCodigo.Select();
            metroTabPage1.Select();
        }

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

        private void CargarGrids()
        {
            DataTable dtItemCostos = ItemCostoBL.GetItemCostosId(Convert.ToInt32(Entidad.IdItem));
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
            //Listado de Items

            dgvListaItems.DataSource = ItemsBL.GetItemsTipo("P");
            //dgvListaItems.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvListaItems.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void FormatearGrids()
        {
            MetroFramework.Controls.MetroGrid[] ArrDgv = { dgvCostoRRHH, dgvCostoProc, dgvCostoAcero };

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

            dgvListaItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List<int> visibleColumns = new List<int> { 1, 2, 3 ,4 ,6 ,7, 8 ,9};
            foreach (DataGridViewColumn col in dgvListaItems.Columns)
            {
                if (!visibleColumns.Contains(col.Index))
                    col.Visible = false;
            }
        }

        private void dgvCostoValidar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MetroFramework.Controls.MetroGrid dgvActual = (MetroFramework.Controls.MetroGrid)sender;
            if (e.RowIndex == -1)
                return;
            else if(dgvActual.SelectedRows.Count == 1)
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
            else if (dgvActual.CurrentCell.ColumnIndex == 7 )
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

            if (dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[7].Value.ToString().Length == 0 )
                dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[7].Value = "0,00";
            else if (ValorCostoEditado != Convert.ToDouble(dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[7].Value))
            {
                dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[8].Value = Convert.ToDecimal(dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[6].Value) *
                                                                                Convert.ToDecimal(dgvActual.Rows[dgvActual.CurrentCell.RowIndex].Cells[7].Value)  ;
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

        private double SumaColumnaDoubleDT(DataTable dt, string sCol1, string sCol2)
        {
            var Total = dt.AsEnumerable()
                        .Sum(r => (r.Field<decimal>(sCol1) * r.Field<decimal>(sCol2)));
            return Convert.ToDouble(Total);
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
            txtTotalCostos.Text = (Convert.ToDouble(txtTotCosCom.Text) + Convert.ToDouble(txtCostoAcero.Text) +
                                   Convert.ToDouble(txtCostoProc.Text) + Convert.ToDouble(txtCostoRRHH.Text)).ToString(); ;
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

        private void dgvListaItems_DoubleClick(object sender, EventArgs e)
        {
            int ItemId = Convert.ToInt32(dgvListaItems.Rows[dgvListaItems.CurrentCell.RowIndex].Cells[0].Value);
            CargarCampos(ItemId);
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            int ItemId = Convert.ToInt32(dgvListaItems.Rows[dgvListaItems.CurrentCell.RowIndex].Cells[0].Value);
            CargarCampos(ItemId);
        }

        private void CargarCampos(int itemId)
        {

            ItemEntidad = ItemsBL.GetItemId(itemId).FirstOrDefault();
            EnlazarCampos();
            metroTabControl1.SelectedIndex = 0;
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

        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtDescrpcion.Text = "";
            txtNombre.Text = "";
            txtEspesor.Text = "";
            txtAncho.Text = "";
            txtLargo.Text = "";
            txtDiametro.Text = "";
            txtVolumen.Text = "";
            txtPeso.Text = "";
        }

        private void txtValidar_TextChanged(object sender, EventArgs e)
        {
            TextBox TxtActual = (TextBox)sender;
            if(!TxtActual.Focused)
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
            ModoPantalla = "Crear";
            panel3.Visible = false;
            labelNoMouse1.Text = "Agregar";
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
                if(oFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pathImagen = oFD.FileName;
                    pictureBox1.BackgroundImage = new Bitmap(@pathImagen);

                    byte[] byteimg =  ImageExtensions.imageToByteArray(pictureBox1.BackgroundImage);
                    ItemEntidad.Imagen = byteimg;
                    //pictureBox1.BackgroundImage.Dispose();
                    //pictureBox1.BackgroundImage = null;

                    //MessageBox.Show("Conversion");

                    //Image nImg =  ImageExtensions.byteArrayToImage(byteimg);

                    //pictureBox1.BackgroundImage = nImg;
                }
            }
            catch {}
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}