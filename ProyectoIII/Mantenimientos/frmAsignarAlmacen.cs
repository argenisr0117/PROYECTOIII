using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Entidades;

namespace ProyectoIII.Mantenimientos
{
    public partial class frmAsignarAlmacen : MetroForm
    {
        public frmAsignarAlmacen()
        {
            InitializeComponent();
        }
        clsAlmacen A = new clsAlmacen();
        clsProducto P = new clsProducto();
        private void LlenarComboAlmacen()
        {
            try
            {
                A.Idsucursal = 0;
                cbAlmacen.DataSource = A.Listar(true);
                cbAlmacen.DisplayMember = "DESCRIPCION";
                cbAlmacen.ValueMember = "ID_ALMACEN";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm2(this, errorProvider1) == false)
            {
                return;
            }
            try
            {
                string mensaje = "";
                P.Idproducto = Program.Idproducto;
                P.Idalmacen = Convert.ToInt32(cbAlmacen.SelectedValue);
                mensaje = P.AsignarAlmacen();
                if (mensaje == "1")
                {
                    MessageBoxEx.Show("Asignado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (mensaje == "2")
                {
                    MessageBoxEx.Show("Producto ya tiene almacén asignado", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                LlenarGrid();
                Limpiar();
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            txtProducto.Clear();
        }
        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            try
            {
                Consultas.frmcProducto obj = new Consultas.frmcProducto();
                obj.ShowDialog();
                txtProducto.Text = Program.Producto;
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void LlenarGrid()
        {
            DataTable dt = new DataTable();
            try
            {
                P.Idproducto = Program.Idproducto;
                P.Estado = true;
                P.Idsucursal = 0;
                dt = P.AlmacenesProducto();
                dtgAlmacen.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgAlmacen.Rows.Add(dt.Rows[x][0]);
                    dtgAlmacen.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgAlmacen.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgAlmacen.Rows[x].Cells[3].Value = dt.Rows[x][2].ToString();
                    dtgAlmacen.Rows[x].Cells[4].Value = dt.Rows[x][3].ToString();

                }
                dtgAlmacen.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAsignarAlmacen_Load(object sender, EventArgs e)
        {
            LlenarComboAlmacen();
        }

        private void dtgAlmacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    string mensaje = "";
                    P.Idproducto = Convert.ToInt32(dtgAlmacen.CurrentRow.Cells[3].Value);
                    P.Idalmacen = Convert.ToInt32(dtgAlmacen.CurrentRow.Cells[0].Value);
                    P.Estado = false;
                    mensaje = P.BloquearAlmacen();
                    if (mensaje == "1")
                    {
                        MessageBoxEx.Show("Bloqueado", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrid();
                        Limpiar();
                    }
                    else if(mensaje=="2")
                    {
                        MessageBoxEx.Show("Existencia del producto debe ser cero", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
          
        }

        private void dtgAlmacen_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && this.dtgAlmacen.Columns[e.ColumnIndex].Name == "eliminar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dtgAlmacen.Rows[e.RowIndex].Cells["eliminar"] as DataGridViewButtonCell;
                    Icon icoEditar = new Icon(Environment.CurrentDirectory + @"\Recursos\" + @"cancel (2).ico");
                    e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 20, e.CellBounds.Top + 3);
                    this.dtgAlmacen.Rows[e.RowIndex].Height = icoEditar.Height + 5;
                    this.dtgAlmacen.Columns[e.ColumnIndex].Width = icoEditar.Width + 40;

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
    }
}
