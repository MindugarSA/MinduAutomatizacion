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

namespace PresentationLayer
{
    public partial class FrmReportesGrid : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;
        private DataTable DTListado;

        public string TipoAcceso { get; set; }
        //public PictureBox Pic = new PictureBox();
        private Rectangle sizeGripRectangle;
        private int currentMouseOverCol;
        private int currentMouseOverRow;

        public delegate void EnvEvent(String idDetalle);
        public event EnvEvent EnviarEvento;
        bool bAgregandoRow = false;

        //FrmCotizador FrmCot = new FrmCotizador();

        DataTable dtItems;
        DataGridViewCheckBoxColumn chk1 = new DataGridViewCheckBoxColumn();

        //fue comentado por no uso
        // DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();


        //CheckBox chk1 = new CheckBox();

        // DataGridViewCheckBoxCell CheckboxColumn =  new DataGridViewCheckBoxCell();

        //CheckBox chk1 = new CheckBox();

        private string message;
        private object errorDetalle;

        public FrmReportesGrid(FrmPrincipalPanel FormP = null)
        {
            InitializeComponent();
            SetearControles();
            panel2.Visible = false;
            label1.Visible = false;
            pictureBox1.Visible = false;

            this.InitializeClickHandlers();

        }


        private void FrmReportesGrid_Load(object sender, EventArgs e)
        {


            if (TipoAcceso != "ADMIN")
            {

                metroComboBox2.Visible = true;
                label2.Visible = true;
                txtBuscarItem.Visible = true;
                label4.Visible = true;

                CargaComboReportes(TipoAcceso);
                if (TipoAcceso == "LECTURA") //dejar invisible el cotizador para usuarios de lectura
                {
                    btnAñadirCot.Visible = false;
                }


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

        private void FrmReportesGrid_Shown(object sender, EventArgs e)
        {
            this.Activate();
            this.BringToFront();
            CargarCombos();
            DTListado = new DataTable();

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
            metroComboBox2.SelectedIndex = 0;

            //dgvListaItems.AllowUserToResizeColumns = true;
            //dgvListaItems.Columns[28].Width = dgvListaItems.Columns[17].Width;

            //dgvListaItems.ResumeLayout();

            //dgvListado.Columns["Imagen"].Visible = true; //ocultar celda imagen
            //Rectangle rec = dgvListado.GetCellDisplayRectangle(i, dgvListado.CurrentRow.Index, true);
            //try
            //{
            //    dgvListado.Columns[5].Visible = true;
            //    ((DataGridViewImageColumn)dgvListado.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            //}
            //catch
            //{

            //}
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

                                new { Text = "Productos Terminados Autorizados", Value = "4" },
                                new { Text = "Listado de Repuestos", Value = "5" },
                                new { Text = "Estado de autorización de Productos Terminados", Value = "6" }
                                       };
                    metroComboBox1.DataSource = items;

                    break;
                default:
                    var items2 = new[] {
                                //new { Text = "Listado de Productos con Costo Directo + Factor", Value = "3" },
                                new { Text = "Productos Terminados Autorizados", Value = "4" },
                                new { Text = "Listado de Repuestos", Value = "5" },
                                new { Text = "Estado de autorización de Productos Terminados", Value = "6" }
                              //  new { Text = "Listado de Productos Terminados", Value = "4" }
                                       };
                    metroComboBox1.DataSource = items2;


                    break;
            }
            //dgvListado.Columns["Imagen"].Visible = true;
            //((DataGridViewImageColumn)dgvListado.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            //foreach (DataGridViewRow row in dgvListado.Rows)
            //{
            //    row.Height = 22;
            //    dgvListado.Columns["Imagen"].Width = 50;
            //}

        }

        private void metroComboBox1_SelectedIndexChangedAsync(object sender, EventArgs e)
        {

            panel2.Visible = true;
            label1.Visible = true;
            CargarGridGistado();
            panel2.Visible = false;
            label1.Visible = false;

        }

