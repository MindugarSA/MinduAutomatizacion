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
    public partial class FrmAprobacion : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        Item ItemEntidad = new Item();


        public FrmAprobacion(FrmPrincipalPanel FormP = null)
        {
            InitializeComponent();
            SetearControles();

            this.InitializeClickHandlers();
        }

        private void FrmAprobacion_Shown(object sender, EventArgs e)
        {
            this.Activate();
            this.BringToFront();
            CargarGridListado();

        }

        private void CargarGridListado()
        {
            DataTable dt = new DataTable();

            dt = ItemsBL.ListadoItemsAutorizacion();


            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListado.DataSource = dt;

            FormatearGridListado();
        }

        private void FormatearGridListado()
        {
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Name = "Autor";
            chk.HeaderText = "Autorizado";
            chk.Width = 50;
            chk.ReadOnly = false;
            dgvListado.Columns.Add(chk);

            List<int> numericColumns = new List<int> { 3, 4, 5 };
            dgvListado.Columns[6].Visible = false;
            dgvListado.Columns[7].Visible = false;

            foreach (DataGridViewColumn col in dgvListado.Columns)
            {
                if (numericColumns.Contains(col.Index))
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    col.DefaultCellStyle.Format = "#,0.00###";
                }
                if (col.Index != 8) col.ReadOnly = true;
            }

            foreach (DataGridViewRow row in dgvListado.Rows)
            {
                if (Convert.ToInt32(row.Cells[6].Value) == 1)
                {
                    row.Cells[8].Value = true;
                    row.DefaultCellStyle.ForeColor = Color.Green;
                }
                else
                {
                    row.Cells[8].Value = false;
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void CargarEntidadItem()
        {
            ItemEntidad = ItemsBL.GetItemId(Convert.ToInt32(dgvListado.Rows[dgvListado.CurrentCell.RowIndex].Cells[7].Value)).FirstOrDefault();
            ItemEntidad.Autorizado = (bool)dgvListado.Rows[dgvListado.CurrentCell.RowIndex].Cells[8].Value ? 1 : 0;
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
            //materialFlatButton1.Parent = panel2;
            //materialFlatButton2.Parent = panel3;
            //materialFlatButton3.Parent = panel4;
            //materialFlatButton4.Parent = panel1;
            //labelNoMouse1.Parent = materialFlatButton1;
            //labelNoMouse2.Parent = materialFlatButton2;
            //labelNoMouse3.Parent = materialFlatButton3;
            //labelNoMouse4.Parent = materialFlatButton4;
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

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell cell = dgvListado.CurrentCell as DataGridViewCheckBoxCell;
            DataGridViewRow row = dgvListado.CurrentRow as DataGridViewRow;

            if (cell != null && !cell.ReadOnly)
            {
                cell.Value = cell.Value == null || !((bool)cell.Value);
                if((bool)cell.Value)
                    row.DefaultCellStyle.ForeColor = Color.Green;
                else
                    row.DefaultCellStyle.ForeColor = Color.Red;

                CargarEntidadItem();
                ItemsBL.UpdateItem(ItemEntidad);

                dgvListado.RefreshEdit();
                dgvListado.NotifyCurrentCellDirty(true);
            }
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListado.RefreshEdit();
        }

        private void dgvListado_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
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

        private void copiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dgvListado[currentMouseOverCol, currentMouseOverRow].Value.ToString());
        }

        private void verParteKitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count > 0)
            {
                int IdDetalle = Convert.ToInt32(dgvListado.Rows[dgvListado.CurrentCell.RowIndex].Cells[7].Value);
                FrmPrincipalPanel frmParentForm = (FrmPrincipalPanel)Application.OpenForms["FrmPrincipalPanel"];

                if (IdDetalle > 0)
                {
                    FrmProducto FrmProd = new FrmProducto();
                    FrmProd.IdIetmSearch = IdDetalle;
                    frmParentForm.AbrirFormulario(FrmProd, 370, 230);
                }
            }
        }
    }
}
