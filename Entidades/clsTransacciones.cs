using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsTransacciones
    {
        private clsManejador M = new clsManejador();
        int Mtipo;
        int Mnumero;
        string Mdescripcion;
        string Mdetalle;
        Boolean Mestado;
        string Mcampo = "id_cargo";
        string Mtabla = "Cargo";

        public int Tipo
        {
            get { return Mtipo; }
            set { Mtipo = value; }
        }
        public int Numero
        {
            get { return Mnumero; }
            set { Mnumero = value; }
        }
        public string Detalle
        {
            get { return Mdetalle; }
            set { Mdetalle = value; }
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

        public int NumeroDocumento()
        {
            int numero = 0;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@tipo", Mtipo));
            lst.Add(new clsParametros("@numero", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("obtener_numero_documento", ref lst);
            numero = Convert.ToInt32(lst[1].Valor);
            return numero;
        }
        public string [] NumeroNCF()
        {
            string[] numero= new string[2];
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@tipo", Mtipo));
            lst.Add(new clsParametros("@numero", "", SqlDbType.Int, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@ncf", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("obtener_numero_ncf", ref lst);
            numero[0] = lst[1].Valor.ToString();
            numero[1] = lst[2].Valor.ToString();
            return numero;
        }
        public DataTable ListadoMoneda()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_moneda", lst);

        }

    }
}
