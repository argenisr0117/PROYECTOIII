using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsCaja
    {
        private clsManejador M = new clsManejador();
        int Mid;
        int Mvalor;
        string Mdescripcion;
        string Mdetalle;
        Boolean Mestado;
        string Mcampo = "id_cargo";
        string Mtabla = "Cargo";
        int Midcaja;
        int Midusuario;
        double Mmonto;

        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }
        public int Idusuario
        {
            get { return Midusuario; }
            set { Midusuario = value; }
        }
        public int Idcaja
        {
            get { return Midcaja; }
            set { Midcaja = value; }
        }
        public double Monto
        {
            get { return Mmonto; }
            set { Mmonto = value; }
        }
        public int Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
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
        //Registrar

        public bool AbrirCaja()
        {
            bool mensaje = false;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.Bit, ParameterDirection.Output,1));
            lst.Add(new clsParametros("@idcaja", Midcaja));
            lst.Add(new clsParametros("@idusuario", Midusuario));
            lst.Add(new clsParametros("@monto", Mmonto));
            M.EjecutarSP("abrir_caja", ref lst);
            mensaje = Convert.ToBoolean(lst[0].Valor);
            return mensaje;
        }
       
        public DataTable Listar(Boolean objEstado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("listado_caja", lst);

        }
        public DataTable VerificarCajaAbierta()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idusuario", Midusuario));
            return dt = M.Listado("verificar_caja_abierta", lst);
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
