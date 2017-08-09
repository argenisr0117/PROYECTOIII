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
    public partial class frmEntradaInventario : MetroForm
    {
        clsCompras C = new clsCompras();
        clsTransacciones T = new clsTransacciones();
        clsCxpagar Cp = new clsCxpagar();
        public frmEntradaInventario()
        {
            InitializeComponent();
        }
        public double total1 = 0;
        private void frmEntradaInventario_Load(object sender, EventArgs e)
        {
            Autocompletar();
            LlenarCampos();
        }
        private void LlenarCampos ()
        {
            C.Documento = Program.Documento;
            DataTable dt = new DataTable();
            try
            {
                double cantidad;
                double costo;
                double itbis;
                dt = C.ObtenerDatosOrden();
                txtNota.Text = dt.Rows[0][1].ToString();
                dtgEntrada.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgEntrada.Rows.Add(dt.Rows[x][0]);
                    dtgEntrada.Rows[x].Cells[0].Value = dt.Rows[x][2].ToString();
                    dtgEntrada.Rows[x].Cells[1].Value = dt.Rows[x][3].ToString();
                    dtgEntrada.Rows[x].Cells[2].Value = dt.Rows[x][4].ToString();
                    dtgEntrada.Rows[x].Cells[3].Value = dt.Rows[x][5].ToString();
                    dtgEntrada.Rows[x].Cells[4].Value = dt.Rows[x][6].ToString();
                    dtgEntrada.Rows[x].Cells[5].Value = dt.Rows[x][7].ToString();
                    dtgEntrada.Rows[x].Cells[6].Value = dt.Rows[x][8].ToString();
                    dtgEntrada.Rows[x].Cells[7].Value = dt.Rows[x][9].ToString();
                    dtgEntrada.Rows[x].Cells[8].Value = dt.Rows[x][10].ToString();
                    cantidad = Convert.ToDouble(dtgEntrada.Rows[x].Cells[5].Value);
                    costo = Convert.ToDouble(dtgEntrada.Rows[x].Cells[6].Value);
                    itbis = Convert.ToDouble(dtgEntrada.Rows[x].Cells[8].Value) * costo;
                    itbis = itbis * cantidad;
                    dtgEntrada.Rows[x].Cells[9].Value = itbis;


                }
                dtgEntrada.ClearSelection();
                txtFactura.Focus();
            }
            catch(Exception ex)
            {

            }
        }
        private void Autocompletar()
        {
            try
            {
                T.Tipo = 2;
                int numerodoc = T.NumeroDocumento();
                Program.Idtransaccion = numerodoc;
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
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
           

        }

        private void dtgEntrada_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double cantidad;
            double costo;
            double itbis;
            double subtotal;
            try
            {
                if (dtgEntrada.Columns[e.ColumnIndex].Index == 5 || dtgEntrada.Columns[e.ColumnIndex].Index == 6)
                {
                    cantidad = Convert.ToDouble(dtgEntrada.CurrentRow.Cells[5].Value);
                    costo= Convert.ToDouble(dtgEntrada.CurrentRow.Cells[6].Value);
                    itbis= Convert.ToDouble(dtgEntrada.CurrentRow.Cells[8].Value) * costo;
                    itbis = itbis * cantidad;
                    subtotal = cantidad * costo;
                    subtotal = subtotal + itbis;
                    dtgEntrada.CurrentRow.Cells[7].Value = subtotal;
                    dtgEntrada.CurrentRow.Cells[9].Value = itbis;
                }
            }
            catch (Exception ex)
            {
                //MessageBoxEx.Show(ex.Message);
            }
            
        }
        private static KeyPressEventHandler NumericCheckHandler = new KeyPressEventHandler(NumericCheck);
        private void dtgEntrada_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                if (dtgEntrada.CurrentCell.ColumnIndex == 5 || dtgEntrada.CurrentCell.ColumnIndex == 6)
                {
                    e.Control.KeyPress -= NumericCheckHandler;
                    e.Control.KeyPress += NumericCheckHandler;
                }
            }
            catch(Exception ex)
            {

            }
        }
        private static void NumericCheck(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl s = sender as DataGridViewTextBoxEditingControl;
            if (s != null && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                e.Handled = s.Text.Contains(e.KeyChar);
            }
            else
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            if (MessageBoxEx.Show("¿Desea Salir?", "FactSYS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }
        private void CalcularTotal()
        {
            double total = 0.00;
            for (int y = 0; y < dtgEntrada.Rows.Count; y++)
            {
                total = total + Convert.ToDouble(dtgEntrada.Rows[y].Cells[7].Value);
                total1 = total;
            }
            
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            errorProvider1.Clear();
            if (Utilidades.ValidarForm2(this, errorProvider1) == false)
            {
                return;
            }
            try
            {
                CalcularTotal();
                C.Documento = txtDocumento.Text;
                C.Nota = txtNota.Text;
                C.Fecha = dtpFecha.Value;
                C.Idusuario = Program.Idusuario;
                C.Idsucursal = Program.Idsucursal;
                C.Factura = txtFactura.Text;
                C.Documento2 = Program.Documento;
                mensaje = C.RegistrarCompra();
                if (mensaje == "1")
                {
                    for (int x = 0; x < dtgEntrada.Rows.Count; x++)
                    {
                        C.Idcompra = 0;
                        C.Idproducto = Convert.ToInt32(dtgEntrada.Rows[x].Cells[0].Value);
                        C.Idalmacen = Convert.ToInt32(dtgEntrada.Rows[x].Cells[2].Value);
                        C.Idunidad = Convert.ToInt32(dtgEntrada.Rows[x].Cells[3].Value);
                        C.Cantidad = Convert.ToDouble(dtgEntrada.Rows[x].Cells[5].Value);
                        C.Costo = Convert.ToDouble(dtgEntrada.Rows[x].Cells[6].Value);
                        C.Importe = Convert.ToDouble(dtgEntrada.Rows[x].Cells[7].Value);
                        C.Itbis = Convert.ToDouble(dtgEntrada.Rows[x].Cells[9].Value);
                        mensaje = C.RegistrarDetalleCompra();
                    }
                    if (mensaje == "1")
                    {
                        MessageBoxEx.Show("Registrado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgEntrada.Rows.Clear();
                        Cp.Idcompra = Program.Idtransaccion;
                        Cp.Monto = total1;
                        Cp.Documento = Program.Documento;
                        Cp.Registrar();
                        Limpiar();
                        Autocompletar();
                        frmReporte obj = new frmReporte();
                        obj.Valor = 2;
                        obj.Reporte = "compra.rdlc";
                        obj.Idcompra = Program.Idtransaccion;
                        obj.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            txtNota.Clear();
            txtFactura.Clear();
        }
    }
}
