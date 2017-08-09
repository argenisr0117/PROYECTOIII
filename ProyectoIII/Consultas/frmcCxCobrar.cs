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
    public partial class frmcCxCobrar : MetroForm
    {
        public frmcCxCobrar()
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
            txtCliente.Clear();
            txtCodigoCliente.Clear();
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
                    if (string.IsNullOrEmpty(txtCodigoCliente.Text))
                    {
                        obj.Idcliente = 0;
                    }
                    else
                    {
                        obj.Idcliente = Convert.ToInt16(txtCodigoCliente.Text);
                    }
                    obj.Fechad = dtpFechad.Value;
                    obj.Fechah = dtpFechah.Value;
                    obj.Valor = 9;
                    obj.Reporte = "facturas_cxc.rdlc";
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
                Consultas.frmcCliente obj = new Consultas.frmcCliente();
                obj.ShowDialog();
                if (Program.seleccion == 3)
                {
                    txtCodigoCliente.Text = Program.Idcliente;
                    txtCliente.Text = Program.Cliente;
                }
                Program.seleccion = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
