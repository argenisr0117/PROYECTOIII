using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsEmpleado
    {
        private clsManejador M = new clsManejador();


        int Midempleado;
        int Middpto;
        int Midseguro;
        int Midsucursal;
        int Midhorario;
        int Midcargo;
        Double Msueldo;
        int Midnacionalidad;
        string Mnombre;
        string Midgenero;
        string Mapellidos;
        int Midestadoc;
        DateTime Mfechanac;
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
        int Mtipo;
        string Mvalor1;

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
        public int Idempleado
        {
            get { return Midempleado; }
            set { Midempleado = value; }
        }
        public int Idcargo
        {
            get { return Midcargo; }
            set { Midcargo = value; }
        }
        public int Idseguro
        {
            get { return Midseguro; }
            set { Midseguro = value; }
        }
        public int Idhorario
        {
            get { return Midhorario; }
            set { Midhorario = value; }
        }
        public int Idsucursal
        {
            get { return Midsucursal; }
            set { Midsucursal = value; }
        }
        public Double Sueldo
        {
            get { return Msueldo; }
            set { Msueldo = value; }
        }
        public int Iddpto
        {
            get { return Middpto; }
            set { Middpto = value; }
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
        public int Idestadoc
        {
            get { return Midestadoc; }
            set { Midestadoc = value; }
        }
        public string Apellidos
        {
            get { return Mapellidos; }
            set { Mapellidos = value; }
        }
        public DateTime FechaNac
        {
            get { return Mfechanac; }
            set { Mfechanac = value; }
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
            return dt = M.Listado("buscar_empleado", lst);

        }
        public string Registrar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@apellidos", Mapellidos));
            lst.Add(new clsParametros("@fechanac", Mfechanac));
            lst.Add(new clsParametros("@idgenero", Midgenero));
            lst.Add(new clsParametros("@idestadoc", Midestadoc));
            lst.Add(new clsParametros("@idnacionalidad", Midnacionalidad));
            lst.Add(new clsParametros("@iddpto", Middpto));
            lst.Add(new clsParametros("@idcargo", Midcargo));
            lst.Add(new clsParametros("@idhorario", Midhorario));
            lst.Add(new clsParametros("@idsucursal", Midsucursal));
            lst.Add(new clsParametros("@sueldo", Msueldo));
            lst.Add(new clsParametros("@idseguro", Midseguro));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_empleado", ref lst);
            mensaje = lst[12].Valor.ToString();
            return mensaje;
        }
        public string Actualizar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idempleado", Midempleado));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@apellidos", Mapellidos));
            lst.Add(new clsParametros("@fechanac", Mfechanac));
            lst.Add(new clsParametros("@idgenero", Midgenero));
            lst.Add(new clsParametros("@idestadoc", Midestadoc));
            lst.Add(new clsParametros("@idnacionalidad", Midnacionalidad));
            lst.Add(new clsParametros("@iddpto", Middpto));
            lst.Add(new clsParametros("@idcargo", Midcargo));
            lst.Add(new clsParametros("@idhorario", Midhorario));
            lst.Add(new clsParametros("@idsucursal", Midsucursal));
            lst.Add(new clsParametros("@sueldo", Msueldo));
            lst.Add(new clsParametros("@idseguro", Midseguro));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_empleado", ref lst);
            mensaje = lst[13].Valor.ToString();
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
            lst.Add(new clsParametros("@idtercero", Midempleado));
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
            lst.Add(new clsParametros("@idtercero", Midempleado));
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
            lst.Add(new clsParametros("@idtercero", Midempleado));
            lst.Add(new clsParametros("@descripcion", Mdireccion));
            lst.Add(new clsParametros("@idbarrio", Midbarrio));
            lst.Add(new clsParametros("@idciudad", Midciudad));
            lst.Add(new clsParametros("@idregion", Midregion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_direccion", ref lst);
            mensaje = lst[6].Valor.ToString();
            return mensaje;
        }
        public DataTable ListadoSeguro()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_seguro", lst);

        }
        public DataTable ListadoEstadoc()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_estadoc", lst);

        }
        public DataTable ListadoGenero()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_genero", lst);
        }
        public DataTable ListadoHorario()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_horario", lst);

        }
        public string Activar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Midempleado));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
        public DataTable DatosEmpleado()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Midempleado));
            return dt = M.Listado("obtener_datos_empleado", lst);

        }
        public DataTable DatosContacto()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Midempleado));
            return dt = M.Listado("obtener_datos_contactos", lst);

        }
        public DataTable DatosIdentificacion()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Midempleado));
            return dt = M.Listado("obtener_datos_identificacion", lst);

        }
        public DataTable DatosDireccion()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Midempleado));
            return dt = M.Listado("obtener_datos_direccion", lst);

        }
    }
}
