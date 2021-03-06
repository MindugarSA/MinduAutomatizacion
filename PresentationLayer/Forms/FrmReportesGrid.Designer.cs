﻿namespace PresentationLayer
{
    partial class FrmReportesGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportesGrid));
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.dgvListado = new MetroFramework.Controls.MetroGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportarExcelPermiso = new System.Windows.Forms.Button();
            this.formHeader1 = new PresentationLayer.FormHeader();
            this.txtBuscarItem = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Listado de Items",
            "Listado de Items con Costos Resumido",
            "Listado de Items con Costos Detallados",
            "Listado de Productos con Costo Directo + Factor",
            "Listado de Productos con Costo Directo + Factor (Extendido)"});
            this.metroComboBox1.Location = new System.Drawing.Point(104, 19);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(483, 29);
            this.metroComboBox1.TabIndex = 150;
            this.toolTip1.SetToolTip(this.metroComboBox1, "Seleccionar Listado");
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChangedAsync);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(26, 22);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(70, 21);
            this.label42.TabIndex = 149;
            this.label42.Text = "Reporte";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToOrderColumns = true;
            this.dgvListado.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListado.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListado.EnableHeadersVisualStyles = false;
            this.dgvListado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListado.Location = new System.Drawing.Point(19, 153);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListado.RowHeadersVisible = false;
            this.dgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(1147, 486);
            this.dgvListado.TabIndex = 148;
            this.dgvListado.BindingContextChanged += new System.EventHandler(this.dgvListado_BindingContextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.txtBuscarItem);
            this.panel1.Controls.Add(this.pictureBox14);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox17);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.metroComboBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.metroComboBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.metroComboBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnExportarExcelPermiso);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Location = new System.Drawing.Point(17, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 111);
            this.panel1.TabIndex = 152;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.BackgroundImage = global::PresentationLayer.Properties.Resources.magnifying_glass;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Location = new System.Drawing.Point(1067, 69);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(27, 27);
            this.pictureBox14.TabIndex = 162;
            this.pictureBox14.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox14, "Buscar en Listado Actual segun Codigo / Descripcion");
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click);
            this.pictureBox14.MouseEnter += new System.EventHandler(this.PopUp_MouseEnter);
            this.pictureBox14.MouseLeave += new System.EventHandler(this.PopUp_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(592, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 21);
            this.label4.TabIndex = 164;
            this.label4.Text = "Codigo / Descripcion";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.BackgroundImage = global::PresentationLayer.Properties.Resources.refresh__1_;
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox17.Location = new System.Drawing.Point(1104, 69);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(27, 27);
            this.pictureBox17.TabIndex = 163;
            this.pictureBox17.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox17, "Recargar Datos");
            this.pictureBox17.Click += new System.EventHandler(this.pictureBox17_Click);
            this.pictureBox17.MouseEnter += new System.EventHandler(this.PopUp_MouseEnter);
            this.pictureBox17.MouseLeave += new System.EventHandler(this.PopUp_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(613, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 159;
            this.label3.Text = "Tipo";
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Items.AddRange(new object[] {
            "Parte",
            "Kit",
            "Producto"});
            this.metroComboBox3.Location = new System.Drawing.Point(667, 19);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(124, 29);
            this.metroComboBox3.TabIndex = 158;
            this.metroComboBox3.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 157;
            this.label2.Text = "Familia";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(104, 65);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(483, 29);
            this.metroComboBox2.TabIndex = 156;
            this.toolTip1.SetToolTip(this.metroComboBox2, "Filtrar Listado Actual por Familia");
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(821, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 155;
            this.label1.Text = "Cargando Datos";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(886, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(41, 35);
            this.panel2.TabIndex = 154;
            // 
            // btnExportarExcelPermiso
            // 
            this.btnExportarExcelPermiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcelPermiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnExportarExcelPermiso.FlatAppearance.BorderSize = 0;
            this.btnExportarExcelPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcelPermiso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportarExcelPermiso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportarExcelPermiso.Image = global::PresentationLayer.Properties.Resources.white_ms_excel_32;
            this.btnExportarExcelPermiso.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExportarExcelPermiso.Location = new System.Drawing.Point(954, 10);
            this.btnExportarExcelPermiso.Name = "btnExportarExcelPermiso";
            this.btnExportarExcelPermiso.Size = new System.Drawing.Size(186, 44);
            this.btnExportarExcelPermiso.TabIndex = 151;
            this.btnExportarExcelPermiso.Text = "Exportar a Excel";
            this.btnExportarExcelPermiso.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTip1.SetToolTip(this.btnExportarExcelPermiso, "Enviar Listado a Excel");
            this.btnExportarExcelPermiso.UseVisualStyleBackColor = false;
            this.btnExportarExcelPermiso.Click += new System.EventHandler(this.btnExportarExcelPermiso_Click);
            this.btnExportarExcelPermiso.MouseEnter += new System.EventHandler(this.PopUp_MouseEnter);
            this.btnExportarExcelPermiso.MouseLeave += new System.EventHandler(this.PopUp_MouseLeave);
            // 
            // formHeader1
            // 
            this.formHeader1.BackColor = System.Drawing.Color.Transparent;
            this.formHeader1.ControlBoxBackColor = System.Drawing.Color.Transparent;
            this.formHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formHeader1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.formHeader1.HeaderText = "Reportes";
            this.formHeader1.Location = new System.Drawing.Point(0, 0);
            this.formHeader1.Name = "formHeader1";
            this.formHeader1.ParentContainer = null;
            this.formHeader1.Size = new System.Drawing.Size(1186, 44);
            this.formHeader1.TabIndex = 1;
            // 
            // txtBuscarItem
            // 
            this.txtBuscarItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarItem.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarItem.Location = new System.Drawing.Point(762, 68);
            this.txtBuscarItem.Name = "txtBuscarItem";
            this.txtBuscarItem.Size = new System.Drawing.Size(298, 29);
            this.txtBuscarItem.TabIndex = 154;
            this.toolTip1.SetToolTip(this.txtBuscarItem, "Filtrar Listado Actual por Codigo / Descripcion");
            this.txtBuscarItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarItem_KeyPress);
            // 
            // FrmReportesGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1186, 660);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.formHeader1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportesGrid";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.FrmReportesGrid_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FormHeader formHeader1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Label label42;
        private MetroFramework.Controls.MetroGrid dgvListado;
        private System.Windows.Forms.Button btnExportarExcelPermiso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.TextBox txtBuscarItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}