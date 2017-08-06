namespace ProyectoIII.Mantenimientos
{
    partial class frmAsignarPrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarPrecios));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgPrecio = new System.Windows.Forms.DataGridView();
            this.idprecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtProducto = new ProyectoIII.Controles.textbox(this.components);
            this.txtInicial1 = new ProyectoIII.Controles.textboxn(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFinal1 = new ProyectoIII.Controles.textboxn(this.components);
            this.txtUtilidad = new ProyectoIII.Controles.textboxn(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregarD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(43, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "____________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "ASIGNACIÓN DE PRECIOS";
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.BackColor = System.Drawing.Color.White;
            this.btnBuscarP.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnBuscarP.FlatAppearance.BorderSize = 3;
            this.btnBuscarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarP.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarP.Image = global::ProyectoIII.Properties.Resources.search__2_;
            this.btnBuscarP.Location = new System.Drawing.Point(390, 80);
            this.btnBuscarP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(40, 28);
            this.btnBuscarP.TabIndex = 44;
            this.btnBuscarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarP.UseVisualStyleBackColor = false;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "PRODUCTO:";
            // 
            // dtgPrecio
            // 
            this.dtgPrecio.AllowUserToAddRows = false;
            this.dtgPrecio.AllowUserToDeleteRows = false;
            this.dtgPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrecio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprecio,
            this.idproducto,
            this.almacen,
            this.eliminar,
            this.utilidad,
            this.estado});
            this.dtgPrecio.Location = new System.Drawing.Point(16, 210);
            this.dtgPrecio.MultiSelect = false;
            this.dtgPrecio.Name = "dtgPrecio";
            this.dtgPrecio.ReadOnly = true;
            this.dtgPrecio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrecio.Size = new System.Drawing.Size(504, 158);
            this.dtgPrecio.TabIndex = 48;
            this.dtgPrecio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrecio_CellDoubleClick);
            // 
            // idprecio
            // 
            this.idprecio.HeaderText = "idprecio";
            this.idprecio.Name = "idprecio";
            this.idprecio.ReadOnly = true;
            this.idprecio.Visible = false;
            // 
            // idproducto
            // 
            this.idproducto.HeaderText = "IDPRODUCTO";
            this.idproducto.Name = "idproducto";
            this.idproducto.ReadOnly = true;
            this.idproducto.Visible = false;
            // 
            // almacen
            // 
            this.almacen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.almacen.HeaderText = "CANT. INICIAL";
            this.almacen.Name = "almacen";
            this.almacen.ReadOnly = true;
            this.almacen.Width = 132;
            // 
            // eliminar
            // 
            this.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.eliminar.HeaderText = "CANT. FINAL";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.Width = 119;
            // 
            // utilidad
            // 
            this.utilidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.utilidad.HeaderText = "UTILIDAD";
            this.utilidad.Name = "utilidad";
            this.utilidad.ReadOnly = true;
            this.utilidad.Width = 108;
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(117, 80);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(267, 27);
            this.txtProducto.TabIndex = 42;
            this.txtProducto.Validar = true;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // txtInicial1
            // 
            this.txtInicial1.Location = new System.Drawing.Point(117, 148);
            this.txtInicial1.Name = "txtInicial1";
            this.txtInicial1.Size = new System.Drawing.Size(115, 27);
            this.txtInicial1.TabIndex = 49;
            this.txtInicial1.Validar = true;
            this.txtInicial1.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "RANGO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "CANT. INICIAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "CANT. FINAL";
            // 
            // txtFinal1
            // 
            this.txtFinal1.Location = new System.Drawing.Point(238, 148);
            this.txtFinal1.Name = "txtFinal1";
            this.txtFinal1.Size = new System.Drawing.Size(115, 27);
            this.txtFinal1.TabIndex = 52;
            this.txtFinal1.Validar = true;
            this.txtFinal1.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.Location = new System.Drawing.Point(359, 148);
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.Size = new System.Drawing.Size(71, 27);
            this.txtUtilidad.TabIndex = 60;
            this.txtUtilidad.Validar = true;
            this.txtUtilidad.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(356, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "% UTILIDAD";
            // 
            // btnAgregarD
            // 
            this.btnAgregarD.BackColor = System.Drawing.Color.White;
            this.btnAgregarD.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnAgregarD.FlatAppearance.BorderSize = 3;
            this.btnAgregarD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarD.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarD.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarD.Image = global::ProyectoIII.Properties.Resources.add__3_;
            this.btnAgregarD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarD.Location = new System.Drawing.Point(439, 145);
            this.btnAgregarD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarD.Name = "btnAgregarD";
            this.btnAgregarD.Size = new System.Drawing.Size(46, 30);
            this.btnAgregarD.TabIndex = 64;
            this.btnAgregarD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarD.UseVisualStyleBackColor = false;
            this.btnAgregarD.Click += new System.EventHandler(this.btnAgregarD_Click);
            // 
            // frmAsignarPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 375);
            this.Controls.Add(this.btnAgregarD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUtilidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFinal1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInicial1);
            this.Controls.Add(this.dtgPrecio);
            this.Controls.Add(this.btnBuscarP);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAsignarPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAsignarAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarP;
        private Controles.textbox txtProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgPrecio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label9;
        private Controles.textboxn txtUtilidad;
        private System.Windows.Forms.Label label6;
        private Controles.textboxn txtFinal1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Controles.textboxn txtInicial1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button btnAgregarD;
    }
}