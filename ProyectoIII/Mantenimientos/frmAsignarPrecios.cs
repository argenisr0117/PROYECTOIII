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
    public partial class frmAsignarPrecios: MetroForm
    {
        public frmAsignarPrecios()
        {
            InitializeComponent();
        }
        clsAlmacen A = new clsAlmacen();
        clsProducto P = new clsProducto();           

        private void Limpiar()
        {
            txtProducto.Clear();
            txtInicial1.Clear();
            txtFinal1.Clear();
            txtUtilidad.Clear();
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
                dt = P.ListadoPrecios();
                dtgPrecio.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgPrecio.Rows.Add(dt.Rows[x][0]);
                    dtgPrecio.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgPrecio.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgPrecio.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgPrecio.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                    dtgPrecio.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();

                }
                dtgPrecio.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmAsignarAlmacen_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            dtgPrecio.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
        }

        private void btnAgregarD_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm(this, errorProvider1) == false)
            {
                return;
            }
            try
            {
                if(Convert.ToDouble(txtInicial1.Text)< Convert.ToDouble(txtFinal1.Text))
                {
                    if (Program.Evento == 0)
                    {
                        string mensaje = "";
                        P.Idproducto = Program.Idproducto;
                        P.Rangof = Convert.ToDouble(txtFinal1.Text);
                        P.Rangoi = Convert.ToDouble(txtInicial1.Text);
                        P.Utilidad = Convert.ToDouble(txtUtilidad.Text);
                        mensaje = P.RegistrarPrecios();
                        if (mensaje == "1")
                        {
                            MessageBoxEx.Show("Registrado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (mensaje == "0")
                        {
                            MessageBoxEx.Show("Rango ya registrado", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        LlenarGrid();
                        Limpiar();
                    }
                    else if (Program.Evento==1)
                    {
                        string mensaje = "";
                        P.Idprecio=Program.Idprecio;
                        P.Idproducto = Program.Idproducto;
                        P.Rangof = Convert.ToDouble(txtFinal1.Text);
                        P.Rangoi = Convert.ToDouble(txtInicial1.Text);
                        P.Utilidad = Convert.ToDouble(txtUtilidad.Text);
                        mensaje = P.ActualizarPrecios();
                        if (mensaje == "1")
                        {
                            MessageBoxEx.Show("Registrado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (mensaje == "0")
                        {
                            MessageBoxEx.Show("Rango ya registrado", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        LlenarGrid();
                        Limpiar();
                    }
                   
                }
                else
                {
                    MessageBoxEx.Show("Rango inicial no puede ser mayor que el final", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }


            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void dtgPrecio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.Idprecio = Convert.ToInt32(dtgPrecio.CurrentRow.Cells[0].Value);
            txtInicial1.Text = dtgPrecio.CurrentRow.Cells[2].Value.ToString();
            txtFinal1.Text = dtgPrecio.CurrentRow.Cells[3].Value.ToString();
            txtUtilidad.Text = dtgPrecio.CurrentRow.Cells[4].Value.ToString();
            Program.Evento = 1;
        }
    }
}
