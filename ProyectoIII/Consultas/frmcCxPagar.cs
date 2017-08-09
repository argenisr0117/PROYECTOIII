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

namespace ProyectoIII.Consultas
{
    public partial class frmcCxPagar : MetroForm
    {
        public frmcCxPagar()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "FactSYS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtProveedor.Clear();
            txtCodigo.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpFechad.Value > dtpFechah.Value)
                {
                    MessageBox.Show("Fecha inicial no puede ser mayor que la final!");
                }
                else
                {
                    frmReporte obj = new frmReporte();
                    if (string.IsNullOrEmpty(txtCodigo.Text))
                    {
                        obj.Idproveedor = 0;
                    }
                    else
                    {
                        obj.Idproveedor = Convert.ToInt16(txtCodigo.Text);
                    }
                    obj.Fechad = dtpFechad.Value;
                    obj.Fechah = dtpFechah.Value;
                    obj.Valor = 10;
                    obj.Reporte = "facturas_cxp.rdlc";
                    obj.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                frmcProveedor obj = new frmcProveedor();
                obj.ShowDialog();
                if (Program.seleccion == 3)
                {
                    txtCodigo.Text = Program.Idproveedor;
                    txtProveedor.Text = Program.Proveedor;
                }
                Program.seleccion = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmcCxCobrar_Load(object sender, EventArgs e)
        {
            dtpFechad.Value = new DateTime(DateTime.Now.Year,DateTime.Now.Month, 1);
        }
    }
}
