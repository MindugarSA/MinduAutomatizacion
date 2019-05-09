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

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
//using Image = System.Drawing.Image;
using System.Drawing.Imaging;
//using Tekla.Structures.Model;
using Rectangle = System.Drawing.Rectangle;
using Image = iTextSharp.text.Image;
using System.Data.SqlClient;
using System.Web;
using System.Diagnostics;

namespace PresentationLayer.Forms
{
    public partial class FrmCotizador : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;
        private FrmPrincipalPanel formPrincipal;
        //BindingList<ItemDetalle> GloDataSource = new BindingList<ItemDetalle>();
        ItemDetalle ItemDetalleEntidad = new ItemDetalle();
        List<ItemDetalle> ListItemDetalleDelete = new List<ItemDetalle>();
        bool bAgregandoRow = false;


        public delegate void EnvEvent(String idDetalle);
        public event EnvEvent EnviarEvento;
        FrmReportesGrid FrmRep = new FrmReportesGrid();

        public List<Cotizacion> Values { get; set; }
        public string DetallePro { get; private set; }
        public long CostoUni { get; private set; }
        public string CodigoPro { get; private set; }
        public string FamiliaPro { get; private set; }
        public object Response { get; private set; }

        //private readonly Model _model = new Model();
        //private object _model;
        //private List<Assembly> _assemblies; //Assembly
        //  private List<MainAssembly> _assemblyReport; //MainAssembly

        //public void convertidor()
        // {
        //     foreach (DataGridViewRow fila in dgvColaCot.Rows)
        //     {
        //         itemCosto = fila.Cells["ItemC"].Value.ToString();//NO HAY QUE DEJAR VALORES EN BLANCO
        //         codigoC=fila.Cells["CodigoC"].Value.ToString();
        //         detalleC =fila.Cells["DetalleC"].Value.ToString();
        //         familiaC=fila.Cells["FamiliaC"].Value.ToString();
        //         precioUni= Convert.ToUInt32(fila.Cells["PrecioC"].Value.ToString("n"));
        //         cant=fila.Cells["CantC"].Value.ToString();
        //         total=fila.Cells["TotalC"].Value.ToString();


        //     }
        // }

        // public void incremento()
        // {
        //    // Referenciamos el objeto DataTabla existente
        //    // en el objeto DataSet.
        //    //
        //    DataTable dt = myDataSet.Tables[0];

        //    // Referenciamos el campo Autonumérico
        //    //
        //    DataColumn dc = dt.Columns["NombreCampoAutonumérico"];

        //    // Configuramos las propiedades del campo.
        //    //
        //    dc.AutoIncrement = true;
        //    dc.AutoIncrementStep = 1;

        //    // Obtenemos el valor máximo del campo Autonumérico
        //    // para asignárselo a la propiedad AutoIncrementSeed.
        //    //
        //    DataRow[] rows = dt.Select("NombreCampoAutonumérico=MAX(NombreCampoAutonumérico)");


        //    if (rows.Length == 0)
        //    {
        //        // No hay registros
        //        dc.AutoIncrementSeed = 1;
        //    }
        //    else
        //    {
        //        Int64 index = Convert.ToInt64(rows[0]["NombreCampoAutonumérico"]);
        //        dc.AutoIncrementSeed = index + 1;

        //    }
        //}
        public void AddToGrid(List<Cotizacion> val)
        {
            //bAgregandoRow = true;
            
            //DataRow row = dt.NewRow();
            //dt.Rows.Add(row);
            //dgvColaCot.CurrentCell = dgvColaCot.Rows[dgvColaCot.Rows.Count - 1].Cells[9];
            //dgvColaCot[9, dgvColaCot.Rows.Count - 1].Selected = true;
            //dgvColaCot.BeginEdit(true);
            //bAgregandoRow = false;
            //________________________________________________________//autoincremt
            

            // dgvColaCot.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dgvColaCot.Columns["ItemC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvColaCot.Columns["CodigoC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvColaCot.Columns["DetalleC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvColaCot.Columns["PrecioC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvColaCot.Columns["CantC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvColaCot.Columns["TotalC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvColaCot.Columns["PrecioC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvColaCot.Columns["TotalC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            

            dgvColaCot.Columns["PrecioC"].DefaultCellStyle.Format = "N2";
            dgvColaCot.Columns["TotalC"].DefaultCellStyle.Format = "N2";
            if (val != null)
            {
                foreach (Cotizacion item in val)
                {
                    //pruebas vergas
                   
                    //--------------------------------------------aqui termina la prueba verga
                    int n = dgvColaCot.Rows.Add();
                    dgvColaCot.Rows[n].Cells["CodigoC"].Value = item.CodigoPro;
                    dgvColaCot.Rows[n].Cells["DetalleC"].Value = item.DetallePro;
                    dgvColaCot.Rows[n].Cells["PrecioC"].Value = item.CostoUni;
                    dgvColaCot.Rows[n].Cells["FamiliaC"].Value = item.FamiliaPro;
                    
                }

            }           

        }
        public FrmCotizador()
        {
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();
            
            //lblVendedor.Text = _model.GetProjectInfo().Name;
            //lblRut.Text = _model.GetProjectInfo().ProjectNumber;
            //lblCorreo.Text = _model.GetProjectInfo().Builder;
            
            this.InitializeClickHandlers();
        }

