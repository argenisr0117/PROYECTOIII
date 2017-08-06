namespace ProyectoIII.Procesos
{
    partial class frmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoF = new System.Windows.Forms.ComboBox();
            this.txtNota = new ProyectoIII.Controles.textbox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocumento = new ProyectoIII.Controles.textboxn(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMetodop = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new ProyectoIII.Controles.textboxn(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.txtCliente = new ProyectoIII.Controles.textboxn(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.textboxn4 = new ProyectoIII.Controles.textboxn(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.pnProducto = new System.Windows.Forms.Panel();
            this.txtPrecio = new ProyectoIII.Controles.textboxn(this.components);
            this.txtCantidad = new ProyectoIII.Controles.textboxn(this.components);
            this.cbUnidad = new System.Windows.Forms.ComboBox();
            this.txtProducto = new ProyectoIII.Controles.textbox(this.components);
            this.txtCodigoP = new ProyectoIII.Controles.textbox(this.components);
            this.btnProducto = new System.Windows.Forms.Button();
            this.dtgFacturacion = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNcf = new ProyectoIII.Controles.textbox(this.components);
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idunidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.pnProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(-9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(946, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "______________________________________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(391, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "FACTURACIÓN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(261, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 77;
            this.label6.Text = "TIPO FACTURA";
            // 
            // cbTipoF
            // 
            this.cbTipoF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoF.FormattingEnabled = true;
            this.cbTipoF.Location = new System.Drawing.Point(262, 73);
            this.cbTipoF.Name = "cbTipoF";
            this.cbTipoF.Size = new System.Drawing.Size(135, 28);
            this.cbTipoF.TabIndex = 76;
            // 
            // txtNota
            // 
            this.txtNota.BackColor = System.Drawing.Color.White;
            this.txtNota.ForeColor = System.Drawing.Color.Black;
            this.txtNota.Location = new System.Drawing.Point(493, 133);
            this.txtNota.Margin = new System.Windows.Forms.Padding(2);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(403, 90);
            this.txtNota.TabIndex = 70;
            this.txtNota.Validar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(490, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "NOTA";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.White;
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.ForeColor = System.Drawing.Color.Black;
            this.txtDocumento.Location = new System.Drawing.Point(11, 73);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(127, 26);
            this.txtDocumento.TabIndex = 75;
            this.txtDocumento.Validar = false;
            this.txtDocumento.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            // 
            // dtpFecha
            // 
            this.dtpFecha.BackColor = System.Drawing.Color.White;
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(145, 73);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(112, 26);
            this.dtpFecha.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(141, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 72;
            this.label4.Text = "FECHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 71;
            this.label3.Text = "DOCUMENTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(402, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 79;
            this.label7.Text = "MONEDA";
            // 
            // cbMoneda
            // 
            this.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(403, 73);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(82, 28);
            this.cbMoneda.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(490, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 81;
            this.label8.Text = "METODO PAGO";
            // 
            // cbMetodop
            // 
            this.cbMetodop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetodop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMetodop.FormattingEnabled = true;
            this.cbMetodop.Location = new System.Drawing.Point(491, 73);
            this.cbMetodop.Name = "cbMetodop";
            this.cbMetodop.Size = new System.Drawing.Size(131, 28);
            this.cbMetodop.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(623, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 18);
            this.label9.TabIndex = 82;
            this.label9.Text = "NCF";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.BackColor = System.Drawing.Color.White;
            this.txtCodigoCliente.Enabled = false;
            this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoCliente.Location = new System.Drawing.Point(11, 135);
            this.txtCodigoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(86, 26);
            this.txtCodigoCliente.TabIndex = 85;
            this.txtCodigoCliente.Validar = true;
            this.txtCodigoCliente.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 18);
            this.label10.TabIndex = 84;
            this.label10.Text = "CLIENTE";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.Location = new System.Drawing.Point(11, 165);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(373, 26);
            this.txtCliente.TabIndex = 86;
            this.txtCliente.Validar = true;
            this.txtCliente.Valor = ProyectoIII.Controles.textboxn.Tipo.Letras;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Goldenrod;
            this.label11.Location = new System.Drawing.Point(-9, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(946, 23);
            this.label11.TabIndex = 87;
            this.label11.Text = "______________________________________________________________________________";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.White;
            this.btnAgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 3;
            this.btnAgregarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCliente.Image = global::ProyectoIII.Properties.Resources.search__2_;
            this.btnAgregarCliente.Location = new System.Drawing.Point(101, 133);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(43, 28);
            this.btnAgregarCliente.TabIndex = 88;
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // textboxn4
            // 
            this.textboxn4.BackColor = System.Drawing.Color.White;
            this.textboxn4.Enabled = false;
            this.textboxn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxn4.ForeColor = System.Drawing.Color.Black;
            this.textboxn4.Location = new System.Drawing.Point(405, 135);
            this.textboxn4.Margin = new System.Windows.Forms.Padding(2);
            this.textboxn4.Name = "textboxn4";
            this.textboxn4.Size = new System.Drawing.Size(80, 26);
            this.textboxn4.TabIndex = 90;
            this.textboxn4.Validar = true;
            this.textboxn4.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(401, 113);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 18);
            this.label12.TabIndex = 89;
            this.label12.Text = "CAJA";
            // 
            // pnProducto
            // 
            this.pnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnProducto.Controls.Add(this.txtPrecio);
            this.pnProducto.Controls.Add(this.txtCantidad);
            this.pnProducto.Controls.Add(this.cbUnidad);
            this.pnProducto.Controls.Add(this.txtProducto);
            this.pnProducto.Controls.Add(this.txtCodigoP);
            this.pnProducto.Controls.Add(this.btnProducto);
            this.pnProducto.ForeColor = System.Drawing.Color.Black;
            this.pnProducto.Location = new System.Drawing.Point(-2, 310);
            this.pnProducto.Margin = new System.Windows.Forms.Padding(2);
            this.pnProducto.Name = "pnProducto";
            this.pnProducto.Size = new System.Drawing.Size(928, 32);
            this.pnProducto.TabIndex = 91;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtPrecio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(632, 0);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
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
            this.txtCantidad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Black;
            this.txtCantidad.Location = new System.Drawing.Point(549, 0);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(83, 28);
            this.txtCantidad.TabIndex = 47;
            this.txtCantidad.Validar = true;
            this.txtCantidad.Valor = ProyectoIII.Controles.textboxn.Tipo.Números;
            // 
            // cbUnidad
            // 
            this.cbUnidad.BackColor = System.Drawing.Color.White;
            this.cbUnidad.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidad.ForeColor = System.Drawing.Color.Black;
            this.cbUnidad.FormattingEnabled = true;
            this.cbUnidad.Location = new System.Drawing.Point(448, 0);
            this.cbUnidad.Margin = new System.Windows.Forms.Padding(2);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Size = new System.Drawing.Size(101, 28);
            this.cbUnidad.TabIndex = 46;
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.White;
            this.txtProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtProducto.Enabled = false;
            this.txtProducto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.ForeColor = System.Drawing.Color.Black;
            this.txtProducto.Location = new System.Drawing.Point(178, 0);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProducto.Multiline = true;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(270, 28);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.Validar = true;
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.BackColor = System.Drawing.Color.White;
            this.txtCodigoP.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCodigoP.Enabled = false;
            this.txtCodigoP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoP.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoP.Location = new System.Drawing.Point(95, 0);
            this.txtCodigoP.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(95, 28);
            this.btnProducto.TabIndex = 36;
            this.btnProducto.Text = "PRODUCTO";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // dtgFacturacion
            // 
            this.dtgFacturacion.AllowUserToAddRows = false;
            this.dtgFacturacion.AllowUserToDeleteRows = false;
            this.dtgFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminar,
            this.codigo,
            this.cantidad,
            this.idunidad,
            this.unidad,
            this.producto,
            this.precio,
            this.importe,
            this.itbis,
            this.total});
            this.dtgFacturacion.Location = new System.Drawing.Point(0, 341);
            this.dtgFacturacion.Name = "dtgFacturacion";
            this.dtgFacturacion.ReadOnly = true;
            this.dtgFacturacion.Size = new System.Drawing.Size(926, 183);
            this.dtgFacturacion.TabIndex = 92;
            this.dtgFacturacion.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgFacturacion_CellPainting);
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
            this.btnSalir.Location = new System.Drawing.Point(808, 529);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 46);
            this.btnSalir.TabIndex = 95;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnEditar.FlatAppearance.BorderSize = 3;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = global::ProyectoIII.Properties.Resources.cancel__2_;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(684, 529);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 46);
            this.btnEditar.TabIndex = 94;
            this.btnEditar.Text = "CANCELAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.UseVisualStyleBackColor = false;
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
            this.btnRegistrar.Image = global::ProyectoIII.Properties.Resources.save_as;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.Location = new System.Drawing.Point(560, 529);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(118, 46);
            this.btnRegistrar.TabIndex = 93;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtNcf
            // 
            this.txtNcf.BackColor = System.Drawing.Color.White;
            this.txtNcf.Enabled = false;
            this.txtNcf.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNcf.ForeColor = System.Drawing.Color.Black;
            this.txtNcf.Location = new System.Drawing.Point(626, 73);
            this.txtNcf.Margin = new System.Windows.Forms.Padding(2);
            this.txtNcf.Multiline = true;
            this.txtNcf.Name = "txtNcf";
            this.txtNcf.Size = new System.Drawing.Size(270, 28);
            this.txtNcf.TabIndex = 96;
            this.txtNcf.Validar = false;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Width = 50;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // idunidad
            // 
            this.idunidad.HeaderText = "idunidad";
            this.idunidad.Name = "idunidad";
            this.idunidad.ReadOnly = true;
            this.idunidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idunidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idunidad.Visible = false;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "UNIDAD";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            this.unidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // producto
            // 
            this.producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.producto.HeaderText = "DESCRIPCIÓN";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.producto.Width = 93;
            // 
            // precio
            // 
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // importe
            // 
            this.importe.HeaderText = "IMPORTE";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // itbis
            // 
            this.itbis.HeaderText = "ITBIS";
            this.itbis.Name = "itbis";
            this.itbis.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(546, 295);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 97;
            this.label13.Text = "CANTIDAD";
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 586);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNcf);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtgFacturacion);
            this.Controls.Add(this.pnProducto);
            this.Controls.Add(this.textboxn4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbMetodop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMoneda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTipoF);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.pnProducto.ResumeLayout(false);
            this.pnProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipoF;
        private Controles.textbox txtNota;
        private System.Windows.Forms.Label label5;
        private Controles.textboxn txtDocumento;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMetodop;
        private System.Windows.Forms.Label label9;
        private Controles.textboxn txtCodigoCliente;
        private System.Windows.Forms.Label label10;
        private Controles.textboxn txtCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAgregarCliente;
        private Controles.textboxn textboxn4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnProducto;
        private Controles.textboxn txtPrecio;
        private Controles.textboxn txtCantidad;
        private System.Windows.Forms.ComboBox cbUnidad;
        private Controles.textbox txtProducto;
        private Controles.textbox txtCodigoP;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.DataGridView dtgFacturacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegistrar;
        private Controles.textbox txtNcf;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idunidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label13;
    }
}