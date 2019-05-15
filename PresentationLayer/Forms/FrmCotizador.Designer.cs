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
            this.txtNumCot = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtECotizante = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
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
            this.PrecioC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantC = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.metroTabControl1.Size = new System.Drawing.Size(1105, 568);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1097, 526);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "      En Cola     ";
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
            this.groupBox1.Controls.Add(this.txtNumCot);
            this.groupBox1.Controls.Add(this.txtECotizante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblCorreo);
            this.groupBox1.Controls.Add(this.lblEmpresa);
            this.groupBox1.Controls.Add(this.lblCotizacion);
            this.groupBox1.Controls.Add(this.pictureBox11);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.lblVendedor);
            this.groupBox1.Controls.Add(this.dgvColaCot);
            this.groupBox1.Location = new System.Drawing.Point(2, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1092, 585);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
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
            this.txtNumCot.Location = new System.Drawing.Point(445, 20);
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
            this.txtECotizante.Location = new System.Drawing.Point(152, 63);
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
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 146;
            this.label3.Text = "Vendedor:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AcceptsReturn = false;
            this.txtCorreo.AcceptsTab = false;
            this.txtCorreo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCorreo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCorreo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Hint = "";
            this.txtCorreo.Location = new System.Drawing.Point(445, 60);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.ReadOnly = false;
            this.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.Size = new System.Drawing.Size(150, 23);
            this.txtCorreo.TabIndex = 145;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.UseSystemPasswordChar = false;
            this.txtCorreo.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label2.Location = new System.Drawing.Point(622, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 132;
            this.label2.Text = "Fecha:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.lblCorreo.Location = new System.Drawing.Point(384, 63);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(55, 20);
            this.lblCorreo.TabIndex = 130;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.lblEmpresa.Location = new System.Drawing.Point(18, 63);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(128, 20);
            this.lblEmpresa.TabIndex = 128;
            this.lblEmpresa.Text = "Empresa Cotizante:";
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.lblCotizacion.Location = new System.Drawing.Point(345, 20);
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
            this.PrecioC,
            this.CantC,
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
            this.dgvColaCot.Location = new System.Drawing.Point(22, 111);
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
            this.dgvColaCot.Size = new System.Drawing.Size(1048, 413);
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
            // PrecioC
            // 
            this.PrecioC.HeaderText = "Precio Unitario";
            this.PrecioC.Name = "PrecioC";
            // 
            // CantC
            // 
            this.CantC.HeaderText = "Cantidad";
            this.CantC.Name = "CantC";
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
            this.metroTabPage4.Size = new System.Drawing.Size(1097, 526);
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
            this.groupBox6.Size = new System.Drawing.Size(1092, 528);
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
            this.dgvNewCot.Size = new System.Drawing.Size(1048, 413);
            this.dgvNewCot.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label1.Location = new System.Drawing.Point(811, 721);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 111;
            this.label1.Text = "Neto";
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
            this.txtNeto.Location = new System.Drawing.Point(857, 718);
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
            this.btnPdf.Location = new System.Drawing.Point(370, 709);
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
            // FrmCotizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1170, 773);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamiliaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalC;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumCot;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtECotizante;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
    }
}