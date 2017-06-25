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
    public partial class frmDireccion : MetroForm
    {
        clsDirecciones D = new clsDirecciones();
        public int Valor;
        public frmDireccion()
        {
            InitializeComponent();
        }

        private void SeleccionarTab()
        {
            if(Valor==0)
            {
                tabControl1.SelectedTab = tabPais;
                txtDescripcionPais.Focus();
            }
            else if(Valor==1)
            {
                tabControl1.SelectedTab = tabRegion;
            }
            else if (Valor == 2)
            {
                tabControl1.SelectedTab = tabCiudad;
            }
            else if (Valor == 3)
            {
                tabControl1.SelectedTab = tabBarrio;
            }
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

        private void frmDireccion_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            SeleccionarTab();
            LlenarGridPais();
            LlenarGridRegion();
            LlenarGridCiudad();
            LlenarGridBarrio();
            LlenarComboPais();
            LlenarComboRegion();
            LlenarComboCiudad();
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
            txtDescripcionPais.Clear();
            txtDescripcionR.Clear();
            //cbPais.SelectedIndex = -1;
            txtDescripcionB.Clear();
            txtDescripcionC.Clear();
        }

        /////*************************PAIS************************//////
        private void btnRegistrarPais_Click(object sender, EventArgs e)
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
                    D.Descripcion = txtDescripcionPais.Text;
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
                    D.Descripcion = txtDescripcionPais.Text;
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
                LlenarGridPais();
                Program.Evento = 0;
                //Limpiar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LlenarGridPais()
        {
            bool valor = true;
            DataTable dt = new DataTable();
            D.Valor = 0;
            dt = D.Listar(valor); 
            try
            {
                dtgPais.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgPais.Rows.Add(dt.Rows[x][0]);
                    dtgPais.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgPais.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();

                }
                dtgPais.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEditarPais_Click(object sender, EventArgs e)
        {
            if (dtgPais.SelectedRows.Count > 0)
            {

                txtCodigo.Text = dtgPais.CurrentRow.Cells[0].Value.ToString();
                txtDescripcionPais.Text = dtgPais.CurrentRow.Cells[1].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /////****************REGION***************************/////
        private void LlenarGridRegion()
        {
            bool valor = true;
            DataTable dt = new DataTable();
            D.Valor = 1;
            dt = D.Listar(valor);          
            try
            {
                dtgRegion.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgRegion.Rows.Add(dt.Rows[x][0]);
                    dtgRegion.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgRegion.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgRegion.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                }
                dtgRegion.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEditarR_Click(object sender, EventArgs e)
        {
            if (dtgRegion.SelectedRows.Count > 0)
            {

                txtCodigo.Text = dtgRegion.CurrentRow.Cells[0].Value.ToString();
                txtDescripcionR.Text = dtgRegion.CurrentRow.Cells[1].Value.ToString();
                cbPais.SelectedItem = dtgRegion.CurrentRow.Cells[2].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardarR_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm2(tabRegion, errorProvider1) == false)
            {
                return;
            }
            string mensaje = "";
            try
            {
                if (Program.Evento == 0)
                {
                    D.Valor = 1;
                    D.Id = 0;
                    D.Descripcion = txtDescripcionR.Text;
                    D.Id2 = Convert.ToInt32(cbPais.SelectedValue);
                    mensaje = D.Registrar();
                    if (mensaje == "1")
                    {
                        MessageBoxEx.Show("Registrado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        LlenarComboRegion();
                    }
                    else
                    {
                        MessageBoxEx.Show("Registro ya existe", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    D.Valor = 1;
                    D.Descripcion = txtDescripcionR.Text;
                    D.Id2 = Convert.ToInt32(cbPais.SelectedValue);
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
                LlenarGridRegion();
                Program.Evento = 0;
                //Limpiar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //////*****************CIUDAD****************************//////
        private void LlenarGridCiudad()
        {
            bool valor = true;
            DataTable dt = new DataTable();
            D.Valor = 2;
            dt = D.Listar(valor);
            try
            {
                dtgCiudad.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgCiudad.Rows.Add(dt.Rows[x][0]);
                    dtgCiudad.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgCiudad.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgCiudad.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                }
                dtgCiudad.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm2(tabCiudad, errorProvider1) == false)
            {
                return;
            }
            string mensaje = "";
            try
            {
                if (Program.Evento == 0)
                {
                    D.Valor = 2;
                    D.Id = 0;
                    D.Descripcion = txtDescripcionC.Text;
                    D.Id2 = Convert.ToInt32(cbRegion.SelectedValue);
                    mensaje = D.Registrar();
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
                    D.Valor = 2;
                    D.Descripcion = txtDescripcionC.Text;
                    D.Id2 = Convert.ToInt32(cbRegion.SelectedValue);
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
                LlenarGridCiudad();
                Program.Evento = 0;
                //Limpiar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarC_Click(object sender, EventArgs e)
        {
            if (dtgCiudad.SelectedRows.Count > 0)
            {

                txtCodigo.Text = dtgCiudad.CurrentRow.Cells[0].Value.ToString();
                txtDescripcionC.Text = dtgCiudad.CurrentRow.Cells[1].Value.ToString();
                cbPais.SelectedItem = dtgCiudad.CurrentRow.Cells[2].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /////******************BARRIO***************************//////
        private void LlenarGridBarrio()
        {
            bool valor = true;
            DataTable dt = new DataTable();
            D.Valor = 3;
            dt = D.Listar(valor);
            try
            {
                dtgBarrio.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgBarrio.Rows.Add(dt.Rows[x][0]);
                    dtgBarrio.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgBarrio.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgBarrio.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                }
                dtgBarrio.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardarB_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm2(tabBarrio, errorProvider1) == false)
            {
                return;
            }
            string mensaje = "";
            try
            {
                if (Program.Evento == 0)
                {
                    D.Valor = 3;
                    D.Id = 0;
                    D.Descripcion = txtDescripcionB.Text;
                    D.Id2 = Convert.ToInt32(cbCiudad.SelectedValue);
                    mensaje = D.Registrar();
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
                    D.Valor = 3;
                    D.Descripcion = txtDescripcionB.Text;
                    D.Id2 = Convert.ToInt32(cbCiudad.SelectedValue);
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
                LlenarGridBarrio();
                Program.Evento = 0;
                //Limpiar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarB_Click(object sender, EventArgs e)
        {
            if (dtgBarrio.SelectedRows.Count > 0)
            {

                txtCodigo.Text = dtgBarrio.CurrentRow.Cells[0].Value.ToString();
                txtDescripcionB.Text = dtgBarrio.CurrentRow.Cells[1].Value.ToString();
                cbCiudad.SelectedItem = dtgBarrio.CurrentRow.Cells[2].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       
    }
}
