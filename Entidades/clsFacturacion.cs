using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsFacturacion
    {
        private clsManejador M = new clsManejador();
        int Midcaja;
        int Midusuario;
        int Midfactura;
        int Midmoneda;
        int Midalmacen;
        string Mdocumento;
        string Mdocumento2;
        string Mnota;
        string Mncf;
        DateTime Mfecha;
        DateTime Mfechah;
        int Midproducto;
        int Midunidad;
        int Midsucursal;
        int Midcliente;
        double Mprecio;
        double Mcantidad;
        double Mimporte;
        double Mitbis;
        string Mdetalle;
        int Midmetodop;
        int Midtipof;

        public int Idfactura
        {
            get { return Midfactura; }
            set { Midfactura = value; }
        }
        public int Idtipof
        {
            get { return Midtipof; }
            set { Midtipof = value; }
        }
        public int Idalmacen
        {
            get { return Midalmacen; }
            set { Midalmacen = value; }

        }
        public int Idcaja
        {
            get { return Midcaja; }
            set { Midcaja = value; }

        }
        public int Idmoneda
        {
            get { return Midmoneda; }
            set { Midmoneda = value; }
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
        public int Idmetodop
        {
            get { return Midmetodop; }
            set { Midmetodop = value; }
        }
        public int Idcliente
        {
            get { return Midcliente; }
            set { Midcliente = value; }
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
        public string Ncf
        {
            get { return Mncf; }
            set { Mncf = value; }
        }
        public string Nota
        {
            get { return Mnota; }
            set { Mnota = value; }
        }
        public double Precio
        {
            get { return Mprecio; }
            set { Mprecio = value; }
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

        public string RegistrarFactura()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@nota", Mnota));
            lst.Add(new clsParametros("@idcaja", Midcaja));
            lst.Add(new clsParametros("@documento", Mdocumento));
            lst.Add(new clsParametros("@ncf", Mncf));
            lst.Add(new clsParametros("@idusuario", Midusuario));
            lst.Add(new clsParametros("@idmoneda", Midmoneda));
            lst.Add(new clsParametros("@idtipof", Midtipof));
            lst.Add(new clsParametros("@idmetodop", Midmetodop));
            lst.Add(new clsParametros("@idcliente", Midcliente));
            lst.Add(new clsParametros("@idsucursal", Midsucursal));
            M.EjecutarSP("registrar_factura", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        public string RegistrarDetalleFactura()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idfactura", Midfactura));
            lst.Add(new clsParametros("@idproducto", Midproducto));
            lst.Add(new clsParametros("@idunidad", Midunidad));
            lst.Add(new clsParametros("@idalmacen", Midalmacen));
            lst.Add(new clsParametros("@cantidad", Mcantidad));
            lst.Add(new clsParametros("@precio", Mprecio));
            lst.Add(new clsParametros("@itbis", Mitbis));
            lst.Add(new clsParametros("@importe", Mimporte));
            M.EjecutarSP("registrar_detalle_factura", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
    }
}