        private void CargarGridGistado()
        {

            DataTable dt = new DataTable();
            List<int> NumericColumns = new List<int> { };

            // dgvListado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; //MODIFICAR ESTO
            // dgvListado.AllowUserToResizeRows = false;

            //LIMPIEZA DE GRILLA POR CADA CASE QUE SE EJECUTE
            dt = null;
            dgvListado.DataSource = null;
            dgvListado.Rows.Clear();
            dgvListado.Columns.Clear();
            dgvListado.Refresh();

            
            //True=no se puede modificar, false= si se puede
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
                    //Este mmodificar
                    chk1.Name = "Cotizar";
                    dgvListado.Columns.Add(chk1);
                    //////////////////
                    dt = ItemsBL.ListadoItemsTipoCostoFactor("T");
                    NumericColumns.Add(5);
                    NumericColumns.Add(6);
                    dt.Columns["Precio"].ReadOnly = true;                    
                    dt.Columns["Codigo"].ReadOnly = true;
                    dt.Columns["Nombre"].ReadOnly = true;
                    dt.Columns["Descripcion"].ReadOnly = true;                                       
                    dt.Columns["Familia"].ReadOnly = true;
                    //CheckboxColumn.Width = 20;
                   


                    //dgvListado.Columns.Add(CheckboxColumn);


                    //chk1.ReadOnly = false;
                    //dgvListado.Columns.Add(chk1);
                    //chk1.HeaderText = "Cotizar";
                    break;
                case "5":
                    dt = ItemsBL.GetItemsProductosParte("P");
                    NumericColumns.Add(6);
                    NumericColumns.Add(7);
                    chk1.Name = "Cotizar";
                    //dgvListado.Columns["Precio"].ReadOnly = true;
                    //dgvListado.Columns["StockBAP"].ReadOnly = true;
                    dgvListado.Columns.Add(chk1);
                    dt.Columns["Precio"].ReadOnly = true;
                    dt.Columns["NumFamilia"].ReadOnly = true;
                    dt.Columns["Codigo"].ReadOnly = true;
                    dt.Columns["Nombre"].ReadOnly = true;
                    dt.Columns["Descripcion"].ReadOnly = true;
                    dt.Columns["Stock BAP"].ReadOnly = true;
                    dt.Columns["Interno/Externo"].ReadOnly = true;
                    dt.Columns["Familia"].ReadOnly = true;

                    //chk1.ReadOnly = false;

                    //dgvListado.Columns.Add(chk1);
                    //chk1.HeaderText = "Cotizar";

                    //CheckboxColumn.Width = 20;

                    //dgvListado.Columns.Add(CheckboxColumn);
                    break;
                case "6":
                    dt = ItemsBL.EstadoProductosTerminados("T");
                    for (int i = 6; i <= dt.Columns.Count; i++)
                    {
                        NumericColumns.Add(i);
                    }
                    //NumericColumns.Add(4);
                    //NumericColumns.Add(5);
                    chk1.Name = "Cotizar";
                    dgvListado.Columns.Add(chk1);
                    dt.Columns["Precio"].ReadOnly = true;

                    dt.Columns["NumFamilia"].ReadOnly = true;
                    dt.Columns["Codigo"].ReadOnly = true;
                    dt.Columns["Descripcion"].ReadOnly = true;
                    dt.Columns["Familia"].ReadOnly = true;
                    dt.Columns["Estado"].ReadOnly = true;
                    if (dt.Columns["Estado"].ColumnName == "No Autorizado")
                    {
                        dt.Columns["Precio"].DefaultValue = 0;

                    }

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
                    //col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                    col.DefaultCellStyle.Format = "N0";
                }
            }
            // dt.Columns["Cotizar"].ReadOnly = true;
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

        private void btnExportarExcelPermiso_Click(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count > 0)
                dgvListado.ExportToExcel();
        }

        private void dgvListado_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            CargarGridGistado();
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

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox2.SelectedIndex > -1 && dgvListado.DataSource != null)
            {
                DataTable dt = null;

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

        private void txtBuscarItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                BuscarItemPorCodigoDescripcion();
            }
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int i = dgvListado.CurrentCell.ColumnIndex;

            //    Pic.Name = "pictureBox1";
            //    try
            //    {

            //        dgvListado.Columns["Imagen"].Visible = true;
            //        ((DataGridViewImageColumn)dgvListado.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            //    }
            //    catch
            //    {

            //    }
            //    //dgvListado.Columns["Imagen"].Visible = true; //ocultar celda imagen
            //    Rectangle rec = dgvListado.GetCellDisplayRectangle(i, dgvListado.CurrentRow.Index, true);
            //    //Pic.Location = new Point(dgvListado.Location.X + dgvListado.Width, dgvListado.Location.X + rec.Location.X - 0);
            //    Pic.Location = new Point(240, 150);


            //    DataGridViewImageCell Ima = dgvListado.CurrentRow.Cells["Imagen"] as DataGridViewImageCell;

            //    if (Ima == null)
            //    {
            //        return;
            //    }

            //    Byte[] ImaByt = (Byte[])Ima.Value;
            //    MemoryStream Mry = new MemoryStream(ImaByt);
            //    Pic.Width = 500;
            //    Pic.Height = 500;

            //    Pic.Image = Image.FromStream(Mry);
            //    Pic.SizeMode = PictureBoxSizeMode.StretchImage;
            //    this.Controls.Add(Pic);
            //    Pic.BringToFront();



            //}
            //catch
            //{

            //}
        }
        //public void mostrarImagen()
        //{
        //    string imagen= dgvListado.CurrentRow.Cells["Imagen"]
        //    Conexion c = new Conexion();
        //    String Cnn = c.conectar();
        //    String listar = "SELECT imagen from item where codigo= '"+selec+"';
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(listar, Cnn);
        //    da.Fill(dt);

        //    return dt;
        //}
        private void dgvListado_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarCamposItemDetalle(Item ItemConsulta)
        {
            // double CostoC = Convert.ToDouble(ItemConsulta.CostoTotal ?? 0) *
            //               (ItemConsulta.TipoItem.Trim() == "P" ? (ItemConsulta.TipoPieza.Trim() == "E" ? 1.857 : 1.409) : 1);



            pictureBox1.BackgroundImage = null;
            if (ItemConsulta.Imagen != null)
                pictureBox1.BackgroundImage = ImageExtensions.byteArrayToImage(ItemConsulta.Imagen);

            //dgvListado.Columns[5].Visible = true;
            //((DataGridViewImageColumn)dgvListado.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

        }
        //private void cargarImagenpequeña(string tipoItem)
        //{
        //    dgvListado.Columns[5].Visible = true;
        //    ((DataGridViewImageColumn)dgvListado.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        //}
        private void OpenImegeForm(Image Img)
        {
            // FrmReportesGrid frmParentForm = (FrmReportesGrid)Application.OpenForms["FrmPrincipalPanel"];
            FrmViewPicture form = new FrmViewPicture();
            form.Imagen = Img;
            form.AutoSize = true;
            // frmParentForm.AbrirFormulario(form, 0, 0, true);
        }
        //private void pictureBox1_DoubleClick(object sender, EventArgs e)
        //{
        //  // OpenImegeForm(pictureBox1.BackgroundImage);
        //}

        private void dgvListado_DoubleClick(object sender, EventArgs e)
        {

        }

        /*MODIFICAR ACÁ PARA PONER BOTON INDEPENDIENTE CON CONSULTA IMAGEN PRODUCTO*/

        void origendatos()
        {
            dgvListado.DataSource = ItemsBL.MostrarImagen();//Llamar a procedure nuevo

            dgvListado.Columns["Imagen"].Visible = false;
        }

        private void dgvListado_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex <= 0 && this.dgvListado.Columns[e.ColumnIndex].Name == "Imagen" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.dgvListado.Rows[e.RowIndex].Cells["Ver Imagen"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\ojo.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvListado.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvListado.Columns[e.ColumnIndex].Width = icoAtomico.Height + 8;
                e.Handled = true;

            }

        }
        public class ImageHelper
        {
            public static Image ByteArrayToImage(byte[] byteArrayIn)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                return Image.FromStream(ms);
            }

            public static byte[] ImageToByteArray(Image imageIn)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
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


            /*-------------------MUESTRA IMAGEN SIN PICTUREBOX------------------------*/
            //try
            //{
            //    int i = dgvListado.CurrentCell.ColumnIndex;

            //    Pic.Name = "picture";
            //    try
            //    {

            //        dgvListado.Columns["Imagen"].Visible = true;
            //        ((DataGridViewImageColumn)dgvListado.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            //    }
            //    catch
            //    {

            //    }
            //    //dgvListado.Columns["Imagen"].Visible = true; //ocultar celda imagen
            //    Rectangle rec = dgvListado.GetCellDisplayRectangle(i, dgvListado.CurrentRow.Index, true);
            //    //Pic.Location = new Point(dgvListado.Location.X + dgvListado.Width, dgvListado.Location.X + rec.Location.X - 0);
            //    Pic.Location = new Point(450, 150);
            //    Pic.BorderStyle = BorderStyle.FixedSingle;


            //DataGridViewImageCell Ima = dgvListado.CurrentRow.Cells["Imagen"] as DataGridViewImageCell;


            //    if (Ima == null)
            //    {
            //        return;
            //    }

            //    Byte[] ImaByt = (Byte[])Ima.Value;
            //    MemoryStream Mry = new MemoryStream(ImaByt);
            //    Pic.Width = 500;
            //    Pic.Height = 500;

            //    Pic.Image = Image.FromStream(Mry);
            //    Pic.SizeMode = PictureBoxSizeMode.StretchImage;
            //    this.Controls.Add(Pic);
            //    Pic.BringToFront();
            //    /*------------------------------------------------------*/





        }

        private void dgvListado_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ////Evito las cabeceras
            //if (e.RowIndex < 0)
            //    return;

            ////Dimensiones del PictureBox
            //Pic.Width = 100;
            //Pic.Height = 100;

            ////Obtiene el raton
            //Point Posicion = Cursor.Position;

            ////Corrijo la cooredenada respecto al formulario
            ////Lo que hace es calcular el centro del datagridview en Y y restarle la mitad de la Y del PictureBox, de modo que el centro del PictureBox quede centrado en el centro del datagrid
            //Point posCorregida = new Point(Posicion.X - this.Location.X, (dgvListado.Location.Y + (dgvListado.Height / 2) - (Pic.Height / 2)));

            ////Aplico la nueva posicion al PictureBox
            //Pic.Location = posCorregida;

            //DataGridViewImageCell Ima = dgvListado.Rows[e.RowIndex].Cells[2] as DataGridViewImageCell;
            //if (Ima == null)
            //{
            //    return;
            //}



            //Pic.Image = (Bitmap)Ima.Value;
            //Pic.SizeMode = PictureBoxSizeMode.StretchImage;
            //this.Controls.Add(Pic);
            //Pic.BringToFront();
        }

        private void FrmReportesGrid_DragDrop(object sender, DragEventArgs e)
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

        private void FrmReportesGrid_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    Location = new Point(e.X, e.Y);

            //}


        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            //if (Location != Point.Empty)
            //{
            //    Point newlocation = this.pictureBox1.Location;
            //    newlocation.X += e.X - Location.X;
            //    newlocation.Y += e.Y - Location.Y;

            //    this.pictureBox1.Location = newlocation;
            //}

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            //Location = Point.Empty;



        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dgvListado[currentMouseOverCol, currentMouseOverRow].Value.ToString());
        }

        private void copiarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvListado.CopyContentToClipboard();
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

        public void AbrirFormulario(Form oForm, int X, int Y, bool Modal = false)
        {
            oForm.StartPosition = FormStartPosition.Manual;
            FrmPrincipalPanel panel = new FrmPrincipalPanel();


            if (X == 0 && Y == 0)
            {
                oForm.Left = (panel.panel10.Width - oForm.Width) / 2;
                oForm.Top = (panel.panel10.Height - oForm.Height) / 2;
            }
            else
                oForm.Location = new Point(X, Y);


            if (Modal)
            {
                oForm.ShowDialog();
            }
            else
            {
                oForm.MdiParent = this.MdiParent;
                oForm.TopLevel = false;
                panel.panel10.Controls.Add(oForm);
                //oForm.Show();
                oForm.Show();
            }
        }
        private void btnAñadirCot_Click(object sender, EventArgs e)
        {

            FrmCotizador coti = new FrmCotizador();
            List<Cotizacion> co = new List<Cotizacion>();
            #region pruebas

            //if ( coti.Values==null)
            //{
            //    foreach (DataGridViewRow fila in dgvListado.Rows)
            //    {
            //        if (Convert.ToBoolean(fila.Cells[0].Value))
            //        {
            //            co.Add(new Cotizacion
            //            {
            //                //IdItem = Convert.ToInt16(fila.Cells[3].Value)
            //                DetallePro = fila.Cells["Descripcion"].Value.ToString(),
            //                CostoUni = Convert.ToInt64(fila.Cells["Precio"].Value),
            //                CodigoPro = fila.Cells["Codigo"].Value.ToString(),
            //                FamiliaPro = fila.Cells["Familia"].Value.ToString()

            //            });
            //        }
            //    }
            //}
            //else
            //{
            //    foreach (DataGridViewRow fila in dgvListado.Rows)
            //    {
            //        if (Convert.ToBoolean(fila.Cells[0].Value))
            //        {


            //            fila.Cells["Descripcion"].Value.ToString();
            //            Convert.ToInt64(fila.Cells["Precio"].Value);
            //            fila.Cells["Codigo"].Value.ToString();
            //            fila.Cells["Familia"].Value.ToString();


            //        }
            //    }
            //}
            #endregion
            #region CODIGO ORIGINAL

            //if (co.Count > 0)
            //{
            foreach (DataGridViewRow fila in dgvListado.Rows)
            {
                if (Convert.ToBoolean(fila.Cells[0].Value))
                {
                    co.Add(new Cotizacion
                    {
                        // IdItem = Convert.ToInt16(fila.Cells[3].Value)
                        DetallePro = fila.Cells["Descripcion"].Value.ToString(),
                        CostoUni = Convert.ToInt64(fila.Cells["Precio"].Value),
                        CodigoPro = fila.Cells["Codigo"].Value.ToString(),
                        FamiliaPro = fila.Cells["Familia"].Value.ToString()

                    });
                }
            }
            //}
            //else
            //{
            //    throw new Exception("DEBE AÑADIR UN PRODUCTO A COTIZADOR");
            //}

            #endregion

            if (co.Count > 0) //Abrir la pantalla cotizador con toda la lista cargada (Solo si existe items seleccionados)
            {
                FrmPrincipalPanel frmParentForm = (FrmPrincipalPanel)Application.OpenForms["FrmPrincipalPanel"];

                FrmCotizador FrmCot = new FrmCotizador();
                FrmCot.Values = co;
                // FrmCot.Show();  /// ASI NO ESTO ES MODAL DEBES LLAMARLO COMO SE LLAMAN LOS OTROS FORMS DENTRO DEL PANEL DEL FRM PRINCIPAL
                frmParentForm.AbrirFormulario(FrmCot, 370, 230);
            }




        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            //ch1 = (DataGridViewCheckBoxCell)dgvListado.Rows[dgvListado.CurrentRow.Index].Cells[0];

            //if (ch1.Value == null)
            //    ch1.Value = false;
            //switch (ch1.Value.ToString())
            //{
            //    case "True":
            //        ch1.Value = false;
            //        break;
            //    case "False":
            //        ch1.Value = true;
            //        break;


            //}
            //MessageBox.Show(ch1.Value.ToString());

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}



