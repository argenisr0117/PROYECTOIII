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
    }
}
