using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsCompras
    {
        private clsManejador M = new clsManejador();
        int Midorden;
        int Midtipo;
        int Midcompra;
        int Middevolucion;
        int Midmoneda;
        int Midalmacen;
        string Mdocumento;
        string Mdocumento2;
        string Mfactura;
        string Mnota;
        DateTime Mfecha;
        DateTime Mfechah;
        int Midproducto;
        int Midunidad;
        int Midsucursal;
        int Midusuario;
        int Midproveedor;
        int Midtercero;
        double Mcosto;
        double Mcantidad;
        double Mimporte;
        double Mitbis;
        string Mdetalle;
        Boolean Mestado;
        //string Mcampo = "id_cargo";
        //string Mtabla = "Cargo";

        public int Idorden
        {
            get { return Midorden; }
            set { Midorden = value; }
        }
        public int Idtipo
        {
            get { return Midtipo; }
            set { Midtipo = value; }
        }
        public int Idalmacen
        {
            get { return Midalmacen; }
            set { Midalmacen = value; }

        }
         public int Idmoneda
        {
            get { return Midmoneda; }
            set { Midmoneda = value; }
        }
        public int Iddevolucion
        {
            get { return Middevolucion; }
            set { Middevolucion = value; }
        }
        public int Idcompra
        {
            get { return Midcompra; }
            set { Midcompra = value; }
        }
        public int Idproducto
        {
            get { return Midproducto; }
            set { Midproducto = value; }
        }
        public int Idunidad
        {
            get { return Midunidad; }
            set { Midunidad = value; }
        }
        public int Idusuario
        {
            get { return Midusuario; }
            set { Midusuario = value; }
        }
        public int Idsucursal
        {
            get { return Midsucursal; }
            set { Midsucursal = value; }
        }
        public int Idtercero
        {
            get { return Midtercero; }
            set { Midtercero = value; }
        }
        public int Idproveedor
        {
            get { return Midproveedor; }
            set { Midproveedor = value; }
        }
        public string Documento
        {
            get { return Mdocumento; }
            set { Mdocumento = value; }
        }
        public string Documento2
        {
            get { return Mdocumento2; }
            set { Mdocumento2 = value; }
        }
        public string Factura
        {
            get { return Mfactura; }
            set { Mfactura = value; }
        }
        public string Nota
        {
            get { return Mnota; }
            set { Mnota = value; }
        }
        public double Costo
        {
            get { return Mcosto; }
            set { Mcosto = value; }
        }
        public double Itbis
        {
            get { return Mitbis; }
            set { Mitbis = value; }
        }
        public double Cantidad
        {
            get { return Mcantidad; }
            set { Mcantidad = value; }
        }
        public double Importe
        {
            get { return Mimporte; }
            set { Mimporte = value; }
        }
        public DateTime Fecha
        {
            get { return Mfecha; }
            set { Mfecha = value; }
        }
        public DateTime Fechah
        {
            get { return Mfechah; }
            set { Mfechah = value; }
        }
        public string RegistrarOrden()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@documento", Mdocumento));
            lst.Add(new clsParametros("@nota", Mnota));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@idproveedor", Midproveedor));
            lst.Add(new clsParametros("@idusuario", Midusuario));
            lst.Add(new clsParametros("@idsucursal", Midsucursal));
            lst.Add(new clsParametros("@idtipo", Midtipo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_orden_compra", ref lst);
            mensaje = lst[7].Valor.ToString();
            return mensaje;
        }
        public string RegistrarDetalleOrden()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idorden", Midorden));
            lst.Add(new clsParametros("@idproducto", Midproducto));
            lst.Add(new clsParametros("@idunidad", Midunidad));
            lst.Add(new clsParametros("@cantidad", Mcantidad));
            lst.Add(new clsParametros("@costo", Mcosto));
            lst.Add(new clsParametros("@importe", Mimporte));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_detalle_orden_compra", ref lst);
            mensaje = lst[6].Valor.ToString();
            return mensaje;
        }
        public string RegistrarCompra()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@documento", Mdocumento));
            lst.Add(new clsParametros("@factura", Mfactura));
            lst.Add(new clsParametros("@nota", Mnota));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@idusuario", Midusuario));
            lst.Add(new clsParametros("@documento2", Mdocumento2));
            lst.Add(new clsParametros("@idsucursal", Midsucursal));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_compra", ref lst);
            mensaje = lst[7].Valor.ToString();
            return mensaje;
        }
        public string RegistrarDetalleCompra()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idcompra", Midcompra));
            lst.Add(new clsParametros("@idproducto", Midproducto));
            lst.Add(new clsParametros("@idunidad", Midunidad));
            lst.Add(new clsParametros("@idalmacen", Midalmacen));
            lst.Add(new clsParametros("@cantidad", Mcantidad));
            lst.Add(new clsParametros("@costo", Mcosto));
            lst.Add(new clsParametros("@itbis", Mitbis));
            lst.Add(new clsParametros("@importe", Mimporte));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_detalle_compra", ref lst);
            mensaje = lst[8].Valor.ToString();
            return mensaje;
        }
        public DataTable BuscarOrdenes()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fechad", Mfecha));
            lst.Add(new clsParametros("@fechah", Mfechah));
            lst.Add(new clsParametros("@idtercero", Midproveedor));
            lst.Add(new clsParametros("@documento", Mdocumento));
            return dt = M.Listado("buscar_ordenes", lst);

        }
        public DataTable ObtenerDatosOrden()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@documento", Mdocumento));
            return dt = M.Listado("obtener_datos_orden", lst);

        }
        public DataTable ListadoMoneda()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_moneda", lst);

        }
        public string RegistrarDevolucion()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@documento", Mdocumento));
            lst.Add(new clsParametros("@factura", Mfactura));
            lst.Add(new clsParametros("@nota", Mnota));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@idusuario", Midusuario));
            lst.Add(new clsParametros("@idtercero", Midtercero));
            lst.Add(new clsParametros("@idmoneda", Midmoneda));
            lst.Add(new clsParametros("@idtipo", Midtipo));
            lst.Add(new clsParametros("@idsucursal", Midsucursal));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_devolucion", ref lst);
            mensaje = lst[7].Valor.ToString();
            return mensaje;
        }
        public string RegistrarDetalleDevolucion()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@iddevolucion", Middevolucion));
            lst.Add(new clsParametros("@idproducto", Midproducto));
            lst.Add(new clsParametros("@idunidad", Midunidad));
            lst.Add(new clsParametros("@idalmacen", Midalmacen));
            lst.Add(new clsParametros("@cantidad", Mcantidad));
            lst.Add(new clsParametros("@costo", Mcosto));
            lst.Add(new clsParametros("@itbis", Mitbis));
            lst.Add(new clsParametros("@importe", Mimporte));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_detalle_devolucion", ref lst);
            mensaje = lst[8].Valor.ToString();
            return mensaje;
        }
    }
}
