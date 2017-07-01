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
    public partial class frmMarca : MetroForm
    {
        clsMarca M = new clsMarca();
        public frmMarca()
        {
            InitializeComponent();
        }
        private void LlenarGridMarca()
        {
            DataTable dt = new DataTable();
            dt = M.Listar(true);
            try
            {
                dtgMarca.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgMarca.Rows.Add(dt.Rows[x][0]);
                    dtgMarca.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgMarca.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgMarca.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();

                }
                dtgMarca.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtDescripcion.Clear();
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
                    M.Id = 0;
                    M.Descripcion = txtDescripcion.Text;
                    mensaje = M.Registrar();
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
                    M.Descripcion = txtDescripcion.Text;
                    M.Id = Convert.ToInt32(txtCodigo.Text);
                    mensaje = M.Registrar();
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
                LlenarGridMarca();
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
            if (dtgMarca.SelectedRows.Count > 0)
            {

                txtCodigo.Text = dtgMarca.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dtgMarca.CurrentRow.Cells[1].Value.ToString();
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
                if (dtgMarca.SelectedRows.Count > 0)
                {
                    M.Id = Convert.ToInt32(dtgMarca.CurrentRow.Cells[0].Value);
                    M.Estado = Convert.ToBoolean(dtgMarca.CurrentRow.Cells[2].Value);
                    mensaje = M.Activar();
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
            LlenarGridMarca();
        }
        private void frmMarca_Load(object sender, EventArgs e)
        {
            LlenarGridMarca();
            Program.Evento = 0;
        }
    }
}
