using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using System.Globalization;

namespace ProyectoIII
{
    public partial class frmMenu : MetroForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lbMenu.Location = new Point(500, 20);
             lbFecha.Location = new Point(900, 13);
             lbHora.Location = new Point(1100, 13);
            ObtenerHora();
            timer1.Start();
        }
        private void ObtenerHora()
        {
            lbFecha.Text = DateTime.Now.ToString("dddd, d MMMM yyyy",CultureInfo.CreateSpecificCulture("es-DO"));
            lbHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ObtenerHora();
        }
    }
}
