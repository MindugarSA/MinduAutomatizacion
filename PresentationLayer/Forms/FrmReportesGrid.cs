﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class FrmReportesGrid : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;
        private DataTable DTListado;
        public FrmReportesGrid(FrmPrincipalPanel FormP = null)
        {
            InitializeComponent();
            SetearControles();
            panel2.Visible = false;
            label1.Visible = false;

            this.InitializeClickHandlers();
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
        }

        private void metroComboBox1_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            panel2.BringToFront();
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

            switch (metroComboBox1.SelectedIndex)
            {
                case 0:
                    dt = ItemsBL.ListadoItemsResumen();
                    for (int i = 6; i <= dt.Columns.Count; i++)
                    {
                        NumericColumns.Add(i);
                    }
                    break;
                case 1:
                    dt = ItemsBL.ListadoItemsCostoResumen();
                    for (int i = 6; i <= dt.Columns.Count - 2; i++)
                    {
                        NumericColumns.Add(i);
                    }
                    break;
                case 2:
                    dt = ItemsBL.ListadoItemsCostoDetallado();
                    for (int i = 6; i <= dt.Columns.Count - 2; i++)
                    {
                        NumericColumns.Add(i);
                    }
                    break;
                case 3:
                    dt = ItemsBL.ListadoItemsTipoCostoFactorRES("T");
                    NumericColumns.Add(3);
                    NumericColumns.Add(4);
                    break;
                case 4:
                    dt = ItemsBL.ListadoItemsTipoCostoFactor("T");
                    NumericColumns.Add(4);
                    NumericColumns.Add(5);
                    break;
            }

            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListado.DataSource = dt;
            DTListado = dt.Copy();

            if (metroComboBox1.SelectedIndex == 2) dgvListado.Columns[5].Visible = false;

            foreach (DataGridViewColumn col in dgvListado.Columns)
            {
                if (NumericColumns.Contains(col.Index))
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    col.DefaultCellStyle.Format = "N2";
                }
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
                                    || r.Field<string>("Nombre").ToUpper().Contains(txtBuscarItem.Text.Trim().ToUpper()));
                //.CopyToDataTable();

                if (rows.Any())
                {
                    dt = rows.CopyToDataTable();
                    dgvListado.DataSource = dt;
                }
            }
            else
            {
                dgvListado.DataSource = DTListado;
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
    }
}
