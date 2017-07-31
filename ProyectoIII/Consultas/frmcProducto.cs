using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using Entidades;

namespace ProyectoIII.Consultas
{
    public partial class frmcProducto : MetroForm
    {
        clsProducto P = new clsProducto();
        public frmcProducto()
        {
            InitializeComponent();
        }

        private void LlenarGridProducto()
        {
            DataTable dt = new DataTable();
            if (rbActivo.Checked)
            {
                P.Estado = true;
            }
            else if (rbInactivo.Checked)
            {
                P.Estado = false;
            }
            dt = P.Listar();
            try
            {
                dtgProducto.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgProducto.Rows.Add(dt.Rows[x][0]);
                    dtgProducto.Rows[x].Cells[1].Value = dt.Rows[x][0].ToString();
                    dtgProducto.Rows[x].Cells[2].Value = dt.Rows[x][1].ToString();
                    dtgProducto.Rows[x].Cells[3].Value = dt.Rows[x][2].ToString();
                    dtgProducto.Rows[x].Cells[4].Value = dt.Rows[x][3].ToString();
                    dtgProducto.Rows[x].Cells[5].Value = dt.Rows[x][4].ToString();
                    dtgProducto.Rows[x].Cells[6].Value = dt.Rows[x][5].ToString();
                    dtgProducto.Rows[x].Cells[7].Value = dt.Rows[x][6].ToString();
                    dtgProducto.Rows[x].Cells[8].Value = dt.Rows[x][7].ToString();
                    dtgProducto.Rows[x].Cells[9].Value = dt.Rows[x][8].ToString();
                    dtgProducto.Rows[x].Cells[10].Value = dt.Rows[x][9].ToString();
                    dtgProducto.Rows[x].Cells[11].Value = dt.Rows[x][10].ToString();


                }
                dtgProducto.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbDescripcion.Checked)
                {
                    P.Tipo = 1;
                }
                else if (rbReferencia.Checked)
                {
                    P.Tipo = 2;
                }
                P.Valor1 = txtBusqueda.Text;
                LlenarGridProducto();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "FactSYS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Program.Editar = 0;
            Mantenimientos.frmProducto obj = new Mantenimientos.frmProducto();
            obj.ShowDialog();
            P.Valor1 = "";
            LlenarGridProducto();
        }
        private void btnElegir_Click(object sender, EventArgs e)
        {
            if (dtgProducto.SelectedRows.Count>0)
            {
                Program.Idproducto = Convert.ToInt32(dtgProducto.CurrentRow.Cells[1].Value);
                Program.Idproduct = dtgProducto.CurrentRow.Cells[1].Value.ToString();
                Program.Producto = dtgProducto.CurrentRow.Cells[2].Value.ToString();
                Program.Unidad= dtgProducto.CurrentRow.Cells[4].Value.ToString();
                Program.Costo= Convert.ToDouble(dtgProducto.CurrentRow.Cells[8].Value);
                Program.Costoa= Convert.ToDouble(dtgProducto.CurrentRow.Cells[11].Value);
                Program.Costop= Convert.ToDouble(dtgProducto.CurrentRow.Cells[10].Value);
                Program.Itbis= Convert.ToDouble(dtgProducto.CurrentRow.Cells[9].Value);
                this.Close();
            }
            else
            {
                MessageBoxEx.Show("Debe seleccionar un registro", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dtgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Program.Editar = 1;
                Program.Idproducto = Convert.ToInt32(dtgProducto.CurrentRow.Cells[1].Value);
                Mantenimientos.frmProducto obj = new Mantenimientos.frmProducto();
                obj.ShowDialog();
                LlenarGridProducto();
            }
        }

        private void dtgProducto_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && this.dtgProducto.Columns[e.ColumnIndex].Name == "editar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dtgProducto.Rows[e.RowIndex].Cells["editar"] as DataGridViewButtonCell;
                    Icon icoEditar = new Icon(Environment.CurrentDirectory + @"\Recursos\" + @"edit1.ico");
                    e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 10, e.CellBounds.Top + 3);
                    this.dtgProducto.Rows[e.RowIndex].Height = icoEditar.Height + 5;
                    this.dtgProducto.Columns[e.ColumnIndex].Width = icoEditar.Width + 20;

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmcProducto_Load(object sender, EventArgs e)
        {
            rbDescripcion.Checked = true;
            rbActivo.Checked = true;
            //txtBusqueda.Focus();
            P.Valor1 = "";
            P.Tipo = 1;
            LlenarGridProducto();
            txtBusqueda.Focus();
        }

        private void rbReferencia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                P.Tipo = 2;
                P.Valor1 = txtBusqueda.Text;
                LlenarGridProducto();
                txtBusqueda.Focus();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void rbDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                P.Tipo = 1;
                P.Valor1 = txtBusqueda.Text;
                LlenarGridProducto();
                txtBusqueda.Focus();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                P.Tipo = 3;
                P.Valor1 = txtBusqueda.Text;
                LlenarGridProducto();
                txtBusqueda.Focus();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgProducto.SelectedRows.Count > 0)
                {
                    P.Id = Convert.ToInt32(dtgProducto.CurrentRow.Cells[1].Value);
                    P.Estado = Convert.ToBoolean(dtgProducto.CurrentRow.Cells[7].Value);
                    P.Tabla = "Producto";
                    P.Campo = "id_producto";
                    mensaje = P.Activar();
                    if (mensaje == "0")
                    {
                        MessageBoxEx.Show("Desactivado", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBoxEx.Show("Activado", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBoxEx.Show("Seleccione un registro!", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("Error:" + ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LlenarGridProducto();
        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridProducto();
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridProducto();
        }
    }
}