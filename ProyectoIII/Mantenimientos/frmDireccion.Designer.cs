namespace ProyectoIII.Mantenimientos
{
    partial class frmDireccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDireccion));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPais = new System.Windows.Forms.TabPage();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnCancelarPais = new System.Windows.Forms.Button();
            this.btnEditarPais = new System.Windows.Forms.Button();
            this.dtgPais = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrarPais = new System.Windows.Forms.Button();
            this.txtDescripcionPais = new ProyectoIII.Controles.textbox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRegion = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.btnCancelarR = new System.Windows.Forms.Button();
            this.btnEditarR = new System.Windows.Forms.Button();
            this.dtgRegion = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarR = new System.Windows.Forms.Button();
            this.txtDescripcionR = new ProyectoIII.Controles.textbox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabCiudad = new System.Windows.Forms.TabPage();
            this.tabBarrio = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.btnCancelarC = new System.Windows.Forms.Button();
            this.btnEditarC = new System.Windows.Forms.Button();
            this.dtgCiudad = new System.Windows.Forms.DataGridView();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.txtDescripcionC = new ProyectoIII.Controles.textbox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.btnCancelarB = new System.Windows.Forms.Button();
            this.btnEditarB = new System.Windows.Forms.Button();
            this.dtgBarrio = new System.Windows.Forms.DataGridView();
            this.btnGuardarB = new System.Windows.Forms.Button();
            this.txtDescripcionB = new ProyectoIII.Controles.textbox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPais)).BeginInit();
            this.tabRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegion)).BeginInit();
            this.tabCiudad.SuspendLayout();
            this.tabBarrio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBarrio)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPais);
            this.tabControl1.Controls.Add(this.tabRegion);
            this.tabControl1.Controls.Add(this.tabCiudad);
            this.tabControl1.Controls.Add(this.tabBarrio);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 356);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // tabPais
            // 
            this.tabPais.Controls.Add(this.txtCodigo);
            this.tabPais.Controls.Add(this.btnCancelarPais);
            this.tabPais.Controls.Add(this.btnEditarPais);
            this.tabPais.Controls.Add(this.dtgPais);
            this.tabPais.Controls.Add(this.btnRegistrarPais);
            this.tabPais.Controls.Add(this.txtDescripcionPais);
            this.tabPais.Controls.Add(this.label3);
            this.tabPais.Controls.Add(this.label2);
            this.tabPais.Controls.Add(this.label1);
            this.tabPais.Location = new System.Drawing.Point(4, 28);
            this.tabPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPais.Name = "tabPais";
            this.tabPais.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPais.Size = new System.Drawing.Size(538, 324);
            this.tabPais.TabIndex = 0;
            this.tabPais.Text = "PAIS";
            this.tabPais.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(3, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(10, 27);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.Visible = false;
            // 
            // btnCancelarPais
            // 
            this.btnCancelarPais.BackColor = System.Drawing.Color.White;
            this.btnCancelarPais.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelarPais.FlatAppearance.BorderSize = 3;
            this.btnCancelarPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPais.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPais.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarPais.Image = global::ProyectoIII.Properties.Resources.cancel__2_;
            this.btnCancelarPais.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarPais.Location = new System.Drawing.Point(420, 232);
            this.btnCancelarPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarPais.Name = "btnCancelarPais";
            this.btnCancelarPais.Size = new System.Drawing.Size(110, 46);
            this.btnCancelarPais.TabIndex = 7;
            this.btnCancelarPais.Text = "CANCELAR";
            this.btnCancelarPais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarPais.UseVisualStyleBackColor = false;
            // 
            // btnEditarPais
            // 
            this.btnEditarPais.BackColor = System.Drawing.Color.White;
            this.btnEditarPais.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnEditarPais.FlatAppearance.BorderSize = 3;
            this.btnEditarPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPais.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPais.ForeColor = System.Drawing.Color.Black;
            this.btnEditarPais.Image = global::ProyectoIII.Properties.Resources.edit__2_;
            this.btnEditarPais.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarPais.Location = new System.Drawing.Point(420, 181);
            this.btnEditarPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarPais.Name = "btnEditarPais";
            this.btnEditarPais.Size = new System.Drawing.Size(110, 46);
            this.btnEditarPais.TabIndex = 6;
            this.btnEditarPais.Text = "EDITAR";
            this.btnEditarPais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPais.UseVisualStyleBackColor = false;
            this.btnEditarPais.Click += new System.EventHandler(this.btnEditarPais_Click);
            // 
            // dtgPais
            // 
            this.dtgPais.AllowUserToAddRows = false;
            this.dtgPais.AllowUserToDeleteRows = false;
            this.dtgPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion});
            this.dtgPais.Location = new System.Drawing.Point(9, 128);
            this.dtgPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgPais.MultiSelect = false;
            this.dtgPais.Name = "dtgPais";
            this.dtgPais.ReadOnly = true;
            this.dtgPais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPais.Size = new System.Drawing.Size(406, 150);
            this.dtgPais.TabIndex = 5;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CÓDIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "DESCRIPCIÓN";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // btnRegistrarPais
            // 
            this.btnRegistrarPais.BackColor = System.Drawing.Color.White;
            this.btnRegistrarPais.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnRegistrarPais.FlatAppearance.BorderSize = 3;
            this.btnRegistrarPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegistrarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPais.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPais.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarPais.Image = global::ProyectoIII.Properties.Resources.save__2_;
            this.btnRegistrarPais.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarPais.Location = new System.Drawing.Point(420, 130);
            this.btnRegistrarPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarPais.Name = "btnRegistrarPais";
            this.btnRegistrarPais.Size = new System.Drawing.Size(110, 46);
            this.btnRegistrarPais.TabIndex = 4;
            this.btnRegistrarPais.Text = "GUARDAR";
            this.btnRegistrarPais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPais.UseVisualStyleBackColor = false;
            this.btnRegistrarPais.Click += new System.EventHandler(this.btnRegistrarPais_Click);
            // 
            // txtDescripcionPais
            // 
            this.txtDescripcionPais.Location = new System.Drawing.Point(141, 53);
            this.txtDescripcionPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionPais.Name = "txtDescripcionPais";
            this.txtDescripcionPais.Size = new System.Drawing.Size(274, 27);
            this.txtDescripcionPais.TabIndex = 0;
            this.txtDescripcionPais.Validar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESCRIPCIÓN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(-7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(562, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "______________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(171, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE PAÍS";
            // 
            // tabRegion
            // 
            this.tabRegion.Controls.Add(this.label7);
            this.tabRegion.Controls.Add(this.cbPais);
            this.tabRegion.Controls.Add(this.btnCancelarR);
            this.tabRegion.Controls.Add(this.btnEditarR);
            this.tabRegion.Controls.Add(this.dtgRegion);
            this.tabRegion.Controls.Add(this.btnGuardarR);
            this.tabRegion.Controls.Add(this.txtDescripcionR);
            this.tabRegion.Controls.Add(this.label4);
            this.tabRegion.Controls.Add(this.label5);
            this.tabRegion.Controls.Add(this.label6);
            this.tabRegion.Location = new System.Drawing.Point(4, 28);
            this.tabRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRegion.Name = "tabRegion";
            this.tabRegion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRegion.Size = new System.Drawing.Size(538, 324);
            this.tabRegion.TabIndex = 1;
            this.tabRegion.Text = "REGION";
            this.tabRegion.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "PAÍS:";
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(142, 85);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(274, 27);
            this.cbPais.TabIndex = 17;
            // 
            // btnCancelarR
            // 
            this.btnCancelarR.BackColor = System.Drawing.Color.White;
            this.btnCancelarR.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelarR.FlatAppearance.BorderSize = 3;
            this.btnCancelarR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarR.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarR.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarR.Image = global::ProyectoIII.Properties.Resources.cancel__2_;
            this.btnCancelarR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarR.Location = new System.Drawing.Point(421, 232);
            this.btnCancelarR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarR.Name = "btnCancelarR";
            this.btnCancelarR.Size = new System.Drawing.Size(110, 46);
            this.btnCancelarR.TabIndex = 16;
            this.btnCancelarR.Text = "CANCELAR";
            this.btnCancelarR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarR.UseVisualStyleBackColor = false;
            // 
            // btnEditarR
            // 
            this.btnEditarR.BackColor = System.Drawing.Color.White;
            this.btnEditarR.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnEditarR.FlatAppearance.BorderSize = 3;
            this.btnEditarR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarR.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarR.ForeColor = System.Drawing.Color.Black;
            this.btnEditarR.Image = global::ProyectoIII.Properties.Resources.edit__2_;
            this.btnEditarR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarR.Location = new System.Drawing.Point(421, 181);
            this.btnEditarR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarR.Name = "btnEditarR";
            this.btnEditarR.Size = new System.Drawing.Size(110, 46);
            this.btnEditarR.TabIndex = 15;
            this.btnEditarR.Text = "EDITAR";
            this.btnEditarR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarR.UseVisualStyleBackColor = false;
            this.btnEditarR.Click += new System.EventHandler(this.btnEditarR_Click);
            // 
            // dtgRegion
            // 
            this.dtgRegion.AllowUserToAddRows = false;
            this.dtgRegion.AllowUserToDeleteRows = false;
            this.dtgRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.pais});
            this.dtgRegion.Location = new System.Drawing.Point(10, 128);
            this.dtgRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgRegion.MultiSelect = false;
            this.dtgRegion.Name = "dtgRegion";
            this.dtgRegion.ReadOnly = true;
            this.dtgRegion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRegion.Size = new System.Drawing.Size(406, 150);
            this.dtgRegion.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "CÓDIGO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 96;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCRIPCIÓN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 137;
            // 
            // pais
            // 
            this.pais.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pais.HeaderText = "PAÍS";
            this.pais.Name = "pais";
            this.pais.ReadOnly = true;
            this.pais.Width = 69;
            // 
            // btnGuardarR
            // 
            this.btnGuardarR.BackColor = System.Drawing.Color.White;
            this.btnGuardarR.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnGuardarR.FlatAppearance.BorderSize = 3;
            this.btnGuardarR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarR.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarR.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarR.Image = global::ProyectoIII.Properties.Resources.save__2_;
            this.btnGuardarR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarR.Location = new System.Drawing.Point(421, 130);
            this.btnGuardarR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarR.Name = "btnGuardarR";
            this.btnGuardarR.Size = new System.Drawing.Size(110, 46);
            this.btnGuardarR.TabIndex = 13;
            this.btnGuardarR.Text = "GUARDAR";
            this.btnGuardarR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarR.UseVisualStyleBackColor = false;
            this.btnGuardarR.Click += new System.EventHandler(this.btnGuardarR_Click);
            // 
            // txtDescripcionR
            // 
            this.txtDescripcionR.Location = new System.Drawing.Point(142, 53);
            this.txtDescripcionR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionR.Name = "txtDescripcionR";
            this.txtDescripcionR.Size = new System.Drawing.Size(274, 27);
            this.txtDescripcionR.TabIndex = 9;
            this.txtDescripcionR.Validar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "DESCRIPCIÓN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(-6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(562, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "______________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(155, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "REGISTRO DE REGIÓN";
            // 
            // tabCiudad
            // 
            this.tabCiudad.Controls.Add(this.label8);
            this.tabCiudad.Controls.Add(this.cbRegion);
            this.tabCiudad.Controls.Add(this.btnCancelarC);
            this.tabCiudad.Controls.Add(this.btnEditarC);
            this.tabCiudad.Controls.Add(this.dtgCiudad);
            this.tabCiudad.Controls.Add(this.btnGuardarC);
            this.tabCiudad.Controls.Add(this.txtDescripcionC);
            this.tabCiudad.Controls.Add(this.label9);
            this.tabCiudad.Controls.Add(this.label10);
            this.tabCiudad.Controls.Add(this.label11);
            this.tabCiudad.Location = new System.Drawing.Point(4, 28);
            this.tabCiudad.Name = "tabCiudad";
            this.tabCiudad.Padding = new System.Windows.Forms.Padding(3);
            this.tabCiudad.Size = new System.Drawing.Size(538, 324);
            this.tabCiudad.TabIndex = 2;
            this.tabCiudad.Text = "CIUDAD";
            this.tabCiudad.UseVisualStyleBackColor = true;
            // 
            // tabBarrio
            // 
            this.tabBarrio.Controls.Add(this.label12);
            this.tabBarrio.Controls.Add(this.cbCiudad);
            this.tabBarrio.Controls.Add(this.btnCancelarB);
            this.tabBarrio.Controls.Add(this.btnEditarB);
            this.tabBarrio.Controls.Add(this.dtgBarrio);
            this.tabBarrio.Controls.Add(this.btnGuardarB);
            this.tabBarrio.Controls.Add(this.txtDescripcionB);
            this.tabBarrio.Controls.Add(this.label13);
            this.tabBarrio.Controls.Add(this.label14);
            this.tabBarrio.Controls.Add(this.label15);
            this.tabBarrio.Location = new System.Drawing.Point(4, 28);
            this.tabBarrio.Name = "tabBarrio";
            this.tabBarrio.Padding = new System.Windows.Forms.Padding(3);
            this.tabBarrio.Size = new System.Drawing.Size(538, 324);
            this.tabBarrio.TabIndex = 3;
            this.tabBarrio.Text = "BARRIO";
            this.tabBarrio.UseVisualStyleBackColor = true;
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
            this.btnSalir.Location = new System.Drawing.Point(424, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 46);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 46);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "REGIÓN:";
            // 
            // cbRegion
            // 
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(140, 86);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(274, 27);
            this.cbRegion.TabIndex = 27;
            // 
            // btnCancelarC
            // 
            this.btnCancelarC.BackColor = System.Drawing.Color.White;
            this.btnCancelarC.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelarC.FlatAppearance.BorderSize = 3;
            this.btnCancelarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarC.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarC.Image = global::ProyectoIII.Properties.Resources.cancel__2_;
            this.btnCancelarC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarC.Location = new System.Drawing.Point(419, 233);
            this.btnCancelarC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarC.Name = "btnCancelarC";
            this.btnCancelarC.Size = new System.Drawing.Size(110, 46);
            this.btnCancelarC.TabIndex = 26;
            this.btnCancelarC.Text = "CANCELAR";
            this.btnCancelarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarC.UseVisualStyleBackColor = false;
            // 
            // btnEditarC
            // 
            this.btnEditarC.BackColor = System.Drawing.Color.White;
            this.btnEditarC.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnEditarC.FlatAppearance.BorderSize = 3;
            this.btnEditarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarC.ForeColor = System.Drawing.Color.Black;
            this.btnEditarC.Image = global::ProyectoIII.Properties.Resources.edit__2_;
            this.btnEditarC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarC.Location = new System.Drawing.Point(419, 182);
            this.btnEditarC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarC.Name = "btnEditarC";
            this.btnEditarC.Size = new System.Drawing.Size(110, 46);
            this.btnEditarC.TabIndex = 25;
            this.btnEditarC.Text = "EDITAR";
            this.btnEditarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarC.UseVisualStyleBackColor = false;
            this.btnEditarC.Click += new System.EventHandler(this.btnEditarC_Click);
            // 
            // dtgCiudad
            // 
            this.dtgCiudad.AllowUserToAddRows = false;
            this.dtgCiudad.AllowUserToDeleteRows = false;
            this.dtgCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCiudad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtgCiudad.Location = new System.Drawing.Point(8, 129);
            this.dtgCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgCiudad.MultiSelect = false;
            this.dtgCiudad.Name = "dtgCiudad";
            this.dtgCiudad.ReadOnly = true;
            this.dtgCiudad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCiudad.Size = new System.Drawing.Size(406, 150);
            this.dtgCiudad.TabIndex = 24;
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.BackColor = System.Drawing.Color.White;
            this.btnGuardarC.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnGuardarC.FlatAppearance.BorderSize = 3;
            this.btnGuardarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarC.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarC.Image = global::ProyectoIII.Properties.Resources.save__2_;
            this.btnGuardarC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarC.Location = new System.Drawing.Point(419, 131);
            this.btnGuardarC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(110, 46);
            this.btnGuardarC.TabIndex = 23;
            this.btnGuardarC.Text = "GUARDAR";
            this.btnGuardarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarC.UseVisualStyleBackColor = false;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // txtDescripcionC
            // 
            this.txtDescripcionC.Location = new System.Drawing.Point(140, 54);
            this.txtDescripcionC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionC.Name = "txtDescripcionC";
            this.txtDescripcionC.Size = new System.Drawing.Size(274, 27);
            this.txtDescripcionC.TabIndex = 19;
            this.txtDescripcionC.Validar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "DESCRIPCIÓN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Goldenrod;
            this.label10.Location = new System.Drawing.Point(-8, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(562, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "______________________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(156, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "REGISTRO DE CIUDAD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 19);
            this.label12.TabIndex = 28;
            this.label12.Text = "CIUDAD:";
            // 
            // cbCiudad
            // 
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(141, 86);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(274, 27);
            this.cbCiudad.TabIndex = 27;
            // 
            // btnCancelarB
            // 
            this.btnCancelarB.BackColor = System.Drawing.Color.White;
            this.btnCancelarB.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelarB.FlatAppearance.BorderSize = 3;
            this.btnCancelarB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarB.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarB.Image = global::ProyectoIII.Properties.Resources.cancel__2_;
            this.btnCancelarB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarB.Location = new System.Drawing.Point(420, 233);
            this.btnCancelarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarB.Name = "btnCancelarB";
            this.btnCancelarB.Size = new System.Drawing.Size(110, 46);
            this.btnCancelarB.TabIndex = 26;
            this.btnCancelarB.Text = "CANCELAR";
            this.btnCancelarB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarB.UseVisualStyleBackColor = false;
            // 
            // btnEditarB
            // 
            this.btnEditarB.BackColor = System.Drawing.Color.White;
            this.btnEditarB.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnEditarB.FlatAppearance.BorderSize = 3;
            this.btnEditarB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarB.ForeColor = System.Drawing.Color.Black;
            this.btnEditarB.Image = global::ProyectoIII.Properties.Resources.edit__2_;
            this.btnEditarB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarB.Location = new System.Drawing.Point(420, 182);
            this.btnEditarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarB.Name = "btnEditarB";
            this.btnEditarB.Size = new System.Drawing.Size(110, 46);
            this.btnEditarB.TabIndex = 25;
            this.btnEditarB.Text = "EDITAR";
            this.btnEditarB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarB.UseVisualStyleBackColor = false;
            this.btnEditarB.Click += new System.EventHandler(this.btnEditarB_Click);
            // 
            // dtgBarrio
            // 
            this.dtgBarrio.AllowUserToAddRows = false;
            this.dtgBarrio.AllowUserToDeleteRows = false;
            this.dtgBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBarrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dtgBarrio.Location = new System.Drawing.Point(9, 129);
            this.dtgBarrio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgBarrio.MultiSelect = false;
            this.dtgBarrio.Name = "dtgBarrio";
            this.dtgBarrio.ReadOnly = true;
            this.dtgBarrio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBarrio.Size = new System.Drawing.Size(406, 150);
            this.dtgBarrio.TabIndex = 24;
            // 
            // btnGuardarB
            // 
            this.btnGuardarB.BackColor = System.Drawing.Color.White;
            this.btnGuardarB.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnGuardarB.FlatAppearance.BorderSize = 3;
            this.btnGuardarB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarB.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarB.Image = global::ProyectoIII.Properties.Resources.save__2_;
            this.btnGuardarB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarB.Location = new System.Drawing.Point(420, 131);
            this.btnGuardarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarB.Name = "btnGuardarB";
            this.btnGuardarB.Size = new System.Drawing.Size(110, 46);
            this.btnGuardarB.TabIndex = 23;
            this.btnGuardarB.Text = "GUARDAR";
            this.btnGuardarB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarB.UseVisualStyleBackColor = false;
            this.btnGuardarB.Click += new System.EventHandler(this.btnGuardarB_Click);
            // 
            // txtDescripcionB
            // 
            this.txtDescripcionB.Location = new System.Drawing.Point(141, 54);
            this.txtDescripcionB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionB.Name = "txtDescripcionB";
            this.txtDescripcionB.Size = new System.Drawing.Size(274, 27);
            this.txtDescripcionB.TabIndex = 19;
            this.txtDescripcionB.Validar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "DESCRIPCIÓN:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Goldenrod;
            this.label14.Location = new System.Drawing.Point(-7, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(562, 23);
            this.label14.TabIndex = 21;
            this.label14.Text = "______________________________________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(154, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(228, 23);
            this.label15.TabIndex = 20;
            this.label15.Text = "REGISTRO DE BARRIO";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "CÓDIGO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 96;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "DESCRIPCIÓN";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 137;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn8.HeaderText = "CIUDAD";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 94;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "CÓDIGO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 96;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "DESCRIPCIÓN";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 137;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "REGIÓN";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 93;
            // 
            // frmDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDireccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmDireccion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPais.ResumeLayout(false);
            this.tabPais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPais)).EndInit();
            this.tabRegion.ResumeLayout(false);
            this.tabRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegion)).EndInit();
            this.tabCiudad.ResumeLayout(false);
            this.tabCiudad.PerformLayout();
            this.tabBarrio.ResumeLayout(false);
            this.tabBarrio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBarrio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPais;
        private System.Windows.Forms.TabPage tabRegion;
        private Controles.textbox txtDescripcionPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dtgPais;
        private System.Windows.Forms.Button btnRegistrarPais;
        private System.Windows.Forms.Button btnCancelarPais;
        private System.Windows.Forms.Button btnEditarPais;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCancelarR;
        private System.Windows.Forms.Button btnEditarR;
        private System.Windows.Forms.DataGridView dtgRegion;
        private System.Windows.Forms.Button btnGuardarR;
        private Controles.textbox txtDescripcionR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.TabPage tabCiudad;
        private System.Windows.Forms.TabPage tabBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Button btnCancelarC;
        private System.Windows.Forms.Button btnEditarC;
        private System.Windows.Forms.DataGridView dtgCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnGuardarC;
        private Controles.textbox txtDescripcionC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Button btnCancelarB;
        private System.Windows.Forms.Button btnEditarB;
        private System.Windows.Forms.DataGridView dtgBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnGuardarB;
        private Controles.textbox txtDescripcionB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}