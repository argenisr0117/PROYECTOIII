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
    public partial class frmOrdenCompra : MetroForm
    {
        public frmOrdenCompra()
        {
            InitializeComponent();
        }
        clsProducto P = new clsProducto();
        clsTransacciones T = new clsTransacciones();
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
        private void frmOrdenCompra_Load(object sender, EventArgs e)
        {
            Autocompletar();
            dtgProveedor.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dtgProducto.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
        }
        private void Autocompletar()
        {
            T.Tipo = 1;
            int numerodoc = T.NumeroDocumento();
            if(numerodoc==0)
            {
                string var = "1".PadLeft(8, '0');
                txtDocumento.Text = var;
            }
            else if (numerodoc<=9)
            {
                numerodoc++;
                string var = numerodoc.ToString().PadLeft(8, '0');
                txtDocumento.Text = var;
            }
            else if(numerodoc>9 && numerodoc < 100)
            {
                numerodoc++;
                string var = numerodoc.ToString().PadLeft(7, '0');
                txtDocumento.Text = var;
            }
            else if (numerodoc > 99 && numerodoc <=999)
            {
                numerodoc++;
                string var = numerodoc.ToString().PadLeft(6, '0');
                txtDocumento.Text = var;
            }
            else if (numerodoc >999 && numerodoc <= 9999)
            {
                numerodoc++;
                string var = numerodoc.ToString().PadLeft(5, '0');
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
            catch(Exception ex)
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
                if (Program.Evento == 0)
                {
                    if (dtgProducto.Rows.Count > 0)
                    {
                        for (int x = 0; x < dtgProducto.Rows.Count; x++)
                        {
                            if (Program.Producto != dtgProducto.Rows[x].Cells[2].Value.ToString())
                            {
                                dtgProducto.Rows.Add("", txtCodigoP.Text, txtProducto.Text, cbUnidad.SelectedValue, cbUnidad.Text, txtCantidad.Text, txtPrecio.Text);
                                LimpiarProducto();
                                break;
                            }
                            else
                            {
                                double cantidad = Convert.ToDouble(txtCantidad.Text);
                                cantidad = cantidad + Convert.ToDouble(dtgProducto.Rows[x].Cells[5].Value);
                                dtgProducto.Rows[x].Cells[5].Value = cantidad;
                                dtgProducto.Rows[x].Cells[6].Value = txtPrecio.Text;
                                LimpiarProducto();
                                break;
                            }
                        }
                    }
                    else
                    {
                        dtgProducto.Rows.Add("", txtCodigoP.Text, txtProducto.Text, cbUnidad.SelectedValue, cbUnidad.Text, txtCantidad.Text, txtPrecio.Text);
                        LimpiarProducto();
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

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAgregarP_Click(sender, e);
            }
        }
    }
}
