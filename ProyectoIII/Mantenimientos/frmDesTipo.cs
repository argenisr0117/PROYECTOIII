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
    public partial class frmDesTipo : MetroForm
    {
        clsTipos T = new clsTipos();
        public frmDesTipo()
        {
            InitializeComponent();
        }
        private void LlenarGrid()
        {
            DataTable dt = new DataTable();
            dt = T.Listar(true);
            try
            {
                dtgDesTipo.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgDesTipo.Rows.Add(dt.Rows[x][0]);
                    dtgDesTipo.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgDesTipo.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgDesTipo.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();

                }
                dtgDesTipo.ClearSelection();
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
                    T.Id = 0;
                    T.Descripcion = txtDescripcion.Text;
                    mensaje = T.Registrar();
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
                    T.Descripcion = txtDescripcion.Text;
                    T.Id = Convert.ToInt32(txtCodigo.Text);
                    mensaje = T.Registrar();
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
                LlenarGrid();
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
            if (dtgDesTipo.SelectedRows.Count > 0)
            {

                txtCodigo.Text = dtgDesTipo.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dtgDesTipo.CurrentRow.Cells[1].Value.ToString();
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
                if (dtgDesTipo.SelectedRows.Count > 0)
                {
                    T.Id = Convert.ToInt32(dtgDesTipo.CurrentRow.Cells[0].Value);
                    T.Estado = Convert.ToBoolean(dtgDesTipo.CurrentRow.Cells[2].Value);
                    T.Campo = "id_des_tipo";
                    T.Tabla = "Des_Tipo";
                    mensaje = T.Activar();
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
            LlenarGrid();
        }

        private void frmDesTipo_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            Program.Evento = 0;
        }
    }
}
