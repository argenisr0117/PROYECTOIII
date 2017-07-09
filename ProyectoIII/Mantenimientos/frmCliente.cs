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
    public partial class frmCliente : MetroForm
    {
        clsDirecciones D = new clsDirecciones();
        clsTipos T = new clsTipos();
        clsProveedor P = new clsProveedor();
        public frmCliente()
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
            if(Program.Editar==1)
            {
                LlenarCampos();
            }
        }
        private void LlenarCampos()
        {
            try
            {
                Program.Evento = 1;
                P.Idtercero = Program.Codigo;
                DataTable dt = P.DatosProveedor();
                DataTable dt2 = P.DatosContacto();
                DataTable dt3 = P.DatosDireccion();
                txtNombre.Text = dt.Rows[0][1].ToString();
                txtIdentificacion.Text = dt.Rows[0][3].ToString();
                cbTipoProveedor.SelectedValue = dt.Rows[0][4].ToString();
                for (int x = 0; x < dt3.Rows.Count; x++)
                {
                    dtgDireccion.Rows.Add(dt3.Rows[x][0]);
                    dtgDireccion.Rows[x].Cells[0].Value = dt3.Rows[x][0].ToString();
                    dtgDireccion.Rows[x].Cells[1].Value = dt3.Rows[x][1].ToString();
                    dtgDireccion.Rows[x].Cells[2].Value = dt3.Rows[x][2].ToString();
                    dtgDireccion.Rows[x].Cells[3].Value = dt3.Rows[x][3].ToString();
                    dtgDireccion.Rows[x].Cells[4].Value = dt3.Rows[x][4].ToString();
                }
                for (int x = 0; x < dt2.Rows.Count; x++)
                {
                    dtgContacto.Rows.Add(dt2.Rows[x][0]);
                    dtgContacto.Rows[x].Cells[0].Value = dt2.Rows[x][0].ToString();
                    dtgContacto.Rows[x].Cells[1].Value = dt2.Rows[x][1].ToString();
                    dtgContacto.Rows[x].Cells[2].Value = dt2.Rows[x][2].ToString();
                    dtgContacto.Rows[x].Cells[3].Value = dt2.Rows[x][3].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
           

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
                    dtgContacto.Rows.Add(0, txtContacto.Text, cbTipoContacto.SelectedValue, cbTipoContacto.Text, "");
                    txtContacto.Clear();
                }
                else if (Program.Evento == 1)
                {
                    dtgContacto.Rows.Add(Program.Id, txtContacto.Text, cbTipoContacto.SelectedValue, cbTipoContacto.Text, "");
                    txtContacto.Clear();
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
                Program.Id= Convert.ToInt32(dtgContacto.CurrentRow.Cells[0].Value);
                //Program.Evento = 1;
                dtgContacto.Rows.RemoveAt(e.RowIndex);
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
                    dtgDireccion.Rows.Add(0, cbRegion.Text +"," + cbCiudad.Text + "," + cbBarrio.Text + "," + txtDireccion.Text, cbBarrio.SelectedValue, cbCiudad.SelectedValue, cbRegion.SelectedValue,"");
                    txtDireccion.Clear();
                }
                else if (Program.Evento == 1)
                {
                    dtgDireccion.Rows.Add(Program.Id, cbRegion.Text + "," + cbCiudad.Text + "," + cbBarrio.Text + "," + txtDireccion.Text, cbBarrio.SelectedValue, cbCiudad.SelectedValue, cbRegion.SelectedValue, "");
                    txtDireccion.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }

        private void dtgContacto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && this.dtgContacto.Columns[e.ColumnIndex].Name == "editarc" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dtgContacto.Rows[e.RowIndex].Cells["editarc"] as DataGridViewButtonCell;
                    Icon icoEditar = new Icon(Environment.CurrentDirectory + @"\Recursos\" +@"edit (2).ico");
                    e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 20, e.CellBounds.Top + 3);
                    this.dtgContacto.Rows[e.RowIndex].Height = icoEditar.Height+5;
                    this.dtgContacto.Columns[e.ColumnIndex].Width = icoEditar.Width+40;

                    e.Handled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                errorProvider1.Clear();
                if (Utilidades.ValidarForm(this, errorProvider1) == false)
                {
                    return;
                }
                if (Program.Evento == 0)
                {
                    P.Nombre = txtNombre.Text;                  
                    P.Idtipot = Convert.ToInt32(cbTipoProveedor.SelectedValue);
                    mensaje = P.Registrar();
                    if(mensaje=="1")
                    {
                        P.Identificacion = txtIdentificacion.Text;
                        if (cbTipoProveedor.Text == "Empresa")
                        {
                            P.Idtipoi = 8;
                        }
                        else if (cbTipoProveedor.Text == "Persona")
                        {
                            P.Idtipoi = 6;
                        }
                        mensaje = P.RegistrarI();
                        for(int x=0; x < dtgContacto.Rows.Count; x++)
                        {
                            P.Contacto = dtgContacto.Rows[x].Cells[1].Value.ToString();
                            P.Idtipoc = Convert.ToInt32(dtgContacto.Rows[x].Cells[2].Value);
                            mensaje = P.RegistrarC();
                        }
                        for (int x = 0; x < dtgDireccion.Rows.Count; x++)
                        {
                            P.Direccion = dtgDireccion.Rows[x].Cells[1].Value.ToString();
                            P.Idbarrio = Convert.ToInt32(dtgDireccion.Rows[x].Cells[2].Value);
                            P.Idciudad = Convert.ToInt32(dtgDireccion.Rows[x].Cells[3].Value);
                            P.Idregion = Convert.ToInt32(dtgDireccion.Rows[x].Cells[4].Value);
                            mensaje = P.RegistrarD();
                        }
                        if (mensaje == "1")
                        {
                            MessageBoxEx.Show("Registrado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                    }
                    
                }
                else if (Program.Evento == 1)
                {
                    P.Idtercero = Program.Codigo;
                    P.Nombre = txtNombre.Text;
                    P.Idtipot = Convert.ToInt32(cbTipoProveedor.SelectedValue);
                    mensaje = P.Actualizar();
                    if (mensaje == "1")
                    {
                        P.Identificacion = txtIdentificacion.Text;
                        if (cbTipoProveedor.Text == "Empresa")
                        {
                            P.Idtipoi = 8;
                        }
                        else if (cbTipoProveedor.Text == "Persona")
                        {
                            P.Idtipoi = 6;
                        }
                        mensaje = P.ActualizarI();
                        for (int x = 0; x < dtgContacto.Rows.Count; x++)
                        {
                            P.Idcontacto= Convert.ToInt32(dtgContacto.Rows[x].Cells[0].Value);
                            P.Contacto = dtgContacto.Rows[x].Cells[1].Value.ToString();
                            P.Idtipoc = Convert.ToInt32(dtgContacto.Rows[x].Cells[2].Value);
                            mensaje = P.ActualizarC();
                        }
                        for (int x = 0; x < dtgDireccion.Rows.Count; x++)
                        {
                            P.Iddireccion= Convert.ToInt32(dtgDireccion.Rows[x].Cells[0].Value);
                            P.Direccion = dtgDireccion.Rows[x].Cells[1].Value.ToString();
                            P.Idbarrio = Convert.ToInt32(dtgDireccion.Rows[x].Cells[2].Value);
                            P.Idciudad = Convert.ToInt32(dtgDireccion.Rows[x].Cells[3].Value);
                            P.Idregion = Convert.ToInt32(dtgDireccion.Rows[x].Cells[4].Value);
                            mensaje = P.ActualizarD();
                        }
                        if (mensaje == "1")
                        {
                            MessageBoxEx.Show("Actualizado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtDireccion.Clear();
            txtContacto.Clear();
            txtNombre.Focus();
            dtgContacto.Rows.Clear();
            dtgDireccion.Rows.Clear();
        }
        private void dtgDireccion_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && this.dtgDireccion.Columns[e.ColumnIndex].Name == "editard" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dtgDireccion.Rows[e.RowIndex].Cells["editard"] as DataGridViewButtonCell;
                    Icon icoEditar = new Icon(Environment.CurrentDirectory + @"\Recursos\" + @"edit (2).ico");
                    e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 20, e.CellBounds.Top + 3);

                    this.dtgDireccion.Rows[e.RowIndex].Height = icoEditar.Height + 5;
                    this.dtgDireccion.Columns[e.ColumnIndex].Width = icoEditar.Width + 40;

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void dtgDireccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==5)
            {
                txtDireccion.Text = dtgDireccion.CurrentRow.Cells[1].Value.ToString();
                cbBarrio.SelectedValue = dtgDireccion.CurrentRow.Cells[2].Value.ToString();
                cbCiudad.SelectedValue = dtgDireccion.CurrentRow.Cells[3].Value.ToString();
                cbRegion.SelectedValue = dtgDireccion.CurrentRow.Cells[4].Value.ToString();
                Program.Id = Convert.ToInt32(dtgDireccion.CurrentRow.Cells[1].Value);
                dtgDireccion.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
