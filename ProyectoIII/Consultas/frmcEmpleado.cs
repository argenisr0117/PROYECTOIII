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
    public partial class frmcEmpleado : MetroForm
    {
        clsProveedor P = new clsProveedor();
        public frmcEmpleado()
        {
            InitializeComponent();
        }

        private void frmcProveedor_Load(object sender, EventArgs e)
        {
            rbNombre.Checked = true;
            rbActivo.Checked = true;
            //txtBusqueda.Focus();
            P.Valor1 = "";
            P.Tipo = 1;
            LlenarGridProveedor();
            txtBusqueda.Focus();
        }
        private void LlenarGridProveedor()
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
                dtgProveedor.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgProveedor.Rows.Add(dt.Rows[x][0]);
                    dtgProveedor.Rows[x].Cells[1].Value = dt.Rows[x][0].ToString();
                    dtgProveedor.Rows[x].Cells[2].Value = dt.Rows[x][1].ToString();
                    dtgProveedor.Rows[x].Cells[3].Value = dt.Rows[x][2].ToString();
                    dtgProveedor.Rows[x].Cells[4].Value = dt.Rows[x][3].ToString();
                    dtgProveedor.Rows[x].Cells[5].Value = dt.Rows[x][4].ToString();
                    dtgProveedor.Rows[x].Cells[6].Value = dt.Rows[x][5].ToString();
                    dtgProveedor.Rows[x].Cells[7].Value = dt.Rows[x][6].ToString();

                }
                dtgProveedor.ClearSelection();
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
                if (rbNombre.Checked)
                {
                    P.Tipo = 1;
                }
                else if (rbRnc.Checked)
                {
                    P.Tipo = 2;
                }
                P.Valor1 = txtBusqueda.Text;
                LlenarGridProveedor();
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

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                P.Tipo = 1;
                P.Valor1 = txtBusqueda.Text;
                LlenarGridProveedor();
                txtBusqueda.Focus();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void rbRnc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                P.Tipo = 2;
                P.Valor1 = txtBusqueda.Text;
                LlenarGridProveedor();
                txtBusqueda.Focus();
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Program.Editar = 0;
            Mantenimientos.frmProveedor obj = new Mantenimientos.frmProveedor();
            obj.ShowDialog();
            P.Valor1 = "";
            LlenarGridProveedor();
        }

        private void dtgProveedor_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && this.dtgProveedor.Columns[e.ColumnIndex].Name == "editar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dtgProveedor.Rows[e.RowIndex].Cells["editar"] as DataGridViewButtonCell;
                    Icon icoEditar = new Icon(Environment.CurrentDirectory + @"\Recursos\" + @"edit1.ico");
                    e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 10, e.CellBounds.Top + 3);
                    this.dtgProveedor.Rows[e.RowIndex].Height = icoEditar.Height + 5;
                    this.dtgProveedor.Columns[e.ColumnIndex].Width = icoEditar.Width + 20;

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void dtgProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Program.Editar = 1;
                Program.Codigo = Convert.ToInt32(dtgProveedor.CurrentRow.Cells[1].Value);
                Mantenimientos.frmProveedor obj = new Mantenimientos.frmProveedor();
                obj.ShowDialog();
                LlenarGridProveedor();
            }
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            if (dtgProveedor.SelectedRows.Count>0)
            {
                Program.Codigo = Convert.ToInt32(dtgProveedor.CurrentRow.Cells[1].Value);
                Program.Proveedor = dtgProveedor.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBoxEx.Show("Debe seleccionar un registro", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgProveedor.SelectedRows.Count > 0)
                {
                    P.Id = Convert.ToInt32(dtgProveedor.CurrentRow.Cells[1].Value);
                    P.Estado = Convert.ToBoolean(dtgProveedor.CurrentRow.Cells[7].Value);
                    P.Tabla = "Tercero";
                    P.Campo = "id_tercero";
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
            LlenarGridProveedor();
        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridProveedor();
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridProveedor();
        }
    }
}