namespace PresentationLayer.Forms
{
    partial class FrmCotizador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFonoCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFono = new System.Windows.Forms.Label();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtVendedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumCot = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtECotizante = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComent = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.dgvColaCot = new MetroFramework.Controls.MetroGrid();
            this.ItemC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamiliaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBuscarItem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvNewCot = new MetroFramework.Controls.MetroGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNeto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnPdf = new System.Windows.Forms.Button();
            this.formHeader1 = new PresentationLayer.FormHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIVA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNetoIva = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblIva = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaCot)).BeginInit();
            this.metroTabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewCot)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Location = new System.Drawing.Point(32, 55);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1105, 431);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.AutoScroll = true;
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.HorizontalScrollbar = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1097, 389);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "En cola";
            this.metroTabPage1.VerticalScrollbar = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.txtFonoCliente);
            this.groupBox1.Controls.Add(this.lblFono);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtVendedor);
            this.groupBox1.Controls.Add(this.txtNumCot);
            this.groupBox1.Controls.Add(this.txtECotizante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtComent);
            this.groupBox1.Controls.Add(this.lblCorreo);
            this.groupBox1.Controls.Add(this.lblEmpresa);
            this.groupBox1.Controls.Add(this.lblCotizacion);
            this.groupBox1.Controls.Add(this.pictureBox11);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.lblVendedor);
            this.groupBox1.Controls.Add(this.dgvColaCot);
            this.groupBox1.Location = new System.Drawing.Point(2, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1092, 446);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // txtFonoCliente
            // 
            this.txtFonoCliente.AcceptsReturn = false;
            this.txtFonoCliente.AcceptsTab = false;
            this.txtFonoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFonoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFonoCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFonoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFonoCliente.Depth = 0;
            this.txtFonoCliente.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFonoCliente.Hint = "";
            this.txtFonoCliente.Location = new System.Drawing.Point(456, 95);
            this.txtFonoCliente.MaxLength = 32767;
            this.txtFonoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFonoCliente.Multiline = false;
            this.txtFonoCliente.Name = "txtFonoCliente";
            this.txtFonoCliente.PasswordChar = '\0';
            this.txtFonoCliente.ReadOnly = false;
            this.txtFonoCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFonoCliente.SelectedText = "";
            this.txtFonoCliente.SelectionLength = 0;
            this.txtFonoCliente.SelectionStart = 0;
            this.txtFonoCliente.Size = new System.Drawing.Size(150, 23);
            this.txtFonoCliente.TabIndex = 154;
            this.txtFonoCliente.TabStop = false;
            this.txtFonoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFonoCliente.UseSystemPasswordChar = false;
            this.txtFonoCliente.WordWrap = true;
            // 
            // lblFono
            // 
            this.lblFono.AutoSize = true;
            this.lblFono.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.lblFono.Location = new System.Drawing.Point(359, 98);
            this.lblFono.Name = "lblFono";
            this.lblFono.Size = new System.Drawing.Size(65, 20);
            this.lblFono.TabIndex = 153;
            this.lblFono.Text = "Teléfono:";
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = false;
            this.txtEmail.AcceptsTab = false;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(456, 59);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ReadOnly = false;
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(150, 23);
            this.txtEmail.TabIndex = 152;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.WordWrap = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.lblEmail.Location = new System.Drawing.Point(341, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(98, 20);
            this.lblEmail.TabIndex = 151;
            this.lblEmail.Text = "E-mail Cliente:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(678, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 150;
            // 
            // txtVendedor
            // 
            this.txtVendedor.AcceptsReturn = false;
            this.txtVendedor.AcceptsTab = false;
            this.txtVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtVendedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtVendedor.Depth = 0;
            this.txtVendedor.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.Hint = "";
            this.txtVendedor.Location = new System.Drawing.Point(114, 59);
            this.txtVendedor.MaxLength = 32767;
            this.txtVendedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtVendedor.Multiline = false;
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.PasswordChar = '\0';
            this.txtVendedor.ReadOnly = false;
            this.txtVendedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVendedor.SelectedText = "";
            this.txtVendedor.SelectionLength = 0;
            this.txtVendedor.SelectionStart = 0;
            this.txtVendedor.Size = new System.Drawing.Size(193, 23);
            this.txtVendedor.TabIndex = 149;
            this.txtVendedor.TabStop = false;
            this.txtVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVendedor.UseSystemPasswordChar = false;
            this.txtVendedor.WordWrap = true;
            // 
            // txtNumCot
            // 
            this.txtNumCot.AcceptsReturn = false;
            this.txtNumCot.AcceptsTab = false;
            this.txtNumCot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNumCot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNumCot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNumCot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumCot.Depth = 0;
            this.txtNumCot.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCot.Hint = "";
            this.txtNumCot.Location = new System.Drawing.Point(114, 20);
            this.txtNumCot.MaxLength = 32767;
            this.txtNumCot.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumCot.Multiline = false;
            this.txtNumCot.Name = "txtNumCot";
            this.txtNumCot.PasswordChar = '\0';
            this.txtNumCot.ReadOnly = false;
            this.txtNumCot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumCot.SelectedText = "";
            this.txtNumCot.SelectionLength = 0;
            this.txtNumCot.SelectionStart = 0;
            this.txtNumCot.Size = new System.Drawing.Size(150, 23);
            this.txtNumCot.TabIndex = 148;
            this.txtNumCot.TabStop = false;
            this.txtNumCot.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumCot.UseSystemPasswordChar = false;
            this.txtNumCot.WordWrap = true;
            // 
            // txtECotizante
            // 
            this.txtECotizante.AcceptsReturn = false;
            this.txtECotizante.AcceptsTab = false;
            this.txtECotizante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtECotizante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtECotizante.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtECotizante.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtECotizante.Depth = 0;
            this.txtECotizante.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtECotizante.Hint = "";
            this.txtECotizante.Location = new System.Drawing.Point(445, 27);
            this.txtECotizante.MaxLength = 32767;
            this.txtECotizante.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtECotizante.Multiline = false;
            this.txtECotizante.Name = "txtECotizante";
            this.txtECotizante.PasswordChar = '\0';
            this.txtECotizante.ReadOnly = false;
            this.txtECotizante.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtECotizante.SelectedText = "";
            this.txtECotizante.SelectionLength = 0;
            this.txtECotizante.SelectionStart = 0;
            this.txtECotizante.Size = new System.Drawing.Size(190, 23);
            this.txtECotizante.TabIndex = 147;
            this.txtECotizante.TabStop = false;
            this.txtECotizante.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtECotizante.UseSystemPasswordChar = false;
            this.txtECotizante.WordWrap = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 146;
            this.label3.Text = "Representante:";
            // 
            // txtComent
            // 
            this.txtComent.AcceptsReturn = false;
            this.txtComent.AcceptsTab = false;
            this.txtComent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtComent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtComent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtComent.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtComent.Depth = 0;
            this.txtComent.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComent.Hint = "";
            this.txtComent.Location = new System.Drawing.Point(115, 98);
            this.txtComent.MaxLength = 32767;
            this.txtComent.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComent.Multiline = false;
            this.txtComent.Name = "txtComent";
            this.txtComent.PasswordChar = '\0';
            this.txtComent.ReadOnly = false;
            this.txtComent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComent.SelectedText = "";
            this.txtComent.SelectionLength = 0;
            this.txtComent.SelectionStart = 0;
            this.txtComent.Size = new System.Drawing.Size(150, 23);
            this.txtComent.TabIndex = 145;
            this.txtComent.TabStop = false;
            this.txtComent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComent.UseSystemPasswordChar = false;
            this.txtComent.WordWrap = true;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.lblCorreo.Location = new System.Drawing.Point(18, 101);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(90, 20);
            this.lblCorreo.TabIndex = 130;
            this.lblCorreo.Text = "Comentarios:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.lblEmpresa.Location = new System.Drawing.Point(311, 27);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(128, 20);
            this.lblEmpresa.TabIndex = 128;
            this.lblEmpresa.Text = "Empresa Cotizante:";
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.lblCotizacion.Location = new System.Drawing.Point(14, 20);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(94, 20);
            this.lblCotizacion.TabIndex = 126;
            this.lblCotizacion.Text = "Cotización n°:";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = global::PresentationLayer.Properties.Resources.blocked_sign;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(1027, 20);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(27, 27);
            this.pictureBox11.TabIndex = 125;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::PresentationLayer.Properties.Resources.plus_symbol_round_button;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Enabled = false;
            this.pictureBox9.Location = new System.Drawing.Point(994, 20);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(27, 27);
            this.pictureBox9.TabIndex = 124;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.lblVendedor.Location = new System.Drawing.Point(142, 20);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(0, 20);
            this.lblVendedor.TabIndex = 100;
            // 
            // dgvColaCot
            // 
            this.dgvColaCot.AllowUserToAddRows = false;
            this.dgvColaCot.AllowUserToDeleteRows = false;
            this.dgvColaCot.AllowUserToOrderColumns = true;
            this.dgvColaCot.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dgvColaCot.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColaCot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvColaCot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvColaCot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvColaCot.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvColaCot.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColaCot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColaCot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaCot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemC,
            this.CodigoC,
            this.DetalleC,
            this.FamiliaC,
            this.CantC,
            this.PrecioC,
            this.TotalC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColaCot.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvColaCot.EnableHeadersVisualStyles = false;
            this.dgvColaCot.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvColaCot.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvColaCot.Location = new System.Drawing.Point(22, 147);
            this.dgvColaCot.MultiSelect = false;
            this.dgvColaCot.Name = "dgvColaCot";
            this.dgvColaCot.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColaCot.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvColaCot.RowHeadersVisible = false;
            this.dgvColaCot.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvColaCot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColaCot.Size = new System.Drawing.Size(1048, 238);
            this.dgvColaCot.TabIndex = 58;
            this.dgvColaCot.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColaCot_CellEndEdit);
            // 
            // ItemC
            // 
            this.ItemC.HeaderText = "Item";
            this.ItemC.Name = "ItemC";
            // 
            // CodigoC
            // 
            this.CodigoC.HeaderText = "Codigo";
            this.CodigoC.Name = "CodigoC";
            // 
            // DetalleC
            // 
            this.DetalleC.HeaderText = "Detalle";
            this.DetalleC.Name = "DetalleC";
            // 
            // FamiliaC
            // 
            this.FamiliaC.HeaderText = "Familia";
            this.FamiliaC.Name = "FamiliaC";
            // 
            // CantC
            // 
            this.CantC.HeaderText = "Cant";
            this.CantC.Name = "CantC";
            // 
            // PrecioC
            // 
            this.PrecioC.HeaderText = "Precio Unitario";
            this.PrecioC.Name = "PrecioC";
            // 
            // TotalC
            // 
            this.TotalC.HeaderText = "Total";
            this.TotalC.Name = "TotalC";
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.groupBox6);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1097, 389);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "   Nueva Cotización   ";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Controls.Add(this.pictureBox4);
            this.groupBox6.Controls.Add(this.metroComboBox1);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.pictureBox8);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.txtBuscarItem);
            this.groupBox6.Controls.Add(this.dgvNewCot);
            this.groupBox6.Location = new System.Drawing.Point(2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1092, 391);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::PresentationLayer.Properties.Resources.refresh__1_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(390, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 27);
            this.pictureBox4.TabIndex = 109;
            this.pictureBox4.TabStop = false;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(481, 17);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(299, 29);
            this.metroComboBox1.TabIndex = 104;
            this.metroComboBox1.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label6.Location = new System.Drawing.Point(428, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 103;
            this.label6.Text = "Familia";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::PresentationLayer.Properties.Resources.magnifying_glass;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(357, 17);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 27);
            this.pictureBox8.TabIndex = 102;
            this.pictureBox8.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label22.Location = new System.Drawing.Point(18, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(139, 20);
            this.label22.TabIndex = 100;
            this.label22.Text = "Codigo / Descripcion";
            // 
            // txtBuscarItem
            // 
            this.txtBuscarItem.AcceptsReturn = false;
            this.txtBuscarItem.AcceptsTab = false;
            this.txtBuscarItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscarItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscarItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBuscarItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscarItem.Depth = 0;
            this.txtBuscarItem.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarItem.Hint = "";
            this.txtBuscarItem.Location = new System.Drawing.Point(160, 18);
            this.txtBuscarItem.MaxLength = 32767;
            this.txtBuscarItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarItem.Multiline = false;
            this.txtBuscarItem.Name = "txtBuscarItem";
            this.txtBuscarItem.PasswordChar = '\0';
            this.txtBuscarItem.ReadOnly = false;
            this.txtBuscarItem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarItem.SelectedText = "";
            this.txtBuscarItem.SelectionLength = 0;
            this.txtBuscarItem.SelectionStart = 0;
            this.txtBuscarItem.Size = new System.Drawing.Size(190, 23);
            this.txtBuscarItem.TabIndex = 101;
            this.txtBuscarItem.TabStop = false;
            this.txtBuscarItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscarItem.UseSystemPasswordChar = false;
            this.txtBuscarItem.WordWrap = true;
            // 
            // dgvNewCot
            // 
            this.dgvNewCot.AllowUserToAddRows = false;
            this.dgvNewCot.AllowUserToDeleteRows = false;
            this.dgvNewCot.AllowUserToOrderColumns = true;
            this.dgvNewCot.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dgvNewCot.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNewCot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNewCot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvNewCot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNewCot.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvNewCot.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNewCot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNewCot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNewCot.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNewCot.EnableHeadersVisualStyles = false;
            this.dgvNewCot.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvNewCot.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvNewCot.Location = new System.Drawing.Point(20, 60);
            this.dgvNewCot.MultiSelect = false;
            this.dgvNewCot.Name = "dgvNewCot";
            this.dgvNewCot.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNewCot.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNewCot.RowHeadersVisible = false;
            this.dgvNewCot.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNewCot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNewCot.Size = new System.Drawing.Size(1048, 276);
            this.dgvNewCot.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label1.Location = new System.Drawing.Point(434, 729);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 111;
            this.label1.Text = "Neto:";
            // 
            // txtNeto
            // 
            this.txtNeto.AcceptsReturn = false;
            this.txtNeto.AcceptsTab = false;
            this.txtNeto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNeto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNeto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNeto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNeto.Depth = 0;
            this.txtNeto.Hint = "";
            this.txtNeto.Location = new System.Drawing.Point(483, 726);
            this.txtNeto.MaxLength = 32767;
            this.txtNeto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNeto.Multiline = false;
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.PasswordChar = '\0';
            this.txtNeto.ReadOnly = false;
            this.txtNeto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNeto.SelectedText = "";
            this.txtNeto.SelectionLength = 0;
            this.txtNeto.SelectionStart = 0;
            this.txtNeto.Size = new System.Drawing.Size(113, 23);
            this.txtNeto.TabIndex = 110;
            this.txtNeto.TabStop = false;
            this.txtNeto.Text = "0,00";
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNeto.UseSystemPasswordChar = false;
            this.txtNeto.WordWrap = true;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPdf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPdf.Location = new System.Drawing.Point(100, 707);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(107, 32);
            this.btnPdf.TabIndex = 112;
            this.btnPdf.Text = "Descargar";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // formHeader1
            // 
            this.formHeader1.BackColor = System.Drawing.Color.Transparent;
            this.formHeader1.ControlBoxBackColor = System.Drawing.Color.Transparent;
            this.formHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formHeader1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.formHeader1.HeaderText = "Cotizador";
            this.formHeader1.Location = new System.Drawing.Point(0, 0);
            this.formHeader1.Name = "formHeader1";
            this.formHeader1.ParentContainer = null;
            this.formHeader1.Size = new System.Drawing.Size(1170, 49);
            this.formHeader1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label2.Location = new System.Drawing.Point(626, 732);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 114;
            this.label2.Text = "IVA:";
            // 
            // txtIVA
            // 
            this.txtIVA.AcceptsReturn = false;
            this.txtIVA.AcceptsTab = false;
            this.txtIVA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIVA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIVA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtIVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIVA.Depth = 0;
            this.txtIVA.Hint = "";
            this.txtIVA.Location = new System.Drawing.Point(664, 726);
            this.txtIVA.MaxLength = 32767;
            this.txtIVA.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIVA.Multiline = false;
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.PasswordChar = '\0';
            this.txtIVA.ReadOnly = false;
            this.txtIVA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIVA.SelectedText = "";
            this.txtIVA.SelectionLength = 0;
            this.txtIVA.SelectionStart = 0;
            this.txtIVA.Size = new System.Drawing.Size(113, 23);
            this.txtIVA.TabIndex = 113;
            this.txtIVA.TabStop = false;
            this.txtIVA.Text = "0,00";
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIVA.UseSystemPasswordChar = false;
            this.txtIVA.WordWrap = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label4.Location = new System.Drawing.Point(826, 729);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 116;
            this.label4.Text = "Neto + IVA:";
            // 
            // txtNetoIva
            // 
            this.txtNetoIva.AcceptsReturn = false;
            this.txtNetoIva.AcceptsTab = false;
            this.txtNetoIva.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNetoIva.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNetoIva.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNetoIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNetoIva.Depth = 0;
            this.txtNetoIva.Hint = "";
            this.txtNetoIva.Location = new System.Drawing.Point(913, 726);
            this.txtNetoIva.MaxLength = 32767;
            this.txtNetoIva.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNetoIva.Multiline = false;
            this.txtNetoIva.Name = "txtNetoIva";
            this.txtNetoIva.PasswordChar = '\0';
            this.txtNetoIva.ReadOnly = false;
            this.txtNetoIva.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNetoIva.SelectedText = "";
            this.txtNetoIva.SelectionLength = 0;
            this.txtNetoIva.SelectionStart = 0;
            this.txtNetoIva.Size = new System.Drawing.Size(113, 23);
            this.txtNetoIva.TabIndex = 115;
            this.txtNetoIva.TabStop = false;
            this.txtNetoIva.Text = "0,00";
            this.txtNetoIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNetoIva.UseSystemPasswordChar = false;
            this.txtNetoIva.WordWrap = true;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.BackColor = System.Drawing.Color.Transparent;
            this.lblIva.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.lblIva.Location = new System.Drawing.Point(1115, 707);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(33, 20);
            this.lblIva.TabIndex = 117;
            this.lblIva.Text = "0,19";
            this.lblIva.Visible = false;
            // 
            // FrmCotizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1170, 773);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNetoIva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.formHeader1);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCotizador";
            this.Text = "FrmCotizador";
            this.Load += new System.EventHandler(this.FrmCotizador_Load);
            this.Shown += new System.EventHandler(this.FrmCotizador_Shown);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaCot)).EndInit();
            this.metroTabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewCot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormHeader formHeader1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNeto;
        private System.Windows.Forms.Label lblVendedor;
        private MetroFramework.Controls.MetroGrid dgvColaCot;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label22;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarItem;
        private MetroFramework.Controls.MetroGrid dgvNewCot;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblCotizacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumCot;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtECotizante;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComent;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtVendedor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIVA;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNetoIva;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamiliaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalC;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFonoCliente;
        private System.Windows.Forms.Label lblFono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}