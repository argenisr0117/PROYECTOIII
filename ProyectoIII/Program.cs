using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIII
{
    static class Program
    {
        public static int Evento;
        public static int Idorden;
        public static int Iddevolucion;
        public static int Idtransaccion;
        public static int Editar;
        public static int Iddireccion;
        public static int Codigo;
        public static int Id;
        public static int Idusuario;
        public static int Idcontacto;
        public static int Idsucursal;
        public static int IdIdentificacion;
        public static int Idproducto;
        public static int Idalmacen;
        public static string Idproduct;
        public static double Costo;
        public static double Costoa;
        public static double Costop;
        public static string Idproveedor;
        public static double Existencia;
        public static string Idcliente;
        public static string Cliente;
        public static int Idfactura;
        public static double Limite;

        // public static int Idproducto;
        public static int Idunidad;
        public static int Idprecio;
        public static string Proveedor;
        public static string Empleado;
        public static string Producto;
        public static double Itbis;
        public static string Unidad;
        public static string Documento;
        public static string Almacen;
        public static string Usuario;   
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
