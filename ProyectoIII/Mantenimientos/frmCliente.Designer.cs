namespace ProyectoIII.Mantenimientos
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoContacto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbContacto = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgContacto = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoProveedor = new System.Windows.Forms.ComboBox();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.gbDireccion = new System.Windows.Forms.GroupBox();
            this.btnAgregarD = new System.Windows.Forms.Button();
            this.dtgDireccion = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbBarrio = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtDireccion = new ProyectoIII.Controles.textbox(this.components);
            this.txtContacto = new ProyectoIII.Controles.textbox(this.components);
            this.txtIdentificacion = new ProyectoIII.Controles.textbox(this.components);
            this.txtNombre = new ProyectoIII.Controles.textbox(this.components);
            this.codigod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idregion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editard = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContacto)).BeginInit();
            this.gbDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(295, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "REGISTRO DE PROVEEDORES";
            // 
            // cbTipoContacto
            // 
            this.cbTipoContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoContacto.FormattingEnabled = true;
            this.cbTipoContacto.Location = new System.Drawing.Point(106, 69);
            this.cbTipoContacto.Name = "cbTipoContacto";
            this.cbTipoContacto.Size = new System.Drawing.Size(244, 27);
            this.cbTipoContacto.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "CONTACTO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "IDENTIFICACIÓN:";
            // 
            // gbContacto
            // 
            this.gbContacto.Controls.Add(this.btnAgregarC);
            this.gbContacto.Controls.Add(this.dtgContacto);
            this.gbContacto.Controls.Add(this.label6);
            this.gbContacto.Controls.Add(this.txtContacto);
            this.gbContacto.Controls.Add(this.label3);
            this.gbContacto.Controls.Add(this.cbTipoContacto);
            this.gbContacto.Location = new System.Drawing.Point(36, 208);
            this.gbContacto.Name = "gbContacto";
            this.gbContacto.Size = new System.Drawing.Size(472, 280);
            this.gbContacto.TabIndex = 41;
            this.gbContacto.TabStop = false;
            this.gbContacto.Text = "CONTACTOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "TIPO:";
            // 
            // dtgContacto
            // 
            this.dtgContacto.AllowUserToAddRows = false;
            this.dtgContacto.AllowUserToDeleteRows = false;
            this.dtgContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContacto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.contacto,
            this.tipoc,
            this.tipo,
            this.editarc});
            this.dtgContacto.Location = new System.Drawing.Point(10, 126);
            this.dtgContacto.MultiSelect = false;
            this.dtgContacto.Name = "dtgContacto";
            this.dtgContacto.ReadOnly = true;
            this.dtgContacto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgContacto.Size = new System.Drawing.Size(410, 134);
            this.dtgContacto.TabIndex = 39;
            this.dtgContacto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContacto_CellContentClick);
            this.dtgContacto.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgContacto_CellPainting);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "TIPO:";
            // 
            // cbTipoProveedor
            // 
            this.cbTipoProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProveedor.FormattingEnabled = true;
            this.cbTipoProveedor.Location = new System.Drawing.Point(180, 145);
            this.cbTipoProveedor.Name = "cbTipoProveedor";
            this.cbTipoProveedor.Size = new System.Drawing.Size(328, 27);
            this.cbTipoProveedor.TabIndex = 2;
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.BackColor = System.Drawing.Color.White;
            this.btnAgregarC.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnAgregarC.FlatAppearance.BorderSize = 3;
            this.btnAgregarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarC.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarC.Image = global::ProyectoIII.Properties.Resources.add__3_;
            this.btnAgregarC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarC.Location = new System.Drawing.Point(374, 50);
            this.btnAgregarC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(46, 46);
            this.btnAgregarC.TabIndex = 5;
            this.btnAgregarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnAgregarC, "Agregar/Guardar");
            this.btnAgregarC.UseVisualStyleBackColor = false;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // gbDireccion
            // 
            this.gbDireccion.Controls.Add(this.label11);
            this.gbDireccion.Controls.Add(this.cbBarrio);
            this.gbDireccion.Controls.Add(this.label10);
            this.gbDireccion.Controls.Add(this.cbCiudad);
            this.gbDireccion.Controls.Add(this.btnAgregarD);
            this.gbDireccion.Controls.Add(this.dtgDireccion);
            this.gbDireccion.Controls.Add(this.label8);
            this.gbDireccion.Controls.Add(this.txtDireccion);
            this.gbDireccion.Controls.Add(this.label9);
            this.gbDireccion.Controls.Add(this.cbRegion);
            this.gbDireccion.Location = new System.Drawing.Point(532, 82);
            this.gbDireccion.Name = "gbDireccion";
            this.gbDireccion.Size = new System.Drawing.Size(485, 355);
            this.gbDireccion.TabIndex = 44;
            this.gbDireccion.TabStop = false;
            this.gbDireccion.Text = "DIRECCIÓN";
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
            this.btnAgregarD.Location = new System.Drawing.Point(433, 138);
            this.btnAgregarD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarD.Name = "btnAgregarD";
            this.btnAgregarD.Size = new System.Drawing.Size(46, 46);
            this.btnAgregarD.TabIndex = 10;
            this.btnAgregarD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnAgregarD, "Agregar/Guardar");
            this.btnAgregarD.UseVisualStyleBackColor = false;
            this.btnAgregarD.Click += new System.EventHandler(this.btnAgregarD_Click);
            // 
            // dtgDireccion
            // 
            this.dtgDireccion.AllowUserToAddRows = false;
            this.dtgDireccion.AllowUserToDeleteRows = false;
            this.dtgDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDireccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigod,
            this.direccion,
            this.idbarrio,
            this.idciudad,
            this.idregion,
            this.editard});
            this.dtgDireccion.Location = new System.Drawing.Point(12, 203);
            this.dtgDireccion.Name = "dtgDireccion";
            this.dtgDireccion.ReadOnly = true;
            this.dtgDireccion.Size = new System.Drawing.Size(444, 134);
            this.dtgDireccion.TabIndex = 39;
            this.dtgDireccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDireccion_CellContentClick);
            this.dtgDireccion.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgDireccion_CellPainting);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "REGIÓN:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "DIRECCIÓN:";
            // 
            // cbRegion
            // 
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(108, 31);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(296, 27);
            this.cbRegion.TabIndex = 6;
            this.cbRegion.SelectedValueChanged += new System.EventHandler(this.cbRegion_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 45;
            this.label10.Text = "CIUDAD:";
            // 
            // cbCiudad
            // 
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(108, 64);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(296, 27);
            this.cbCiudad.TabIndex = 7;
            this.cbCiudad.SelectedValueChanged += new System.EventHandler(this.cbCiudad_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 19);
            this.label11.TabIndex = 47;
            this.label11.Text = "BARRIO:";
            // 
            // cbBarrio
            // 
            this.cbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarrio.FormattingEnabled = true;
            this.cbBarrio.Location = new System.Drawing.Point(108, 97);
            this.cbBarrio.Name = "cbBarrio";
            this.cbBarrio.Size = new System.Drawing.Size(296, 27);
            this.cbBarrio.TabIndex = 8;
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
            this.btnRegistrar.Location = new System.Drawing.Point(532, 442);
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
            this.btnSalir.Location = new System.Drawing.Point(648, 442);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.contacto.HeaderText = "CONTACTO";
            this.contacto.Name = "contacto";
            this.contacto.ReadOnly = true;
            this.contacto.Width = 120;
            // 
            // tipoc
            // 
            this.tipoc.HeaderText = "CTIPO";
            this.tipoc.Name = "tipoc";
            this.tipoc.ReadOnly = true;
            this.tipoc.Visible = false;
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tipo.HeaderText = "TIPO";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 71;
            // 
            // editarc
            // 
            this.editarc.HeaderText = "EDITAR";
            this.editarc.Name = "editarc";
            this.editarc.ReadOnly = true;
            this.editarc.Text = "";
            this.editarc.ToolTipText = "Editar";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(108, 130);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(296, 68);
            this.txtDireccion.TabIndex = 9;
            this.txtDireccion.Validar = true;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(106, 36);
            this.txtContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(244, 27);
            this.txtContacto.TabIndex = 3;
            this.txtContacto.Validar = true;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(180, 113);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(328, 27);
            this.txtIdentificacion.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtIdentificacion, "Cédula/RNC");
            this.txtIdentificacion.Validar = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 82);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(328, 27);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Validar = true;
            // 
            // codigod
            // 
            this.codigod.HeaderText = "CÓDIGO";
            this.codigod.Name = "codigod";
            this.codigod.ReadOnly = true;
            this.codigod.Visible = false;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.direccion.HeaderText = "DIRECCIÓN";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 119;
            // 
            // idbarrio
            // 
            this.idbarrio.HeaderText = "IDBARRIO";
            this.idbarrio.Name = "idbarrio";
            this.idbarrio.ReadOnly = true;
            this.idbarrio.Visible = false;
            // 
            // idciudad
            // 
            this.idciudad.HeaderText = "IDCIUDAD";
            this.idciudad.Name = "idciudad";
            this.idciudad.ReadOnly = true;
            this.idciudad.Visible = false;
            // 
            // idregion
            // 
            this.idregion.HeaderText = "IDREGIÓN";
            this.idregion.Name = "idregion";
            this.idregion.ReadOnly = true;
            this.idregion.Visible = false;
            // 
            // editard
            // 
            this.editard.HeaderText = "EDITAR";
            this.editard.Name = "editard";
            this.editard.ReadOnly = true;
            this.editard.Text = "";
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 534);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gbDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTipoProveedor);
            this.Controls.Add(this.gbContacto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            this.gbContacto.ResumeLayout(false);
            this.gbContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContacto)).EndInit();
            this.gbDireccion.ResumeLayout(false);
            this.gbDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoContacto;
        private System.Windows.Forms.Label label4;
        private Controles.textbox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Controles.textbox txtIdentificacion;
        private System.Windows.Forms.GroupBox gbContacto;
        private System.Windows.Forms.DataGridView dtgContacto;
        private System.Windows.Forms.Label label6;
        private Controles.textbox txtContacto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipoProveedor;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.GroupBox gbDireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbBarrio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Button btnAgregarD;
        private System.Windows.Forms.DataGridView dtgDireccion;
        private System.Windows.Forms.Label label8;
        private Controles.textbox txtDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewButtonColumn editarc;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigod;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idregion;
        private System.Windows.Forms.DataGridViewButtonColumn editard;
    }
}