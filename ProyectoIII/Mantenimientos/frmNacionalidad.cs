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
        clsDirecciones D = new clsDirecciones();
        public int Valor;
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
     
        private void frmDireccion_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            LlenarComboPais();
            LlenarGridNacionalidad();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "FactSYS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }
        private void Limpiar()
        {
            txtDescripcion.Clear();
            //cbPais.SelectedIndex = -1;
        }

        private void LlenarGridNacionalidad()
        {
            bool valor = true;
            DataTable dt = new DataTable();
            D.Valor = 0;
            dt = D.Listar(valor); 
            try
            {
                dtgNacionalidad.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgNacionalidad.Rows.Add(dt.Rows[x][0]);
                    dtgNacionalidad.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgNacionalidad.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();

                }
                dtgNacionalidad.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm2(tabPais, errorProvider1) == false)
            {
                return;
            }
            string mensaje = "";
            try
            {
                if (Program.Evento == 0)
                {
                    D.Valor = 0;
                    D.Id = 0;
                    D.Descripcion = txtDescripcion.Text;
                    mensaje = D.Registrar();
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
                    D.Valor = 0;
                    D.Descripcion = txtDescripcion.Text;
                    D.Id = Convert.ToInt32(txtCodigo.Text);
                    mensaje = D.Registrar();
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
                Program.Evento = 1;
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
