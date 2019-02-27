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
    public partial class FrmGlosario : Form
    {
        private FrmPrincipalPanel formPrincipal;
        BindingList<Glosario> GloDataSource = new BindingList<Glosario>();

        public FrmGlosario()
        {
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();
            ListarTipos();
            this.InitializeClickHandlers();
        }
        public FrmGlosario(FrmPrincipalPanel FormP = null)
        {
            Functions.ConfigurarMaterialSkinManager();
            InitializeComponent();
            SetearControles();
            
            ListarTipos();
            this.InitializeClickHandlers();
            formPrincipal = FormP;
           
        }

        private void FrmGlosario_Load(object sender, EventArgs e)
        {
            //formPrincipal.VisualizarLabel(false);
            FormatearGrid();
            this.BringToFront();
            
        }

        private void ListarTipos()
        {
            GloDataSource = new BindingList<Glosario>(GlosarioBL.GetGlosario());
            dataGridView1.DataSource = GloDataSource;
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

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells["RowStatus"].Value = "E";
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DataGridViewCell _cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    Font font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                    _cell.Style.Font = font;
                }
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DataGridViewCell _cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Font font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
                    _cell.Style.Font = font;
                }
            }
        }
    }
}
