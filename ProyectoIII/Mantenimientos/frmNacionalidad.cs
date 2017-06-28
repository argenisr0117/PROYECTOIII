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
    public partial class frmNacionalidad : MetroForm
    {
        clsNacionalidad N = new clsNacionalidad();
        clsDirecciones D = new clsDirecciones();
        public frmNacionalidad()
        {
            InitializeComponent();
        }
        private void LlenarComboPais()
        {
            try
            {
                D.Valor = 0;
                cbPais.DataSource = D.Listar(true);
                cbPais.DisplayMember = "DESCRIPCION";
                cbPais.ValueMember = "ID_PAIS";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmNacionalidad_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            LlenarComboPais();
            LlenarGridNacionalidad();
        }
        private void LlenarGridNacionalidad()
        {
            DataTable dt = new DataTable();
            dt = N.Listar(true);
            try
            {
                dtgNacionalidad.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgNacionalidad.Rows.Add(dt.Rows[x][0]);
                    dtgNacionalidad.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgNacionalidad.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgNacionalidad.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgNacionalidad.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();

                }
                dtgNacionalidad.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtDescripcion.Clear();
            cbPais.SelectedValue = -1;
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
                    N.Id = 0;
                    N.Descripcion = txtDescripcion.Text;
                    N.Idpais = Convert.ToInt32(cbPais.SelectedValue);
                    mensaje = N.Registrar();
                    if (mensaje == "1")
                    {
                        MessageBoxEx.Show("Registrado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        LlenarComboPais();
                    }
                    else
                    {
                        MessageBoxEx.Show("Registro ya existe", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    N.Descripcion = txtDescripcion.Text;
                    N.Id = Convert.ToInt32(txtCodigo.Text);
                    N.Idpais = Convert.ToInt32(cbPais.SelectedValue);
                    mensaje = N.Registrar();
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
                LlenarGridNacionalidad();
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
            if (dtgNacionalidad.SelectedRows.Count > 0)
            {

                txtCodigo.Text = dtgNacionalidad.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dtgNacionalidad.CurrentRow.Cells[1].Value.ToString();
                cbPais.Text = dtgNacionalidad.CurrentRow.Cells[2].Value.ToString();
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
                if (dtgNacionalidad.SelectedRows.Count > 0)
                {
                    N.Id = Convert.ToInt32(dtgNacionalidad.CurrentRow.Cells[0].Value);
                    N.Estado = Convert.ToBoolean(dtgNacionalidad.CurrentRow.Cells[3].Value);
                    mensaje = N.Activar();
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
            LlenarGridNacionalidad();
        }
    }
}
