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

        private void dIRECCIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pAISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmDireccion obj = new Mantenimientos.frmDireccion();
            obj.Valor = 0;
            obj.ShowDialog();
        }

        private void rEGIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmDireccion obj = new Mantenimientos.frmDireccion();
            obj.Valor = 1;
            obj.ShowDialog();
        }

        private void cIUDADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmDireccion obj = new Mantenimientos.frmDireccion();
            obj.Valor = 2;
            obj.ShowDialog();
        }

        private void bARRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmDireccion obj = new Mantenimientos.frmDireccion();
            obj.Valor = 3;
            obj.ShowDialog();
        }

        private void nACIONALIDADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmNacionalidad obj = new Mantenimientos.frmNacionalidad();
            obj.ShowDialog();
        }

        private void cATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmCategoria obj = new Mantenimientos.frmCategoria();
            obj.ShowDialog();
        }

        private void uNIDADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmUnidad obj = new Mantenimientos.frmUnidad();
            obj.ShowDialog();
        }

        private void mARCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmMarca obj = new Mantenimientos.frmMarca();
            obj.ShowDialog();
        }

        private void cARGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmCargo obj = new Mantenimientos.frmCargo();
            obj.ShowDialog();
        }

        private void cONTACTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmDesTipo obj = new Mantenimientos.frmDesTipo();
            obj.ShowDialog();
        }

        private void fACTURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmTipos obj = new Mantenimientos.frmTipos();
            obj.ShowDialog();
        }

        private void pROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.frmcProveedor obj = new Consultas.frmcProveedor();
            obj.ShowDialog();
        }

        private void pRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Consultas.frmcProducto obj = new Consultas.frmcProducto();
            obj.ShowDialog();
        }

        private void eQUIVALENCIAUNIDADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmEquivalenciaUnidad obj = new Mantenimientos.frmEquivalenciaUnidad();
            obj.ShowDialog();
        }

        private void dEPARTAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmDepartamento obj = new Mantenimientos.frmDepartamento();
            obj.ShowDialog();
        }

        private void eMPRESAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmEmpresa obj = new Mantenimientos.frmEmpresa();
            obj.ShowDialog();
        }

        private void sUCURSALToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmSucursal obj = new Mantenimientos.frmSucursal();
            obj.ShowDialog();
        }

        private void aLMACENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmAlmacen obj = new Mantenimientos.frmAlmacen();
            obj.ShowDialog();
        }

        private void aSIGNARALMACENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmAsignarAlmacen obj = new Mantenimientos.frmAsignarAlmacen();
            obj.ShowDialog();
        }

        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.frmcEmpleado obj = new Consultas.frmcEmpleado();
            obj.ShowDialog();
        }

        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmUsuario obj = new Mantenimientos.frmUsuario();
            obj.ShowDialog();
        }

        private void oRDENCOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesos.frmOrdenCompra2 obj = new Procesos.frmOrdenCompra2();
            obj.ShowDialog();
        }
    }
}
