namespace ProyectoIII.Mantenimientos
{
    partial class frmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbUnidad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbItbis = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbProveedor = new System.Windows.Forms.GroupBox();
            this.dtgProveedor = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtProveedor = new ProyectoIII.Controles.textbox(this.components);
            this.txtCodigoB = new ProyectoIII.Controles.textboxn(this.components);
            this.txtCostoP = new ProyectoIII.Controles.textboxn(this.components);
            this.txtCostoC = new ProyectoIII.Controles.textboxn(this.components);
            this.txtPuntoMax = new ProyectoIII.Controles.textboxn(this.components);
            this.txtPuntoR = new ProyectoIII.Controles.textboxn(this.components);
            this.txtReferencia = new ProyectoIII.Controles.textbox(this.components);
            this.txtDescripcion = new ProyectoIII.Controles.textbox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(153, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(742, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "_____________________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(377, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(180, 183);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(328, 27);
            this.cbMarca.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "DESCRIPCIÓN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "PUNTO REORDEN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "REFERENCIA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "MARCA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "CATEGORIA:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(180, 149);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(328, 27);
            this.cbCategoria.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(534, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 45;
            this.label10.Text = "UNIDAD:";
            // 
            // cbUnidad
            // 
            this.cbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidad.FormattingEnabled = true;
            this.cbUnidad.Location = new System.Drawing.Point(628, 109);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Size = new System.Drawing.Size(296, 27);
            this.cbUnidad.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "ITBIS:";
            // 
            // cbItbis
            // 
            this.cbItbis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItbis.FormattingEnabled = true;
            this.cbItbis.Location = new System.Drawing.Point(628, 76);
            this.cbItbis.Name = "cbItbis";
            this.cbItbis.Size = new System.Drawing.Size(296, 27);
            this.cbItbis.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 48;
            this.label9.Text = "PUNTO MAX:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 19);
            this.label11.TabIndex = 50;
            this.label11.Text = "COSTO COMPRA:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 19);
            this.label12.TabIndex = 52;
            this.label12.Text = "COSTO PROM.:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 19);
            this.label13.TabIndex = 54;
            this.label13.Text = "CÓDIGO BARRA:";
            // 
            // gbProveedor
            // 
            this.gbProveedor.Controls.Add(this.btnBuscarP);
            this.gbProveedor.Controls.Add(this.btnAgregarP);
            this.gbProveedor.Controls.Add(this.dtgProveedor);
            this.gbProveedor.Controls.Add(this.txtProveedor);
            this.gbProveedor.Controls.Add(this.label15);
            this.gbProveedor.Location = new System.Drawing.Point(538, 157);
            this.gbProveedor.Name = "gbProveedor";
            this.gbProveedor.Size = new System.Drawing.Size(472, 219);
            this.gbProveedor.TabIndex = 56;
            this.gbProveedor.TabStop = false;
            this.gbProveedor.Text = "PROVEEDORES";
            // 
            // dtgProveedor
            // 
            this.dtgProveedor.AllowUserToAddRows = false;
            this.dtgProveedor.AllowUserToDeleteRows = false;
            this.dtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.contacto,
            this.eliminar});
            this.dtgProveedor.Location = new System.Drawing.Point(10, 78);
            this.dtgProveedor.MultiSelect = false;
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.ReadOnly = true;
            this.dtgProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProveedor.Size = new System.Drawing.Size(410, 134);
            this.dtgProveedor.TabIndex = 39;
            this.dtgProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProveedor_CellContentClick);
            this.dtgProveedor.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgProveedor_CellPainting);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 19);
            this.label15.TabIndex = 36;
            this.label15.Text = "NOMBRE:";
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CÓDIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // contacto
            // 
            this.contacto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.contacto.HeaderText = "PROVEEDOR";
            this.contacto.Name = "contacto";
            this.contacto.ReadOnly = true;
            this.contacto.Width = 126;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "ELIMINAR";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Text = "";
            this.eliminar.ToolTipText = "ELIMINAR";
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
            this.btnBuscarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarP.Location = new System.Drawing.Point(368, 25);
            this.btnBuscarP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(46, 46);
            this.btnBuscarP.TabIndex = 40;
            this.btnBuscarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnBuscarP, "Agregar/Guardar");
            this.btnBuscarP.UseVisualStyleBackColor = false;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.BackColor = System.Drawing.Color.White;
            this.btnAgregarP.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnAgregarP.FlatAppearance.BorderSize = 3;
            this.btnAgregarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarP.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarP.Image = global::ProyectoIII.Properties.Resources.add__3_;
            this.btnAgregarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarP.Location = new System.Drawing.Point(420, 25);
            this.btnAgregarP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(46, 46);
            this.btnAgregarP.TabIndex = 5;
            this.btnAgregarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnAgregarP, "Agregar/Guardar");
            this.btnAgregarP.UseVisualStyleBackColor = false;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = global::ProyectoIII.Properties.Resources.salir2;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(527, 442);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 46);
            this.btnSalir.TabIndex = 46;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnRegistrar.FlatAppearance.BorderSize = 3;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = global::ProyectoIII.Properties.Resources.save__2_;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.Location = new System.Drawing.Point(411, 442);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(110, 46);
            this.btnRegistrar.TabIndex = 45;
            this.btnRegistrar.Text = "GUARDAR";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnRegistrar, "Guardar");
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(106, 36);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(251, 27);
            this.txtProveedor.TabIndex = 3;
            this.txtProveedor.Validar = true;
            // 
            // txtCodigoB
            // 
            this.txtCodigoB.Location = new System.Drawing.Point(180, 349);
            this.txtCodigoB.Name = "txtCodigoB";
            this.txtCodigoB.Size = new System.Drawing.Size(328, 27);
            this.txtCodigoB.TabIndex = 8;
            this.txtCodigoB.Validar = true;
            this.txtCodigoB.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            // 
            // txtCostoP
            // 
            this.txtCostoP.Location = new System.Drawing.Point(180, 316);
            this.txtCostoP.Name = "txtCostoP";
            this.txtCostoP.Size = new System.Drawing.Size(328, 27);
            this.txtCostoP.TabIndex = 7;
            this.txtCostoP.Validar = true;
            this.txtCostoP.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            // 
            // txtCostoC
            // 
            this.txtCostoC.Location = new System.Drawing.Point(180, 283);
            this.txtCostoC.Name = "txtCostoC";
            this.txtCostoC.Size = new System.Drawing.Size(328, 27);
            this.txtCostoC.TabIndex = 6;
            this.txtCostoC.Validar = true;
            this.txtCostoC.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            // 
            // txtPuntoMax
            // 
            this.txtPuntoMax.Location = new System.Drawing.Point(180, 250);
            this.txtPuntoMax.Name = "txtPuntoMax";
            this.txtPuntoMax.Size = new System.Drawing.Size(328, 27);
            this.txtPuntoMax.TabIndex = 5;
            this.txtPuntoMax.Validar = true;
            this.txtPuntoMax.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            // 
            // txtPuntoR
            // 
            this.txtPuntoR.Location = new System.Drawing.Point(180, 217);
            this.txtPuntoR.Name = "txtPuntoR";
            this.txtPuntoR.Size = new System.Drawing.Size(328, 27);
            this.txtPuntoR.TabIndex = 4;
            this.txtPuntoR.Validar = true;
            this.txtPuntoR.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(180, 115);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(328, 27);
            this.txtReferencia.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtReferencia, "Referencia");
            this.txtReferencia.Validar = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(180, 81);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(328, 27);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.Validar = true;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 534);
            this.Controls.Add(this.gbProveedor);
            this.Controls.Add(this.txtCodigoB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCostoP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCostoC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPuntoMax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPuntoR);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbUnidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbItbis);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbProveedor.ResumeLayout(false);
            this.gbProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label4;
        private Controles.textbox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Controles.textbox txtReferencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbUnidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbItbis;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Controles.textboxn txtCostoP;
        private System.Windows.Forms.Label label12;
        private Controles.textboxn txtCostoC;
        private System.Windows.Forms.Label label11;
        private Controles.textboxn txtPuntoMax;
        private System.Windows.Forms.Label label9;
        private Controles.textboxn txtPuntoR;
        private Controles.textboxn txtCodigoB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbProveedor;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.DataGridView dtgProveedor;
        private Controles.textbox txtProveedor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacto;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}