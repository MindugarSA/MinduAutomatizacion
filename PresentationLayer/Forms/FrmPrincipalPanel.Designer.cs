namespace PresentationLayer
{
    partial class FrmPrincipalPanel
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalPanel));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tmrOcultarMenu = new System.Windows.Forms.Timer(this.components);
            this.tmrMostrarMenu = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.MetroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.formHeader1 = new PresentationLayer.FormHeader();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.DimGray;
            this.pnlMenu.Controls.Add(this.pictureBox5);
            this.pnlMenu.Controls.Add(this.button5);
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.panel4);
            this.pnlMenu.Controls.Add(this.panel6);
            this.pnlMenu.Controls.Add(this.button3);
            this.pnlMenu.Controls.Add(this.panel7);
            this.pnlMenu.Controls.Add(this.panel5);
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.pictureBox2);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.button1);
            this.BunifuTransition1.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlMenu.Location = new System.Drawing.Point(2, 31);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(203, 673);
            this.pnlMenu.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.BackgroundImage = global::PresentationLayer.Properties.Resources.clock_padlock;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuTransition1.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox5.Location = new System.Drawing.Point(6, 625);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Bloquear Sistema");
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseEnter += new System.EventHandler(this.PopUp_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.PopUp_MouseLeave);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.BunifuTransition1.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::PresentationLayer.Properties.Resources.tetris;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(10, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 35);
            this.button5.TabIndex = 11;
            this.button5.Text = "   Producto";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_ClickAsync);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.BunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(0, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(9, 35);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.button7);
            this.BunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(28, 332);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 177);
            this.panel4.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.BunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(36, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 35);
            this.panel2.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.BunifuTransition1.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(46, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "Costos";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.BunifuTransition1.SetDecoration(this.panel9, BunifuAnimatorNS.DecorationType.None);
            this.panel9.Location = new System.Drawing.Point(36, 92);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(9, 35);
            this.panel9.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.BunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(36, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(9, 35);
            this.panel1.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.BunifuTransition1.SetDecoration(this.button8, BunifuAnimatorNS.DecorationType.None);
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(46, 50);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 35);
            this.button8.TabIndex = 3;
            this.button8.Text = "Tipo";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.BunifuTransition1.SetDecoration(this.panel8, BunifuAnimatorNS.DecorationType.None);
            this.panel8.Location = new System.Drawing.Point(36, 50);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(9, 35);
            this.panel8.TabIndex = 9;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.BunifuTransition1.SetDecoration(this.button9, BunifuAnimatorNS.DecorationType.None);
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(46, 8);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(121, 35);
            this.button9.TabIndex = 0;
            this.button9.Text = "Familia";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.BunifuTransition1.SetDecoration(this.button7, BunifuAnimatorNS.DecorationType.None);
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(46, 92);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 35);
            this.button7.TabIndex = 4;
            this.button7.Text = "Propiedades";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.BunifuTransition1.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.panel6.Location = new System.Drawing.Point(0, 169);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(9, 35);
            this.panel6.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.BunifuTransition1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::PresentationLayer.Properties.Resources.equipment;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(10, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "   Kit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_ClickAsync);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.BunifuTransition1.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.panel7.Location = new System.Drawing.Point(0, 223);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(9, 35);
            this.panel7.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.BunifuTransition1.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Location = new System.Drawing.Point(0, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(9, 35);
            this.panel5.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.BunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::PresentationLayer.Properties.Resources.screw;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(10, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "    Parte";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_ClickAsync);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::PresentationLayer.Properties.Resources.line_menu;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(163, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 27);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PresentationLayer.Properties.Resources.Logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 56);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.BunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PresentationLayer.Properties.Resources.organization;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(11, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "      Configuracion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrOcultarMenu
            // 
            this.tmrOcultarMenu.Interval = 50;
            this.tmrOcultarMenu.Tick += new System.EventHandler(this.tmrOcultarMenu_Tick);
            // 
            // tmrMostrarMenu
            // 
            this.tmrMostrarMenu.Interval = 50;
            this.tmrMostrarMenu.Tick += new System.EventHandler(this.tmrMostrarMenu_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.BunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cargando Datos ...";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.MetroProgressSpinner1);
            this.panel10.Controls.Add(this.pictureBox4);
            this.panel10.Controls.Add(this.pictureBox3);
            this.panel10.Controls.Add(this.label1);
            this.BunifuTransition1.SetDecoration(this.panel10, BunifuAnimatorNS.DecorationType.None);
            this.panel10.Location = new System.Drawing.Point(204, 31);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(970, 670);
            this.panel10.TabIndex = 13;
            this.panel10.Resize += new System.EventHandler(this.panel10_Resize);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.BunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(639, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nombre Usuario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MetroProgressSpinner1
            // 
            this.BunifuTransition1.SetDecoration(this.MetroProgressSpinner1, BunifuAnimatorNS.DecorationType.None);
            this.MetroProgressSpinner1.Location = new System.Drawing.Point(263, 19);
            this.MetroProgressSpinner1.Maximum = 100;
            this.MetroProgressSpinner1.Name = "MetroProgressSpinner1";
            this.MetroProgressSpinner1.Size = new System.Drawing.Size(30, 30);
            this.MetroProgressSpinner1.Speed = 6F;
            this.MetroProgressSpinner1.TabIndex = 21;
            this.MetroProgressSpinner1.UseSelectable = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuTransition1.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Location = new System.Drawing.Point(395, 270);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(203, 200);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.PopUp_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.PopUp_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuTransition1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Location = new System.Drawing.Point(666, 578);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(292, 80);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // BunifuTransition1
            // 
            this.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.BunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.BunifuTransition1.DefaultAnimation = animation1;
            this.BunifuTransition1.Interval = 40;
            this.BunifuTransition1.MaxAnimationTime = 3000;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.BunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sistema Automatizacion";
            // 
            // formHeader1
            // 
            this.formHeader1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formHeader1.BackColor = System.Drawing.Color.Transparent;
            this.formHeader1.ControlBoxBackColor = System.Drawing.SystemColors.Control;
            this.BunifuTransition1.SetDecoration(this.formHeader1, BunifuAnimatorNS.DecorationType.None);
            this.formHeader1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.formHeader1.HeaderText = "";
            this.formHeader1.Location = new System.Drawing.Point(0, 1);
            this.formHeader1.Name = "formHeader1";
            this.formHeader1.ParentContainer = null;
            this.formHeader1.Size = new System.Drawing.Size(1174, 30);
            this.formHeader1.TabIndex = 5;
            // 
            // FrmPrincipalPanel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 701);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.formHeader1);
            this.BunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipalPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.toolTip1.SetToolTip(this, "Bloquear Sistema");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipalPanel_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Shown += new System.EventHandler(this.FrmPrincipalPanel_Shown);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmPrincipalPanel_DragEnter);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer tmrOcultarMenu;
        private System.Windows.Forms.Timer tmrMostrarMenu;
        private FormHeader formHeader1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox3;
        internal System.Windows.Forms.PictureBox pictureBox4;
        internal BunifuAnimatorNS.BunifuTransition BunifuTransition1;
        internal MetroFramework.Controls.MetroProgressSpinner MetroProgressSpinner1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
    }
}