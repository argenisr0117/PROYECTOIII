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
        clsProducto P = new clsProducto();
        public frmEquivalenciaUnidad()
        {
            InitializeComponent();
        }
        private void LlenarComboUnidad()
        {
            try
            {
                cbUnidad.DataSource = U.Listar(true);
                cbUnidad.DisplayMember = "DESCRIPCION";
                cbUnidad.ValueMember = "ID_UNIDAD";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarGrid()
        {
            DataTable dt = new DataTable();
            if (rbActivo.Checked)
            {
                P.Estado = true;
            }
            else
            {
                P.Estado = false;
            }
            dt = P.ListadoEquivalenciaP();
            try
            {
                dtgEquivalencia.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgEquivalencia.Rows.Add(dt.Rows[x][0]);
                    dtgEquivalencia.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgEquivalencia.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgEquivalencia.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgEquivalencia.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                    dtgEquivalencia.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                    dtgEquivalencia.Rows[x].Cells[5].Value = dt.Rows[x][5].ToString();
                    dtgEquivalencia.Rows[x].Cells[6].Value = dt.Rows[x][6].ToString();
                    dtgEquivalencia.Rows[x].Cells[7].Value = dt.Rows[x][7].ToString();

                }
                dtgEquivalencia.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtUnidadb.Clear();
            txtEquivalencia.Clear();
            txtProducto.Clear();
            //txtAbreviacion.Clear();
            txtUnidadb.Focus();
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
                    P.Idproducto = Program.Idproducto;
                    P.Unidadb = txtUnidadb.Text;
                    P.Idunidad = Convert.ToInt32(cbUnidad.SelectedValue);
                    P.Equivalencia = Convert.ToDouble(txtEquivalencia.Text);
                   // U.Abreviacion = txtAbreviacion.Text;
                    mensaje = P.RegistrarEp();
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
                else if(Program.Evento==1)
                {
                    P.Idproducto = Program.Idproducto;
                    P.Idequivalencia = Convert.ToInt32(txtCodigo.Text);
                    P.Unidadb = txtUnidadb.Text;
                    P.Idunidad = Convert.ToInt32(cbUnidad.SelectedValue);
                    P.Equivalencia = Convert.ToDouble(txtEquivalencia.Text);
                    mensaje = P.ActualizarEp();
                    if (mensaje == "1")
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
            if (dtgEquivalencia.SelectedRows.Count > 0)
            {

                txtCodigo.Text = dtgEquivalencia.CurrentRow.Cells[0].Value.ToString();
                Program.Idproducto = Convert.ToInt32(dtgEquivalencia.CurrentRow.Cells[1].Value);
                txtProducto.Text = dtgEquivalencia.CurrentRow.Cells[2].Value.ToString();
                cbUnidad.Text= dtgEquivalencia.CurrentRow.Cells[5].Value.ToString();
                txtUnidadb.Text = dtgEquivalencia.CurrentRow.Cells[3].Value.ToString();
                txtEquivalencia.Text= dtgEquivalencia.CurrentRow.Cells[6].Value.ToString();
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
                if (dtgEquivalencia.SelectedRows.Count > 0)
                {
                    U.Id = Convert.ToInt32(dtgEquivalencia.CurrentRow.Cells[0].Value);
                    U.Estado = Convert.ToBoolean(dtgEquivalencia.CurrentRow.Cells[3].Value);
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
            LlenarGrid();
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            try
            {
                Consultas.frmcProducto obj = new Consultas.frmcProducto();
                obj.ShowDialog();
                txtProducto.Text = Program.Producto;
                txtUnidadb.Text = Program.Unidad;
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmEquivalencia_Load(object sender, EventArgs e)
        {
            LlenarComboUnidad();
            //LlenarGridUnidad();
            Program.Evento = 0;
            rbActivo.Checked = true;
        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }
    }
}
