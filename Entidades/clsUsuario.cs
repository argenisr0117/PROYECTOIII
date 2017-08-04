using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsUsuario
    {
        private clsManejador M = new clsManejador();
        int Mid;
        int Midempleado;
        int Midperfil;
        int Mvalor;
        string Mdescripcion;
        string Mclave;
        Boolean Mestado;
        string Mcampo = "id_usuario";
        string Mtabla = "usuario";

        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }
        public int Idempleado
        {
            get { return Midempleado; }
            set { Midempleado = value; }
        }
        public int Idperfil
        {
            get { return Midperfil; }
            set { Midperfil = value; }
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
        public string Clave
        {
            get { return Mclave; }
            set { Mclave = value; }
        }
        public Boolean Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
        }
        //Registrar

        //public static bool Autenticar()
        //{
        //    bool mensaje;
        //}
        public string Registrar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@usuario", Mdescripcion));
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@idempleado", Midempleado));
            lst.Add(new clsParametros("@idperfil", Midperfil));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_usuario", ref lst);
            mensaje = lst[5].Valor.ToString();
            return mensaje;
        }
        public string VerificarLogin()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@usuario", Mdescripcion));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("verificar_login", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }
        public void RegistrarLog()
        {
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@terminal",Mdescripcion));
            M.EjecutarSP("registro_log_usuario", ref lst);
        }

        public DataTable Listar(Boolean objEstado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("listado_usuarios", lst);

        }
        public DataTable ListarP()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_perfil", lst);

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
