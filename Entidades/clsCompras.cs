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
        string Mdocumento;
        string Mnota;
        DateTime Mfecha;
        DateTime Mfechah;
        int Midproducto;
        int Midunidad;
        int Midsucursal;
        int Midusuario;
        int Midproveedor;
        double Mcosto;
        double Mcantidad;
        double Mimporte;
        string Mdetalle;
        Boolean Mestado;
        string Mcampo = "id_cargo";
        string Mtabla = "Cargo";

        public int Idorden
        {
            get { return Midorden; }
            set { Midorden = value; }
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
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_orden_compra", ref lst);
            mensaje = lst[6].Valor.ToString();
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
    }
}
