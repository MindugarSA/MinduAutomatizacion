namespace PresentationLayer
{
    partial class FrmFamilia
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFamilia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescrpcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelNoMouse3 = new PresentationLayer.Controls.LabelNoMouse();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNoMouse2 = new PresentationLayer.Controls.LabelNoMouse();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelNoMouse1 = new PresentationLayer.Controls.LabelNoMouse();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.formHeader2 = new PresentationLayer.FormHeader();
            this.dragControl1 = new PresentationLayer.DragControl();
            this.dragControl2 = new PresentationLayer.DragControl();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuTransition1.SetDecoration(this.metroGrid1, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(20, 26);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(706, 329);
            this.metroGrid1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroGrid1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtResponsable);
            this.groupBox1.Controls.Add(this.materialCheckBox1);
            this.groupBox1.Controls.Add(this.metroComboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescrpcion);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.bunifuTransition1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(20, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 490);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PresentationLayer.Properties.Resources.plus_sign_in_a_black_circle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(531, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.PopUp_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PopUp_MouseLeave);
            // 
            // txtResponsable
            // 
            this.txtResponsable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(158)))));
            this.txtResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.txtResponsable, BunifuAnimatorNS.DecorationType.None);
            this.txtResponsable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.ForeColor = System.Drawing.Color.White;
            this.txtResponsable.Location = new System.Drawing.Point(20, 363);
            this.txtResponsable.Margin = new System.Windows.Forms.Padding(0);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.ReadOnly = true;
            this.txtResponsable.Size = new System.Drawing.Size(706, 22);
            this.txtResponsable.TabIndex = 30;
            this.txtResponsable.TabStop = false;
            this.txtResponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.materialCheckBox1, BunifuAnimatorNS.DecorationType.None);
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(689, 399);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(26, 30);
            this.materialCheckBox1.TabIndex = 36;
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.metroComboBox2, BunifuAnimatorNS.DecorationType.None);
            this.metroComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Nuevo",
            "Usado",
            "Baja"});
            this.metroComboBox2.Location = new System.Drawing.Point(370, 400);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(156, 29);
            this.metroComboBox2.TabIndex = 41;
            this.metroComboBox2.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Codigo Familia";
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
            this.bunifuTransition1.SetDecoration(this.txtDescrpcion, BunifuAnimatorNS.DecorationType.None);
            this.txtDescrpcion.Depth = 0;
            this.txtDescrpcion.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrpcion.Hint = "";
            this.txtDescrpcion.Location = new System.Drawing.Point(127, 438);
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
            this.txtDescrpcion.Size = new System.Drawing.Size(586, 23);
            this.txtDescrpcion.TabIndex = 34;
            this.txtDescrpcion.TabStop = false;
            this.txtDescrpcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescrpcion.UseSystemPasswordChar = false;
            this.txtDescrpcion.WordWrap = true;
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
            this.bunifuTransition1.SetDecoration(this.txtCodigo, BunifuAnimatorNS.DecorationType.None);
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Hint = "";
            this.txtCodigo.Location = new System.Drawing.Point(132, 403);
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
            this.txtCodigo.Size = new System.Drawing.Size(220, 23);
            this.txtCodigo.TabIndex = 32;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigo.UseSystemPasswordChar = false;
            this.txtCodigo.WordWrap = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(650, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Activo";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.labelNoMouse3);
            this.panel4.Controls.Add(this.materialFlatButton3);
            this.bunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(652, 541);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(111, 34);
            this.panel4.TabIndex = 40;
            this.panel4.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // labelNoMouse3
            // 
            this.labelNoMouse3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.labelNoMouse3, BunifuAnimatorNS.DecorationType.None);
            this.labelNoMouse3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoMouse3.ForeColor = System.Drawing.Color.White;
            this.labelNoMouse3.Location = new System.Drawing.Point(28, 7);
            this.labelNoMouse3.Name = "labelNoMouse3";
            this.labelNoMouse3.Size = new System.Drawing.Size(52, 20);
            this.labelNoMouse3.TabIndex = 1;
            this.labelNoMouse3.Text = "Cerrar";
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.materialFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialFlatButton3.ForeColor = System.Drawing.Color.White;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(111, 34);
            this.materialFlatButton3.TabIndex = 0;
            this.materialFlatButton3.UseCompatibleTextRendering = true;
            this.materialFlatButton3.UseVisualStyleBackColor = false;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            this.materialFlatButton3.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.materialFlatButton3.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.labelNoMouse2);
            this.panel3.Controls.Add(this.materialFlatButton2);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(138, 541);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 34);
            this.panel3.TabIndex = 39;
            this.panel3.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // labelNoMouse2
            // 
            this.labelNoMouse2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.labelNoMouse2, BunifuAnimatorNS.DecorationType.None);
            this.labelNoMouse2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoMouse2.ForeColor = System.Drawing.Color.White;
            this.labelNoMouse2.Location = new System.Drawing.Point(28, 7);
            this.labelNoMouse2.Name = "labelNoMouse2";
            this.labelNoMouse2.Size = new System.Drawing.Size(55, 20);
            this.labelNoMouse2.TabIndex = 1;
            this.labelNoMouse2.Text = "Nuevo";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.materialFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialFlatButton2.ForeColor = System.Drawing.Color.White;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(111, 34);
            this.materialFlatButton2.TabIndex = 0;
            this.materialFlatButton2.UseCompatibleTextRendering = true;
            this.materialFlatButton2.UseVisualStyleBackColor = false;
            this.materialFlatButton2.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.materialFlatButton2.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.labelNoMouse1);
            this.panel2.Controls.Add(this.materialFlatButton1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(17, 541);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 34);
            this.panel2.TabIndex = 38;
            this.panel2.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // labelNoMouse1
            // 
            this.labelNoMouse1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.labelNoMouse1, BunifuAnimatorNS.DecorationType.None);
            this.labelNoMouse1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoMouse1.ForeColor = System.Drawing.Color.White;
            this.labelNoMouse1.Location = new System.Drawing.Point(16, 7);
            this.labelNoMouse1.Name = "labelNoMouse1";
            this.labelNoMouse1.Size = new System.Drawing.Size(77, 20);
            this.labelNoMouse1.TabIndex = 1;
            this.labelNoMouse1.Text = "Actualizar";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.materialFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialFlatButton1.ForeColor = System.Drawing.Color.White;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(111, 34);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.UseCompatibleTextRendering = true;
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            this.materialFlatButton1.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.materialFlatButton1.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // formHeader2
            // 
            this.formHeader2.BackColor = System.Drawing.Color.Transparent;
            this.formHeader2.ControlBoxBackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.formHeader2, BunifuAnimatorNS.DecorationType.None);
            this.formHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.formHeader2.HeaderBackColor = System.Drawing.Color.Transparent;
            this.formHeader2.HeaderText = "Familia";
            this.formHeader2.Location = new System.Drawing.Point(0, 0);
            this.formHeader2.Name = "formHeader2";
            this.formHeader2.ParentContainer = null;
            this.formHeader2.Size = new System.Drawing.Size(783, 47);
            this.formHeader2.TabIndex = 9;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.formHeader2;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this;
            // 
            // FrmFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.formHeader2);
            this.Controls.Add(this.panel2);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFamilia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Familia";
            this.Load += new System.EventHandler(this.FrmFamilia_Load);
            this.Click += new System.EventHandler(this.FrmFamilia_Click);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescrpcion;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private System.Windows.Forms.TextBox txtResponsable;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Label label3;
        private FormHeader formHeader2;
        private Controls.LabelNoMouse labelNoMouse1;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private System.Windows.Forms.Panel panel4;
        private Controls.LabelNoMouse labelNoMouse3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.Panel panel3;
        private Controls.LabelNoMouse labelNoMouse2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}