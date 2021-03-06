﻿namespace ProyectoIII.Consultas
{
    partial class frmcCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcCliente));
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbRnc = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusqueda = new ProyectoIII.Controles.textbox(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnElegir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.codigo,
            this.nombre,
            this.rnc,
            this.telefono,
            this.correo,
            this.direccion,
            this.estado,
            this.limite});
            this.dtgCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgCliente.Location = new System.Drawing.Point(0, 139);
            this.dtgCliente.MultiSelect = false;
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            this.dtgCliente.RowHeadersWidth = 20;
            this.dtgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCliente.Size = new System.Drawing.Size(920, 308);
            this.dtgCliente.TabIndex = 0;
            this.dtgCliente.TabStop = false;
            this.dtgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProveedor_CellContentClick);
            this.dtgCliente.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgProveedor_CellPainting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 72);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(139, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(742, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "_____________________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(385, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "BÚSQUEDA DE CLIENTES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.rbRnc);
            this.panel2.Controls.Add(this.rbNombre);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBusqueda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 67);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.rbInactivo);
            this.panel5.Controls.Add(this.rbActivo);
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(916, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(101, 58);
            this.panel5.TabIndex = 44;
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.BackColor = System.Drawing.Color.White;
            this.rbInactivo.ForeColor = System.Drawing.Color.Black;
            this.rbInactivo.Location = new System.Drawing.Point(3, 31);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(90, 23);
            this.rbInactivo.TabIndex = 1;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivos";
            this.rbInactivo.UseVisualStyleBackColor = false;
            this.rbInactivo.CheckedChanged += new System.EventHandler(this.rbInactivo_CheckedChanged);
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.BackColor = System.Drawing.Color.White;
            this.rbActivo.ForeColor = System.Drawing.Color.Black;
            this.rbActivo.Location = new System.Drawing.Point(3, 7);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(78, 23);
            this.rbActivo.TabIndex = 0;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activos";
            this.rbActivo.UseVisualStyleBackColor = false;
            this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
            // 
            // rbRnc
            // 
            this.rbRnc.AutoSize = true;
            this.rbRnc.BackColor = System.Drawing.Color.White;
            this.rbRnc.ForeColor = System.Drawing.Color.Black;
            this.rbRnc.Location = new System.Drawing.Point(199, 37);
            this.rbRnc.Name = "rbRnc";
            this.rbRnc.Size = new System.Drawing.Size(124, 23);
            this.rbRnc.TabIndex = 3;
            this.rbRnc.TabStop = true;
            this.rbRnc.Text = "CÉDULA/RNC";
            this.rbRnc.UseVisualStyleBackColor = false;
            this.rbRnc.CheckedChanged += new System.EventHandler(this.rbRnc_CheckedChanged);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.BackColor = System.Drawing.Color.White;
            this.rbNombre.ForeColor = System.Drawing.Color.Black;
            this.rbNombre.Location = new System.Drawing.Point(103, 37);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(90, 23);
            this.rbNombre.TabIndex = 2;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "NOMBRE";
            this.rbNombre.UseVisualStyleBackColor = false;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(-1, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "BÚSQUEDA:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.White;
            this.txtBusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtBusqueda.Location = new System.Drawing.Point(103, 6);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(430, 27);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.Validar = false;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnSalir);
            this.panel4.Controls.Add(this.btnActivar);
            this.panel4.Controls.Add(this.btnElegir);
            this.panel4.Controls.Add(this.btnNuevo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(923, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(101, 308);
            this.panel4.TabIndex = 47;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = global::ProyectoIII.Properties.Resources.salir2;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(0, 188);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 62);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.White;
            this.btnActivar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActivar.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnActivar.FlatAppearance.BorderSize = 0;
            this.btnActivar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.ForeColor = System.Drawing.Color.Black;
            this.btnActivar.Image = global::ProyectoIII.Properties.Resources.refresh__3_;
            this.btnActivar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnActivar.Location = new System.Drawing.Point(0, 126);
            this.btnActivar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(97, 62);
            this.btnActivar.TabIndex = 50;
            this.btnActivar.Text = "DESACTIVAR/ACTIVAR";
            this.btnActivar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnElegir
            // 
            this.btnElegir.BackColor = System.Drawing.Color.White;
            this.btnElegir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnElegir.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnElegir.FlatAppearance.BorderSize = 0;
            this.btnElegir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnElegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegir.ForeColor = System.Drawing.Color.Black;
            this.btnElegir.Image = global::ProyectoIII.Properties.Resources.apply__2_;
            this.btnElegir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnElegir.Location = new System.Drawing.Point(0, 63);
            this.btnElegir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(97, 63);
            this.btnElegir.TabIndex = 48;
            this.btnElegir.Text = "ELEGIR";
            this.btnElegir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElegir.UseVisualStyleBackColor = false;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Image = global::ProyectoIII.Properties.Resources.add__3_;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.Location = new System.Drawing.Point(0, 0);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 63);
            this.btnNuevo.TabIndex = 46;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnNuevo, "Nuevo Proveedor");
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 447);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 54);
            this.panel3.TabIndex = 3;
            // 
            // editar
            // 
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.HeaderText = "";
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editar.ToolTipText = "Editar";
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codigo.HeaderText = "CÓDIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 96;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 97;
            // 
            // rnc
            // 
            this.rnc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rnc.HeaderText = "RNC/CÉDULA";
            this.rnc.Name = "rnc";
            this.rnc.ReadOnly = true;
            this.rnc.Width = 131;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.telefono.HeaderText = "TELÉFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 113;
            // 
            // correo
            // 
            this.correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.correo.HeaderText = "CORREO";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 97;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.direccion.HeaderText = "DIRECCIÓN";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 119;
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // limite
            // 
            this.limite.HeaderText = "LIMITE CRED.";
            this.limite.Name = "limite";
            this.limite.ReadOnly = true;
            this.limite.Visible = false;
            // 
            // frmcCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 501);
            this.Controls.Add(this.dtgCliente);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmcCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmcProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbRnc;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.Label label3;
        private Controles.textbox txtBusqueda;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn limite;
    }
}