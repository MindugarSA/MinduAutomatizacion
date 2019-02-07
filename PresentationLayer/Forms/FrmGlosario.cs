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

namespace PresentationLayer.Forms
{
    public partial class FrmGlosario : Form
    {
        private FrmPrincipalPanel formPrincipal;

        BindingList<Glosario> TipoItemDataSource = new BindingList<Glosario>();

        public FrmGlosario()
        {
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();
            ListarTipos();
            this.InitializeClickHandlers();
        }
        private void FrmGlosario_Load(object sender, EventArgs e)
        {
            FormatearGrid();//
            // TODO: esta línea de código carga datos en la tabla 'dB_AUTOMATIZACIONDataSet1.Glosario' Puede moverla o quitarla según sea necesario.
            this.glosarioTableAdapter.Fill(this.dB_AUTOMATIZACIONDataSet1.Glosario);
            formPrincipal.VisualizarLabel(false);
            this.BringToFront();
            BringToFront();
        }

        private void ListarTipos()
        {
            TipoItemDataSource = new BindingList<Glosario>(GlosarioBL.GetGlosario());
            dataGridView1.DataSource = TipoItemDataSource;
        }

        private void FormatearGrid()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.AjustColumnsWidthForGridWidth();
            foreach (DataGridViewRow Fila in dataGridView1.Rows)
            {
                Fila.Cells["RowType"].Value = "N";
            }
        }


        public FrmGlosario(FrmPrincipalPanel FormP = null)
        {
            InitializeComponent();
            SetearControles();
            this.InitializeClickHandlers();
            formPrincipal = FormP;

            //Label Label1 = new Label();
            //Label1.Text = "This is a label with a tooltip";
            //Label1.Width = 200;
            //Label1.Left = 15;
            //Label1.Top = 15;
            ToolTip tooltip = new ToolTip();
            
            tooltip.SetToolTip(label1, "Módulo en el cuál se pueden realizar cambios a nivel administrativos como agregar y actualizar familia, tipo, propiedades,costos,tasas/factores,autorizaciones.");
            tooltip.SetToolTip(label2, "Submódulo para agregar y actualizar familia");
            tooltip.SetToolTip(label3, "Submódulo para agregar tipos de items como parte o kit");
            tooltip.SetToolTip(label4, "Submódulo de especificación de características de los productos");
            tooltip.SetToolTip(label5, "Submódulo en el cuál se pueden modificar los costos de procesos, aceros y RR.HH");
            tooltip.SetToolTip(label6, "Submódulo que se usa para agregar tipos de costos(tasa/factores) y su valor base");
            tooltip.SetToolTip(label7, "Submódulo para autorizar productos terminados");

            tooltip.SetToolTip(label8, "En este módulo se crean las partes y piezas que componen un producto con todos sus detalles, magnitudes y costos");
            tooltip.SetToolTip(label9, "En este módulo se crean los kit agregando las partes y piezas que componen el KIT");
            tooltip.SetToolTip(label10, "En este módulo se crean los productos añadiendo sus partes, piezas o KIT que los componen");
            tooltip.SetToolTip(label11, "Aquí se puede acceder al detalle de los costos de los productos finalizados con la posibilidad de descargar el detalle en PDF");

            //label1.Visible = true;
            //this.Controls.Add(Label1);
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
        private int currentMouseOverRow;
        private int currentMouseOverCol;
        private bool CambioGrid;

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

        private void label1_Click(object sender, EventArgs e)
        {
            
         

        }
    }
}
