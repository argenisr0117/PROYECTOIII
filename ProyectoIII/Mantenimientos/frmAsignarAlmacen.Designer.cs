namespace ProyectoIII.Mantenimientos
{
    partial class frmAsignarAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarAlmacen));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.txtProducto = new ProyectoIII.Controles.textbox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAlmacen = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtgAlmacen = new System.Windows.Forms.DataGridView();
            this.idalmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlmacen)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "ASIGNACIÓN DE ALMACÉN";
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
            this.btnBuscarP.Location = new System.Drawing.Point(434, 76);
            this.btnBuscarP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(40, 28);
            this.btnBuscarP.TabIndex = 44;
            this.btnBuscarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarP.UseVisualStyleBackColor = false;
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(161, 76);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(267, 27);
            this.txtProducto.TabIndex = 42;
            this.txtProducto.Validar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "PRODUCTO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "ALMACÉN:";
            // 
            // cbAlmacen
            // 
            this.cbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlmacen.FormattingEnabled = true;
            this.cbAlmacen.Location = new System.Drawing.Point(161, 109);
            this.cbAlmacen.Name = "cbAlmacen";
            this.cbAlmacen.Size = new System.Drawing.Size(267, 27);
            this.cbAlmacen.TabIndex = 45;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnAgregar.FlatAppearance.BorderSize = 3;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = global::ProyectoIII.Properties.Resources.add__3_;
            this.btnAgregar.Location = new System.Drawing.Point(434, 108);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 28);
            this.btnAgregar.TabIndex = 47;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // dtgAlmacen
            // 
            this.dtgAlmacen.AllowUserToAddRows = false;
            this.dtgAlmacen.AllowUserToDeleteRows = false;
            this.dtgAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlmacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalmacen,
            this.almacen,
            this.eliminar});
            this.dtgAlmacen.Location = new System.Drawing.Point(12, 154);
            this.dtgAlmacen.Name = "dtgAlmacen";
            this.dtgAlmacen.ReadOnly = true;
            this.dtgAlmacen.Size = new System.Drawing.Size(504, 191);
            this.dtgAlmacen.TabIndex = 48;
            // 
            // idalmacen
            // 
            this.idalmacen.HeaderText = "idalmacen";
            this.idalmacen.Name = "idalmacen";
            this.idalmacen.ReadOnly = true;
            this.idalmacen.Visible = false;
            // 
            // almacen
            // 
            this.almacen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.almacen.HeaderText = "ALMACÉN";
            this.almacen.Name = "almacen";
            this.almacen.ReadOnly = true;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmAsignarAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 356);
            this.Controls.Add(this.dtgAlmacen);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbAlmacen);
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
            this.Name = "frmAsignarAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlmacen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarP;
        private Controles.textbox txtProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAlmacen;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacen;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}