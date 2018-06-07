namespace PresentationLayer
{
    partial class FrmPropiedades
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
            this.dragControl1 = new PresentationLayer.DragControl();
            this.formHeader1 = new PresentationLayer.FormHeader();
            this.dragControl2 = new PresentationLayer.DragControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelNoMouse3 = new PresentationLayer.Controls.LabelNoMouse();
            this.btnCerrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNoMouse2 = new PresentationLayer.Controls.LabelNoMouse();
            this.btnNuevo = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelNoMouse1 = new PresentationLayer.Controls.LabelNoMouse();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescrpcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.formHeader1;
            // 
            // formHeader1
            // 
            this.formHeader1.BackColor = System.Drawing.Color.Transparent;
            this.formHeader1.ControlBoxBackColor = System.Drawing.Color.Transparent;
            this.formHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formHeader1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.formHeader1.HeaderText = "Propiedades";
            this.formHeader1.Location = new System.Drawing.Point(0, 0);
            this.formHeader1.Name = "formHeader1";
            this.formHeader1.ParentContainer = null;
            this.formHeader1.Size = new System.Drawing.Size(515, 41);
            this.formHeader1.TabIndex = 0;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.labelNoMouse3);
            this.panel4.Controls.Add(this.btnCerrar);
            this.panel4.Location = new System.Drawing.Point(379, 428);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(111, 34);
            this.panel4.TabIndex = 43;
            // 
            // labelNoMouse3
            // 
            this.labelNoMouse3.AutoSize = true;
            this.labelNoMouse3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoMouse3.ForeColor = System.Drawing.Color.White;
            this.labelNoMouse3.Location = new System.Drawing.Point(28, 7);
            this.labelNoMouse3.Name = "labelNoMouse3";
            this.labelNoMouse3.Size = new System.Drawing.Size(52, 20);
            this.labelNoMouse3.TabIndex = 1;
            this.labelNoMouse3.Text = "Cerrar";
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Depth = 0;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Icon = null;
            this.btnCerrar.Location = new System.Drawing.Point(0, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Primary = false;
            this.btnCerrar.Size = new System.Drawing.Size(111, 34);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseCompatibleTextRendering = true;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.labelNoMouse2);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Location = new System.Drawing.Point(140, 428);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 34);
            this.panel3.TabIndex = 42;
            // 
            // labelNoMouse2
            // 
            this.labelNoMouse2.AutoSize = true;
            this.labelNoMouse2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoMouse2.ForeColor = System.Drawing.Color.White;
            this.labelNoMouse2.Location = new System.Drawing.Point(28, 7);
            this.labelNoMouse2.Name = "labelNoMouse2";
            this.labelNoMouse2.Size = new System.Drawing.Size(55, 20);
            this.labelNoMouse2.TabIndex = 1;
            this.labelNoMouse2.Text = "Nuevo";
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(0, 0);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = false;
            this.btnNuevo.Size = new System.Drawing.Size(111, 34);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseCompatibleTextRendering = true;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.labelNoMouse1);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Location = new System.Drawing.Point(19, 428);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 34);
            this.panel2.TabIndex = 41;
            // 
            // labelNoMouse1
            // 
            this.labelNoMouse1.AutoSize = true;
            this.labelNoMouse1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoMouse1.ForeColor = System.Drawing.Color.White;
            this.labelNoMouse1.Location = new System.Drawing.Point(16, 7);
            this.labelNoMouse1.Name = "labelNoMouse1";
            this.labelNoMouse1.Size = new System.Drawing.Size(77, 20);
            this.labelNoMouse1.TabIndex = 1;
            this.labelNoMouse1.Text = "Actualizar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(111, 34);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.UseCompatibleTextRendering = true;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.materialCheckBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescrpcion);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 373);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(19, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(430, 263);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(409, 298);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(26, 30);
            this.materialCheckBox1.TabIndex = 42;
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Codigo Propiedad";
            // 
            // txtDescrpcion
            // 
            this.txtDescrpcion.AcceptsReturn = false;
            this.txtDescrpcion.AcceptsTab = false;
            this.txtDescrpcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescrpcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescrpcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescrpcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescrpcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescrpcion.Depth = 0;
            this.txtDescrpcion.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrpcion.Hint = "";
            this.txtDescrpcion.Location = new System.Drawing.Point(141, 336);
            this.txtDescrpcion.MaxLength = 32767;
            this.txtDescrpcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescrpcion.Multiline = false;
            this.txtDescrpcion.Name = "txtDescrpcion";
            this.txtDescrpcion.PasswordChar = '\0';
            this.txtDescrpcion.ReadOnly = false;
            this.txtDescrpcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescrpcion.SelectedText = "";
            this.txtDescrpcion.SelectionLength = 0;
            this.txtDescrpcion.SelectionStart = 0;
            this.txtDescrpcion.Size = new System.Drawing.Size(292, 23);
            this.txtDescrpcion.TabIndex = 41;
            this.txtDescrpcion.TabStop = false;
            this.txtDescrpcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescrpcion.UseSystemPasswordChar = false;
            this.txtDescrpcion.WordWrap = true;
            this.txtDescrpcion.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.AcceptsReturn = false;
            this.txtCodigo.AcceptsTab = false;
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Hint = "";
            this.txtCodigo.Location = new System.Drawing.Point(141, 301);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ReadOnly = false;
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(95, 23);
            this.txtCodigo.TabIndex = 39;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigo.UseSystemPasswordChar = false;
            this.txtCodigo.WordWrap = true;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Activo";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FrmPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(515, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.formHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPropiedades";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DragControl dragControl1;
        private FormHeader formHeader1;
        private DragControl dragControl2;
        private System.Windows.Forms.Panel panel4;
        private Controls.LabelNoMouse labelNoMouse3;
        private MaterialSkin.Controls.MaterialFlatButton btnCerrar;
        private System.Windows.Forms.Panel panel3;
        private Controls.LabelNoMouse labelNoMouse2;
        private MaterialSkin.Controls.MaterialFlatButton btnNuevo;
        private System.Windows.Forms.Panel panel2;
        private Controls.LabelNoMouse labelNoMouse1;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescrpcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroGrid dataGridView1;
        private System.Windows.Forms.ErrorProvider errorIcono;
    }
}