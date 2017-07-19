namespace ProyectoIII.Procesos
{
    partial class frmOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenCompra));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgProveedor = new System.Windows.Forms.DataGridView();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnProducto = new System.Windows.Forms.Panel();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.txtPrecio = new ProyectoIII.Controles.textboxn(this.components);
            this.txtCantidad = new ProyectoIII.Controles.textboxn(this.components);
            this.cbUnidad = new System.Windows.Forms.ComboBox();
            this.txtProducto = new ProyectoIII.Controles.textbox(this.components);
            this.txtCodigoP = new ProyectoIII.Controles.textbox(this.components);
            this.btnProducto = new System.Windows.Forms.Button();
            this.pnProveedor = new System.Windows.Forms.Panel();
            this.btnAgregarPv = new System.Windows.Forms.Button();
            this.txtProveedor = new ProyectoIII.Controles.textbox(this.components);
            this.txtCodigoPv = new ProyectoIII.Controles.textbox(this.components);
            this.btnProveedor = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtgProducto = new System.Windows.Forms.DataGridView();
            this.eliminarp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.codigop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idunidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNota = new ProyectoIII.Controles.textbox(this.components);
            this.txtDocumento = new ProyectoIII.Controles.textboxn(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            this.pnProducto.SuspendLayout();
            this.pnProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(-10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(898, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "__________________________________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "REGISTRO DE ORDEN DE COMPRA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "DOCUMENTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(144, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "FECHA:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.BackColor = System.Drawing.Color.White;
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(148, 84);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(111, 27);
            this.dtpFecha.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "NOTA:";
            // 
            // dtgProveedor
            // 
            this.dtgProveedor.AllowUserToAddRows = false;
            this.dtgProveedor.AllowUserToDeleteRows = false;
            this.dtgProveedor.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminar,
            this.codigo,
            this.nombre});
            this.dtgProveedor.Location = new System.Drawing.Point(453, 142);
            this.dtgProveedor.MultiSelect = false;
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.ReadOnly = true;
            this.dtgProveedor.RowHeadersWidth = 20;
            this.dtgProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProveedor.Size = new System.Drawing.Size(409, 101);
            this.dtgProveedor.TabIndex = 31;
            this.dtgProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProveedor_CellContentClick);
            this.dtgProveedor.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgProveedor_CellPainting);
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminar.Width = 80;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CÓDIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 97;
            // 
            // pnProducto
            // 
            this.pnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnProducto.Controls.Add(this.btnAgregarP);
            this.pnProducto.Controls.Add(this.txtPrecio);
            this.pnProducto.Controls.Add(this.txtCantidad);
            this.pnProducto.Controls.Add(this.cbUnidad);
            this.pnProducto.Controls.Add(this.txtProducto);
            this.pnProducto.Controls.Add(this.txtCodigoP);
            this.pnProducto.Controls.Add(this.btnProducto);
            this.pnProducto.ForeColor = System.Drawing.Color.Black;
            this.pnProducto.Location = new System.Drawing.Point(15, 249);
            this.pnProducto.Name = "pnProducto";
            this.pnProducto.Size = new System.Drawing.Size(846, 32);
            this.pnProducto.TabIndex = 33;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.BackColor = System.Drawing.Color.White;
            this.btnAgregarP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarP.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnAgregarP.FlatAppearance.BorderSize = 3;
            this.btnAgregarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarP.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarP.Image = global::ProyectoIII.Properties.Resources.add__3_;
            this.btnAgregarP.Location = new System.Drawing.Point(726, 0);
            this.btnAgregarP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(116, 28);
            this.btnAgregarP.TabIndex = 1;
            this.btnAgregarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarP.UseVisualStyleBackColor = false;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtPrecio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(632, 0);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(94, 28);
            this.txtPrecio.TabIndex = 48;
            this.txtPrecio.Validar = true;
            this.txtPrecio.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCantidad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Black;
            this.txtCantidad.Location = new System.Drawing.Point(549, 0);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(83, 28);
            this.txtCantidad.TabIndex = 47;
            this.txtCantidad.Validar = true;
            this.txtCantidad.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cbUnidad
            // 
            this.cbUnidad.BackColor = System.Drawing.Color.White;
            this.cbUnidad.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidad.ForeColor = System.Drawing.Color.Black;
            this.cbUnidad.FormattingEnabled = true;
            this.cbUnidad.Location = new System.Drawing.Point(449, 0);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Size = new System.Drawing.Size(100, 27);
            this.cbUnidad.TabIndex = 46;
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.White;
            this.txtProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtProducto.Enabled = false;
            this.txtProducto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.ForeColor = System.Drawing.Color.Black;
            this.txtProducto.Location = new System.Drawing.Point(178, 0);
            this.txtProducto.Multiline = true;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(271, 28);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.Validar = true;
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.BackColor = System.Drawing.Color.White;
            this.txtCodigoP.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCodigoP.Enabled = false;
            this.txtCodigoP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoP.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoP.Location = new System.Drawing.Point(95, 0);
            this.txtCodigoP.Multiline = true;
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(83, 28);
            this.txtCodigoP.TabIndex = 0;
            this.txtCodigoP.Validar = true;
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.White;
            this.btnProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProducto.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnProducto.FlatAppearance.BorderSize = 3;
            this.btnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.Black;
            this.btnProducto.Image = global::ProyectoIII.Properties.Resources.folder_find;
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducto.Location = new System.Drawing.Point(0, 0);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(95, 28);
            this.btnProducto.TabIndex = 36;
            this.btnProducto.Text = "PRODUCTO";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // pnProveedor
            // 
            this.pnProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnProveedor.Controls.Add(this.btnAgregarPv);
            this.pnProveedor.Controls.Add(this.txtProveedor);
            this.pnProveedor.Controls.Add(this.txtCodigoPv);
            this.pnProveedor.Controls.Add(this.btnProveedor);
            this.pnProveedor.ForeColor = System.Drawing.Color.Black;
            this.pnProveedor.Location = new System.Drawing.Point(453, 115);
            this.pnProveedor.Name = "pnProveedor";
            this.pnProveedor.Size = new System.Drawing.Size(409, 32);
            this.pnProveedor.TabIndex = 38;
            // 
            // btnAgregarPv
            // 
            this.btnAgregarPv.BackColor = System.Drawing.Color.White;
            this.btnAgregarPv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarPv.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnAgregarPv.FlatAppearance.BorderSize = 3;
            this.btnAgregarPv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarPv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPv.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPv.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarPv.Image = global::ProyectoIII.Properties.Resources.add__3_;
            this.btnAgregarPv.Location = new System.Drawing.Point(362, 0);
            this.btnAgregarPv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarPv.Name = "btnAgregarPv";
            this.btnAgregarPv.Size = new System.Drawing.Size(43, 28);
            this.btnAgregarPv.TabIndex = 48;
            this.btnAgregarPv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPv.UseVisualStyleBackColor = false;
            this.btnAgregarPv.Click += new System.EventHandler(this.btnAgregarPv_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.Color.White;
            this.txtProveedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtProveedor.Enabled = false;
            this.txtProveedor.ForeColor = System.Drawing.Color.Black;
            this.txtProveedor.Location = new System.Drawing.Point(162, 0);
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
            this.txtCodigoPv.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoPv.Location = new System.Drawing.Point(98, 0);
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
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(98, 28);
            this.btnProveedor.TabIndex = 35;
            this.btnProveedor.Text = "PROVEEDOR";
            this.btnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtgProducto
            // 
            this.dtgProducto.AllowUserToAddRows = false;
            this.dtgProducto.AllowUserToDeleteRows = false;
            this.dtgProducto.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminarp,
            this.codigop,
            this.producto,
            this.idunidad,
            this.unidad,
            this.cantidad,
            this.costo});
            this.dtgProducto.Location = new System.Drawing.Point(17, 284);
            this.dtgProducto.MultiSelect = false;
            this.dtgProducto.Name = "dtgProducto";
            this.dtgProducto.ReadOnly = true;
            this.dtgProducto.RowHeadersWidth = 20;
            this.dtgProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProducto.Size = new System.Drawing.Size(843, 179);
            this.dtgProducto.TabIndex = 51;
            // 
            // eliminarp
            // 
            this.eliminarp.HeaderText = "";
            this.eliminarp.Name = "eliminarp";
            this.eliminarp.ReadOnly = true;
            this.eliminarp.Width = 60;
            // 
            // codigop
            // 
            this.codigop.HeaderText = "CÓDIGO";
            this.codigop.Name = "codigop";
            this.codigop.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "PRODUCTO";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 270;
            // 
            // idunidad
            // 
            this.idunidad.HeaderText = "idunidad";
            this.idunidad.Name = "idunidad";
            this.idunidad.ReadOnly = true;
            this.idunidad.Visible = false;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "UNIDAD";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // costo
            // 
            this.costo.HeaderText = "COSTO";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            // 
            // txtNota
            // 
            this.txtNota.BackColor = System.Drawing.Color.White;
            this.txtNota.ForeColor = System.Drawing.Color.Black;
            this.txtNota.Location = new System.Drawing.Point(15, 153);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(432, 90);
            this.txtNota.TabIndex = 0;
            this.txtNota.Validar = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.White;
            this.txtDocumento.Enabled = false;
            this.txtDocumento.ForeColor = System.Drawing.Color.Black;
            this.txtDocumento.Location = new System.Drawing.Point(14, 84);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(128, 27);
            this.txtDocumento.TabIndex = 50;
            this.txtDocumento.Validar = false;
            this.txtDocumento.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            // 
            // frmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 523);
            this.Controls.Add(this.dtgProducto);
            this.Controls.Add(this.pnProveedor);
            this.Controls.Add(this.pnProducto);
            this.Controls.Add(this.dtgProveedor);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).EndInit();
            this.pnProducto.ResumeLayout(false);
            this.pnProducto.PerformLayout();
            this.pnProveedor.ResumeLayout(false);
            this.pnProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private Controles.textboxn txtDocumento;
        private System.Windows.Forms.Label label5;
        private Controles.textbox txtNota;
        private System.Windows.Forms.DataGridView dtgProveedor;
        private System.Windows.Forms.Panel pnProducto;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnProducto;
        private Controles.textbox txtProducto;
        private Controles.textbox txtCodigoP;
        private Controles.textboxn txtCantidad;
        private System.Windows.Forms.ComboBox cbUnidad;
        private Controles.textbox txtCodigoPv;
        private System.Windows.Forms.Panel pnProveedor;
        private Controles.textbox txtProveedor;
        private Controles.textboxn txtPrecio;
        private System.Windows.Forms.Button btnAgregarPv;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridView dtgProducto;
        private System.Windows.Forms.DataGridViewButtonColumn eliminarp;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigop;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idunidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.Button btnAgregarP;
    }
}