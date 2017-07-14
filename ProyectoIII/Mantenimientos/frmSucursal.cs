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
    public partial class frmSucursal : MetroForm
    {
        clsSucursal C = new clsSucursal();
        clsDirecciones D = new clsDirecciones();
        clsTipos T = new clsTipos();
        clsEmpresa E = new clsEmpresa();
        clsProveedor P = new clsProveedor();
        public frmSucursal()
        {
            InitializeComponent();
        }
        private void LlenarComboTipoC()
        {
            try
            {
                T.Iddestipo = 7;
                cbTipo.DataSource = T.ListarT(true);
                cbTipo.DisplayMember = "DESCRIPCION";
                cbTipo.ValueMember = "ID_TIPO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarComboRegion()
        {
            try
            {
                D.Valor = 1;
                cbRegion.DataSource = D.Listar(true);
                cbRegion.DisplayMember = "DESCRIPCION";
                cbRegion.ValueMember = "ID_REGION";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarComboEmpresa()
        {
            try
            {
                cbEmpresa.DataSource = E.Listar(true);
                cbEmpresa.DisplayMember = "nombre";
                cbEmpresa.ValueMember = "ID_tercero";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarComboCiudad()
        {
            try
            {
                D.Valor = 2;
                cbCiudad.DataSource = D.Listar(true);
                cbCiudad.DisplayMember = "DESCRIPCION";
                cbCiudad.ValueMember = "ID_CIUDAD";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarComboBarrio()
        {
            try
            {
                D.Valor = 3;
                cbBarrio.DataSource = D.Listar(true);
                cbBarrio.DisplayMember = "DESCRIPCION";
                cbBarrio.ValueMember = "ID_BARRIO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarGridCategoria()
        {
            DataTable dt = new DataTable();
            if(rbActivo.Checked)
            {
                C.Idtercero = 0;
                dt = C.Listar(true);

            }
            else if (rbInactivo.Checked)
            {
                C.Idtercero = 0;
                dt = C.Listar(false);

            }
          
            try
            {
                dtgSucursal.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgSucursal.Rows.Add(dt.Rows[x][0]);
                    dtgSucursal.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgSucursal.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgSucursal.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgSucursal.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                    dtgSucursal.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                    dtgSucursal.Rows[x].Cells[5].Value = dt.Rows[x][5].ToString();
                    dtgSucursal.Rows[x].Cells[6].Value = dt.Rows[x][6].ToString();
                    dtgSucursal.Rows[x].Cells[7].Value = dt.Rows[x][7].ToString();
                    dtgSucursal.Rows[x].Cells[8].Value = dt.Rows[x][8].ToString();
                    dtgSucursal.Rows[x].Cells[9].Value = dt.Rows[x][9].ToString();
                    dtgSucursal.Rows[x].Cells[10].Value = dt.Rows[x][10].ToString();

                }
                dtgSucursal.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtDescripcion.Clear();
            txtDireccion.Clear();
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
                    C.Direccion = txtDireccion.Text + "," + cbBarrio.Text + "," + cbCiudad.Text + "," + cbRegion.Text;
                    C.Idbarrio = Convert.ToInt32(cbBarrio.SelectedValue);
                    C.Idciudad = Convert.ToInt32(cbCiudad.SelectedValue);
                    C.Idregion = Convert.ToInt32(cbRegion.SelectedValue);
                    mensaje = C.RegistrarD();
                   
                    if (mensaje == "1")
                    {
                        C.Id = 0;
                        C.Descripcion = txtDescripcion.Text;
                        C.Idtercero = Convert.ToInt32(cbEmpresa.SelectedValue);
                        C.Idtipo = Convert.ToInt32(cbTipo.SelectedValue);
                        mensaje = C.Registrar();
                        if (mensaje == "1")
                        {
                            MessageBoxEx.Show("Registrado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Registro ya existe", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(Program.Evento==1)
                {
                    C.Iddireccion = Program.Iddireccion;
                    C.Direccion = txtDireccion.Text + "," + cbBarrio.Text + "," + cbCiudad.Text + "," + cbRegion.Text;
                    C.Idbarrio = Convert.ToInt32(cbBarrio.SelectedValue);
                    C.Idciudad = Convert.ToInt32(cbCiudad.SelectedValue);
                    C.Idregion = Convert.ToInt32(cbRegion.SelectedValue);
                    mensaje = C.ActualizarD();
                    if (mensaje == "1")
                    {
                        C.Id = Convert.ToInt32(txtCodigo.Text);
                        C.Descripcion = txtDescripcion.Text;
                        C.Idtercero = Convert.ToInt32(cbEmpresa.SelectedValue);
                        C.Idtipo = Convert.ToInt32(cbTipo.SelectedValue);
                        mensaje = C.Actualizar();
                        if (mensaje == "1")
                        {
                            MessageBoxEx.Show("Actualizado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
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
            if (dtgSucursal.SelectedRows.Count > 0)
            {

                txtCodigo.Text = dtgSucursal.CurrentRow.Cells[0].Value.ToString();
                Program.Iddireccion = Convert.ToInt32(dtgSucursal.CurrentRow.Cells[3].Value);
                txtDescripcion.Text = dtgSucursal.CurrentRow.Cells[1].Value.ToString();
                txtDireccion.Text= dtgSucursal.CurrentRow.Cells[4].Value.ToString();
                cbRegion.SelectedValue = Convert.ToInt32(dtgSucursal.CurrentRow.Cells[8].Value);
                cbCiudad.SelectedValue = Convert.ToInt32(dtgSucursal.CurrentRow.Cells[7].Value);
                cbBarrio.SelectedValue = Convert.ToInt32(dtgSucursal.CurrentRow.Cells[6].Value);
                cbTipo.SelectedValue = Convert.ToInt32(dtgSucursal.CurrentRow.Cells[9].Value);
                cbEmpresa.SelectedValue = Convert.ToInt32(dtgSucursal.CurrentRow.Cells[10].Value);
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
                if (dtgSucursal.SelectedRows.Count > 0)
                {
                    C.Id = Convert.ToInt32(dtgSucursal.CurrentRow.Cells[0].Value);
                    C.Estado = Convert.ToBoolean(dtgSucursal.CurrentRow.Cells[5].Value);
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
            rbActivo.Checked = true;
            LlenarGridCategoria();
            LlenarComboEmpresa();
            LlenarComboBarrio();
            LlenarComboCiudad();
            LlenarComboRegion();
            LlenarComboTipoC();
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
