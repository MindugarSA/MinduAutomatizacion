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
    public partial class FrmBusquedaItem : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        public delegate void EnvEvent(int idDetalle = 0);
        public event EnvEvent EnviarEvento;

        DataTable dtItems;

        public FrmBusquedaItem()
        {
            InitializeComponent();
            SetearControles();
        }

        /// <summary>
        /// EVENTOS    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void FrmBusquedaItem_Load(object sender, EventArgs e)
        {
            CargarGridListadoItem();
            cmbTipo.SelectedIndex = 0;
            txtBusqueda.Focus();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FiltrarInstrumentos("Busqueda");
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FiltrarInstrumentos("TipoItem");
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                FiltrarInstrumentos("Busqueda");
        }

        private void dgvListaItems_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int ItemId = Convert.ToInt32(dgvListaItems.Rows[dgvListaItems.CurrentCell.RowIndex].Cells["Id"].Value);
                Item ItemConsulta = ItemsBL.GetItemId(ItemId).FirstOrDefault();

                txtCodigoC.Text = ItemConsulta.Codigo;
                txtDescripcionC.Text = ItemConsulta.Descripcion;
                txtNombreC.Text = ItemConsulta.Nombre;
                txtEspesorC.Text = ItemConsulta.Espesor.ToString();
                txtAnchoC.Text = ItemConsulta.Ancho.ToString();
                txtLargoC.Text = ItemConsulta.Largo.ToString();
                txtDiametroC.Text = ItemConsulta.Diametro.ToString();
                txtVolumenC.Text = ItemConsulta.Volumen.ToString();
                txtPesoC.Text = ItemConsulta.Peso.ToString();
                //txtPesoC.Text = ItemConsulta.cos.ToString();
                pictureBox10.BackgroundImage = null;
                if (ItemConsulta.Imagen != null)
                    pictureBox10.BackgroundImage = ImageExtensions.byteArrayToImage(ItemConsulta.Imagen);
            }
            catch { }

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvListaItems_DoubleClick(object sender, EventArgs e)
        {
            int ItemId = Convert.ToInt32(dgvListaItems.Rows[dgvListaItems.CurrentCell.RowIndex].Cells["Id"].Value);
            EnviarEvento(ItemId);
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int ItemId = Convert.ToInt32(dgvListaItems.Rows[dgvListaItems.CurrentCell.RowIndex].Cells["Id"].Value);
            EnviarEvento(ItemId);
            this.Close();
        }

        /// <summary>
        /// METODOS    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void CargarGridListadoItem()
        {
            //Listado de Items
            dtItems = ItemsBL.GetItemsBusqueda(null); 
            dgvListaItems.DataSource = dtItems; 
            //dgvListaItems.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvListaItems.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListaItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List<int> visibleColumns = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 10 };
            foreach (DataGridViewColumn col in dgvListaItems.Columns)
            {
                if (!visibleColumns.Contains(col.Index))
                    col.Visible = false;
            }

            dgvListaItems.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListaItems.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListaItems.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListaItems.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvListaItems.Columns[5].DefaultCellStyle.Format = "#,0.00###";
            dgvListaItems.Columns[6].DefaultCellStyle.Format = "#,0.00###";
            dgvListaItems.Columns[7].DefaultCellStyle.Format = "#,0.00###";
            dgvListaItems.Columns[8].DefaultCellStyle.Format = "#,0.00###";

            ((DataGridViewImageColumn)dgvListaItems.Columns[10]).ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private void FiltrarInstrumentos(String TipoFiltro = null)
        {
            DataTable dtf = null;
            string sTipoPieza = cmbTipo.Text == "Pieza" ? "P" :
                                                            cmbTipo.Text == "Kit" ? "K" : "T";
            var results = dtItems.AsEnumerable()
                          .Where(s => s.Field<int>("Id") != s.Field<int>("Id")); // Inicializar en vacio

            if (TipoFiltro == null || TipoFiltro == "Busqueda")
            {

                results = dtItems.AsEnumerable()
                          .Where(s => (!String.IsNullOrEmpty(s.Field<string>("Codigo"))
                                        && s.Field<string>("Codigo").ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                                        || (!String.IsNullOrEmpty(s.Field<string>("Descripcion"))
                                            && s.Field<string>("Descripcion").ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper())))
                          .OrderBy(s => s[9])
                          .ThenBy(s => s[1]);

                if (sTipoPieza != "T") results = results
                                                .Where(s => (!String.IsNullOrEmpty(s.Field<string>("TipoPieza"))
                                                             && s.Field<string>("TipoPieza").ToUpper().Contains(sTipoPieza)))
                                                .OrderBy(s => s[9])
                                                .ThenBy(s => s[1]);
            }
            else if (TipoFiltro == "TipoItem")
            {

                if (sTipoPieza != "T")
                {
                    results = dtItems.AsEnumerable()
                              .Where(s => (!String.IsNullOrEmpty(s.Field<string>("TipoPieza"))
                                     && s.Field<string>("TipoPieza").ToUpper().Contains(sTipoPieza)))
                              .OrderBy(s => s[9])
                              .ThenBy(s => s[1]);

                }
                else
                    results = dtItems.AsEnumerable()
                                .OrderBy(s => s[9])
                                .ThenBy(s => s[1]);
            }

            if (results.Any())
            {
                dtf = results.CopyToDataTable();
                if (dtf.Rows.Count > 0)
                    dgvListaItems.DataSource = dtf;
            }
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
            formHeader2.ParentContainer = this;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            btnAgregar.Parent = panel2;
            btnCerrar.Parent = panel4;
            labelNoMouse1.Parent = btnAgregar;
            labelNoMouse3.Parent = btnCerrar;
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


    }
}
