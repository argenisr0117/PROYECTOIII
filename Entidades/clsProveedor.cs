using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsProveedor
    {
        private clsManejador M = new clsManejador();
        int Midtercero;
        string Mnombre;
        int Midtipot;      
        int Middireccion;
        int Midregion;
        int Midciudad;
        int Midbarrio;
        string Mdireccion;
        int Midcontacto;
        string Mcontacto;
        int Midtipoc;
        int Mididentificacion;
        string Midentificacion;
        int Midtipoi;
        Boolean Mestado;
        string Mcampo;
        string Mtabla;
        int Mvalor;
        int Mtipo;
        string Mvalor1;


        public int Idtercero
        {
            get { return Midtercero; }
            set { Midtercero = value; }
        }
        public int Tipo
        {
            get { return Mtipo; }
            set { Mtipo = value; }
        }
        public string Nombre
        {
            get { return Mnombre; }
            set { Mnombre = value; }
        }
        public int Idtipot
        {
            get { return Midtipot; }
            set { Midtipot = value; }
        }
        //tercero
        public int Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
        }

        public string Valor1
        {
            get { return Mvalor1; }
            set { Mvalor1 = value; }
        }

        //direccion
        public int Iddireccion
        {
            get { return Middireccion; }
            set { Middireccion = value; }
        }
        public string Direccion
        {
            get { return Mdireccion; }
            set { Mdireccion = value; }
        }
        public int Idregion
        {
            get { return Midregion; }
            set { Midregion = value; }
        }
        public int Idciudad
        {
            get { return Midciudad; }
            set { Midciudad = value; }
        }
        public int Idbarrio
        {
            get { return Midbarrio; }
            set { Midbarrio = value; }
        }
        //direccion

        //Contacto
        public int Idcontacto
        {
            get { return Midcontacto; }
            set { Midcontacto = value; }
        }
        public string Contacto
        {
            get { return Mcontacto; }
            set { Mcontacto = value; }
        }
        public int Idtipoc
        {
            get { return Midtipoc; }
            set { Midtipoc = value; }
        }
        //Contacto

        //Identificacion
        public int Ididentificacion
        {
            get { return Mididentificacion; }
            set { Mididentificacion = value; }
        }
        public string Identificacion
        {
            get { return Midentificacion; }
            set { Midentificacion = value; }
        }
        public int Idtipoi
        {
            get { return Midtipoi; }
            set { Midtipoi = value; }
        }
        //Identificacion
        public string Campo
        {
            get { return Mcampo; }
            set { Mcampo = value; }
        }
        public string Tabla
        {
            get { return Mtabla; }
            set { Mtabla = value; }
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
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@idtipot", Midtipot));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_proveedor", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }
        public string RegistrarI()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@identificacion", Midentificacion));
            lst.Add(new clsParametros("@idtipoi", Midtipoi));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_identificacion", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }

        public string RegistrarC()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@contacto", Mcontacto));
            lst.Add(new clsParametros("@idtipoc", Midtipoc));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_contacto", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }

        public string RegistrarD()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@descripcion", Mdireccion));
            lst.Add(new clsParametros("@idbarrio", Midbarrio));
            lst.Add(new clsParametros("@idciudad", Midciudad));
            lst.Add(new clsParametros("@idregion", Midregion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_direccion", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@valor", Mvalor1));
            lst.Add(new clsParametros("@tipo", Mtipo));
            return dt = M.Listado("buscar_proveedor", lst);

        }
        public DataTable DatosProveedor()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Midtercero));
            return dt = M.Listado("obtener_datos_proveedor", lst);

        }
        public DataTable DatosContacto()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Midtercero));
            return dt = M.Listado("obtener_datos_contactos", lst);

        }
        public DataTable DatosDireccion()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Midtercero));
            return dt = M.Listado("obtener_datos_direccion", lst);

        }
        //public string Activar()
        //{
        //    string mensaje = "";
        //    List<clsParametros> lst = new List<clsParametros>();
        //    lst.Add(new clsParametros("@id", Mid));
        //    lst.Add(new clsParametros("@valor", Mestado));
        //    lst.Add(new clsParametros("@table", Mtabla));
        //    lst.Add(new clsParametros("@campo", Mcampo));
        //    lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
        //    M.EjecutarSP("actdes_entidades", ref lst);
        //    mensaje = lst[4].Valor.ToString();
        //    return mensaje;
        //}

    }
}
