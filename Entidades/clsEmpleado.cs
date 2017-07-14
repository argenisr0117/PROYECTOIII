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
        string Mnombre;
        string Mgenero;
        string Mapellidos;
        string Mestadoc;
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

        public int Idempleado
        {
            get { return Midempleado; }
            set { Midempleado = value; }
        } 
        public string Nombre
        {
            get { return Mnombre; }
            set { Mnombre = value; }
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
    }
}
