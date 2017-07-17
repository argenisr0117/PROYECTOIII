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
        public static int Editar;
        public static int Iddireccion;
        public static int Codigo;
        public static int Id;
        public static int Idusuario;
        public static int Idcontacto;
        public static int Idsucursal;
        public static int IdIdentificacion;
        public static int Idproducto;
        public static int Idunidad;
        public static string Proveedor;
        public static string Empleado;
        public static string Producto;
        public static string Unidad;


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
