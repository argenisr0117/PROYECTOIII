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
    public partial class frmEquivalenciaUnidad : MetroForm
    {
        clsUnidad U = new clsUnidad();
        public frmEquivalenciaUnidad()
        {
            InitializeComponent();
        }
        private void LlenarGridUnidad()
        {
            DataTable dt = new DataTable();
            dt = U.Listar(true);
            try
            {
                dtgUnidad.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgUnidad.Rows.Add(dt.Rows[x][0]);
                    dtgUnidad.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgUnidad.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgUnidad.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgUnidad.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();

                }
                dtgUnidad.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtDescripcion.Clear();
            //txtAbreviacion.Clear();
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
                    U.Id = 0;
                    U.Descripcion = txtDescripcion.Text;
                   // U.Abreviacion = txtAbreviacion.Text;
                    mensaje = U.Registrar();
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
                    U.Descripcion = txtDescripcion.Text;
                    U.Id = Convert.ToInt32(txtCodigo.Text);
                    //U.Abreviacion = txtAbreviacion.Text;
                    mensaje = U.Registrar();
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
                LlenarGridUnidad();
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
            if (dtgUnidad.SelectedRows.Count > 0)
            {

                txtCodigo.Text = dtgUnidad.CurrentRow.Cells[0].Value.ToString();
               // txtAbreviacion.Text = dtgUnidad.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = dtgUnidad.CurrentRow.Cells[2].Value.ToString();
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
                if (dtgUnidad.SelectedRows.Count > 0)
                {
                    U.Id = Convert.ToInt32(dtgUnidad.CurrentRow.Cells[0].Value);
                    U.Estado = Convert.ToBoolean(dtgUnidad.CurrentRow.Cells[3].Value);
                    mensaje = U.Activar();
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
            LlenarGridUnidad();
        }
        private void frmUnidad_Load(object sender, EventArgs e)
        {

            LlenarGridUnidad();
            Program.Evento = 0;
        }
    }
}
