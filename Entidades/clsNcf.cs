using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsNcf
    {
        private clsManejador M = new clsManejador();
        int Mid;
        int Mvalor;
        string Mserie;
        string Mdivision;
        string Mpuntoe;
        string Mareaimp;
        string Mtipocf;
        string Msecuencia;
        string Msecuenciaf;
        Boolean Mestado;
        string Mcampo = "id_cargo";
        string Mtabla = "Cargo";

        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }
        public int Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
        }
        public string Secuenciaf
        {
            get { return Msecuenciaf; }
            set { Msecuenciaf = value; }
        }
        public string Secuencia
        {
            get { return Msecuencia; }
            set { Msecuencia = value; }
        }
        public string Serie
        {
            get { return Mserie; }
            set { Mserie = value; }
        }
        public string Puntoe
        {
            get { return Mpuntoe; }
            set { Mpuntoe = value; }
        }
        public string Areaimp
        {
            get { return Mareaimp; }
            set { Mareaimp = value; }
        }
        public string Tipocf
        {
            get { return Mtipocf; }
            set { Mtipocf = value; }
        }
        public string Division
        {
            get { return Mdivision; }
            set { Mdivision = value; }
        }
        public Boolean Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
        }
        //Registrar

        public bool Registrar()
        {
            bool mensaje;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.Bit, ParameterDirection.Output, 1));
            lst.Add(new clsParametros("@serie", Mserie));
            lst.Add(new clsParametros("@division", Mdivision));
            lst.Add(new clsParametros("@puntoe", Mpuntoe));
            lst.Add(new clsParametros("@areaimp", Mareaimp));
            lst.Add(new clsParametros("@tipocf", Mtipocf));
            lst.Add(new clsParametros("@secuencia", Msecuencia));
            lst.Add(new clsParametros("@secuenciaf", Msecuenciaf));
            M.EjecutarSP("registrar_ncf", ref lst);
            mensaje = Convert.ToBoolean(lst[0].Valor);
            return mensaje;
        }
        public bool Actualizar()
        {
            bool mensaje;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.Bit, ParameterDirection.Output, 1));
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@secuenciaf", Msecuenciaf));
            M.EjecutarSP("actualizar_secuencia_ncf", ref lst);
            mensaje = Convert.ToBoolean(lst[0].Valor);
            return mensaje;
        }
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_ncf", lst);

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
