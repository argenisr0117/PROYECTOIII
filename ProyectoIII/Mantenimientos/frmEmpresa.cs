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
    public partial class frmEmpresa : MetroForm
    {
        clsEmpresa C = new clsEmpresa();
        public frmEmpresa()
        {
            InitializeComponent();
        }
        private void LlenarGridCategoria()
        {
            DataTable dt = new DataTable();
            if(rbActivo.Checked)
            {
                dt = C.Listar(true);

            }
            else if (rbInactivo.Checked)
            {
                dt = C.Listar(false);
            }
            try
            {
                dtgEmpresa.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgEmpresa.Rows.Add(dt.Rows[x][0]);
                    dtgEmpresa.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgEmpresa.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgEmpresa.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgEmpresa.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();

                }
                dtgEmpresa.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtDescripcion.Clear();
            txtRnc.Clear();
            txtDescripcion.Focus();
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
                    C.Id = 0;
                    C.Descripcion = txtDescripcion.Text;
                    C.Rnc = txtRnc.Text;
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
                    C.Descripcion = txtDescripcion.Text;
                    C.Id = Convert.ToInt32(txtCodigo.Text);
                    C.Rnc = txtRnc.Text;
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
                LlenarGridCategoria();
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
            if (dtgEmpresa.SelectedRows.Count > 0)
            {

                txtCodigo.Text = dtgEmpresa.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dtgEmpresa.CurrentRow.Cells[1].Value.ToString();
                txtRnc.Text = dtgEmpresa.CurrentRow.Cells[2].Value.ToString();
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
                if (dtgEmpresa.SelectedRows.Count > 0)
                {
                    C.Id = Convert.ToInt32(dtgEmpresa.CurrentRow.Cells[0].Value);
                    C.Estado = Convert.ToBoolean(dtgEmpresa.CurrentRow.Cells[3].Value);
                    mensaje = C.Activar();
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
            LlenarGridCategoria();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            LlenarGridCategoria();
            rbActivo.Checked = true;
            Program.Evento = 0;
        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridCategoria();
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridCategoria();
        }
    }
}
