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
namespace ProyectoIII
{
    public partial class frmLogin : MetroForm
    {
        clsUsuario U = new clsUsuario();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmMenu obj = new frmMenu();
            Program.Idsucursal = 1;
            string mensaje = VerificarLogin();
            if (mensaje == "0")
            {
                MessageBoxEx.Show("Datos incorrectos!", "FactSYS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                txtContrasena.Clear();
                txtUsuario.Clear();
                txtUsuario.Focus();
            }
            else if (mensaje != "0")
            {
                Program.Idusuario = Convert.ToInt32(mensaje);
                U.Descripcion = Environment.MachineName;
                U.Id = Convert.ToInt32(mensaje);
                U.RegistrarLog();
                this.Hide();
                obj.ShowDialog();
                this.Close();
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
        private string VerificarLogin()
        {
            string mensaje="";
            string hash = Utilidades.EncodePassword(string.Concat(txtUsuario.Text, txtContrasena.Text));
            try
            {
                U.Descripcion = txtUsuario.Text;
                U.Clave = hash;
                mensaje = U.VerificarLogin();
               
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
            return mensaje;
        }
    }
}
