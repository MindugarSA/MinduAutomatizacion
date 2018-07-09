using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace PresentationLayer.Forms
{
    public partial class FrmReportes : Form
    {
        private  ReportDocument ReporteActual;

        public FrmReportes(ReportDocument prmReporte)
        {
            InitializeComponent();
            ReporteActual = prmReporte;
            prmReporte.SetDatabaseLogon("sa", "Sqladmin281");
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = ReporteActual;
            crystalReportViewer1.Zoom(140);
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmReportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReporteActual.Dispose();
            ReporteActual.Close();
            this.Dispose();
        }

        private void FrmReportes_Shown(object sender, EventArgs e)
        {
            this.Visible = true;
            this.Refresh();
        }
    }
}
