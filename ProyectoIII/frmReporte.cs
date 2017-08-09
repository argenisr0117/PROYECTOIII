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
using Microsoft.Reporting.WinForms;
using System.Net.Mail;
using System.IO;

namespace ProyectoIII
{
    public partial class frmReporte : MetroForm
    {
        public frmReporte()
        {
            InitializeComponent();
        }
        public LocalReport lc;
        public int Valor;
        public int Idorden;
        public int Idfactura;
        public int Iddevolucion;
        public int Idcompra;
        public int Idcliente;
        public DateTime Fechah;
        public DateTime Fechad;
        public string Reporte;
        public string Orden1;
        public string Orden2;
        public string Orden3;
        public string Orden4;
        public string Orden5;
        private void frmReporte_Load(object sender, EventArgs e)
        {
            rbPdf.Checked = true;
            if (Valor == 1)
            {
                Orden_Compra();
            }
            else if (Valor == 2)
            {
                Compra();
            }
            else if(Valor == 3)
            {
                Devolucion_Compra();
            }
            else if (Valor == 4)
            {
                Listado();
            }
            else if (Valor == 5)
            {
                ListadoProveedores();
            }
            else if (Valor == 6)
            {
                ListadoClientes();
            }
            else if (Valor == 7)
            {
                ListadoProductos();
            }
            else if (Valor == 8)
            {
                Factura();
            }
            else if (Valor == 9)
            {
                CuentasxCobrar();
            }
        }
        private void Orden_Compra()
        {
          
            //ReportParameter[] parametros = new ReportParameter[4];
            //parametros[0] = new ReportParameter("Itbis", itbis.ToString());
            //parametros[1] = new ReportParameter("Total", total.ToString());
            //parametros[2] = new ReportParameter("Descuento", descuento.ToString());
            //parametros[3] = new ReportParameter("Subtotal", subtotal.ToString());
            Proyecto3DataSet ds = new Proyecto3DataSet();
            Proyecto3DataSetTableAdapters.obtener_ordenTableAdapter sta = new Proyecto3DataSetTableAdapters.obtener_ordenTableAdapter();
            Proyecto3DataSetTableAdapters.obtener_orden_proveedorTableAdapter sta1 = new Proyecto3DataSetTableAdapters.obtener_orden_proveedorTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Reporte;
            lc.ReportPath = ruta;
            sta.Fill(ds.obtener_orden, Idorden);
            sta1.Fill(ds.obtener_orden_proveedor, Idorden);
            ReportDataSource rds = new ReportDataSource();
            ReportDataSource rds1 = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obtener_orden"]);
            rds1.Name = "DataSet2";
            rds1.Value = (ds.Tables["obtener_orden_proveedor"]);
            reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            lc.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
        private void Factura()
        {

            //ReportParameter[] parametros = new ReportParameter[4];
            //parametros[0] = new ReportParameter("Itbis", itbis.ToString());
            //parametros[1] = new ReportParameter("Total", total.ToString());
            //parametros[2] = new ReportParameter("Descuento", descuento.ToString());
            //parametros[3] = new ReportParameter("Subtotal", subtotal.ToString());
            Proyecto3DataSet ds = new Proyecto3DataSet();
            Proyecto3DataSetTableAdapters.obtener_facturaTableAdapter sta = new Proyecto3DataSetTableAdapters.obtener_facturaTableAdapter();
            Proyecto3DataSetTableAdapters.obtener_cliente_facturaTableAdapter sta1 = new Proyecto3DataSetTableAdapters.obtener_cliente_facturaTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Reporte;
            lc.ReportPath = ruta;
            sta.Fill(ds.obtener_factura, Idfactura);
            sta1.Fill(ds.obtener_cliente_factura, Idfactura);
            ReportDataSource rds = new ReportDataSource();
            ReportDataSource rds1 = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obtener_factura"]);
            rds1.Name = "DataSet2";
            rds1.Value = (ds.Tables["obtener_cliente_factura"]);
            reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            lc.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
        private void Devolucion_Compra()
        {
            //ReportParameter[] parametros = new ReportParameter[4];
            //parametros[0] = new ReportParameter("Itbis", itbis.ToString());
            //parametros[1] = new ReportParameter("Total", total.ToString());
            //parametros[2] = new ReportParameter("Descuento", descuento.ToString());
            //parametros[3] = new ReportParameter("Subtotal", subtotal.ToString());
            Proyecto3DataSet ds = new Proyecto3DataSet();
            Proyecto3DataSetTableAdapters.obtener_devolucionTableAdapter sta = new Proyecto3DataSetTableAdapters.obtener_devolucionTableAdapter();
            Proyecto3DataSetTableAdapters.obtener_devolucion_proveedorTableAdapter sta1 = new Proyecto3DataSetTableAdapters.obtener_devolucion_proveedorTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Reporte;
            lc.ReportPath = ruta;
            sta.Fill(ds.obtener_devolucion, Iddevolucion);
            sta1.Fill(ds.obtener_devolucion_proveedor, Iddevolucion);
            ReportDataSource rds = new ReportDataSource();
            ReportDataSource rds1 = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obtener_devolucion"]);
            rds1.Name = "DataSet2";
            rds1.Value = (ds.Tables["obtener_devolucion_proveedor"]);
            reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            lc.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
        private void Compra()
        {
            //ReportParameter[] parametros = new ReportParameter[4];
            //parametros[0] = new ReportParameter("Itbis", itbis.ToString());
            //parametros[1] = new ReportParameter("Total", total.ToString());
            //parametros[2] = new ReportParameter("Descuento", descuento.ToString());
            //parametros[3] = new ReportParameter("Subtotal", subtotal.ToString());
            Proyecto3DataSet ds = new Proyecto3DataSet();
            Proyecto3DataSetTableAdapters.obtener_compraTableAdapter sta = new Proyecto3DataSetTableAdapters.obtener_compraTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Reporte;
            lc.ReportPath = ruta;
            sta.Fill(ds.obtener_compra, Idcompra);
            ReportDataSource rds = new ReportDataSource();
            ReportDataSource rds1 = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obtener_compra"]);
            reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
        private void Listado()
        {
            ReportParameter[] parametros = new ReportParameter[5];
            parametros[0] = new ReportParameter("Orden1", Orden1.ToString());
            parametros[1] = new ReportParameter("Orden2", Orden2.ToString());
            parametros[2] = new ReportParameter("Orden3", Orden3.ToString());
            parametros[3] = new ReportParameter("Orden4", Orden4.ToString());
            parametros[4] = new ReportParameter("Orden5", Orden5.ToString());
            Proyecto3DataSet ds = new Proyecto3DataSet();
            Proyecto3DataSetTableAdapters.listado_empleadosTableAdapter sta = new Proyecto3DataSetTableAdapters.listado_empleadosTableAdapter();
            //Proyecto3DataSetTableAdapters.obtener_orden_proveedorTableAdapter sta1 = new Proyecto3DataSetTableAdapters.obtener_orden_proveedorTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Reporte;
            lc.ReportPath = ruta;
            sta.Fill(ds.listado_empleados);
            //sta1.Fill(ds.obtener_orden_proveedor,Idorden);
            ReportDataSource rds = new ReportDataSource();
            //ReportDataSource rds1 = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["listado_empleados"]);
            //rds1.Name = "DataSet2";
            //rds1.Value = (ds.Tables["obtener_orden_proveedor"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            //lc.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
        private void ListadoProveedores()
        {
            ReportParameter[] parametros = new ReportParameter[5];
            parametros[0] = new ReportParameter("Orden1", Orden1.ToString());
            parametros[1] = new ReportParameter("Orden2", Orden2.ToString());
            parametros[2] = new ReportParameter("Orden3", Orden3.ToString());
            parametros[3] = new ReportParameter("Orden4", Orden4.ToString());
            parametros[4] = new ReportParameter("Orden5", Orden5.ToString());
            Proyecto3DataSet ds = new Proyecto3DataSet();
            Proyecto3DataSetTableAdapters.listado_proveedoresTableAdapter sta = new Proyecto3DataSetTableAdapters.listado_proveedoresTableAdapter();
            //Proyecto3DataSetTableAdapters.obtener_orden_proveedorTableAdapter sta1 = new Proyecto3DataSetTableAdapters.obtener_orden_proveedorTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Reporte;
            lc.ReportPath = ruta;
            sta.Fill(ds.listado_proveedores);
            //sta1.Fill(ds.obtener_orden_proveedor,Idorden);
            ReportDataSource rds = new ReportDataSource();
            //ReportDataSource rds1 = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["listado_proveedores"]);
            //rds1.Name = "DataSet2";
            //rds1.Value = (ds.Tables["obtener_orden_proveedor"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            //lc.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
        private void ListadoProductos()
        {
            ReportParameter[] parametros = new ReportParameter[5];
            parametros[0] = new ReportParameter("Orden1", Orden1.ToString());
            parametros[1] = new ReportParameter("Orden2", Orden2.ToString());
            parametros[2] = new ReportParameter("Orden3", Orden3.ToString());
            parametros[3] = new ReportParameter("Orden4", Orden4.ToString());
            parametros[4] = new ReportParameter("Orden5", Orden5.ToString());
            Proyecto3DataSet ds = new Proyecto3DataSet();
            Proyecto3DataSetTableAdapters.listado_productosTableAdapter sta = new Proyecto3DataSetTableAdapters.listado_productosTableAdapter();
            //Proyecto3DataSetTableAdapters.obtener_orden_proveedorTableAdapter sta1 = new Proyecto3DataSetTableAdapters.obtener_orden_proveedorTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Reporte;
            lc.ReportPath = ruta;           
            sta.Fill(ds.listado_productos);
            //sta1.Fill(ds.obtener_orden_proveedor,Idorden);
            ReportDataSource rds = new ReportDataSource();
            //ReportDataSource rds1 = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["listado_productos"]);
            //rds1.Name = "DataSet2";
            //rds1.Value = (ds.Tables["obtener_orden_proveedor"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            //lc.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
        private void ListadoClientes()
        {
            ReportParameter[] parametros = new ReportParameter[5];
            parametros[0] = new ReportParameter("Orden1", Orden1.ToString());
            parametros[1] = new ReportParameter("Orden2", Orden2.ToString());
            parametros[2] = new ReportParameter("Orden3", Orden3.ToString());
            parametros[3] = new ReportParameter("Orden4", Orden4.ToString());
            parametros[4] = new ReportParameter("Orden5", Orden5.ToString());
            Proyecto3DataSet ds = new Proyecto3DataSet();
            Proyecto3DataSetTableAdapters.listado_clientesTableAdapter sta = new Proyecto3DataSetTableAdapters.listado_clientesTableAdapter();
            //Proyecto3DataSetTableAdapters.obtener_orden_proveedorTableAdapter sta1 = new Proyecto3DataSetTableAdapters.obtener_orden_proveedorTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Reporte;
            lc.ReportPath = ruta;
            sta.Fill(ds.listado_clientes);
            //sta1.Fill(ds.obtener_orden_proveedor,Idorden);
            ReportDataSource rds = new ReportDataSource();
            //ReportDataSource rds1 = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["listado_clientes"]);
            //rds1.Name = "DataSet2";
            //rds1.Value = (ds.Tables["obtener_orden_proveedor"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            //lc.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
        private void CuentasxCobrar()
        {
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("Fechad", Fechad.ToShortDateString());
            parametros[1] = new ReportParameter("Fechah", Fechah.ToShortDateString());
            Proyecto3DataSet ds = new Proyecto3DataSet();
            Proyecto3DataSetTableAdapters.obtener_facturas_pendientesTableAdapter sta = new Proyecto3DataSetTableAdapters.obtener_facturas_pendientesTableAdapter();
            //Proyecto3DataSetTableAdapters.obtener_orden_proveedorTableAdapter sta1 = new Proyecto3DataSetTableAdapters.obtener_orden_proveedorTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Reporte;
            lc.ReportPath = ruta;
            sta.Fill(ds.obtener_facturas_pendientes,Fechad,Fechah,Idcliente);
            //sta1.Fill(ds.obtener_orden_proveedor,Idorden);
            ReportDataSource rds = new ReportDataSource();
            //ReportDataSource rds1 = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["obtener_facturas_pendientes"]);
            //rds1.Name = "DataSet2";
            //rds1.Value = (ds.Tables["obtener_orden_proveedor"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            //lc.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
        private void EnviarCorreo(string emailTo,string Formato, string extension)
        {
            try
            {
                var bytes = lc.Render(Formato);
                var correo = new MailMessage { From = new MailAddress("argenis1765@gmail.com", "Argenis Rosario") };
                foreach (var address in emailTo.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    correo.To.Add(address);
                }
                correo.Subject = "Reporte como Correo";
                correo.Attachments.Add(new Attachment(new MemoryStream(bytes), "Reporte"+extension));
                using (var smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    smtpClient.EnableSsl = true;
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new System.Net.NetworkCredential("argenis1765@gmail.com", "12345678p");
                    smtpClient.Send(correo);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (rbExcel.Checked)
            {
                EnviarCorreo(txtDestinos.Text,"Excel",".xls");
            }
            if (rbPdf.Checked)
            {
                EnviarCorreo(txtDestinos.Text, "PDF",".pdf");
            }
            if (rbWord.Checked)
            {
                EnviarCorreo(txtDestinos.Text, "Word",".doc");
            }
            txtDestinos.Clear();
        }
    }
}
