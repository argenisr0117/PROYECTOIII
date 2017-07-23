namespace ProyectoIII.Consultas
{
    partial class frmcOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcOrdenCompra));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaD = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpFechaH = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgOrdenes = new System.Windows.Forms.DataGridView();
            this.nodocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnProveedor = new System.Windows.Forms.Panel();
            this.txtNoDocumento = new ProyectoIII.Controles.textbox(this.components);
            this.txtProveedor = new ProyectoIII.Controles.textbox(this.components);
            this.txtCodigoPv = new ProyectoIII.Controles.textbox(this.components);
            this.btnProveedor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenes)).BeginInit();
            this.pnProveedor.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(-14, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(634, 23);
            this.label2.TabIndex = 56;
            this.label2.Text = "____________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "FILTRO DE ORDEN DE COMPRA";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 29);
            this.panel1.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "DESDE";
            // 
            // dtpFechaD
            // 
            this.dtpFechaD.BackColor = System.Drawing.Color.White;
            this.dtpFechaD.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaD.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaD.Location = new System.Drawing.Point(0, 0);
            this.dtpFechaD.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaD.Name = "dtpFechaD";
            this.dtpFechaD.Size = new System.Drawing.Size(118, 26);
            this.dtpFechaD.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtpFechaD);
            this.panel2.Location = new System.Drawing.Point(68, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 29);
            this.panel2.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dtpFechaH);
            this.panel3.Location = new System.Drawing.Point(248, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 29);
            this.panel3.TabIndex = 62;
            // 
            // dtpFechaH
            // 
            this.dtpFechaH.BackColor = System.Drawing.Color.White;
            this.dtpFechaH.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaH.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaH.Location = new System.Drawing.Point(0, 0);
            this.dtpFechaH.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaH.Name = "dtpFechaH";
            this.dtpFechaH.Size = new System.Drawing.Size(118, 26);
            this.dtpFechaH.TabIndex = 59;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(193, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(62, 29);
            this.panel4.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 58;
            this.label3.Text = "HASTA";
            // 
            // dtgOrdenes
            // 
            this.dtgOrdenes.AllowUserToAddRows = false;
            this.dtgOrdenes.AllowUserToDeleteRows = false;
            this.dtgOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nodocumento,
            this.fecha,
            this.codigop});
            this.dtgOrdenes.Location = new System.Drawing.Point(1, 125);
            this.dtgOrdenes.MultiSelect = false;
            this.dtgOrdenes.Name = "dtgOrdenes";
            this.dtgOrdenes.ReadOnly = true;
            this.dtgOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgOrdenes.Size = new System.Drawing.Size(553, 242);
            this.dtgOrdenes.TabIndex = 63;
            this.dtgOrdenes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgOrdenes_CellDoubleClick);
            // 
            // nodocumento
            // 
            this.nodocumento.HeaderText = "NODOCUMENTO";
            this.nodocumento.Name = "nodocumento";
            this.nodocumento.ReadOnly = true;
            this.nodocumento.Width = 140;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 83;
            // 
            // codigop
            // 
            this.codigop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigop.HeaderText = "PROVEEDOR";
            this.codigop.Name = "codigop";
            this.codigop.ReadOnly = true;
            // 
            // pnProveedor
            // 
            this.pnProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnProveedor.Controls.Add(this.txtNoDocumento);
            this.pnProveedor.Controls.Add(this.txtProveedor);
            this.pnProveedor.Controls.Add(this.txtCodigoPv);
            this.pnProveedor.Controls.Add(this.btnProveedor);
            this.pnProveedor.ForeColor = System.Drawing.Color.Black;
            this.pnProveedor.Location = new System.Drawing.Point(1, 90);
            this.pnProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.pnProveedor.Name = "pnProveedor";
            this.pnProveedor.Size = new System.Drawing.Size(553, 32);
            this.pnProveedor.TabIndex = 64;
            // 
            // txtNoDocumento
            // 
            this.txtNoDocumento.BackColor = System.Drawing.Color.White;
            this.txtNoDocumento.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtNoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoDocumento.ForeColor = System.Drawing.Color.Black;
            this.txtNoDocumento.Location = new System.Drawing.Point(406, 0);
            this.txtNoDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoDocumento.Multiline = true;
            this.txtNoDocumento.Name = "txtNoDocumento";
            this.txtNoDocumento.Size = new System.Drawing.Size(143, 28);
            this.txtNoDocumento.TabIndex = 0;
            this.txtNoDocumento.Validar = true;
            this.txtNoDocumento.TextChanged += new System.EventHandler(this.txtNoDocumento_TextChanged);
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.Color.White;
            this.txtProveedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.ForeColor = System.Drawing.Color.Black;
            this.txtProveedor.Location = new System.Drawing.Point(162, 0);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtProveedor.Multiline = true;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(200, 28);
            this.txtProveedor.TabIndex = 38;
            this.txtProveedor.Validar = true;
            // 
            // txtCodigoPv
            // 
            this.txtCodigoPv.BackColor = System.Drawing.Color.White;
            this.txtCodigoPv.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCodigoPv.Enabled = false;
            this.txtCodigoPv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPv.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoPv.Location = new System.Drawing.Point(98, 0);
            this.txtCodigoPv.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoPv.Multiline = true;
            this.txtCodigoPv.Name = "txtCodigoPv";
            this.txtCodigoPv.Size = new System.Drawing.Size(64, 28);
            this.txtCodigoPv.TabIndex = 37;
            this.txtCodigoPv.Validar = true;
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.White;
            this.btnProveedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProveedor.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnProveedor.FlatAppearance.BorderSize = 3;
            this.btnProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.ForeColor = System.Drawing.Color.Black;
            this.btnProveedor.Image = global::ProyectoIII.Properties.Resources.folder_find;
            this.btnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedor.Location = new System.Drawing.Point(0, 0);
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(98, 28);
            this.btnProveedor.TabIndex = 35;
            this.btnProveedor.Text = "PROVEEDOR";
            this.btnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(406, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 65;
            this.label5.Text = "NoDocumento";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 367);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(554, 46);
            this.panel5.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 18);
            this.label6.TabIndex = 59;
            this.label6.Text = "Doble click para seleccionar";
            // 
            // frmcOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 413);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnProveedor);
            this.Controls.Add(this.dtgOrdenes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmcOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmcOrdenCompra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenes)).EndInit();
            this.pnProveedor.ResumeLayout(false);
            this.pnProveedor.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpFechaH;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgOrdenes;
        private System.Windows.Forms.Panel pnProveedor;
        private Controles.textbox txtProveedor;
        private Controles.textbox txtCodigoPv;
        private System.Windows.Forms.Button btnProveedor;
        private Controles.textbox txtNoDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigop;
    }
}