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
    public partial class frmcOrdenCompra : MetroForm
    {
        public frmcOrdenCompra()
        {
            InitializeComponent();
        }
        clsCompras C = new clsCompras();
        private void LlenarGrid()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = C.BuscarOrdenes();
                dtgOrdenes.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgOrdenes.Rows.Add(dt.Rows[x][0]);
                    dtgOrdenes.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgOrdenes.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgOrdenes.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    //dtgOrdenes.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();

                }
                dtgOrdenes.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmcOrdenCompra_Load(object sender, EventArgs e)
        {
            dtgOrdenes.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9);
            dtgOrdenes.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dtpFechaD.Value= new DateTime(DateTime.Now.Year, 1, 1);
            C.Idproveedor = 0;
            C.Documento = "";
            C.Fecha = dtpFechaD.Value;
            C.Fechah = dtpFechaH.Value;
            LlenarGrid();
            txtNoDocumento.Focus();

        }

        private void txtNoDocumento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoPv.Text))
                {
                    C.Idproveedor = 0;
                }
                else
                {
                    C.Idproveedor = Convert.ToInt32(txtCodigoPv.Text);
                }
                C.Documento = txtNoDocumento.Text;
                C.Fecha = dtpFechaD.Value;
                C.Fechah = dtpFechaH.Value;
                LlenarGrid();
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
            
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                frmcProveedor obj = new frmcProveedor();
                obj.ShowDialog();
                C.Idproveedor = Convert.ToInt32(Program.Idproveedor);
                LlenarGrid();
                txtCodigoPv.Text = Program.Idproveedor.ToString();
                txtProveedor.Text = Program.Proveedor;
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
            
        }

        private void dtgOrdenes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.Documento = dtgOrdenes.CurrentRow.Cells[0].Value.ToString();
            Procesos.frmEntradaInventario obj = new Procesos.frmEntradaInventario();
            this.Hide();
            obj.ShowDialog();
            this.Close();
        }
    }
}
