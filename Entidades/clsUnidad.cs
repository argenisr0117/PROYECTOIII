using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsUnidad
    {
        private clsManejador M = new clsManejador();
        int Mid;
        int Midproducto;
        int Mvalor;
        string Mdescripcion;
        string Mabreviacion;
        Boolean Mestado;
        string Mcampo = "id_unidad";
        string Mtabla = "Unidad";

        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
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
        public string Abreviacion
        {
            get { return Mabreviacion; }
            set { Mabreviacion = value; }
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
            lst.Add(new clsParametros("@abreviacion", Mabreviacion));
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_unidad", ref lst);
            mensaje = lst[3].Valor.ToString();
            return mensaje;
        }

        public DataTable Listar(Boolean objEstado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("listado_unidad", lst);
        }
        public DataTable EquivalenciaUnidad()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idproducto", Midproducto));
            lst.Add(new clsParametros("@abrev", Mabreviacion));
            return dt = M.Listado("obtener_Equivalencia", lst);

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
