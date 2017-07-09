using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsProducto
    {
        private clsManejador M = new clsManejador();

        int Midproducto;
        string Mdescripcion;
        string Mreferencia;
        int Midcategoria;
        int Midmarca;
        int Midunidad;
        int Miditbis;
        int Midproveedor;
        string Mproveedor;
        double Mpuntor;
        double Mpuntom;
        double Mcostoc;
        double Mcostop;
        string Mcodigob;
        string Mcampo;
        string Mtabla;
        int Mvalor;
        string Mvalor1;
        int Mtipo;
        Boolean Mestado;

        public string Valor1
        {
            get { return Mvalor1; }
            set { Mvalor1 = value; }
        }
        public int Idproducto
        {
            get { return Midproducto; }
            set { Midproducto = value; }
        }
        public int Tipo
        {
            get { return Mtipo; }
            set { Mtipo = value; }
        }
        public string Descripcion
        {
            get { return Mdescripcion; }
            set { Mdescripcion = value; }
        }
        public string Referencia
        {
            get { return Mreferencia; }
            set { Mreferencia = value; }
        }
        //tercero
        public int Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
        }

        public string Codigob
        {
            get { return Mcodigob; }
            set { Mcodigob = value; }
        }

        public int Idproveedor
        {
            get { return Midproveedor; }
            set { Midproveedor = value; }
        }
        public int Idcategoria
        {
            get { return Midcategoria; }
            set { Midcategoria = value; }
        }
        public string Proveedor
        {
            get { return Mproveedor; }
            set { Mproveedor = value; }
        }
        public int Idunidad
        {
            get { return Midunidad; }
            set { Midunidad = value; }
        }
        public int Iditbis
        {
            get { return Miditbis; }
            set { Miditbis = value; }
        }
        public int Idmarca
        {
            get { return Midmarca; }
            set { Midmarca = value; }
        }
 
        public double Puntor
        {
            get { return Mpuntor; }
            set { Mpuntor = value; }
        }
        public double Puntom
        {
            get { return Mpuntom; }
            set { Mpuntom = value; }
        }
        public double Costoc
        {
            get { return Mcostoc; }
            set { Mcostoc = value; }
        }
        
        public double Costop
        {
            get { return Mcostop; }
            set { Mcostop = value; }
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
            lst.Add(new clsParametros("@referencia", Mreferencia));
            lst.Add(new clsParametros("@idcategoria", Midcategoria));
            lst.Add(new clsParametros("@idmarca", Midmarca));
            lst.Add(new clsParametros("@idunidad", Midunidad));
            lst.Add(new clsParametros("@iditbis", Miditbis));
            lst.Add(new clsParametros("@puntore", Mpuntor));
            lst.Add(new clsParametros("@puntomax", Mpuntom));
            lst.Add(new clsParametros("@costoc", Mcostoc));
            lst.Add(new clsParametros("@costop", Mcostop));
            lst.Add(new clsParametros("@codigob",Mcodigob));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_producto", ref lst);
            mensaje = lst[11].Valor.ToString();
            return mensaje;
        }
        public string RegistrarP()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idproveedor", Midproveedor));
            M.EjecutarSP("registrar_producto_proveedor", ref lst);
            return mensaje;
        }
        public DataTable ListarI()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_itbis", lst);

        }
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@valor", Mvalor1));
            lst.Add(new clsParametros("@tipo", Mtipo));
            return dt = M.Listado("buscar_producto", lst);

        }
    }
}
