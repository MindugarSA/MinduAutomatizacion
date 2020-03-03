namespace PresentationLayer
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Label13 = new System.Windows.Forms.Label();
            this.TxtBx_Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Bttn_Login = new MetroFramework.Controls.MetroButton();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.TxtBx_UserID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Controls.Add(this.PictureBox1);
            this.BunifuTransition1.SetDecoration(this.Panel2, BunifuAnimatorNS.DecorationType.None);
            this.Panel2.Location = new System.Drawing.Point(172, 11);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(201, 201);
            this.Panel2.TabIndex = 21;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.metroButton1);
            this.Panel1.Controls.Add(this.PictureBox4);
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Controls.Add(this.Label13);
            this.Panel1.Controls.Add(this.TxtBx_Password);
            this.Panel1.Controls.Add(this.PictureBox3);
            this.Panel1.Controls.Add(this.Bttn_Login);
            this.Panel1.Controls.Add(this.UsernameLabel);
            this.Panel1.Controls.Add(this.TxtBx_UserID);
            this.BunifuTransition1.SetDecoration(this.Panel1, BunifuAnimatorNS.DecorationType.None);
            this.Panel1.Location = new System.Drawing.Point(6, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(510, 320);
            this.Panel1.TabIndex = 20;
            // 
            // metroButton1
            // 
            this.BunifuTransition1.SetDecoration(this.metroButton1, BunifuAnimatorNS.DecorationType.None);
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(331, 220);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(124, 35);
            this.metroButton1.TabIndex = 18;
            this.metroButton1.Text = "Salir";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.BunifuTransition1.SetDecoration(this.Label13, BunifuAnimatorNS.DecorationType.None);
            this.Label13.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(190, 110);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(167, 30);
            this.Label13.TabIndex = 14;
            this.Label13.Text = "Login del Sistema";
            // 
            // TxtBx_Password
            // 
            this.TxtBx_Password.AcceptsReturn = false;
            this.TxtBx_Password.AcceptsTab = false;
            this.TxtBx_Password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtBx_Password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtBx_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BunifuTransition1.SetDecoration(this.TxtBx_Password, BunifuAnimatorNS.DecorationType.None);
            this.TxtBx_Password.Depth = 0;
            this.TxtBx_Password.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtBx_Password.Hint = " Contraseña";
            this.TxtBx_Password.Location = new System.Drawing.Point(63, 232);
            this.TxtBx_Password.MaxLength = 4;
            this.TxtBx_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBx_Password.Multiline = false;
            this.TxtBx_Password.Name = "TxtBx_Password";
            this.TxtBx_Password.PasswordChar = '•';
            this.TxtBx_Password.ReadOnly = false;
            this.TxtBx_Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBx_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBx_Password.SelectedText = "";
            this.TxtBx_Password.SelectionLength = 0;
            this.TxtBx_Password.SelectionStart = 0;
            this.TxtBx_Password.Size = new System.Drawing.Size(233, 23);
            this.TxtBx_Password.TabIndex = 2;
            this.TxtBx_Password.TabStop = false;
            this.TxtBx_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBx_Password.UseSystemPasswordChar = false;
            this.TxtBx_Password.WordWrap = true;
            this.TxtBx_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBx_Password_KeyDown);
            // 
            // Bttn_Login
            // 
            this.BunifuTransition1.SetDecoration(this.Bttn_Login, BunifuAnimatorNS.DecorationType.None);
            this.Bttn_Login.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Bttn_Login.Location = new System.Drawing.Point(331, 168);
            this.Bttn_Login.Name = "Bttn_Login";
            this.Bttn_Login.Size = new System.Drawing.Size(124, 35);
            this.Bttn_Login.TabIndex = 8;
            this.Bttn_Login.Text = "Entrar";
            this.Bttn_Login.UseSelectable = true;
            this.Bttn_Login.Click += new System.EventHandler(this.Bttn_Login_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.BunifuTransition1.SetDecoration(this.UsernameLabel, BunifuAnimatorNS.DecorationType.None);
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.UsernameLabel.Location = new System.Drawing.Point(65, 176);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(66, 23);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "R.U.T";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBx_UserID
            // 
            this.TxtBx_UserID.AcceptsReturn = false;
            this.TxtBx_UserID.AcceptsTab = false;
            this.TxtBx_UserID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtBx_UserID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtBx_UserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BunifuTransition1.SetDecoration(this.TxtBx_UserID, BunifuAnimatorNS.DecorationType.None);
            this.TxtBx_UserID.Depth = 0;
            this.TxtBx_UserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_UserID.Hint = "";
            this.TxtBx_UserID.Location = new System.Drawing.Point(63, 180);
            this.TxtBx_UserID.MaxLength = 11;
            this.TxtBx_UserID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBx_UserID.Multiline = false;
            this.TxtBx_UserID.Name = "TxtBx_UserID";
            this.TxtBx_UserID.PasswordChar = '\0';
            this.TxtBx_UserID.ReadOnly = false;
            this.TxtBx_UserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBx_UserID.SelectedText = "";
            this.TxtBx_UserID.SelectionLength = 0;
            this.TxtBx_UserID.SelectionStart = 0;
            this.TxtBx_UserID.Size = new System.Drawing.Size(233, 23);
            this.TxtBx_UserID.TabIndex = 1;
            this.TxtBx_UserID.TabStop = false;
            this.TxtBx_UserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBx_UserID.UseSystemPasswordChar = false;
            this.TxtBx_UserID.WordWrap = true;
            this.TxtBx_UserID.Enter += new System.EventHandler(this.TxtBx_UserID_Enter);
            this.TxtBx_UserID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyPress);
            this.TxtBx_UserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBx_UserID_KeyPress);
            this.TxtBx_UserID.TextChanged += new System.EventHandler(this.TxtBx_UserID_TextChanged);
            this.TxtBx_UserID.Validated += new System.EventHandler(this.TxtBx_UserID_Validated);
            // 
            // BunifuElipse1
            // 
            this.BunifuElipse1.ElipseRadius = 35;
            this.BunifuElipse1.TargetControl = this.Panel2;
            // 
            // BunifuElipse2
            // 
            this.BunifuElipse2.ElipseRadius = 30;
            this.BunifuElipse2.TargetControl = this.Panel1;
            // 
            // BunifuTransition1
            // 
            this.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.BunifuTransition1.Cursor = null;
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
            this.BunifuTransition1.DefaultAnimation = animation1;
            this.BunifuTransition1.Interval = 40;
            this.BunifuTransition1.MaxAnimationTime = 4000;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.Panel1);
            this.BunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(11, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 331);
            this.panel3.TabIndex = 22;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.panel3;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuTransition1.SetDecoration(this.PictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.PictureBox1.Image = global::PresentationLayer.Properties.Resources.LogoAjust;
            this.PictureBox1.InitialImage = null;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(200, 200);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            // 
            // PictureBox4
            // 
            this.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BunifuTransition1.SetDecoration(this.PictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.PictureBox4.Image = global::PresentationLayer.Properties.Resources.lock__2_;
            this.PictureBox4.Location = new System.Drawing.Point(272, 227);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(24, 24);
            this.PictureBox4.TabIndex = 17;
            this.PictureBox4.TabStop = false;
            // 
            // PictureBox2
            // 
            this.BunifuTransition1.SetDecoration(this.PictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.PictureBox2.Image = global::PresentationLayer.Properties.Resources.plus;
            this.PictureBox2.Location = new System.Drawing.Point(157, 109);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(32, 32);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 15;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BunifuTransition1.SetDecoration(this.PictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.PictureBox3.Image = global::PresentationLayer.Properties.Resources.user__2_;
            this.PictureBox3.Location = new System.Drawing.Point(272, 175);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(24, 24);
            this.PictureBox3.TabIndex = 16;
            this.PictureBox3.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 454);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.panel3);
            this.BunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Shown += new System.EventHandler(this.FrmLogin_Shown);
            this.Panel2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PictureBox4;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Label13;
        internal MaterialSkin.Controls.MaterialSingleLineTextField TxtBx_Password;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal MetroFramework.Controls.MetroButton Bttn_Login;
        internal System.Windows.Forms.Label UsernameLabel;
        internal MaterialSkin.Controls.MaterialSingleLineTextField TxtBx_UserID;
        internal BunifuAnimatorNS.BunifuTransition BunifuTransition1;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse2;
        internal MetroFramework.Controls.MetroButton metroButton1;
        internal System.Windows.Forms.Panel panel3;
        internal Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}