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

namespace ProyectoIII.Mantenimientos
{
    public partial class frmUsuario : MetroForm
    {
        clsUsuario C = new clsUsuario();
        clsEmpleado E = new clsEmpleado();
        public frmUsuario()
        {
            InitializeComponent();
        }
        private void LlenarComboPerfil()
        {
            try
            {
                cbPerfil.DataSource = C.ListarP();
                cbPerfil.DisplayMember = "DESCRIPCION";
                cbPerfil.ValueMember = "ID_perfil";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarGridCategoria()
        {
            DataTable dt = new DataTable();
            dt = C.Listar(true);
            try
            {
                dtgUsuario.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgUsuario.Rows.Add(dt.Rows[x][0]);
                    dtgUsuario.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgUsuario.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgUsuario.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();

                }
                dtgUsuario.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtUsuario.Clear();
            txtClave2.Clear();
            txtClave.Clear();
            txtEmpleado.Clear();
            txtUsuario.Focus();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "FactSYS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm2(this, errorProvider1) == false)
            {
                return;
            }
            string mensaje = "";
            try
            {
                if (Program.Evento == 0)
                {
                    if (txtClave.Text == txtClave2.Text)
                    {
                        string hash= Utilidades.EncodePassword(string.Concat(txtUsuario.Text, txtClave.Text));
                        C.Id = 0;
                        C.Descripcion = txtUsuario.Text;
                        C.Clave = hash;
                        C.Idempleado = Program.Codigo;
                        C.Idperfil = Convert.ToInt32(cbPerfil.SelectedValue);
                        mensaje = C.Registrar();
                        if (mensaje == "1")
                        {
                            MessageBoxEx.Show("Registrado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBoxEx.Show("Registro ya existe", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Claves no coinciden", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtClave.Clear();
                        txtClave2.Clear();
                    }
                    
                }
                else
                {
                    C.Id = Convert.ToInt32(txtCodigo.Text);
                    C.Descripcion = txtUsuario.Text;
                    C.Clave = txtClave.Text;
                    C.Idempleado = Program.Codigo;
                    C.Idperfil = Convert.ToInt32(cbPerfil.SelectedValue);
                    mensaje = C.Registrar();
                    if (mensaje == "2")
                    {
                        MessageBoxEx.Show("Actualizado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBoxEx.Show("Ha ocurrido un error", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Limpiar();
                    }
                }
                //LlenarGridCategoria();
                Program.Evento = 0;
                //Limpiar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgUsuario.SelectedRows.Count > 0)
            {

                txtCodigo.Text = dtgUsuario.CurrentRow.Cells[0].Value.ToString();
                txtUsuario.Text = dtgUsuario.CurrentRow.Cells[1].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgUsuario.SelectedRows.Count > 0)
                {
                    C.Id = Convert.ToInt32(dtgUsuario.CurrentRow.Cells[0].Value);
                    C.Estado = Convert.ToBoolean(dtgUsuario.CurrentRow.Cells[2].Value);
                    mensaje = C.Activar();
                    if (mensaje == "0")
                    {
                        MessageBoxEx.Show("Cancelado", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            LlenarGridCategoria();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            LlenarComboPerfil();
            //LlenarGridCategoria();
            Program.Evento = 0;
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            try
            {
                Consultas.frmcEmpleado obj = new Consultas.frmcEmpleado();
                obj.ShowDialog();
                txtEmpleado.Text = Program.Empleado;
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
    }
}
