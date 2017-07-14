using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsSucursal
    {
        private clsManejador M = new clsManejador();
        int Mid;
        int Midtercero;
        int Midtipo;
        int Mvalor;
        string Mdescripcion;
        Boolean Mestado;
        string Mcampo = "id_sucursal";
        string Mtabla = "Sucursal";
        int Middireccion;
        int Midregion;
        int Midciudad;
        int Midbarrio;
        string Mdireccion;

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
        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }
        public int Idtercero
        {
            get { return Midtercero; }
            set { Midtercero = value; }
        }
        public int Idtipo
        {
            get { return Midtipo; }
            set { Midtipo = value; }
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
            lst.Add(new clsParametros("@idtercero", Midtercero));
            lst.Add(new clsParametros("@idtipo", Midtipo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_sucursal", ref lst);
            mensaje = lst[3].Valor.ToString();
            return mensaje;
        }
        public string Actualizar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idsucursal", Mid));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@idtercero", Midtercero));
            lst.Add(new clsParametros("@idtipo", Midtipo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_sucursal", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }

        public DataTable Listar(Boolean objEstado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado",objEstado));
            lst.Add(new clsParametros("@idtercero",Midtercero));
            return dt = M.Listado("listado_sucursal", lst);

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
        public string RegistrarD()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@descripcion", Mdireccion));
            lst.Add(new clsParametros("@idbarrio", Midbarrio));
            lst.Add(new clsParametros("@idciudad", Midciudad));
            lst.Add(new clsParametros("@idregion", Midregion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_direccion2", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
        public string ActualizarD()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@iddireccion", Middireccion));
            lst.Add(new clsParametros("@descripcion", Mdireccion));
            lst.Add(new clsParametros("@idbarrio", Midbarrio));
            lst.Add(new clsParametros("@idciudad", Midciudad));
            lst.Add(new clsParametros("@idregion", Midregion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_direccion2", ref lst);
            mensaje = lst[5].Valor.ToString();
            return mensaje;
        }
    }
}
