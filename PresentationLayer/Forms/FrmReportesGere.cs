using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLayer;
using System.IO;
using System.Data.Sql;
using PresentationLayer.Forms;
using DataAccessLayer;
using System.Drawing.Imaging;


namespace PresentationLayer.Forms
{
    public partial class FrmReportesGere : Form
    {
        public string TipoAcceso { get; set; }
        private const int cGrip = 16;
        private const int cCaption = 32;
        private DataTable DTListado;
        private int currentMouseOverCol;
        private int currentMouseOverRow;

        DataGridViewCheckBoxColumn chk1 = new DataGridViewCheckBoxColumn();

        DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();

        public FrmReportesGere(FrmPrincipalPanel FormP = null)
        {
            InitializeComponent();
            SetearControles();
            panel2.Visible = false;
            label1.Visible = false;
            pictureBox1.Visible = false;
            btnAñadirCot.Enabled = false;
            this.InitializeClickHandlers();
        }


        public FrmReportesGere()
        {
            InitializeComponent();
        }

        private void FrmReportesGere_Load(object sender, EventArgs e)
        {
            if (TipoAcceso != "ADMIN")
            {

                metroComboBox2.Visible = true;
                label2.Visible = true;
                txtBuscarItem.Visible = true;
                label4.Visible = true;

                CargaComboReportes(TipoAcceso);


            }
            else
            {
                metroComboBox1.Visible = true;
                label42.Visible = true;
                metroComboBox2.Visible = true;
                label2.Visible = true;
                txtBuscarItem.Visible = true;
                label4.Visible = true;

                CargaComboReportes(TipoAcceso);


            }
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
            //btnAgregar.Parent = panel2;
            //btnNuevo.Parent = panel3;
            //btnCerrar.Parent = panel4;
            //labelNoMouse1.Parent = btnAgregar;
            //labelNoMouse2.Parent = btnNuevo;
            //labelNoMouse3.Parent = btnCerrar;
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



        #endregion

        private void CargarCombos()// COMBOS FAMILIAS
        {
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
            metroComboBox2.SelectedIndex = 0;

        }

        private void CargaComboReportes(string TipoAcceso)
        {
            metroComboBox1.DisplayMember = "Text";
            metroComboBox1.ValueMember = "Value";

            switch (TipoAcceso)
            {
                case "ADMIN":
                    var items = new[] {
                                //new { Text = "Costos, Dimensiones y estado de ITEMS (Partes,Kits,Productos)", Value = "0" },
                                //new { Text = "ITEMS con Costos de étapas/Procesos (Resumido)", Value = "1" },
                                //new { Text = "ITEMS con Todos los Costos Involucrados (Detallado)", Value = "2" },
                                //new { Text = "Productos Terminados con Costo Directo + Factor", Value = "3" },
                                //new { Text = "Productos Terminados Autorizados", Value = "4" },
                                new { Text = "Listado de Repuestos", Value = "5" },
                                new { Text = "Listado de Productos Terminados", Value = "6" }
                                       };
                    metroComboBox1.DataSource = items;

                    break;
                default:
                    var items2 = new[] {
                           
                                new { Text = "Productos Terminados Autorizados", Value = "4" },
                                new { Text = "Listado de Repuestos", Value = "5" },
                                new { Text = "Estado de autorización de Productos Terminados", Value = "6" }
                             
                                       };
                    metroComboBox1.DataSource = items2;


                    break;
            }
        

        }
        private void CargarGridGistado()
        {

            DataTable dt = new DataTable();
            List<int> NumericColumns = new List<int> { };

            dgvListado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            // dgvListado.AllowUserToResizeRows = false;

            //LIMPIEZA DE GRILLA POR CADA CASE QUE SE EJECUTE
            dt = null;
            dgvListado.DataSource = null;
            dgvListado.Rows.Clear();
            dgvListado.Columns.Clear();
            dgvListado.Refresh();

            dgvListado.ReadOnly = false;

            chk1.Width = 43;


            //dgvListado.Columns.Add(CheckboxColumn);

            switch (metroComboBox1.SelectedValue)
            {
                case "0":
                    dt = ItemsBL.ListadoItemsResumen();
                    for (int i = 6; i <= dt.Columns.Count; i++)
                    {
                        NumericColumns.Add(i);
                    }
                    break;
                case "1":
                    dt = ItemsBL.ListadoItemsCostoResumen();
                    for (int i = 6; i <= dt.Columns.Count - 2; i++)
                    {
                        NumericColumns.Add(i);
                    }
                    break;
                case "2":
                    dt = ItemsBL.ListadoItemsCostoDetallado();
                    for (int i = 6; i <= dt.Columns.Count - 2; i++)
                    {
                        NumericColumns.Add(i);
                    }
                    break;
                case "3":
                    dt = ItemsBL.ListadoItemsTipoCostoFactorRES("T");

                    //NumericColumns.Add(3);
                    NumericColumns.Add(4);
                    NumericColumns.Add(5);
                    NumericColumns.Add(6);
                    break;
                case "4":
                    dt = ItemsBL.ListadoItemsTipoCostoFactor("T");
                    NumericColumns.Add(5);
                    NumericColumns.Add(6);
                    dt.Columns["Precio"].ReadOnly = true;
                    //CheckboxColumn.Width = 20;

                    //dgvListado.Columns.Add(CheckboxColumn);


                    //chk1.ReadOnly = false;
                    //dgvListado.Columns.Add(chk1);
                    //chk1.HeaderText = "Cotizar";
                    break;
                case "5":
                    dt = ItemsBL.GetItemsProductosParteGerencia("P");
                    for (int i = 5; i <= dt.Columns.Count; i++)
                    {
                        NumericColumns.Add(i);
                    }
                    //NumericColumns.Add(6);
                    //NumericColumns.Add(9);
                    //NumericColumns.Add(10);
                    
                    //chk1.Name = "Cotizar";

                    //dgvListado.Columns.Add(chk1);
                    dt.Columns["Precio Fac.Ind"].ReadOnly = true;
                   

                    //CheckboxColumn.Width = 20;

                    //dgvListado.Columns.Add(CheckboxColumn);
                    break;
                case "6":
                    dt = ItemsBL.EstadoProductosTerminadosGerencia("T");
                    for (int i = 6; i <= dt.Columns.Count; i++)
                    {
                        NumericColumns.Add(i);
                    }
                    //NumericColumns.Add(4);
                    //NumericColumns.Add(5);
                    //chk1.Name = "Cotizar";
                    //dgvListado.Columns.Add(chk1);
                    dt.Columns["Precio Fac.Ind"].ReadOnly = true;


                    break;
            }
            //if (dgvListado.ReadOnly == true)
            //{
            //   // chk1.ReadOnly = false;
            //   // chk2.ReadOnly = false;
            //    chk3.ReadOnly = false;
            //}
            dgvListado.DataSource = dt;
            DTListado = dt.Copy();
            ((DataGridViewImageColumn)dgvListado.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Zoom;


            //if (metroComboBox1.SelectedIndex == 6) dgvListado.Columns[5].Visible = false;
            try
            {
                if (metroComboBox1.SelectedIndex == 2) dgvListado.Columns[5].Visible = false;
            }
            catch { }

            foreach (DataGridViewColumn col in dgvListado.Columns)
            {
                if (NumericColumns.Contains(col.Index))
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    col.DefaultCellStyle.Format = "N2";
                }
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label1.Visible = true;
            CargarGridGistado();
            panel2.Visible = false;
            label1.Visible = false;
        }

        private void btnExportarExcelPermiso_Click(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count > 0)
                dgvListado.ExportToExcel();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = null;
            
                if (metroComboBox2.SelectedIndex  > -1 && dgvListado.DataSource != null)
                {                        
                                    
                var rows = DTListado.AsEnumerable()
                           .Where(r => r.Field<string>("Familia").ToUpper().Contains(metroComboBox2.Text.Trim().ToUpper()));
                //.CopyToDataTable();

                if (rows.Any())
                {
                    dt = rows.CopyToDataTable();
                    dgvListado.DataSource = dt;

                }
                else
                    ((DataTable)dgvListado.DataSource).Clear();
            }
            
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewImageCell Ima = dgvListado.CurrentRow.Cells["Imagen"] as DataGridViewImageCell;

            pictureBox1.Visible = true;
            //FrmViewPicture form = new FrmViewPicture();
            //form.Imagen = e;
            //OpenImegeForm(pictureBox1.BackgroundImage);
            if (Ima == null)
            {
                return;
            }

            Byte[] ImaByt = (Byte[])Ima.Value;
            MemoryStream Mry = new MemoryStream(ImaByt);
            pictureBox1.Width = 500;
            pictureBox1.Height = 500;

            pictureBox1.Image = Image.FromStream(Mry);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox1);
            pictureBox1.BringToFront();
            pictureBox1.Location = new Point(1180, 200);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void FrmReportesGere_Shown(object sender, EventArgs e)
        {
            
                this.Activate();
                this.BringToFront();
                CargarCombos();
                DTListado = new DataTable();
            
           
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            BuscarItemPorCodigoDescripcion();
        }

        private void BuscarItemPorCodigoDescripcion()
        {
            if (txtBuscarItem.Text.Trim().Length > 0)
            {
                DataTable dt = null;

                var rows = ((DataTable)dgvListado.DataSource).AsEnumerable()
                      .Where(r => r.Field<string>("Codigo").ToUpper().Contains(txtBuscarItem.Text.Trim().ToUpper())
                               || r.Field<string>("Descripcion").ToUpper().Contains(txtBuscarItem.Text.Trim().ToUpper()));


                if (rows.Any())
                {
                    dt = rows.CopyToDataTable();
                    dgvListado.DataSource = dt;
                }

                //.CopyToDataTable();


            }
            else
            {
                //dgvListado.DataSource = DTListado;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            CargarGridGistado();
        }

        private void txtBuscarItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                BuscarItemPorCodigoDescripcion();
            }
        }

        private void dgvListado_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    currentMouseOverRow = e.RowIndex;
                    currentMouseOverCol = e.ColumnIndex;
                    if (currentMouseOverCol > -1)
                        try
                        {
                            dgvListado.CurrentCell = dgvListado[currentMouseOverCol, currentMouseOverRow < 0 ? 0 : currentMouseOverRow];
                            dgvListado.Rows[(currentMouseOverRow)].Selected = true;
                        }
                        catch { }
                }
            }
            catch { }
        }
    }
}
