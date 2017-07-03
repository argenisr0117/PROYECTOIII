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
    public partial class frmTipos : MetroForm
    {
        clsTipos T = new clsTipos();
        public frmTipos()
        {
            InitializeComponent();
        }
        private void LlenarComboTipos()
        {
            try
            {
                //T.Valor = 0;
                cbTipo.DataSource = T.Listar(true);
                cbTipo.DisplayMember = "DESCRIPCION";
                cbTipo.ValueMember = "ID_DES_TIPO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void LlenarGridTipos()
        {
            DataTable dt = new DataTable();
            T.Valor = 0;
            dt = T.ListarT(true);
            try
            {
                dtgTipos.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgTipos.Rows.Add(dt.Rows[x][0]);
                    dtgTipos.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgTipos.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgTipos.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgTipos.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();

                }
                dtgTipos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtDescripcion.Clear();
            cbTipo.SelectedValue = 0;
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
                    T.Iddestipo = Convert.ToInt32(cbTipo.SelectedValue);
                    mensaje = T.RegistrarT();
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
                    T.Iddestipo = Convert.ToInt32(cbTipo.SelectedValue);
                    mensaje = T.RegistrarT();
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
                LlenarGridTipos();
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
            if (dtgTipos.SelectedRows.Count > 0)
            {

                txtCodigo.Text = dtgTipos.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dtgTipos.CurrentRow.Cells[1].Value.ToString();
                cbTipo.Text = dtgTipos.CurrentRow.Cells[2].Value.ToString();
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
                if (dtgTipos.SelectedRows.Count > 0)
                {
                    T.Id = Convert.ToInt32(dtgTipos.CurrentRow.Cells[0].Value);
                    T.Estado = Convert.ToBoolean(dtgTipos.CurrentRow.Cells[3].Value);
                    T.Campo = "id_tipo";
                    T.Tabla = "Tipos";
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
            LlenarGridTipos();
        }

        private void frmTipos_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            LlenarComboTipos();
            LlenarGridTipos();
        }
    }
}
