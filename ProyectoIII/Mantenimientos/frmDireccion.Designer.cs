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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRegion = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtgPais = new System.Windows.Forms.DataGridView();
            this.btnCancelarPais = new System.Windows.Forms.Button();
            this.btnEditarPais = new System.Windows.Forms.Button();
            this.btnRegistrarPais = new System.Windows.Forms.Button();
            this.btnSalirPais = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcionPais = new ProyectoIII.Controles.textbox(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPais)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPais);
            this.tabControl1.Controls.Add(this.tabRegion);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(607, 439);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // tabPais
            // 
            this.tabPais.Controls.Add(this.btnSalirPais);
            this.tabPais.Controls.Add(this.btnCancelarPais);
            this.tabPais.Controls.Add(this.btnEditarPais);
            this.tabPais.Controls.Add(this.dtgPais);
            this.tabPais.Controls.Add(this.btnRegistrarPais);
            this.tabPais.Controls.Add(this.txtDescripcionPais);
            this.tabPais.Controls.Add(this.label3);
            this.tabPais.Controls.Add(this.label2);
            this.tabPais.Controls.Add(this.label1);
            this.tabPais.Location = new System.Drawing.Point(4, 32);
            this.tabPais.Name = "tabPais";
            this.tabPais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPais.Size = new System.Drawing.Size(599, 403);
            this.tabPais.TabIndex = 0;
            this.tabPais.Text = "PAIS";
            this.tabPais.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESCRIPCIÓN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(-8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(634, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "____________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(201, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE PAÍS";
            // 
            // tabRegion
            // 
            this.tabRegion.Location = new System.Drawing.Point(4, 32);
            this.tabRegion.Name = "tabRegion";
            this.tabRegion.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegion.Size = new System.Drawing.Size(599, 403);
            this.tabRegion.TabIndex = 1;
            this.tabRegion.Text = "REGION";
            this.tabRegion.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtgPais
            // 
            this.dtgPais.AllowUserToAddRows = false;
            this.dtgPais.AllowUserToDeleteRows = false;
            this.dtgPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion});
            this.dtgPais.Location = new System.Drawing.Point(10, 155);
            this.dtgPais.MultiSelect = false;
            this.dtgPais.Name = "dtgPais";
            this.dtgPais.ReadOnly = true;
            this.dtgPais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPais.Size = new System.Drawing.Size(451, 242);
            this.dtgPais.TabIndex = 5;
            // 
            // btnCancelarPais
            // 
            this.btnCancelarPais.BackColor = System.Drawing.Color.White;
            this.btnCancelarPais.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelarPais.FlatAppearance.BorderSize = 3;
            this.btnCancelarPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPais.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPais.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarPais.Image = global::ProyectoIII.Properties.Resources.cancel__2_;
            this.btnCancelarPais.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarPais.Location = new System.Drawing.Point(467, 279);
            this.btnCancelarPais.Name = "btnCancelarPais";
            this.btnCancelarPais.Size = new System.Drawing.Size(122, 56);
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
            this.btnEditarPais.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPais.ForeColor = System.Drawing.Color.Black;
            this.btnEditarPais.Image = global::ProyectoIII.Properties.Resources.edit__2_;
            this.btnEditarPais.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarPais.Location = new System.Drawing.Point(467, 217);
            this.btnEditarPais.Name = "btnEditarPais";
            this.btnEditarPais.Size = new System.Drawing.Size(122, 56);
            this.btnEditarPais.TabIndex = 6;
            this.btnEditarPais.Text = "EDITAR";
            this.btnEditarPais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPais.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarPais
            // 
            this.btnRegistrarPais.BackColor = System.Drawing.Color.White;
            this.btnRegistrarPais.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnRegistrarPais.FlatAppearance.BorderSize = 3;
            this.btnRegistrarPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegistrarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPais.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPais.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarPais.Image = global::ProyectoIII.Properties.Resources.save__2_;
            this.btnRegistrarPais.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarPais.Location = new System.Drawing.Point(467, 155);
            this.btnRegistrarPais.Name = "btnRegistrarPais";
            this.btnRegistrarPais.Size = new System.Drawing.Size(122, 56);
            this.btnRegistrarPais.TabIndex = 4;
            this.btnRegistrarPais.Text = "GUARDAR";
            this.btnRegistrarPais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPais.UseVisualStyleBackColor = false;
            // 
            // btnSalirPais
            // 
            this.btnSalirPais.BackColor = System.Drawing.Color.White;
            this.btnSalirPais.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnSalirPais.FlatAppearance.BorderSize = 3;
            this.btnSalirPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalirPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirPais.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirPais.ForeColor = System.Drawing.Color.Black;
            this.btnSalirPais.Image = global::ProyectoIII.Properties.Resources.salir2;
            this.btnSalirPais.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirPais.Location = new System.Drawing.Point(467, 341);
            this.btnSalirPais.Name = "btnSalirPais";
            this.btnSalirPais.Size = new System.Drawing.Size(122, 56);
            this.btnSalirPais.TabIndex = 8;
            this.btnSalirPais.Text = "SALIR";
            this.btnSalirPais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirPais.UseVisualStyleBackColor = false;
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
            // txtDescripcionPais
            // 
            this.txtDescripcionPais.Location = new System.Drawing.Point(157, 64);
            this.txtDescripcionPais.Name = "txtDescripcionPais";
            this.txtDescripcionPais.Size = new System.Drawing.Size(304, 30);
            this.txtDescripcionPais.TabIndex = 0;
            this.txtDescripcionPais.Validar = false;
            // 
            // frmDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 439);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmDireccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmDireccion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPais.ResumeLayout(false);
            this.tabPais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPais)).EndInit();
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
        private System.Windows.Forms.Button btnSalirPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}