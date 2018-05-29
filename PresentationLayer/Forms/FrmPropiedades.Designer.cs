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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dragControl1 = new PresentationLayer.DragControl();
            this.formHeader1 = new PresentationLayer.FormHeader();
            this.dataItemsComp = new MetroFramework.Controls.MetroGrid();
            this.dragControl2 = new PresentationLayer.DragControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelNoMouse3 = new PresentationLayer.Controls.LabelNoMouse();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNoMouse2 = new PresentationLayer.Controls.LabelNoMouse();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelNoMouse1 = new PresentationLayer.Controls.LabelNoMouse();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescrpcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemsComp)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // dataItemsComp
            // 
            this.dataItemsComp.AllowUserToAddRows = false;
            this.dataItemsComp.AllowUserToDeleteRows = false;
            this.dataItemsComp.AllowUserToOrderColumns = true;
            this.dataItemsComp.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dataItemsComp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataItemsComp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataItemsComp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataItemsComp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataItemsComp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataItemsComp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItemsComp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataItemsComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataItemsComp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataItemsComp.EnableHeadersVisualStyles = false;
            this.dataItemsComp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataItemsComp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataItemsComp.Location = new System.Drawing.Point(21, 20);
            this.dataItemsComp.MultiSelect = false;
            this.dataItemsComp.Name = "dataItemsComp";
            this.dataItemsComp.ReadOnly = true;
            this.dataItemsComp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItemsComp.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataItemsComp.RowHeadersVisible = false;
            this.dataItemsComp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataItemsComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItemsComp.Size = new System.Drawing.Size(427, 261);
            this.dataItemsComp.TabIndex = 1;
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
            this.panel4.Controls.Add(this.materialFlatButton3);
            this.panel4.Location = new System.Drawing.Point(382, 428);
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
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.BackColor = System.Drawing.Color.Transparent;
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
            this.materialFlatButton3.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.materialFlatButton3.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.labelNoMouse2);
            this.panel3.Controls.Add(this.materialFlatButton2);
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
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.BackColor = System.Drawing.Color.Transparent;
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
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.labelNoMouse1);
            this.panel2.Controls.Add(this.materialFlatButton1);
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
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.Transparent;
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
            this.materialFlatButton1.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.materialFlatButton1.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.materialCheckBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescrpcion);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataItemsComp);
            this.groupBox1.Location = new System.Drawing.Point(20, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 373);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataItemsComp)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DragControl dragControl1;
        private FormHeader formHeader1;
        private MetroFramework.Controls.MetroGrid dataItemsComp;
        private DragControl dragControl2;
        private System.Windows.Forms.Panel panel4;
        private Controls.LabelNoMouse labelNoMouse3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.Panel panel3;
        private Controls.LabelNoMouse labelNoMouse2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.Panel panel2;
        private Controls.LabelNoMouse labelNoMouse1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescrpcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private System.Windows.Forms.Label label3;
    }
}