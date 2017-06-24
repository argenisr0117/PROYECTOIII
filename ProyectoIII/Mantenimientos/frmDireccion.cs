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

namespace ProyectoIII.Mantenimientos
{
    public partial class frmDireccion : MetroForm
    {
        public int Valor;
        public frmDireccion()
        {
            InitializeComponent();
        }

        private void SeleccionarTab()
        {
            if(Valor==0)
            {
                tabControl1.SelectedTab = tabPais;
                txtDescripcionPais.Focus();
            }
            else if(Valor==1)
            {
                tabControl1.SelectedTab = tabRegion;
            }
        }

        private void frmDireccion_Load(object sender, EventArgs e)
        {
            SeleccionarTab();
        }
    }
}
