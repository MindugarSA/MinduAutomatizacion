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
    public partial class FrmDetalleKit : Form
    {
        public int itemIdDet { get; set; }
        public string Origen { get; set; }
        int ClickCount = 0;

        DataTable dtItemDetalle = new DataTable();
        bool bAgregandoRow = false;
        private int currentMouseOverRow;
        private int currentMouseOverCol;

        public FrmDetalleKit()
        {
            InitializeComponent();
        }

        private void FrmDetalleKit_Load(object sender, EventArgs e)
        {
            if (itemIdDet > 0)
            {
                switch (Origen)
                {
                    case "Detalle":
                        CargarGridsDetalleItem(itemIdDet);
                        break;
                    case "Dependencia":
                        CargarGridsDependenciasItem(itemIdDet);
                        break;
                }
            }

        }

        private void CargarGridsDetalleItem(int itemId)
        {
            dtItemDetalle = ItemDetalleBL.GetItemDetalleId(itemId);
            bAgregandoRow = true;
            if (dtItemDetalle.Rows.Count > 0)
            {
                dgvDetalleItemAmp.DataSource = dtItemDetalle;

                MetroFramework.Controls.MetroGrid[] ArrDgv = { dgvDetalleItemAmp };

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
                    

                    dgvActual.Columns[9].DefaultCellStyle.Format = "N2";
                    dgvActual.Columns[10].DefaultCellStyle.Format = "N2";
                    dgvActual.Columns[11].DefaultCellStyle.Format = "N2";
                    

                    dgvActual.Columns[9].ReadOnly = false;

                    dgvActual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvActual.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvActual.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvActual.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               


                    if (dgvDetalleItemAmp.Rows.Count > 0) dgvDetalleItemAmp.CurrentCell = dgvDetalleItemAmp.Rows[0].Cells[9];
                }
            }
            else
                this.Close();
            bAgregandoRow = false;

        }

        private void CargarGridsDependenciasItem(int itemId)
        {
            dtItemDetalle = ItemsBL.GetItemsDependencias(itemId);
            bAgregandoRow = true;
            if (dtItemDetalle.Rows.Count > 0)
            {
                dgvDetalleItemAmp.DataSource = dtItemDetalle;

                MetroFramework.Controls.MetroGrid[] ArrDgv = { dgvDetalleItemAmp };

                foreach (MetroFramework.Controls.MetroGrid dgvActual in ArrDgv)
                {
                    List<int> visibleColumns = new List<int> { 2, 3, 8, 9 };
                    foreach (DataGridViewColumn col in dgvActual.Columns)
                    {
                        if (!visibleColumns.Contains(col.Index))
                            col.Visible = false;
                        col.ReadOnly = true;
                    }

                    dgvActual.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvActual.Columns[9].DefaultCellStyle.Format = "#,0.00###";

                    dgvActual.Columns[9].ReadOnly = false;

                    dgvActual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvActual.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    if (dgvDetalleItemAmp.Rows.Count > 0) dgvDetalleItemAmp.CurrentCell = dgvDetalleItemAmp.Rows[0].Cells[2];
                }
            }
            else
                this.Close();
            bAgregandoRow = false;

        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // if click outside dialog -> Close Dlg
            if (m.Msg == 0x86) //0x86
            {
                ClickCount += 1;
                if (this.Visible && ClickCount > 1)
                {
                    if (!this.RectangleToScreen(this.DisplayRectangle).Contains(Cursor.Position))
                        this.Close();
                }
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);

            Brush aGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(50, 0), Color.Gray, Color.White);
            Pen pencil = new Pen(Color.LightGray, 5);
            e.Graphics.DrawRectangle(pencil, rect);
        }

        private void dgvDetalleItemAmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmDetalleKit FrmDetalle = new FrmDetalleKit();
            var cellRectangle = dgvDetalleItemAmp.GetCellDisplayRectangle(5, e.RowIndex, false);
            FrmDetalle.StartPosition = FormStartPosition.Manual;
            FrmDetalle.Location = dgvDetalleItemAmp.PointToScreen(dgvDetalleItemAmp.GetCellDisplayRectangle(6, e.RowIndex, false).Location);
            FrmDetalle.Location = new Point(FrmDetalle.Location.X, FrmDetalle.Location.Y + cellRectangle.Height);
            FrmDetalle.Origen = "Detalle";
            if (Origen == "Detalle")
                FrmDetalle.itemIdDet = Convert.ToInt32(dgvDetalleItemAmp.Rows[dgvDetalleItemAmp.CurrentCell.RowIndex].Cells[4].Value);
            else
                FrmDetalle.itemIdDet = Convert.ToInt32(dgvDetalleItemAmp.Rows[dgvDetalleItemAmp.CurrentCell.RowIndex].Cells[1].Value);
            FrmDetalle.Show();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dgvDetalleItemAmp[currentMouseOverCol, currentMouseOverRow].Value.ToString());
        }

        private void dgvDetalleItemAmp_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentMouseOverRow = e.RowIndex;
                currentMouseOverCol = e.ColumnIndex;
                if (currentMouseOverCol > -1)
                    try
                    {
                        dgvDetalleItemAmp.CurrentCell = dgvDetalleItemAmp[currentMouseOverCol, currentMouseOverRow < 0 ? 0 : currentMouseOverRow];
                        dgvDetalleItemAmp.Rows[(currentMouseOverRow)].Selected = true;
                    }
                    catch { }
            }
        }

        private void copiarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvDetalleItemAmp.CopyContentToClipboard();
        }

        private void verParteKitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetalleItemAmp.Rows.Count > 0)
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
        }
    }
}
