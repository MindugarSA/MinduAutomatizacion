namespace PresentationLayer.Forms
{
    partial class FrmGlosario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlosario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formHeader1 = new PresentationLayer.FormHeader();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dB_AUTOMATIZACIONDataSet1 = new PresentationLayer.DB_AUTOMATIZACIONDataSet1();
            this.glosarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glosarioTableAdapter = new PresentationLayer.DB_AUTOMATIZACIONDataSet1TableAdapters.GlosarioTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AUTOMATIZACIONDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glosarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formHeader1
            // 
            this.formHeader1.BackColor = System.Drawing.Color.Transparent;
            this.formHeader1.ControlBoxBackColor = System.Drawing.Color.Transparent;
            this.formHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formHeader1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.formHeader1.HeaderText = "Glosario";
            this.formHeader1.Location = new System.Drawing.Point(0, 0);
            this.formHeader1.Name = "formHeader1";
            this.formHeader1.ParentContainer = null;
            this.formHeader1.Size = new System.Drawing.Size(1028, 47);
            this.formHeader1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "";
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(70, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestión";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(27, 50);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(547, 23);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Desliza el puntero del mouse en la imágen con módulos para ver su descripción.";
            this.materialLabel1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "";
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Cursor = System.Windows.Forms.Cursors.Help;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(86, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Familia";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = "";
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Cursor = System.Windows.Forms.Cursors.Help;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(87, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "";
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Cursor = System.Windows.Forms.Cursors.Help;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(87, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Propiedades";
            // 
            // label5
            // 
            this.label5.AccessibleDescription = "";
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Cursor = System.Windows.Forms.Cursors.Help;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(87, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Costos";
            // 
            // label6
            // 
            this.label6.AccessibleDescription = "";
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Cursor = System.Windows.Forms.Cursors.Help;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(87, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tasas/Factores";
            // 
            // label7
            // 
            this.label7.AccessibleDescription = "";
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Cursor = System.Windows.Forms.Cursors.Help;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(87, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Autorizaciones";
            // 
            // label8
            // 
            this.label8.AccessibleDescription = "";
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Cursor = System.Windows.Forms.Cursors.Help;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(70, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Parte";
            // 
            // label9
            // 
            this.label9.AccessibleDescription = "";
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Cursor = System.Windows.Forms.Cursors.Help;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(70, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 31);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kit";
            // 
            // label10
            // 
            this.label10.AccessibleDescription = "";
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.label10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Cursor = System.Windows.Forms.Cursors.Help;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(70, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "Producto";
            // 
            // label11
            // 
            this.label11.AccessibleDescription = "";
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.label11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Cursor = System.Windows.Forms.Cursors.Help;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(70, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 31);
            this.label11.TabIndex = 19;
            this.label11.Text = "Reportes";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(27, 559);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(189, 23);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "Glosario en Construcción...";
            this.materialLabel2.UseCompatibleTextRendering = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(236, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 448);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GLOSARIO AUTOMATIZACION";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.glosarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 423);
            this.dataGridView1.TabIndex = 0;
            // 
            // dB_AUTOMATIZACIONDataSet1
            // 
            this.dB_AUTOMATIZACIONDataSet1.DataSetName = "DB_AUTOMATIZACIONDataSet1";
            this.dB_AUTOMATIZACIONDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // glosarioBindingSource
            // 
            this.glosarioBindingSource.DataMember = "Glosario";
            this.glosarioBindingSource.DataSource = this.dB_AUTOMATIZACIONDataSet1;
            // 
            // glosarioTableAdapter
            // 
            this.glosarioTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // FrmGlosario
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1028, 923);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.formHeader1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGlosario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmGlosario";
            this.Load += new System.EventHandler(this.FrmGlosario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AUTOMATIZACIONDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glosarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormHeader formHeader1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_AUTOMATIZACIONDataSet1 dB_AUTOMATIZACIONDataSet1;
        private System.Windows.Forms.BindingSource glosarioBindingSource;
        private DB_AUTOMATIZACIONDataSet1TableAdapters.GlosarioTableAdapter glosarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}