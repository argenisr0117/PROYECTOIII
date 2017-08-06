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
            ObtenerNumeroNCF();

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

        private void btnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Consultas.frmcProducto obj = new Consultas.frmcProducto();
                obj.ShowDialog();
                txtCodigoP.Text = Program.Idproduct;
                txtProducto.Text = Program.Producto;
                LlenarComboUnidad();
            }
            catch (Exception ex)
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
    }
}
