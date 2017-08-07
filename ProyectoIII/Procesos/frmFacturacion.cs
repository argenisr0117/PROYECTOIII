using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Entidades;

namespace ProyectoIII.Procesos
{
    public partial class frmFacturacion : MetroForm
    {
        clsTipos T = new clsTipos();
        clsTransacciones Tr = new clsTransacciones();
        clsProducto P = new clsProducto();
        clsCaja C = new clsCaja();
        clsUnidad U = new clsUnidad();
        public DataTable dtPrecios = new DataTable();
        public double Equiv = 0;
        private void LlenarComboTipo()
        {
            try
            {
                T.Iddestipo = 1;
                cbTipoF.DataSource = T.ListarT(true);
                cbTipoF.DisplayMember = "DESCRIPCION";
                cbTipoF.ValueMember = "ID_TIPO";
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
                P.Idproducto = Convert.ToInt32(Program.Idproduct);
                cbUnidad.DataSource = P.ObtenerUnidadesProducto();
                cbUnidad.DisplayMember = "abrev";
                cbUnidad.ValueMember = "id_unidad";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarMetodoP()
        {
            try
            {
                T.Iddestipo = 9;
                cbMetodop.DataSource = T.ListarT(true);
                cbMetodop.DisplayMember = "DESCRIPCION";
                cbMetodop.ValueMember = "ID_TIPO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarMoneda()
        {
            try
            {
                cbMoneda.DataSource = Tr.ListadoMoneda();
                cbMoneda.DisplayMember = "DESCRIPCION";
                cbMoneda.ValueMember = "ID_moneda";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            LlenarComboTipo();
            LlenarMetodoP();
            LlenarMoneda();
            Autocompletar();
            //ObtenerNumeroNCF();
            VerificarCajaAbierta();
            Program.Evento = 0;

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Consultas.frmcCliente obj = new Consultas.frmcCliente();
                obj.ShowDialog();
                txtCodigoCliente.Text = Program.Idcliente;
                txtCliente.Text = Program.Cliente;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Autocompletar()
        {
            Tr.Tipo = 4;
            int numerodoc = Tr.NumeroDocumento();
            Program.Idfactura= numerodoc;
            if (numerodoc == 0)
            {
                string var = "1".PadLeft(8, '0');
                txtDocumento.Text = var;
            }
            else if (numerodoc <= 9)
            {
                numerodoc++;
                string var = numerodoc.ToString().PadLeft(8, '0');
                txtDocumento.Text = var;
            }
            else if (numerodoc > 9 && numerodoc < 100)
            {
                numerodoc++;
                string var = numerodoc.ToString().PadLeft(8, '0');
                txtDocumento.Text = var;
            }
            else if (numerodoc > 99 && numerodoc <= 999)
            {
                numerodoc++;
                string var = numerodoc.ToString().PadLeft(7, '0');
                txtDocumento.Text = var;
            }
            else if (numerodoc > 999 && numerodoc <= 9999)
            {
                numerodoc++;
                string var = numerodoc.ToString().PadLeft(6, '0');
                txtDocumento.Text = var;
            }

        }
        private void ObtenerNumeroNCF()
        {
            Tr.Tipo = 02;
            string[] numero = Tr.NumeroNCF();
            if(numero[0]!="-1")
            {
                if (numero[0] == "1")
                {
                    string var = "1".PadLeft(8, '0');
                    txtNcf.Text = numero[1] + var;
                }
                else if (Convert.ToInt32(numero[0]) <= 9)
                {
                    int num = Convert.ToInt32(numero[0]) + 1;
                    string var = num.ToString().PadLeft(8, '0');
                    txtNcf.Text = numero[1] + var;

                }
                else if (Convert.ToInt32(numero[0]) > 9 && Convert.ToInt32(numero[0]) < 100)
                {
                    int num = Convert.ToInt32(numero[0]) + 1;
                    string var = num.ToString().PadLeft(8, '0');
                    txtNcf.Text = numero[1] + var;

                }
                else if (Convert.ToInt32(numero[0]) > 99 && Convert.ToInt32(numero[0]) <= 999)
                {
                    int num = Convert.ToInt32(numero[0]) + 1;
                    string var = num.ToString().PadLeft(7, '0');
                    txtNcf.Text = numero[1] + var;

                }
                else if (Convert.ToInt32(numero[0]) > 999 && Convert.ToInt32(numero[0]) <= 9999)
                {
                    int num = Convert.ToInt32(numero[0]) + 1;
                    string var = num.ToString().PadLeft(6, '0');
                    txtNcf.Text = numero[1] + var;
                }
            }
            else
            {
                MessageBoxEx.Show("Numero de comprobantes agotados", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        private void VerificarCajaAbierta()
        {
            try
            {
                DataTable dt = new DataTable();
                C.Idusuario = Program.Idusuario;
                dt = C.VerificarCajaAbierta();
                if (dt.Rows.Count == 0)
                {
                    MessageBoxEx.Show("Usuario no tiene una caja abierta\n No podra facturar.", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAgregarCliente.Enabled = false;
                    btnRegistrar.Enabled = false;
                    btnProducto.Enabled = false;
                }
                else
                {
                    txtCaja.Text = dt.Rows[0][0].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Consultas.frmcProducto obj = new Consultas.frmcProducto();
                obj.ShowDialog();
                txtCodigoP.Text = Program.Idproduct;
                txtProducto.Text = Program.Producto;
                LlenarComboUnidad();
                ObtenerPrecioProducto();
                ObtenerExistencia();
                txtCantidad.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ObtenerExistencia()
        {
            try
            {
                double existencia;
                double cant;
                //cant = Convert.ToDouble(txtCantidad.Text);
                DataTable dt = new DataTable();
                if (cbUnidad.SelectedValue.ToString() !="System.Data.DataRowView")
                {
                    U.Abreviacion = cbUnidad.Text;
                    U.Idproducto = Convert.ToInt32(Program.Idproduct);
                    dt = U.EquivalenciaUnidad();
                    cant = Convert.ToDouble(dt.Rows[0][0]);
                    Equiv= Convert.ToDouble(dt.Rows[0][0]); 
                    existencia = Math.Round(Program.Existencia / cant, 2);
                    //cant = cant * (Convert.ToDouble(txtCantidad.Text));
                    lbExistencia.Text = existencia.ToString();
                    lbUnidad.Text = cbUnidad.Text;
                }
               
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
           
        }
        private void ObtenerPrecioProducto ()
        {
            P.Idproducto = Convert.ToInt32(Program.Idproduct);
            dtPrecios.Rows.Clear();
            try
            {
                dtPrecios=P.ObtenerPrecios();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dtgFacturacion_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && this.dtgFacturacion.Columns[e.ColumnIndex].Name == "eliminar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dtgFacturacion.Rows[e.RowIndex].Cells["eliminar"] as DataGridViewButtonCell;
                    Icon icoEditar = new Icon(Environment.CurrentDirectory + @"\Recursos\" + @"16 (Delete).ico");
                    e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 20, e.CellBounds.Top + 3);
                    this.dtgFacturacion.Rows[e.RowIndex].Height = icoEditar.Height + 5;
                    this.dtgFacturacion.Columns[e.ColumnIndex].Width = icoEditar.Width + 40;

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void chbNCF_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!chbNCF.Checked)
                {
                    txtNcf.Text = "";
                }
                else
                {
                    ObtenerNumeroNCF();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalcularPrecio()
        {
            double cantidad = 0;
            double precio = 0;
            double impuesto = 0;
            double rangoi=0;
            double rangof=0;
            if (!string.IsNullOrEmpty(txtCantidad.Text))
            {
                cantidad = Convert.ToDouble(txtCantidad.Text) * Equiv;
            }
            else
            {
                cantidad = 0;
            }
            for (int x=0; x < dtPrecios.Rows.Count; x++)
            {
                rangoi = Convert.ToDouble(dtPrecios.Rows[x][0]);
                rangof = Convert.ToDouble(dtPrecios.Rows[x][1]);
                if (cantidad>=rangoi && cantidad <=rangof )
                {                   
                    precio = Program.Costo * Convert.ToDouble(dtPrecios.Rows[x][2]);
                    precio = Program.Costo + precio;
                    precio = precio * Equiv;
                    Program.Precio = precio;
                    impuesto = precio * Convert.ToDouble(dtPrecios.Rows[x][3]);
                    Program.Itbis = impuesto;
                    precio = precio + impuesto;
                    txtPrecio.Text = precio.ToString("N2");
                }
                else if(txtCantidad.Text=="")
                {
                    txtPrecio.Clear();
                }
            }
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularPrecio();
            }
            catch(Exception ex)
            {

            }
        }

        private void cbUnidad_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbUnidad.DataSource != null)
                {
                    ObtenerExistencia();
                    CalcularPrecio();
                }
                

            }
            catch(Exception ex)
            {
                return;
            }
        }

        private void AgregarProducto()
        {
            try
            {
                errorProvider1.Clear();
                if (Utilidades.ValidarForm2(pnProducto, errorProvider1) == false)
                {
                    return;
                }
                if (Utilidades.ValidarForm(this, errorProvider1) == false)
                {
                    return;
                }
                double existencia;
                double cant;
                cant = Convert.ToDouble(txtCantidad.Text);
                DataTable dt = new DataTable();
                U.Abreviacion = cbUnidad.Text;
                U.Idproducto = Convert.ToInt32(txtCodigoP.Text);
                dt = U.EquivalenciaUnidad();
                cant = Convert.ToDouble(dt.Rows[0][0]);
                existencia = Math.Round(Program.Existencia / cant, 2);
                cant = cant * (Convert.ToDouble(txtCantidad.Text));
                if (cant > Program.Existencia)
                {
                    MessageBoxEx.Show("Solo hay [" + existencia + "] disponible", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    double importe = 0;
                    double itbis = 0;
                    double total = 0;
                    double precio = 0;
                    double impuesto = 0;
                    double rangoi = 0;
                    double rangof = 0;
                    if (Program.Evento == 0)
                    {
                        bool valor = true;
                        if (dtgFacturacion.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow item in dtgFacturacion.Rows)
                            {
                                if (item.Cells[5].Value.ToString() == txtProducto.Text)
                                {
                                    double cantidad = Convert.ToDouble(txtCantidad.Text);
                                    cantidad = cantidad + Convert.ToDouble(item.Cells[2].Value);

                                    for (int x = 0; x < dtPrecios.Rows.Count; x++)
                                    {
                                        rangoi = Convert.ToDouble(dtPrecios.Rows[x][0]);
                                        rangof = Convert.ToDouble(dtPrecios.Rows[x][1]);
                                        if (cantidad >= rangoi && cantidad <= rangof)
                                        {
                                            precio = Program.Costo * Convert.ToDouble(dtPrecios.Rows[x][2]);
                                            precio = Program.Costo + precio;
                                            precio = precio * Equiv;
                                            Program.Precio = precio;
                                            impuesto = precio * Convert.ToDouble(dtPrecios.Rows[x][3]);
                                            Program.Itbis = impuesto;
                                            txtPrecio.Text = precio.ToString("N2");
                                        }
                                    }

                                    itbis = cantidad * Program.Itbis;
                                    importe = cantidad * Program.Precio;
                                    total = importe + itbis;
                                    item.Cells[2].Value = cantidad;
                                    item.Cells[6].Value = txtPrecio.Text;
                                    item.Cells[7].Value = importe.ToString("N2");
                                    item.Cells[8].Value = itbis.ToString("N2");
                                    Limpiar();
                                    valor = false;
                                    itbis = 0;
                                    importe = 0;
                                    total = 0;
                                    break;
                                }
                            }
                            if (valor == true)
                            {
                                itbis = Program.Itbis;
                                itbis = itbis * Convert.ToDouble(txtCantidad.Text);
                                importe = Convert.ToDouble(txtCantidad.Text) * Program.Precio;
                                total = importe + itbis;
                                precio = Program.Precio;
                                dtgFacturacion.Rows.Add("", txtCodigoP.Text, txtCantidad.Text, cbUnidad.SelectedValue, cbUnidad.Text, txtProducto.Text, precio, importe, itbis, total);
                                Limpiar();
                                itbis = 0;
                                importe = 0;
                                total = 0;
                            }
                        }
                        else
                        {
                            itbis = Program.Itbis;
                            itbis = itbis * Convert.ToDouble(txtCantidad.Text);
                            importe = Convert.ToDouble(txtCantidad.Text) * Program.Precio;
                            total = importe+itbis;
                            precio = Program.Precio;
                            dtgFacturacion.Rows.Add("", txtCodigoP.Text, txtCantidad.Text, cbUnidad.SelectedValue, cbUnidad.Text, txtProducto.Text, precio.ToString("N2"), importe.ToString("N2"), itbis.ToString("N2"), total.ToString("N2"));
                            Limpiar();
                            itbis = 0;
                            importe = 0;
                            total = 0;
                        }
                    }
                    else if (Program.Evento == 1)
                    {
                        //dtgProveedor.Rows.Add("", txtCodigoPv.Text, txtProveedor.Text);
                        //txtCodigoPv.Clear();
                        //txtProveedor.Clear();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void Limpiar ()
        {
            txtProducto.Clear();
            txtCodigoP.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            dtPrecios.Rows.Clear();
            Program.Existencia = 0;
            Program.Itbis = 0;
            Program.Idproduct = "";
            Program.Precio = 0;
            lbExistencia.Text = "0.00";
            lbUnidad.Text = "--";
            //cbUnidad.SelectedValue = "System.Data.DataRowView";
            cbUnidad.DataSource = null;
            cbUnidad.Items.Clear();
            
        }
        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AgregarProducto();
                CalcularTotal();
            }
        }

        private void CalcularTotal()
        {
            double total = 0;
            for(int y =0; y < dtgFacturacion.Rows.Count; y++)
            {
                total = total +Convert.ToDouble(dtgFacturacion.Rows[y].Cells[9].Value);
            }
            lbTotal.Text =cbMoneda.Text+" "+ total.ToString("N2");
        }
    
    }
}
