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
    public partial class frmcAlmacen : MetroForm
    {
        clsAlmacen A = new clsAlmacen();
        public frmcAlmacen()
        {
            InitializeComponent();
        }

        private void frmcProveedor_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        private void LlenarGrid()
        {
            DataTable dt = new DataTable();
            A.Idproducto =Convert.ToInt32(Program.Idproduct);
            dt = A.AlmacenesProductos();
            try
            {
                dtgAlmacen.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgAlmacen.Rows.Add(dt.Rows[x][0]);
                    dtgAlmacen.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgAlmacen.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgAlmacen.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgAlmacen.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();

                }
                dtgAlmacen.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgAlmacen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.Idalmacen = Convert.ToInt32(dtgAlmacen.CurrentRow.Cells[0].Value);
            Program.Almacen = dtgAlmacen.CurrentRow.Cells[1].Value.ToString();
            Program.Existencia = Convert.ToDouble(dtgAlmacen.CurrentRow.Cells[3].Value);
            this.Close();
        }

        private void dtgAlmacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}