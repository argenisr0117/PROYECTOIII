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
    public partial class frmProveedor : MetroForm
    {
        clsDirecciones D = new clsDirecciones();
        clsTipos T = new clsTipos();
        public frmProveedor()
        {
            InitializeComponent();
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
        private void LlenarComboTipoC()
        {
            try
            {
                T.Iddestipo = 2;
                cbTipoContacto.DataSource = T.ListarT(true);
                cbTipoContacto.DisplayMember = "DESCRIPCION";
                cbTipoContacto.ValueMember = "ID_TIPO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarComboTipoP()
        {
            try
            {
                T.Iddestipo = 6;
                cbTipoProveedor.DataSource = T.ListarT(true);
                cbTipoProveedor.DisplayMember = "DESCRIPCION";
                cbTipoProveedor.ValueMember = "ID_TIPO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void frmProveedor_Load(object sender, EventArgs e)
        {
            LlenarComboCiudad();
            LlenarComboRegion();
            LlenarComboBarrio();
            LlenarComboTipoC();
            LlenarComboTipoP();
            Program.Evento = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "FactSYS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void cbRegion_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                D.Id = Convert.ToInt32(cbRegion.SelectedValue);
                LlenarComboCiudad();
            }
            catch(Exception ex)
            {

            }
            
        }

        private void cbCiudad_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                D.Id = Convert.ToInt32(cbCiudad.SelectedValue);
                LlenarComboBarrio();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (Utilidades.ValidarForm2(gbContacto, errorProvider1) == false)
                {
                    return;
                }
                if(Program.Evento==0)
                {
                    dtgContacto.Rows.Add(0, txtContacto.Text, cbTipoContacto.SelectedValue, cbTipoContacto.Text, "EDITAR");
                    txtContacto.Clear();
                }
                else if (Program.Evento == 1)
                {

                }
                
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
           
        }

        private void dtgContacto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==4)
            {
                txtContacto.Text = dtgContacto.CurrentRow.Cells[1].Value.ToString();
                cbTipoContacto.Text= dtgContacto.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnAgregarD_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (Utilidades.ValidarForm2(gbDireccion, errorProvider1) == false)
                {
                    return;
                }
                if (Program.Evento == 0)
                {
                    //dtgContacto.Rows.Add(0, txtContacto.Text, cbTipoContacto.SelectedValue, cbTipoContacto.Text, "EDITAR");
                    //txtContacto.Clear();
                }
                else if (Program.Evento == 1)
                {

                }

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }
    }
}
