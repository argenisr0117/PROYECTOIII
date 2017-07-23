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

namespace ProyectoIII
{
    public partial class frmReporte : MetroForm
    {
        public frmReporte()
        {
            InitializeComponent();
        }
        public int Valor;
        public int Idorden;
        public int Idcompra;
        public string Reporte;
        private void frmReporte_Load(object sender, EventArgs e)
        {
            if (Valor == 1)
            {
                Orden_Compra();
            }
            else if (Valor == 2)
            {
                Compra();
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
            LocalReport lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\"+Reporte;
            lc.ReportPath = ruta;
            sta.Fill(ds.obtener_orden,Idorden);
            sta1.Fill(ds.obtener_orden_proveedor,Idorden);
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
            LocalReport lc = reportViewer1.LocalReport;
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
    }
}