        public FrmCotizador(FrmPrincipalPanel FormP = null)
        {
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();

            //ListarTipos();
            this.InitializeClickHandlers();
            //formPrincipal = FormP;

        }

        private void FrmCotizador_Load(object sender, EventArgs e)
        {
            AddToGrid(Values);
           // Suma();
            //dgvColaCot.ColumnCount = 0;
            FormatearGrid();
            this.BringToFront();
            //FrmPrincipalPanel fr = new FrmPrincipalPanel();
            //fr.labelUsser.GetType();
            //AsignarNombreUsuario(label5.Text);
      
            
        }

        private void ListarTipos()
        {
            //GloDataSource = new BindingList<Glosario>(GlosarioBL.GetGlosario());
            //dataGridView1.DataSource = GloDataSource;
            BindingList<ItemDetalle> GloDataSource = new BindingList<ItemDetalle>();
            //FrmRep.EnviarEvento += new FrmReportesGrid.EnvEvent(AgregarDetalleItem);
            dgvColaCot.DataSource = GloDataSource;
        }

        private void FormatearGrid()
        {
            int i = 1;
            foreach (DataGridViewRow row in dgvColaCot.Rows)
            {
                row.Cells["ItemC"].Value = i;
                i++;
            }
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.AjustColumnsWidthForGridWidth();

        }

       

        #region Aplicar Acciones Visuales a Controles
        private void SetearControles()
        {
            formHeader1.ParentContainer = this;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        #endregion

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        //private void AgregarDetalleItem(int IdDetalle = 0)
        private void AgregarDetalleItem(String idDetalle)
        {

            bAgregandoRow = true;
            DataTable dt = (DataTable)dgvColaCot.DataSource;
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);
            dgvColaCot.CurrentCell = dgvColaCot.Rows[dgvColaCot.Rows.Count - 1].Cells[9];
            dgvColaCot[9, dgvColaCot.Rows.Count - 1].Selected = true;
            dgvColaCot.BeginEdit(true);
            bAgregandoRow = false;
            //________________________________________________________//autoincremt
            //DataColumn dc = dt.Columns["ItemC"];
            //dc.AutoIncrement = true;
            //dc.AutoIncrementStep = 1;
            //DataRow[] rows = dt.Select("ItemC=MAX(ItemC)");
            //if (rows.Length == 0)
            //{
            //    // No hay registros
            //    dc.AutoIncrementSeed = 1;
            //}
            //else
            //{
            //    Int64 index = Convert.ToInt64(rows[0]["ItemC"]);
            //    dc.AutoIncrementSeed = index + 1;

            //}
        }

        private void CargarCamposItemDetalle(Item ItemConsulta)
        {
            double CostoC = Convert.ToDouble(ItemConsulta.CostoTotal ?? 0) *
                            (ItemConsulta.TipoItem.Trim() == "P" ? (ItemConsulta.TipoPieza.Trim() == "E" ? 1.857 : 1.409) : 1);
           
        }

        private void FrmCotizador_Shown(object sender, EventArgs e)
        {
            this.Activate();
            this.BringToFront();
        }

        private double SumaColumnaDoubleDT(DataTable dt, string sCol1/*, string sCol2*/)
        {
            var Total = dt.AsEnumerable()
                        .Sum(r => (r.Field<decimal>(sCol1)/* * r.Field<decimal>(sCol2)*/));
            return Convert.ToDouble(Total);
        }

