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
    public partial class frmCargo : MetroForm
    {
        clsCargo C = new clsCargo();
        public frmCargo()
        {
            InitializeComponent();
        }
        private void LlenarGridCargo()
        {
            DataTable dt = new DataTable();
            dt = C.Listar(true);
            try
            {
                dtgCargo.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgCargo.Rows.Add(dt.Rows[x][0]);
                    dtgCargo.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgCargo.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgCargo.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgCargo.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();

                }
                dtgCargo.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtDescripcion.Clear();
            txtDetalle.Clear();
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
                    C.Detalle = txtDetalle.Text;
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
                    C.Detalle = txtDetalle.Text;
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
                LlenarGridCargo();
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
            if (dtgCargo.SelectedRows.Count > 0)
            {

                txtCodigo.Text = dtgCargo.CurrentRow.Cells[0].Value.ToString();
                txtDetalle.Text = dtgCargo.CurrentRow.Cells[2].Value.ToString();
                txtDescripcion.Text = dtgCargo.CurrentRow.Cells[1].Value.ToString();
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
                if (dtgCargo.SelectedRows.Count > 0)
                {
                    C.Id = Convert.ToInt32(dtgCargo.CurrentRow.Cells[0].Value);
                    C.Estado = Convert.ToBoolean(dtgCargo.CurrentRow.Cells[3].Value);
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
            LlenarGridCargo();
        }
        private void frmCargo_Load(object sender, EventArgs e)
        {
            LlenarGridCargo();
            Program.Evento = 0;
        }
    }
}
