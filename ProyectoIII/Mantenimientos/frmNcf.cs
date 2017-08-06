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
using Entidades;

namespace ProyectoIII.Mantenimientos
{
    public partial class frmNcf : MetroForm
    {
        clsNcf N = new clsNcf();
        public int id;
        public int sec_anterior;
        public frmNcf()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "FactSYS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }
        private void LlenarGrid()
        {
            DataTable dt = new DataTable();

            dt = N.Listar();

            try
            {
                dtgNcf.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgNcf.Rows.Add(dt.Rows[x][0]);
                    dtgNcf.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgNcf.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgNcf.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgNcf.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                    dtgNcf.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                    dtgNcf.Rows[x].Cells[5].Value = dt.Rows[x][5].ToString();
                    dtgNcf.Rows[x].Cells[6].Value = dt.Rows[x][6].ToString();
                    dtgNcf.Rows[x].Cells[7].Value = dt.Rows[x][7].ToString();

                }
                dtgNcf.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (Utilidades.ValidarForm2(this, errorProvider1) == false)
                {
                    return;
                }
                bool mensaje;
                if (Program.Evento == 0)
                {
                    N.Serie = txtSerie.Text;
                    N.Division = txtDivision.Text;
                    N.Puntoe = txtPuntoe.Text;
                    N.Areaimp = txtAreaimp.Text;
                    N.Tipocf = txtTipocf.Text;
                    N.Secuencia = txtSecuencia.Text;
                    N.Secuenciaf = txtSecuenciaf.Text;
                    mensaje = N.Registrar();
                    if(mensaje==true)
                    {
                        MessageBoxEx.Show("Registrado con éxito", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBoxEx.Show("Ya se ha registrado este comprobante", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
                else if (Program.Evento == 1)
                {
                    int sec = Convert.ToInt32(txtSecuenciaf.Text);
                    if(sec>sec_anterior)
                    {
                        N.Id = id;
                        N.Secuenciaf = txtSecuenciaf.Text;
                        mensaje = N.Actualizar();
                        if (mensaje == true)
                        {
                            MessageBoxEx.Show("Secuencia actualizada", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            LlenarGrid();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Secuencia final debe ser mayor", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmNcf_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            dtgNcf.DefaultCellStyle.Font = new Font("Tahoma", 9);
            dtgNcf.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            LlenarGrid();
            Autocompletar();
            txtSerie.Focus();
        }
        private void Limpiar()
        {
            txtSecuenciaf.Clear();
            txtSerie.Clear();
            txtSecuencia.Clear();
            txtAreaimp.Clear();
            txtPuntoe.Clear();
            txtTipocf.Clear();
            txtDivision.Clear();
            txtTipocf.Clear();
            Autocompletar();
            txtSerie.Enabled = true;
            txtDivision.Enabled = true;
            txtPuntoe.Enabled = true;
            txtAreaimp.Enabled = true;
            txtTipocf.Enabled = true;
            txtSecuencia.Enabled = true;
        }
        private void Autocompletar()
        {
            string var = "1".PadLeft(8, '0');
            txtSecuencia.Text = var;
            txtSecuenciaf.Text = var;
        }

        private void dtgNcf_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dtgNcf.CurrentRow.Cells[0].Value);
            txtSerie.Text = dtgNcf.CurrentRow.Cells[1].Value.ToString();
            txtDivision.Text = dtgNcf.CurrentRow.Cells[2].Value.ToString();
            txtPuntoe.Text = dtgNcf.CurrentRow.Cells[3].Value.ToString();
            txtAreaimp.Text = dtgNcf.CurrentRow.Cells[4].Value.ToString();
            txtTipocf.Text = dtgNcf.CurrentRow.Cells[5].Value.ToString();
            txtSecuencia.Text = dtgNcf.CurrentRow.Cells[6].Value.ToString();
            txtSecuenciaf.Text = dtgNcf.CurrentRow.Cells[7].Value.ToString();
            sec_anterior = Convert.ToInt32(dtgNcf.CurrentRow.Cells[7].Value);
            txtSerie.Enabled = false;
            txtDivision.Enabled = false;
            txtPuntoe.Enabled = false;
            txtAreaimp.Enabled = false;
            txtTipocf.Enabled = false;
            txtSecuencia.Enabled = false;
            Program.Evento = 1;
        }
    }
}
