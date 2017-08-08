using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsCxcobrar
    {
        private clsManejador M = new clsManejador();
        int Midcuenta;
        int Midcliente;
        int Midfactura;
        double Mmonto;

        public int Idcuenta
        {
            get { return Midcuenta; }
            set { Midcuenta = value; }
        }
        public int Idcliente
        {
            get { return Midcliente; }
            set { Midcliente = value; }
        }
        public int Idfactura
        {
            get { return Midfactura; }
            set { Midfactura = value; }
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
            lst.Add(new clsParametros("@idfactura", Midfactura));
            lst.Add(new clsParametros("@idcliente", Midcliente));
            lst.Add(new clsParametros("@monto", Mmonto));
            M.EjecutarSP("registrar_cxc", ref lst);
            //mensaje = Convert.ToBoolean(lst[0].Valor);
            //return mensaje;
        }

    }
}
