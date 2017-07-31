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

namespace ProyectoIII.Procesos
{
    public partial class frmDevolucionC : MetroForm
    {
        public frmDevolucionC()
        {
            InitializeComponent();
        }
        clsProducto P = new clsProducto();
        clsTransacciones T = new clsTransacciones();
        clsCompras C = new clsCompras();
        clsTipos Ti = new clsTipos();
        private void LlenarComboMoneda()
        {
            try
            {
                cbMoneda.DataSource = C.ListadoMoneda();
                cbMoneda.DisplayMember = "DESCRIPCION";
                cbMoneda.ValueMember = "ID_moneda";
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
        private void frmOrdenCompra2_Load(object sender, EventArgs e)
        {
            Autocompletar();
            dtgProveedor.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dtgProducto.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dtgProducto.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dtgProveedor.DefaultCellStyle.Font = new Font("Tahoma", 10);
            LlenarComboMoneda();
        }
        private void Autocompletar()
        {
            T.Tipo = 3;
            int numerodoc = T.NumeroDocumento();
            Program.Idorden = numerodoc;
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

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Consultas.frmcProducto obj = new Consultas.frmcProducto();
            obj.ShowDialog();
            txtCodigoP.Text = Program.Idproduct;
            txtProducto.Text = Program.Producto;
            LlenarComboUnidad();
            txtPrecio.Text = Program.Costo.ToString();
            txtCantidad.Focus();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            Consultas.frmcProveedor obj = new Consultas.frmcProveedor();
            obj.ShowDialog();
            txtCodigoPv.Text = Program.Idproveedor.ToString();
            txtProveedor.Text = Program.Proveedor;
        }

        private void btnAgregarPv_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (Utilidades.ValidarForm(pnProveedor, errorProvider1) == false)
                {
                    return;
                }
                if (Program.Evento == 0)
                {
                    if (dtgProveedor.Rows.Count > 0)
                    {
                        for (int x = 0; x < dtgProveedor.Rows.Count; x++)
                        {
                            if (Program.Proveedor != dtgProveedor.Rows[x].Cells[2].Value.ToString())
                            {
                                dtgProveedor.Rows.Add("", txtCodigoPv.Text, txtProveedor.Text);
                                txtCodigoPv.Clear();
                                txtProveedor.Clear();
                                break;
                            }
                            else
                            {
                                MessageBoxEx.Show("Ya ha agregado este proveedor", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtCodigoPv.Clear();
                                txtProveedor.Clear();
                                break;
                            }
                        }
                    }
                    else
                    {
                        dtgProveedor.Rows.Add("", txtCodigoPv.Text, txtProveedor.Text);
                        txtCodigoPv.Clear();
                        txtProveedor.Clear();
                    }


                    Program.Proveedor = "";
                    Program.Idproveedor = "";
                }
                else if (Program.Evento == 1)
                {
                    dtgProveedor.Rows.Add("", txtCodigoPv.Text, txtProveedor.Text);
                    txtCodigoPv.Clear();
                    txtProveedor.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
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
                    Icon icoEditar = new Icon(Environment.CurrentDirectory + @"\Recursos\" + @"16 (Delete).ico");
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

        private void dtgProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    if (Program.Evento == 0)
                    {
                        dtgProveedor.Rows.RemoveAt(e.RowIndex);
                    }
                    else if (Program.Evento == 1)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LimpiarProducto()
        {
            txtCodigoP.Clear();
            txtProducto.Clear();
            cbUnidad.DataSource = null;
            txtCantidad.Clear();
            txtPrecio.Clear();
            Program.Producto = "";
            Program.Idproduct = "";
            Program.Unidad = "";
            Program.Costo = 0;
        }

        private void AgregarProducto()
        {
            try
            {
                errorProvider1.Clear();
                if (Utilidades.ValidarForm(pnProducto, errorProvider1) == false)
                {
                    return;
                }
                double importe = 0;
                double itbis = 0;
                double cant_a = 0;         
                if (Program.Evento == 0)
                {
                    bool valor = true;
                    if (dtgProducto.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow item in dtgProducto.Rows)
                        {
                            if (item.Cells[2].Value.ToString() == txtProducto.Text)
                            {
                                double cantidad = Convert.ToDouble(txtCantidad.Text);
                                cantidad = cantidad + Convert.ToDouble(item.Cells[5].Value);
                                itbis = Convert.ToDouble(txtPrecio.Text) * Program.Itbis;
                                itbis = itbis * cantidad;
                                importe = cantidad * Convert.ToDouble(txtPrecio.Text);
                                importe = importe + itbis;
                                item.Cells[5].Value = cantidad;
                                item.Cells[6].Value = txtPrecio.Text;
                                item.Cells[7].Value = itbis;
                                item.Cells[8].Value = importe;
                                LimpiarProducto();
                                valor = false;
                                itbis = 0;
                                importe = 0;
                                break;
                            }
                        }
                        if(valor==true)
                        {
                            itbis = Convert.ToDouble(txtPrecio.Text) * Program.Itbis;
                            itbis = itbis * Convert.ToDouble(txtCantidad.Text);
                            importe = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                            importe = importe + itbis;
                            dtgProducto.Rows.Add("", txtCodigoP.Text, txtProducto.Text, cbUnidad.SelectedValue, cbUnidad.Text, txtCantidad.Text, txtPrecio.Text,itbis,importe);
                            LimpiarProducto();
                            itbis = 0;
                            importe = 0;
                        }               
                    }
                    else
                    {
                        itbis = Convert.ToDouble(txtPrecio.Text) * Program.Itbis;
                        itbis = itbis * Convert.ToDouble(txtCantidad.Text);
                        importe = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                        importe = importe + itbis;
                        dtgProducto.Rows.Add("", txtCodigoP.Text, txtProducto.Text, cbUnidad.SelectedValue, cbUnidad.Text, txtCantidad.Text, txtPrecio.Text,itbis,importe);
                        LimpiarProducto();
                        itbis = 0;
                        importe = 0;
                    }
                }
                else if (Program.Evento == 1)
                {
                    //dtgProveedor.Rows.Add("", txtCodigoPv.Text, txtProveedor.Text);
                    //txtCodigoPv.Clear();
                    //txtProveedor.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                AgregarProducto();
            }
        }

        private void dtgProducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && this.dtgProducto.Columns[e.ColumnIndex].Name == "eliminarp" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dtgProducto.Rows[e.RowIndex].Cells["eliminarp"] as DataGridViewButtonCell;
                    Icon icoEditar = new Icon(Environment.CurrentDirectory + @"\Recursos\" + @"16 (Delete).ico");
                    e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 20, e.CellBounds.Top + 3);
                    this.dtgProducto.Rows[e.RowIndex].Height = icoEditar.Height + 5;
                    this.dtgProducto.Columns[e.ColumnIndex].Width = icoEditar.Width + 40;

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void dtgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    if (Program.Evento == 0)
                    {
                        dtgProducto.Rows.RemoveAt(e.RowIndex);
                    }
                    else if (Program.Evento == 1)
                    {

                    }
                }
            }
            catch (Exception ex)
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
                if (dtgProducto.Rows.Count > 0 && dtgProveedor.Rows.Count > 0)
                {
                    C.Documento = txtDocumento.Text;
                    C.Nota = txtNota.Text;
                    C.Idtercero = Convert.ToInt32(dtgProveedor.Rows[0].Cells[1].Value);
                    C.Fecha = dtpFecha.Value;
                    C.Idusuario = Program.Idusuario;
                    C.Idsucursal = Program.Idsucursal;
                    C.Idmoneda = Convert.ToInt32(cbMoneda.SelectedValue);
                    C.Idtipo = 14;
                    C.Factura = txtFactura.Text;
                    mensaje = C.RegistrarDevolucion();
                    if (mensaje == "1")
                    {
                        for(int x = 0; x < dtgProducto.Rows.Count; x++)
                        {
                            C.Iddevolucion = 0;
                            C.Idproducto= Convert.ToInt32(dtgProducto.Rows[x].Cells[1].Value);
                            C.Idunidad= Convert.ToInt32(dtgProducto.Rows[x].Cells[3].Value);
                            C.Cantidad= Convert.ToDouble(dtgProducto.Rows[x].Cells[5].Value);
                            C.Costo= Convert.ToDouble(dtgProducto.Rows[x].Cells[6].Value);
                            C.Importe= Convert.ToDouble(dtgProducto.Rows[x].Cells[8].Value);
                            C.Itbis= Convert.ToDouble(dtgProducto.Rows[x].Cells[7].Value);
                            mensaje = C.RegistrarDevolucion();
                        }
                        if (mensaje == "1")
                        {
                            MessageBoxEx.Show("Registrado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dtgProducto.Rows.Clear();
                            dtgProveedor.Rows.Clear();
                            txtNota.Clear();
                            Autocompletar();
                            frmReporte obj = new frmReporte();
                            obj.Valor = 1;
                            obj.Reporte = "orden_compra.rdlc";
                            obj.Idorden = Program.Idorden;
                            obj.Show();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }
    }
}
