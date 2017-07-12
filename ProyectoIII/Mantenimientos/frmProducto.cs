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
    public partial class frmProducto : MetroForm
    {
        clsMarca M = new clsMarca();
        clsCategoria C = new clsCategoria();
        clsUnidad U = new clsUnidad();
        clsTipos T = new clsTipos();
        clsProveedor P = new clsProveedor();
        clsProducto Pr = new clsProducto();
        public frmProducto()
        {
            InitializeComponent();
        }
        private void LlenarComboItbis()
        {
            try
            {
                cbItbis.DataSource = Pr.ListarI();
                cbItbis.DisplayMember = "itbis";
                cbItbis.ValueMember = "ID_itbis";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
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
        private void LlenarComboMarca()
        {
            try
            {
                cbMarca.DataSource = M.Listar(true);
                cbMarca.DisplayMember = "DESCRIPCION";
                cbMarca.ValueMember = "ID_MARCA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarComboCategoria()
        {
            try
            {
                cbCategoria.DataSource = C.Listar(true);
                cbCategoria.DisplayMember = "DESCRIPCION";
                cbCategoria.ValueMember = "ID_CATEGORIA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void frmProveedor_Load(object sender, EventArgs e)
        {
            LlenarComboItbis();
            LlenarComboMarca();
            LlenarComboUnidad();
            LlenarComboCategoria();
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
                Pr.Idproducto = Program.Idproducto;
                DataTable dt = Pr.DatosProducto();
                DataTable dt2 = Pr.DatosProveedores();
                txtDescripcion.Text = dt.Rows[0][1].ToString();
                txtReferencia.Text = dt.Rows[0][2].ToString();
                cbCategoria.SelectedValue = dt.Rows[0][3].ToString();
                cbMarca.SelectedValue = dt.Rows[0][4].ToString();
                cbUnidad.SelectedValue = dt.Rows[0][5].ToString();
                cbItbis.SelectedValue = dt.Rows[0][6].ToString();
                txtPuntoR.Text= dt.Rows[0][7].ToString();
                txtPuntoMax.Text= dt.Rows[0][8].ToString();
                txtCostoC.Text= dt.Rows[0][9].ToString();
                txtCostoP.Text= dt.Rows[0][10].ToString();
                txtCodigoB.Text= dt.Rows[0][11].ToString();
                for (int x = 0; x < dt2.Rows.Count; x++)
                {
                    dtgProveedor.Rows.Add(dt2.Rows[x][0]);
                    dtgProveedor.Rows[x].Cells[0].Value = dt2.Rows[x][0].ToString();
                    dtgProveedor.Rows[x].Cells[1].Value = dt2.Rows[x][1].ToString();
        
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
                    Pr.Descripcion = txtDescripcion.Text;
                    Pr.Referencia = txtReferencia.Text;                 
                    Pr.Idcategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                    Pr.Idunidad = Convert.ToInt32(cbUnidad.SelectedValue);
                    Pr.Idmarca = Convert.ToInt32(cbMarca.SelectedValue);
                    Pr.Iditbis = Convert.ToInt32(cbItbis.SelectedValue);
                    Pr.Codigob = txtCodigoB.Text;
                    Pr.Costoc = Convert.ToDouble(txtCostoC.Text);
                    Pr.Costop = Convert.ToDouble(txtCostoP.Text);
                    Pr.Puntor = Convert.ToDouble(txtPuntoR.Text);
                    Pr.Puntom = Convert.ToDouble(txtPuntoMax.Text);
                    mensaje = Pr.Registrar();
                    if(mensaje=="1")
                    {                        
                        for(int x=0; x < dtgProveedor.Rows.Count; x++)
                        {
                            Pr.Idproveedor = Convert.ToInt32(dtgProveedor.Rows[x].Cells[0].Value);
                            Pr.Idproducto = 0;
                            mensaje = Pr.RegistrarP();
                           
                        }
                        MessageBoxEx.Show("Registrado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();

                    }
                    
                }
                else if (Program.Evento == 1)
                {
                    Pr.Idproducto = Program.Idproducto;
                    Pr.Descripcion = txtDescripcion.Text;
                    Pr.Referencia = txtReferencia.Text;
                    Pr.Idcategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                    Pr.Idunidad = Convert.ToInt32(cbUnidad.SelectedValue);
                    Pr.Idmarca = Convert.ToInt32(cbMarca.SelectedValue);
                    Pr.Iditbis = Convert.ToInt32(cbItbis.SelectedValue);
                    Pr.Codigob = txtCodigoB.Text;
                    Pr.Costoc = Convert.ToDouble(txtCostoC.Text);
                    Pr.Costop = Convert.ToDouble(txtCostoP.Text);
                    Pr.Puntor = Convert.ToDouble(txtPuntoR.Text);
                    Pr.Puntom = Convert.ToDouble(txtPuntoMax.Text);
                    mensaje = Pr.Actualizar();
                    if (mensaje == "1")
                    {
                        for (int x = 0; x < dtgProveedor.Rows.Count; x++)
                        {
                            Pr.Idproveedor = Convert.ToInt32(dtgProveedor.Rows[x].Cells[0].Value);
                            Pr.Idproducto = Program.Idproducto;
                            mensaje = Pr.RegistrarP();

                        }
                        MessageBoxEx.Show("Actualizado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        
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
            txtDescripcion.Clear();
            txtReferencia.Clear();
            txtProveedor.Clear();
            txtDescripcion.Focus();
            txtCodigoB.Clear();
            txtCostoC.Clear();
            txtCostoP.Clear();
            txtPuntoMax.Clear();
            txtPuntoR.Clear();
            dtgProveedor.Rows.Clear();
        }

        private void dtgProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (Program.Editar == 1)
                {
                    Pr.Idproveedor = Convert.ToInt32(dtgProveedor.CurrentRow.Cells[0].Value);
                    Pr.Idproducto = Program.Idproducto;
                    Pr.EliminarP();
                    dtgProveedor.Rows.RemoveAt(e.RowIndex);

                }
                else
                {
                    Program.Id = Convert.ToInt32(dtgProveedor.CurrentRow.Cells[0].Value);
                    dtgProveedor.Rows.RemoveAt(e.RowIndex);
                }
              
            }
        }

        private void dtgProveedor_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && this.dtgProveedor.Columns[e.ColumnIndex].Name == "eliminar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dtgProveedor.Rows[e.RowIndex].Cells["eliminar"] as DataGridViewButtonCell;
                    Icon icoEditar = new Icon(Environment.CurrentDirectory + @"\Recursos\" + @"delete (2).ico");
                    e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 20, e.CellBounds.Top + 3);

                    this.dtgProveedor.Rows[e.RowIndex].Height = icoEditar.Height + 5;
                    this.dtgProveedor.Columns[e.ColumnIndex].Width = icoEditar.Width + 40;

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            try
            {
                Consultas.frmcProveedor obj = new Consultas.frmcProveedor();
                obj.ShowDialog();
                txtProveedor.Text = Program.Proveedor;
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (Utilidades.ValidarForm2(gbProveedor, errorProvider1) == false)
                {
                    return;
                }
                if (Program.Evento == 0)
                {
                    dtgProveedor.Rows.Add(Program.Codigo, txtProveedor.Text);
                    txtProveedor.Clear();
                }
                else if (Program.Evento == 1)
                {
                    dtgProveedor.Rows.Add(Program.Codigo, txtProveedor.Text);
                    txtProveedor.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
    }
}
