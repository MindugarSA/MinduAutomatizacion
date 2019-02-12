using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLayer;
using System.Drawing.Drawing2D;

namespace PresentationLayer.Forms
{
    public partial class FrmGlosarioGest : Form
    {
        private FrmPrincipalPanel formPrincipal;
        BindingList<Glosario> GloDataSource = new BindingList<Glosario>();

        public FrmGlosarioGest()
        {
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();
            ListarTipos();
            this.InitializeClickHandlers();
        }

        public FrmGlosarioGest(FrmPrincipalPanel FormP = null)
        {
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();

            ListarTipos();
            this.InitializeClickHandlers();
            formPrincipal = FormP;
        }

        private void FrmGlosarioGest_Load(object sender, EventArgs e)
        {
            //InitializeComponent();//prueba para inicializar componentes
            FormatearGrid();
            this.BringToFront();
        }    


        private void ListarTipos()
        {
            GloDataSource = new BindingList<Glosario>(GlosarioBL.GetGlosario());
            dataGridView1.DataSource = GloDataSource;
        }
        private void Actualizar()
        {
            List<Glosario> glo = new List<Glosario>();
            Glosario glosario = new Glosario();
           // GloDataSource = new BindingList<Glosario>(GlosarioBL.UpdateGlosario(glo));
            dataGridView1.DataSource = GloDataSource;

            //glosario.Nombre = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            glosario.Nombre = Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre"].Value);
            glo.Add(glosario);
            
          // GlosarioBL.UpdateGlosario(glosario.Nombre);

            GlosarioBL.UpdateGlosario(glo);
            int nRow = dataGridView1.CurrentRow.Index;          

            dataGridView1.Rows[nRow].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1];

        }
        private void FormatearGrid()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AjustColumnsWidthForGridWidth();
            //foreach (DataGridViewRow Fila in dataGridView1.Rows)
            //{
            //    Fila.Cells["RowType"].Value = "Nombre";
            //}
        }

        #region Aplicar Modificaciones Visuales a Form
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);

            Brush aGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(50, 0), Color.Gray, Color.White); //USING DRAWING 2D
            Pen pencil = new Pen(Color.LightGray, 5);
            e.Graphics.DrawRectangle(pencil, rect);
        }

        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
#pragma warning disable CS0169 // El campo 'FrmGestGlosario.currentMouseOverRow' nunca se usa
        private int currentMouseOverRow;
#pragma warning restore CS0169 // El campo 'FrmGestGlosario.currentMouseOverRow' nunca se usa
#pragma warning disable CS0169 // El campo 'FrmGestGlosario.currentMouseOverCol' nunca se usa
        private int currentMouseOverCol;
#pragma warning restore CS0169 // El campo 'FrmGestGlosario.currentMouseOverCol' nunca se usa
#pragma warning disable CS0169 // El campo 'FrmGestGlosario.CambioGrid' nunca se usa
        private bool CambioGrid;
#pragma warning restore CS0169 // El campo 'FrmGestGlosario.CambioGrid' nunca se usa

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
        
        #endregion

        #region Aplicar Acciones Visuales a Controles
        private void SetearControles()
        {
            //formHeader1.ParentContainer = this;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
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

        private void button1_Click(object sender, EventArgs e)
        {
           
                List<Glosario> Palabra = new List<Glosario>();
                Glosario glo = new Glosario();
                string Categ = "";

                glo.Nombre = txtNombre.Text;
                glo.Descripcion = txtDescripción.Text;
                Palabra.Add(glo);
                GlosarioBL.InsertToGlosario(Palabra);

                ListarTipos();
                // LimpiarCampos();
                dataGridView1.Rows[(dataGridView1.RowCount - 1)].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2];

            //    switch() 
            //    {

            //        case "Agregar":
            //            Palabra.Add(glo);
            //            GlosarioBL.InsertToGlosario(Palabra);

            //            ListarTipos();
            //            // LimpiarCampos();
            //            dataGridView1.Rows[(dataGridView1.RowCount - 1)].Selected = true;
            //            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            //            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3];



            //            break;
            //        case "Actualizar":
            //           // glo.Nombre = Convert.ToInt32(dataGridView1[1, dataGridView1.CurrentRow.Index].Value);
            //            glo.Nombre = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            //            Palabra.Add(glo);
            //            GlosarioBL.UpdateGlosario(Palabra);


            //            int nRow = dataGridView1.CurrentRow.Index;
            //            ListarTipos();

            //            dataGridView1.Rows[nRow].Selected = true;
            //            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3];
            //            break;


            //}


        }
        #endregion

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells["RowStatus"].Value = "E";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Glosario> Palabra = new List<Glosario>();
            Glosario glo = new Glosario();
            string Categ = "";

            glo.Nombre = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            Palabra.Add(glo);
            GlosarioBL.UpdateGlosario(Palabra);


            int nRow = dataGridView1.CurrentRow.Index;
            ListarTipos();

            dataGridView1.Rows[nRow].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2];
        }

        
        private void CargarCampos(int nRow)
        {
            txtNombre.Text = Convert.ToString(dataGridView1.Rows[nRow].Cells[1].Value);
            txtDescripción.Text = Convert.ToString(dataGridView1.Rows[nRow].Cells[2].Value);
            //materialCheckBox1.Checked = dataGridView1.Rows[nRow].Cells[3].Value.ToString() == "1" ? true : false;

        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indice = dataGridView1.SelectedRows[0].Index;
                CargarCampos(indice);
            }
        }
    }
}
