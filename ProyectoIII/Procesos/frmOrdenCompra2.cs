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
    public partial class frmOrdenCompra2 : MetroForm
    {
        public frmOrdenCompra2()
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
        private void frmOrdenCompra2_Load(object sender, EventArgs e)
        {
            Autocompletar();
            dtgProveedor.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dtgProducto.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
        }
        private void Autocompletar()
        {
            T.Tipo = 1;
            int numerodoc = T.NumeroDocumento();
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
                string var = numerodoc.ToString().PadLeft(7, '0');
                txtDocumento.Text = var;
            }
            else if (numerodoc > 99 && numerodoc <= 999)
            {
                numerodoc++;
                string var = numerodoc.ToString().PadLeft(6, '0');
                txtDocumento.Text = var;
            }
            else if (numerodoc > 999 && numerodoc <= 9999)
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
    }
}
