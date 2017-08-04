using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsCliente
    {
        private clsManejador M = new clsManejador();

        int Mid;
        int Mtipo;
        int Midcliente;
        Double Mlimite;
        int Midnacionalidad;
        string Mnombre;
        string Midgenero;
        Boolean Mestado;
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
        int Mvalor;
        int Middestipo;
        string Mcampo;
        string Mtabla;
        string Mvalor1;

        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }
        public int Tipo
        {
            get { return Mtipo; }
            set { Mtipo = value; }
        }
        public string Valor1
        {
            get { return Mvalor1; }
            set { Mvalor1 = value; }
        }
        public int Idcliente
        {
            get { return Midcliente; }
            set { Midcliente = value; }
        }
        public Double Limite
        {
            get { return Mlimite; }
            set { Mlimite = value; }
        }
        public int Idnacionalidad
        {
            get { return Midnacionalidad; }
            set { Midnacionalidad = value; }
        }
        public string Nombre
        {
            get { return Mnombre; }
            set { Mnombre = value; }
        }
        public string Idgenero
        {
            get { return Midgenero; }
            set { Midgenero = value; }
        }
        public Boolean Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
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
        public int Iddestipo
        {
            get { return Middestipo; }
            set { Middestipo = value; }
        }
        public int Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
        }
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
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@valor", Mvalor1));
            lst.Add(new clsParametros("@tipo", Mtipo));
            lst.Add(new clsParametros("@estado", Mestado));
            return dt = M.Listado("buscar_cliente", lst);

        }
        public string Registrar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@idgenero", Midgenero));
            lst.Add(new clsParametros("@idnacionalidad", Midnacionalidad));
            lst.Add(new clsParametros("@idtipot", Midtipoc));
            lst.Add(new clsParametros("@limite", Mlimite));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_cliente", ref lst);
            mensaje = lst[5].Valor.ToString();
            return mensaje;
        }
        public string Actualizar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idtercero", Midcliente));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@idgenero", Midgenero));
            lst.Add(new clsParametros("@idnacionalidad", Midnacionalidad));
            lst.Add(new clsParametros("@idtipot", Midtipoc));
            lst.Add(new clsParametros("@limite", Mlimite));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_cliente", ref lst);
            mensaje = lst[6].Valor.ToString();
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

        public string ActualizarI()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@ididentificacion", Mididentificacion));
            lst.Add(new clsParametros("@idtercero", Midcliente));
            lst.Add(new clsParametros("@identificacion", Midentificacion));
            lst.Add(new clsParametros("@idtipoi", Midtipoi));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_identificacion", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }

        public string ActualizarC()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idcontacto", Midcontacto));
            lst.Add(new clsParametros("@idtercero", Midcliente));
            lst.Add(new clsParametros("@contacto", Mcontacto));
            lst.Add(new clsParametros("@idtipoc", Midtipoc));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_contacto", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }

        public string ActualizarD()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@iddireccion", Middireccion));
            lst.Add(new clsParametros("@idtercero", Midcliente));
            lst.Add(new clsParametros("@descripcion", Mdireccion));
            lst.Add(new clsParametros("@idbarrio", Midbarrio));
            lst.Add(new clsParametros("@idciudad", Midciudad));
            lst.Add(new clsParametros("@idregion", Midregion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_direccion", ref lst);
            mensaje = lst[6].Valor.ToString();
            return mensaje;
        }
        public DataTable ListadoGenero()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_genero", lst);
        }
        public string Activar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Midcliente));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
        public DataTable DatosCliente()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Midcliente));
            return dt = M.Listado("obtener_datos_cliente", lst);

        }
        public DataTable DatosContacto()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Midcliente));
            return dt = M.Listado("obtener_datos_contactos", lst);

        }
        public DataTable DatosDireccion()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Midcliente));
            return dt = M.Listado("obtener_datos_direccion", lst);

        }
    }
}
