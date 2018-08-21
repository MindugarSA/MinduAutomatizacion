namespace PresentationLayer.Forms
{
    partial class FrmBusquedaItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelNoMouse3 = new PresentationLayer.Controls.LabelNoMouse();
            this.btnCerrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.formHeader2 = new PresentationLayer.FormHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelNoMouse1 = new PresentationLayer.Controls.LabelNoMouse();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtEspesorC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAnchoC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label25 = new System.Windows.Forms.Label();
            this.txtLargoC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label27 = new System.Windows.Forms.Label();
            this.txtDiametroC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label28 = new System.Windows.Forms.Label();
            this.txtVolumenC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPesoC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label29 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtNombreC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label34 = new System.Windows.Forms.Label();
            this.txtCodigoC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label35 = new System.Windows.Forms.Label();
            this.dgvListaItems = new MetroFramework.Controls.MetroGrid();
            this.txtDescripcionC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label45 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.labelNoMouse3);
            this.panel4.Controls.Add(this.btnCerrar);
            this.panel4.Location = new System.Drawing.Point(1022, 647);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(111, 34);
            this.panel4.TabIndex = 47;
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
            // formHeader2
            // 
            this.formHeader2.BackColor = System.Drawing.Color.Transparent;
            this.formHeader2.ControlBoxBackColor = System.Drawing.Color.Transparent;
            this.formHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.formHeader2.HeaderBackColor = System.Drawing.Color.Transparent;
            this.formHeader2.HeaderText = "Busqueda Pieza / Kit";
            this.formHeader2.Location = new System.Drawing.Point(0, 0);
            this.formHeader2.Name = "formHeader2";
            this.formHeader2.ParentContainer = null;
            this.formHeader2.Size = new System.Drawing.Size(1153, 47);
            this.formHeader2.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.labelNoMouse1);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Location = new System.Drawing.Point(19, 647);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 34);
            this.panel2.TabIndex = 45;
            // 
            // labelNoMouse1
            // 
            this.labelNoMouse1.AutoSize = true;
            this.labelNoMouse1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoMouse1.ForeColor = System.Drawing.Color.White;
            this.labelNoMouse1.Location = new System.Drawing.Point(12, 7);
            this.labelNoMouse1.Name = "labelNoMouse1";
            this.labelNoMouse1.Size = new System.Drawing.Size(87, 20);
            this.labelNoMouse1.TabIndex = 1;
            this.labelNoMouse1.Text = "Seleccionar";
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtEspesorC);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtAnchoC);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtLargoC);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtDiametroC);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.txtVolumenC);
            this.groupBox1.Controls.Add(this.txtPesoC);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.txtNombreC);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.txtCodigoC);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.dgvListaItems);
            this.groupBox1.Controls.Add(this.txtDescripcionC);
            this.groupBox1.Controls.Add(this.label45);
            this.groupBox1.Location = new System.Drawing.Point(22, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1111, 590);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.ItemHeight = 23;
            this.cmbTipo.Items.AddRange(new object[] {
            "Todos",
            "Pieza",
            "Kit"});
            this.cmbTipo.Location = new System.Drawing.Point(474, 12);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(97, 29);
            this.cmbTipo.TabIndex = 149;
            this.cmbTipo.UseSelectable = true;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 148;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label2.Location = new System.Drawing.Point(30, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 146;
            this.label2.Text = "Codigo / Descripcion";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.AcceptsReturn = false;
            this.txtBusqueda.AcceptsTab = false;
            this.txtBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBusqueda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBusqueda.Depth = 0;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Hint = "";
            this.txtBusqueda.Location = new System.Drawing.Point(175, 15);
            this.txtBusqueda.MaxLength = 32767;
            this.txtBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBusqueda.Multiline = false;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.ReadOnly = false;
            this.txtBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.SelectionLength = 0;
            this.txtBusqueda.SelectionStart = 0;
            this.txtBusqueda.Size = new System.Drawing.Size(246, 23);
            this.txtBusqueda.TabIndex = 147;
            this.txtBusqueda.TabStop = false;
            this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBusqueda.UseSystemPasswordChar = false;
            this.txtBusqueda.WordWrap = true;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::PresentationLayer.Properties.Resources.magnifying_glass;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(582, 11);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 30);
            this.pictureBox8.TabIndex = 122;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            this.pictureBox8.MouseEnter += new System.EventHandler(this.PopUp_MouseEnter);
            this.pictureBox8.MouseLeave += new System.EventHandler(this.PopUp_MouseLeave);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10.Location = new System.Drawing.Point(719, 407);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(230, 170);
            this.pictureBox10.TabIndex = 141;
            this.pictureBox10.TabStop = false;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label23.Location = new System.Drawing.Point(476, 545);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 20);
            this.label23.TabIndex = 140;
            this.label23.Text = "Volumen(cm3)";
            // 
            // txtEspesorC
            // 
            this.txtEspesorC.AcceptsReturn = false;
            this.txtEspesorC.AcceptsTab = false;
            this.txtEspesorC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEspesorC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEspesorC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEspesorC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEspesorC.Depth = 0;
            this.txtEspesorC.Hint = "";
            this.txtEspesorC.Location = new System.Drawing.Point(182, 516);
            this.txtEspesorC.MaxLength = 32767;
            this.txtEspesorC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEspesorC.Multiline = false;
            this.txtEspesorC.Name = "txtEspesorC";
            this.txtEspesorC.PasswordChar = '\0';
            this.txtEspesorC.ReadOnly = true;
            this.txtEspesorC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEspesorC.SelectedText = "";
            this.txtEspesorC.SelectionLength = 0;
            this.txtEspesorC.SelectionStart = 0;
            this.txtEspesorC.Size = new System.Drawing.Size(72, 23);
            this.txtEspesorC.TabIndex = 129;
            this.txtEspesorC.TabStop = false;
            this.txtEspesorC.Text = "0,00";
            this.txtEspesorC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEspesorC.UseSystemPasswordChar = false;
            this.txtEspesorC.WordWrap = true;
            this.txtEspesorC.TextChanged += new System.EventHandler(this.txtValidar_TextChanged);
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label24.Location = new System.Drawing.Point(117, 517);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 20);
            this.label24.TabIndex = 130;
            this.label24.Text = "Espesor";
            // 
            // txtAnchoC
            // 
            this.txtAnchoC.AcceptsReturn = false;
            this.txtAnchoC.AcceptsTab = false;
            this.txtAnchoC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAnchoC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAnchoC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAnchoC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAnchoC.Depth = 0;
            this.txtAnchoC.Hint = "";
            this.txtAnchoC.Location = new System.Drawing.Point(182, 546);
            this.txtAnchoC.MaxLength = 32767;
            this.txtAnchoC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAnchoC.Multiline = false;
            this.txtAnchoC.Name = "txtAnchoC";
            this.txtAnchoC.PasswordChar = '\0';
            this.txtAnchoC.ReadOnly = true;
            this.txtAnchoC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAnchoC.SelectedText = "";
            this.txtAnchoC.SelectionLength = 0;
            this.txtAnchoC.SelectionStart = 0;
            this.txtAnchoC.Size = new System.Drawing.Size(72, 23);
            this.txtAnchoC.TabIndex = 131;
            this.txtAnchoC.TabStop = false;
            this.txtAnchoC.Text = "0,00";
            this.txtAnchoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAnchoC.UseSystemPasswordChar = false;
            this.txtAnchoC.WordWrap = true;
            this.txtAnchoC.TextChanged += new System.EventHandler(this.txtValidar_TextChanged);
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label25.Location = new System.Drawing.Point(126, 547);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 20);
            this.label25.TabIndex = 132;
            this.label25.Text = "Ancho";
            // 
            // txtLargoC
            // 
            this.txtLargoC.AcceptsReturn = false;
            this.txtLargoC.AcceptsTab = false;
            this.txtLargoC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLargoC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLargoC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLargoC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLargoC.Depth = 0;
            this.txtLargoC.Hint = "";
            this.txtLargoC.Location = new System.Drawing.Point(586, 516);
            this.txtLargoC.MaxLength = 32767;
            this.txtLargoC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLargoC.Multiline = false;
            this.txtLargoC.Name = "txtLargoC";
            this.txtLargoC.PasswordChar = '\0';
            this.txtLargoC.ReadOnly = true;
            this.txtLargoC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLargoC.SelectedText = "";
            this.txtLargoC.SelectionLength = 0;
            this.txtLargoC.SelectionStart = 0;
            this.txtLargoC.Size = new System.Drawing.Size(72, 23);
            this.txtLargoC.TabIndex = 133;
            this.txtLargoC.TabStop = false;
            this.txtLargoC.Text = "0,00";
            this.txtLargoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLargoC.UseSystemPasswordChar = false;
            this.txtLargoC.WordWrap = true;
            this.txtLargoC.TextChanged += new System.EventHandler(this.txtValidar_TextChanged);
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label27.Location = new System.Drawing.Point(531, 517);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 20);
            this.label27.TabIndex = 134;
            this.label27.Text = "Largo";
            // 
            // txtDiametroC
            // 
            this.txtDiametroC.AcceptsReturn = false;
            this.txtDiametroC.AcceptsTab = false;
            this.txtDiametroC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDiametroC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDiametroC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDiametroC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDiametroC.Depth = 0;
            this.txtDiametroC.Hint = "";
            this.txtDiametroC.Location = new System.Drawing.Point(372, 514);
            this.txtDiametroC.MaxLength = 32767;
            this.txtDiametroC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDiametroC.Multiline = false;
            this.txtDiametroC.Name = "txtDiametroC";
            this.txtDiametroC.PasswordChar = '\0';
            this.txtDiametroC.ReadOnly = true;
            this.txtDiametroC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiametroC.SelectedText = "";
            this.txtDiametroC.SelectionLength = 0;
            this.txtDiametroC.SelectionStart = 0;
            this.txtDiametroC.Size = new System.Drawing.Size(72, 23);
            this.txtDiametroC.TabIndex = 135;
            this.txtDiametroC.TabStop = false;
            this.txtDiametroC.Text = "0,00";
            this.txtDiametroC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiametroC.UseSystemPasswordChar = false;
            this.txtDiametroC.WordWrap = true;
            this.txtDiametroC.TextChanged += new System.EventHandler(this.txtValidar_TextChanged);
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label28.Location = new System.Drawing.Point(299, 515);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 20);
            this.label28.TabIndex = 136;
            this.label28.Text = "Diametro";
            // 
            // txtVolumenC
            // 
            this.txtVolumenC.AcceptsReturn = false;
            this.txtVolumenC.AcceptsTab = false;
            this.txtVolumenC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVolumenC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtVolumenC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtVolumenC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtVolumenC.Depth = 0;
            this.txtVolumenC.Hint = "";
            this.txtVolumenC.Location = new System.Drawing.Point(586, 544);
            this.txtVolumenC.MaxLength = 32767;
            this.txtVolumenC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtVolumenC.Multiline = false;
            this.txtVolumenC.Name = "txtVolumenC";
            this.txtVolumenC.PasswordChar = '\0';
            this.txtVolumenC.ReadOnly = true;
            this.txtVolumenC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVolumenC.SelectedText = "";
            this.txtVolumenC.SelectionLength = 0;
            this.txtVolumenC.SelectionStart = 0;
            this.txtVolumenC.Size = new System.Drawing.Size(72, 23);
            this.txtVolumenC.TabIndex = 139;
            this.txtVolumenC.TabStop = false;
            this.txtVolumenC.Text = "0,00";
            this.txtVolumenC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVolumenC.UseSystemPasswordChar = false;
            this.txtVolumenC.WordWrap = true;
            this.txtVolumenC.TextChanged += new System.EventHandler(this.txtValidar_TextChanged);
            // 
            // txtPesoC
            // 
            this.txtPesoC.AcceptsReturn = false;
            this.txtPesoC.AcceptsTab = false;
            this.txtPesoC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPesoC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPesoC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPesoC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPesoC.Depth = 0;
            this.txtPesoC.Hint = "";
            this.txtPesoC.Location = new System.Drawing.Point(372, 546);
            this.txtPesoC.MaxLength = 32767;
            this.txtPesoC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesoC.Multiline = false;
            this.txtPesoC.Name = "txtPesoC";
            this.txtPesoC.PasswordChar = '\0';
            this.txtPesoC.ReadOnly = true;
            this.txtPesoC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesoC.SelectedText = "";
            this.txtPesoC.SelectionLength = 0;
            this.txtPesoC.SelectionStart = 0;
            this.txtPesoC.Size = new System.Drawing.Size(72, 23);
            this.txtPesoC.TabIndex = 137;
            this.txtPesoC.TabStop = false;
            this.txtPesoC.Text = "0,00";
            this.txtPesoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPesoC.UseSystemPasswordChar = false;
            this.txtPesoC.WordWrap = true;
            this.txtPesoC.TextChanged += new System.EventHandler(this.txtValidar_TextChanged);
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label29.Location = new System.Drawing.Point(304, 547);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(62, 20);
            this.label29.TabIndex = 138;
            this.label29.Text = "Peso(Kg)";
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label33.Location = new System.Drawing.Point(111, 482);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(61, 20);
            this.label33.TabIndex = 127;
            this.label33.Text = "Nombre";
            // 
            // txtNombreC
            // 
            this.txtNombreC.AcceptsReturn = false;
            this.txtNombreC.AcceptsTab = false;
            this.txtNombreC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNombreC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombreC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreC.Depth = 0;
            this.txtNombreC.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreC.Hint = "";
            this.txtNombreC.Location = new System.Drawing.Point(179, 481);
            this.txtNombreC.MaxLength = 32767;
            this.txtNombreC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreC.Multiline = false;
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.PasswordChar = '\0';
            this.txtNombreC.ReadOnly = false;
            this.txtNombreC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreC.SelectedText = "";
            this.txtNombreC.SelectionLength = 0;
            this.txtNombreC.SelectionStart = 0;
            this.txtNombreC.Size = new System.Drawing.Size(508, 23);
            this.txtNombreC.TabIndex = 128;
            this.txtNombreC.TabStop = false;
            this.txtNombreC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreC.UseSystemPasswordChar = false;
            this.txtNombreC.WordWrap = true;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label34.Location = new System.Drawing.Point(119, 424);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(53, 20);
            this.label34.TabIndex = 125;
            this.label34.Text = "Codigo";
            // 
            // txtCodigoC
            // 
            this.txtCodigoC.AcceptsReturn = false;
            this.txtCodigoC.AcceptsTab = false;
            this.txtCodigoC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCodigoC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCodigoC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCodigoC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodigoC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigoC.Depth = 0;
            this.txtCodigoC.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoC.Hint = "";
            this.txtCodigoC.Location = new System.Drawing.Point(179, 423);
            this.txtCodigoC.MaxLength = 32767;
            this.txtCodigoC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigoC.Multiline = false;
            this.txtCodigoC.Name = "txtCodigoC";
            this.txtCodigoC.PasswordChar = '\0';
            this.txtCodigoC.ReadOnly = false;
            this.txtCodigoC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoC.SelectedText = "";
            this.txtCodigoC.SelectionLength = 0;
            this.txtCodigoC.SelectionStart = 0;
            this.txtCodigoC.Size = new System.Drawing.Size(206, 23);
            this.txtCodigoC.TabIndex = 126;
            this.txtCodigoC.TabStop = false;
            this.txtCodigoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoC.UseSystemPasswordChar = false;
            this.txtCodigoC.WordWrap = true;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label35.Location = new System.Drawing.Point(90, 453);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(82, 20);
            this.label35.TabIndex = 123;
            this.label35.Text = "Descripcion";
            // 
            // dgvListaItems
            // 
            this.dgvListaItems.AllowUserToAddRows = false;
            this.dgvListaItems.AllowUserToDeleteRows = false;
            this.dgvListaItems.AllowUserToOrderColumns = true;
            this.dgvListaItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dgvListaItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListaItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvListaItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaItems.EnableHeadersVisualStyles = false;
            this.dgvListaItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvListaItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListaItems.Location = new System.Drawing.Point(18, 47);
            this.dgvListaItems.MultiSelect = false;
            this.dgvListaItems.Name = "dgvListaItems";
            this.dgvListaItems.ReadOnly = true;
            this.dgvListaItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaItems.RowHeadersVisible = false;
            this.dgvListaItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaItems.Size = new System.Drawing.Size(1076, 350);
            this.dgvListaItems.TabIndex = 121;
            this.dgvListaItems.SelectionChanged += new System.EventHandler(this.dgvListaItems_SelectionChanged);
            this.dgvListaItems.DoubleClick += new System.EventHandler(this.dgvListaItems_DoubleClick);
            // 
            // txtDescripcionC
            // 
            this.txtDescripcionC.AcceptsReturn = false;
            this.txtDescripcionC.AcceptsTab = false;
            this.txtDescripcionC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescripcionC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescripcionC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescripcionC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescripcionC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescripcionC.Depth = 0;
            this.txtDescripcionC.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionC.Hint = "";
            this.txtDescripcionC.Location = new System.Drawing.Point(179, 452);
            this.txtDescripcionC.MaxLength = 32767;
            this.txtDescripcionC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcionC.Multiline = false;
            this.txtDescripcionC.Name = "txtDescripcionC";
            this.txtDescripcionC.PasswordChar = '\0';
            this.txtDescripcionC.ReadOnly = false;
            this.txtDescripcionC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcionC.SelectedText = "";
            this.txtDescripcionC.SelectionLength = 0;
            this.txtDescripcionC.SelectionStart = 0;
            this.txtDescripcionC.Size = new System.Drawing.Size(507, 23);
            this.txtDescripcionC.TabIndex = 124;
            this.txtDescripcionC.TabStop = false;
            this.txtDescripcionC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcionC.UseSystemPasswordChar = false;
            this.txtDescripcionC.WordWrap = true;
            // 
            // label45
            // 
            this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label45.BackColor = System.Drawing.Color.LightGray;
            this.label45.Location = new System.Drawing.Point(716, 404);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(236, 176);
            this.label45.TabIndex = 150;
            // 
            // FrmBusquedaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 691);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.formHeader2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBusquedaItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBusquedaItem";
            this.Load += new System.EventHandler(this.FrmBusquedaItem_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private Controls.LabelNoMouse labelNoMouse3;
        private MaterialSkin.Controls.MaterialFlatButton btnCerrar;
        private FormHeader formHeader2;
        private System.Windows.Forms.Panel panel2;
        private Controls.LabelNoMouse labelNoMouse1;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label23;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEspesorC;
        private System.Windows.Forms.Label label24;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAnchoC;
        private System.Windows.Forms.Label label25;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLargoC;
        private System.Windows.Forms.Label label27;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDiametroC;
        private System.Windows.Forms.Label label28;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtVolumenC;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesoC;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label33;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreC;
        private System.Windows.Forms.Label label34;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoC;
        private System.Windows.Forms.Label label35;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcionC;
        private System.Windows.Forms.PictureBox pictureBox8;
        private MetroFramework.Controls.MetroGrid dgvListaItems;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBusqueda;
        private MetroFramework.Controls.MetroComboBox cmbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label45;
    }
}