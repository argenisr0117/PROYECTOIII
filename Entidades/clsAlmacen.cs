using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsAlmacen
    {
        private clsManejador M = new clsManejador();
        int Mid;
        int Midsucursal;
        int Midproducto;
        int Mvalor;
        string Mdescripcion;
        string Midentificador;
        Boolean Mestado;
        string Mcampo = "id_almacen";
        string Mtabla = "Almacen";

        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }
        public int Idsucursal
        {
            get { return Midsucursal; }
            set { Midsucursal = value; }
        }
        public int Idproducto
        {
            get { return Midproducto; }
            set { Midproducto = value; }
        }
        public int Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
        }
        public string Descripcion
        {
            get { return Mdescripcion; }
            set { Mdescripcion = value; }
        }
        public string Identificador
        {
            get { return Midentificador; }
            set { Midentificador = value; }
        }
        public Boolean Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
        }
        //Registrar

        public string Registrar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@abreviacion", Midentificador));
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@idsucursal", Midsucursal));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_almacen", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }

        public DataTable Listar(Boolean objEstado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            lst.Add(new clsParametros("@idsucursal", Midsucursal));
            return dt = M.Listado("listado_almacen", lst);
        }
        public DataTable AlmacenesProductos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idproducto", Midproducto));
            return dt = M.Listado("obtener_almacenes_producto", lst);

        }
        public string Activar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
    }
}
