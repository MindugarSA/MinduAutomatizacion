﻿namespace PresentationLayer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.formHeader1.Size = new System.Drawing.Size(496, 41);
            this.formHeader1.TabIndex = 0;
            // 
            // dataItemsComp
            // 
            this.dataItemsComp.AllowUserToAddRows = false;
            this.dataItemsComp.AllowUserToDeleteRows = false;
            this.dataItemsComp.AllowUserToOrderColumns = true;
            this.dataItemsComp.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dataItemsComp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataItemsComp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataItemsComp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataItemsComp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataItemsComp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataItemsComp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItemsComp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataItemsComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataItemsComp.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataItemsComp.EnableHeadersVisualStyles = false;
            this.dataItemsComp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataItemsComp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataItemsComp.Location = new System.Drawing.Point(13, 20);
            this.dataItemsComp.MultiSelect = false;
            this.dataItemsComp.Name = "dataItemsComp";
            this.dataItemsComp.ReadOnly = true;
            this.dataItemsComp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItemsComp.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataItemsComp.RowHeadersVisible = false;
            this.dataItemsComp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataItemsComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItemsComp.Size = new System.Drawing.Size(427, 247);
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
            this.panel4.Location = new System.Drawing.Point(363, 428);
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataItemsComp);
            this.groupBox1.Location = new System.Drawing.Point(20, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 373);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // FrmPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.formHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPropiedades";
            this.Load += new System.EventHandler(this.FrmPropiedades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataItemsComp)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
    }
}