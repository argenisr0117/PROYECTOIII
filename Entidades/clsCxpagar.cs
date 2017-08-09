using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsCxpagar
    {
        private clsManejador M = new clsManejador();
        int Midcuenta;
        int Midproveedor;
        int Midcompra;
        string Mdocumento;
        double Mmonto;

        public int Idcuenta
        {
            get { return Midcuenta; }
            set { Midcuenta = value; }
        }
        public int Idproveedor
        {
            get { return Midproveedor; }
            set { Midproveedor = value; }
        }
        public int Idcompra
        {
            get { return Midcompra; }
            set { Midcompra = value; }
        }
        public string Documento
        {
            get { return Mdocumento; }
            set { Mdocumento = value; }
        }
        public double Monto
        {
            get { return Mmonto; }
            set { Mmonto = value; }
        }

        public void Registrar()
        {
            //bool mensaje = false;
            List<clsParametros> lst = new List<clsParametros>();
            //lst.Add(new clsParametros("@mensaje", "", SqlDbType.Bit, ParameterDirection.Output, 1));
            lst.Add(new clsParametros("@idcompra", Midcompra));
            lst.Add(new clsParametros("@monto", Mmonto));
            lst.Add(new clsParametros("@documento", Mdocumento));
            M.EjecutarSP("registrar_cxp", ref lst);
            //mensaje = Convert.ToBoolean(lst[0].Valor);
            //return mensaje;
        }

    }
}