        private void dgvColaCot_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double TotalU = 0;
            decimal TotalNeto = 0;
            try
            {
               
               
                if (dgvColaCot.CurrentRow.Index == -1 || bAgregandoRow)
                    return;

                if (dgvColaCot.Rows[dgvColaCot.CurrentCell.RowIndex].Cells["CantC"].Value.ToString().Length == 0)
                    dgvColaCot.Rows[dgvColaCot.CurrentCell.RowIndex].Cells["CantC"].Value = "0,00";
                else if (TotalU != Convert.ToDouble(dgvColaCot.Rows[dgvColaCot.CurrentCell.RowIndex].Cells["CantC"].Value))
                {
                    dgvColaCot.Rows[dgvColaCot.CurrentCell.RowIndex].Cells["TotalC"].Value = Convert.ToDecimal(dgvColaCot.Rows[dgvColaCot.CurrentCell.RowIndex].Cells["PrecioC"].Value) *
                                                                                    Convert.ToDecimal(dgvColaCot.Rows[dgvColaCot.CurrentCell.RowIndex].Cells["CantC"].Value);
                    

                    foreach (DataGridViewRow row in dgvColaCot.Rows)
                    {
                        TotalNeto += Convert.ToDecimal(row.Cells["TotalC"].Value);
                       
                    }
                    txtNeto.Text = Convert.ToDecimal(TotalNeto).ToString();

                }
            }
            catch { }
         
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FrmBusquedaItem FrmBuscar = new FrmBusquedaItem();
            FrmBuscar.MdiParent = this.MdiParent;
            //FrmBuscar.EnviarEvento += new FrmReportesGrid.EnvEvent();
            FrmBuscar.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            dgvColaCot.Rows.RemoveAt(dgvColaCot.CurrentRow.Index);
            FormatearGrid();
            double TotalU = 0;
            decimal TotalNeto = 0;
            try
            {
                if (dgvColaCot.CurrentRow.Index == -1 || bAgregandoRow)
                    return;

                if (dgvColaCot.Rows[dgvColaCot.CurrentCell.RowIndex].Cells["CantC"].Value.ToString().Length == 0)
                    dgvColaCot.Rows[dgvColaCot.CurrentCell.RowIndex].Cells["CantC"].Value = "0,00";
                else if (TotalU != Convert.ToDouble(dgvColaCot.Rows[dgvColaCot.CurrentCell.RowIndex].Cells["CantC"].Value))
                {
                    dgvColaCot.Rows[dgvColaCot.CurrentCell.RowIndex].Cells["TotalC"].Value = Convert.ToDecimal(dgvColaCot.Rows[dgvColaCot.CurrentCell.RowIndex].Cells["PrecioC"].Value) *
                                                                                    Convert.ToDecimal(dgvColaCot.Rows[dgvColaCot.CurrentCell.RowIndex].Cells["CantC"].Value);
                    //txtNeto.Text= SumaColumnaDoubleDT([dgvColaCot.CurrentCell.RowIndex].Cells["TotalC"].Value]);

                    foreach (DataGridViewRow row in dgvColaCot.Rows) 
                    {
                        TotalNeto += Convert.ToDecimal(row.Cells["TotalC"].Value);
                        // txtNeto.Text = TotalNeto;
                    }
                    txtNeto.Text = Convert.ToDecimal(TotalNeto).ToString();
                    //txtNeto.Text = SumaColumnaDoubleDT((DataTable)dgvColaCot.DataSource, "TotalC").ToString("N2");
                    //SumaColumnaDoubleDT((DataTable)dgvColaCot.DataSource, "CantC", "PrecioC").ToString("N2");
                }
            }
            catch { }
        }

        private void ExportToPdf()
        {
            try
            {
                
                //-----------------------------------------------------------------------------------------------------------------------------------
                var pdfDoc = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:";
                saveFileDialog1.Title = "Guardar Cotizacion";
                saveFileDialog1.DefaultExt = "pdf";
                saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                string filename = "";
                if(saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    filename = saveFileDialog1.FileName;
                }
                if(filename.Trim()!="")
                {
                    FileStream file = new FileStream(filename,
                        FileMode.OpenOrCreate,
                        FileAccess.ReadWrite,
                        FileShare.ReadWrite);
                    //PdfWriter.GetInstance(pdfDoc, file);
                    
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, file);
                    writer.PageEvent = new PDFFooter();
                    pdfDoc.Open();

                    var imagepath = @"\\Fssapbo\d\pruebas\MinduAutomatizacion\\img\logo.png";
                    using (FileStream fs = new FileStream(imagepath, FileMode.Open))
                    {
                        var png = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                        png.ScalePercent(18F, 30f);
                        png.SetAbsolutePosition(pdfDoc.Left, pdfDoc.Top);
                        pdfDoc.Add(png);
                    }

                    var spacer = new Paragraph("")
                    {
                        SpacingBefore = 10f,
                        SpacingAfter = 10f,
                    };
                    pdfDoc.Add(spacer);

                    var headerTable = new PdfPTable(new[] { .75f, 2f })// 2f es ancho de celda y 4f es menos ancho
                    {
                        HorizontalAlignment = Left,
                        WidthPercentage = 75,
                        // DefaultCell = { MinimumHeight = 30f }//22f ancho de celda si sube es menos
                        //DefaultCell = { MinimumHeight = 0f }

                    };
                    headerTable.DefaultCell.Border = 0;
                    headerTable.AddCell("R.U.T:");
                    headerTable.AddCell("96588890-k");
                    headerTable.AddCell("Fecha Doc:");
                    headerTable.AddCell(DateTime.Now.ToString());
                    headerTable.AddCell("Cotizacion N°:");
                    headerTable.AddCell(txtNumCot.Text);
                    headerTable.AddCell("Solicitado por:");
                    headerTable.AddCell(txtECotizante.Text);
                    headerTable.AddCell("Vendedor:");
                    headerTable.AddCell(lblVendedor.Text);
                    headerTable.AddCell("Correo:");
                    headerTable.AddCell(txtCorreo.Text);


                    pdfDoc.Add(headerTable);
                    pdfDoc.Add(spacer);

                    var columnCount = 7;
                    var columnWidths = new[] { 0.3f, 1f, 3f, 0f, 1f, 0.8f, 1f };//0f es familia no lo muestra Acá se puede enanchar columna

                    var table = new PdfPTable(columnWidths)//columnWidths
                    {
                        HorizontalAlignment = Left,
                        WidthPercentage = 100,
                        DefaultCell = { MinimumHeight = 22f }
                    };

                    var cell = new PdfPCell(new Phrase("COTIZACION"))
                    {
                        Colspan = columnCount,
                        HorizontalAlignment = 1,  //0=Left, 1=Centre, 2=Right
                        MinimumHeight = 30f
                    };

                    table.AddCell(cell);

                    for (int j = 0; j < dgvColaCot.Columns.Count; j++)
                    {
                        table.AddCell(new Phrase(dgvColaCot.Columns[j].HeaderText));

                    }


                    var valores = new PdfPCell(new Phrase())
                    {
                        Colspan = columnCount,
                        HorizontalAlignment = 1,  //0=Left, 1=Centre, 2=Right
                        MinimumHeight = 30f

                    };

                    foreach (DataGridViewRow fila in dgvColaCot.Rows)
                    {
                        table.AddCell(fila.Cells["ItemC"].Value.ToString());//NO HAY QUE DEJAR VALORES EN BLANCO
                        table.AddCell(fila.Cells["CodigoC"].Value.ToString());
                        table.AddCell(fila.Cells["DetalleC"].Value.ToString());
                        table.AddCell(fila.Cells["FamiliaC"].Value.ToString());
                        table.AddCell("$ " + Convert.ToDouble(fila.Cells["PrecioC"].Value).ToString("N0"));
                        table.AddCell(fila.Cells["CantC"].Value.ToString());
                        table.AddCell("$ " + Convert.ToDouble(fila.Cells["TotalC"].Value).ToString("N0"));
                        
                    }
                   
                    var total = new PdfPCell(new Phrase(""/*TOTAL:     "+"$"+txtNeto.Text*/))
                    {
                        Colspan = columnCount,
                        //HorizontalAlignment = 2,  //0=Left, 1=Centre, 2=Right
                        MinimumHeight = 30f


                    };

                    total.Padding = Padding.Right;
                    //table.DefaultCell.Border = 0;

                    table.AddCell(new Phrase(""));
                    table.AddCell(new Phrase(""));
                    table.AddCell(new Phrase(""));
                    table.AddCell(new Phrase(""));
                    table.AddCell(new Phrase(""));
                    table.AddCell(new Phrase("Total Neto:"));
                    table.AddCell(new Phrase("$ " + Convert.ToDouble(txtNeto.Text).ToString("N0")));


                    pdfDoc.Add(table);
                    pdfDoc.Close();
                    Process.Start(filename);
                }
               
                

            }
            catch (Exception ex)
            {
                //throw new Exception("Debe seleccionar productos", ex);
            }
        }

        public class PDFFooter : PdfPageEventHelper
        {
            // write on start of each page
            public override void OnStartPage(PdfWriter writer, Document document)
            {
                base.OnStartPage(writer, document);

            }
            // write on top of document
            public override void OnOpenDocument(PdfWriter writer, Document document)
            {
                base.OnOpenDocument(writer, document);
                PdfPTable tabFot = new PdfPTable(new float[] { 1F });
                //tabFot.SpacingAfter = 200f;//10f
                tabFot.SpacingBefore = 200f;
                PdfPCell cell;
                
                tabFot.TotalWidth = 290F;//290f
                tabFot.DefaultCell.Border = 0;
                //tabFot.HorizontalAlignment = 2;
                cell = new PdfPCell(new Phrase("MINDUGAR SPA (Transportadores y piezas)"));
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.PaddingTop = -14;//ESPACIO VERTICAL DE CELDA 
                cell.Colspan = 50;
                //tabFot.AddCell("MINDUGAR SPA");     
                //tabFot.HorizontalAlignment = Element.ALIGN_LEFT;
                tabFot.AddCell(cell);                
                tabFot.WriteSelectedRows(0, -1, 150, document.Top, writer.DirectContent);
                
            }
            

            // write on end of each page
            public override void OnEndPage(PdfWriter writer, Document document)
            {
                var pdfDoc = new Document(PageSize.LETTER, 20f, 20f, 30f, 30f);
                base.OnEndPage(writer, document);
                PdfPTable tabFot = new PdfPTable(new float[] { 4F });
                //var tabFot = new PdfPTable(new[] { .75f, 2f })//.75 me puso columnas con los datos no filas
                //{
                //    HorizontalAlignment = Left,
                //    WidthPercentage = 75,
                //    DefaultCell = { MinimumHeight = 22f }
                //};

                //headerTable.AddCell("Date");
                PdfPCell cell;
                tabFot.TotalWidth = 350F;//300f
                tabFot.DefaultCell.Border = 0;
                //cell = new PdfPCell(new Phrase("Domingo Arteaga 270, Macul - Santiago F:(56-2) 28707400"));
                cell = new PdfPCell(new Phrase(""));                
                tabFot.AddCell(cell);
                tabFot.AddCell("Domingo Arteaga 270, Macul - Santiago F: (56 - 2) 28707400");
                tabFot.AddCell("Email: ventas@mindugar.com");
                tabFot.AddCell("www.mindugar.com");


                tabFot.WriteSelectedRows(0, -1, 150, document.Bottom, writer.DirectContent);
            }

            //write on close of document
            public override void OnCloseDocument(PdfWriter writer, Document document)
            {
                base.OnCloseDocument(writer, document);
            }
        }
            public void AsignarNombreUsuario(string UserName)
        {
            lblVendedor.Visible = true;
            lblVendedor.Text = UserName;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            
            ExportToPdf();
        }
    }

        
        //private void AgregarDetalleItem(int IdDetalle = 0)
        //{

        //    bAgregandoRow = true;
        //    Item ItemDet = ItemsBL.GetItemId(IdDetalle).FirstOrDefault();
        //    Costos dFactor = CostosBL.GetCostos()
        //                      .Where(x => x.Id == Convert.ToDouble(ItemDet.FactorInd))
        //                      .FirstOrDefault();

        //    DataTable dt = (DataTable)dgvListado.DataSource;
        //    DataRow row = dt.NewRow();
        //    row[4] = IdDetalle;
        //    row[5] = ItemDet.Codigo;
        //    row[6] = ItemDet.Descripcion;
        //    row[7] = dgvListado.Rows.Count + 1;
        //    row[8] = ItemDet.TipoPieza == "T" ? ItemDet.TipoItem : ItemDet.TipoItem + ItemDet.TipoPieza;
        //    row[9] = 0;
        //    row[10] = Convert.ToDouble(ItemDet.CostoTotal ?? 0);
        //    row[11] = Convert.ToDouble(ItemDet.CostoTotal ?? 0) * (dFactor == null ? 1 : Convert.ToDouble(dFactor.Valor ?? 1));
        //    row[12] = 0;
        //    row[13] = 0;
        //    row[14] = ItemDet.Imagen;
        //    row[15] = (dFactor == null ? 1 : Convert.ToDouble(dFactor.Valor ?? 1));
        //    row[16] = (dFactor == null ? "" : dFactor.Tipo ?? "");
        //    row[17] = ItemDet.FactorInd ?? 0;

        //    dt.Rows.Add(row);
        //    // errorDetalle.SetErrorWithCount(dgvListado, "");
        //    CargarCamposItemDetalle(ItemDet);
        //    //dgvDetalleItemAmp.Rows[dgvDetalleItemAmp.Rows.Count - 1].Selected = true;
        //    dgvListado.CurrentCell = dgvListado.Rows[dgvListado.Rows.Count - 1].Cells[9];
        //    dgvListado[9, dgvListado.Rows.Count - 1].Selected = true;
        //    dgvListado.BeginEdit(true);
        //    bAgregandoRow = false;
        //}

    }

   


        

