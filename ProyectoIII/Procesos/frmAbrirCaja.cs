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

namespace ProyectoIII.Procesos
{
    public partial class frmAbrirCaja : MetroForm
    {
        clsUsuario U = new clsUsuario();
        clsCaja C = new clsCaja();
        private void LlenarComboUsuario()
        {
            try
            {
                cbUsuario.DataSource = U.Listar(true);
                cbUsuario.DisplayMember = "Usuario";
                cbUsuario.ValueMember = "ID_usuario";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarComboCaja()
        {
            try
            {
                cbCaja.DataSource = C.Listar(true);
                cbCaja.DisplayMember = "Descripcion";
                cbCaja.ValueMember = "ID_caja";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        public frmAbrirCaja()
        {
            InitializeComponent();
        }

        private void frmAbrirCaja_Load(object sender, EventArgs e)
        {
            LlenarComboCaja();
            LlenarComboUsuario();
            Program.Evento = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "FactSYS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (Utilidades.ValidarForm(this, errorProvider1) == false)
                {
                    return;
                }
                if (Program.Evento == 0)
                {
                    bool mensaje;
                    C.Idcaja = Convert.ToInt32(cbCaja.SelectedValue);
                    C.Idusuario = Convert.ToInt32(cbUsuario.SelectedValue);
                    C.Monto = Convert.ToDouble(txtMontoInicial.Text);
                    mensaje = C.AbrirCaja();
                    if (mensaje)
                    {
                        MessageBoxEx.Show("Caja abierta con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBoxEx.Show("Ha ocurrido un error o caja ya esta abierta", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            txtMontoInicial.Clear();
            cbCaja.SelectedIndex = -1;
            cbUsuario.SelectedIndex = -1;
        }
    }
}
