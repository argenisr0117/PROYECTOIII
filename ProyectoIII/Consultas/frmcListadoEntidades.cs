using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;

namespace ProyectoIII.Consultas
{
    public partial class frmcListadoEntidades : MetroForm
    {
        public frmcListadoEntidades()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItems.Count > 0)
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    listBox1.SelectedItem = 0;
                }
                else
                {
                    MessageBoxEx.Show("Debe seleccionar un registro", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmcListadoEntidades_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedItems.Count > 0)
                {
                    listBox1.Items.Add(listBox2.SelectedItem);
                    listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                    listBox2.SelectedItem = 0;
                }
                else
                {
                    MessageBoxEx.Show("Debe seleccionar un registro", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Addall_btn_Click(object sender, EventArgs e)
        {
            try
            {
               
                listBox2.Items.AddRange(listBox1.Items);
                listBox1.Items.Clear();              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Removeall_btn_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.AddRange(listBox2.Items);
                listBox2.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "FactSYS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void cbEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbEntidad.SelectedIndex == 0)
                {
                    listBox1.Items[0] = "Cedula";
                    listBox1.Items[1] = "Nombre";
                    listBox1.Items[2] = "Apellidos";
                    listBox1.Items[3] = "Genero";
                    listBox1.Items[4] = "Departamento";
                }
                else if (cbEntidad.SelectedIndex == 1)
                {
                    listBox1.Items[0] = "Cedula/Rnc";
                    listBox1.Items[1] = "Nombre";
                    listBox1.Items[2] = "Codigo";
                    listBox1.Items[3] = "Region";
                    listBox1.Items[4] = "Tipo";
                }
                else if (cbEntidad.SelectedIndex == 2)
                {
                    listBox1.Items[0] = "Cedula/Rnc";
                    listBox1.Items[1] = "Nombre";
                    listBox1.Items[2] = "Codigo";
                    listBox1.Items[3] = "Nacionalidad";
                    listBox1.Items[4] = "Genero";
                }
                else if (cbEntidad.SelectedIndex == 3)
                {
                    listBox1.Items[0] = "Referencia";
                    listBox1.Items[1] = "Descripcion";
                    listBox1.Items[2] = "Existencia";
                    listBox1.Items[3] = "Categoria";
                    listBox1.Items[4] = "Marca";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbEntidad.SelectedIndex == -1)
                {
                    MessageBoxEx.Show("Debe seleccionar una entidad", "FactSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmReporte obj = new frmReporte();
                    if(listBox2.Items.Count>0)
                    {
                        obj.Orden1 = listBox2.Items[0].ToString();
                    }
                    else
                    {
                        obj.Orden1 = "0";
                    }
                    if (listBox2.Items.Count >= 2)
                    {
                        obj.Orden2 = listBox2.Items[1].ToString();
                    }
                    else
                    {
                        obj.Orden2 = "0";
                    }

                    if (listBox2.Items.Count >= 3)
                    {
                        obj.Orden3 = listBox2.Items[2].ToString();
                    }
                    else
                    {
                        obj.Orden3 = "0";
                    }
                    if (listBox2.Items.Count >= 4)
                    {
                        obj.Orden4 = listBox2.Items[3].ToString();
                    }
                    else
                    {
                        obj.Orden4 = "0";
                    }
                    if (listBox2.Items.Count >= 5)
                    {
                        obj.Orden5 = listBox2.Items[4].ToString();
                    }
                    else
                    {
                        obj.Orden5 = "0";
                    }

                    if(cbEntidad.SelectedIndex==0)
                    {
                        obj.Valor = 4;
                        obj.Reporte = "listado_empleados.rdlc";
                    }
                    if (cbEntidad.SelectedIndex == 1)
                    {
                        obj.Valor = 5;
                        obj.Reporte = "listado_proveedores.rdlc";
                    }
                    if (cbEntidad.SelectedIndex == 2)
                    {
                        obj.Valor = 6;
                        obj.Reporte = "listado_clientes.rdlc";
                    }
                    if (cbEntidad.SelectedIndex == 3)
                    {
                        obj.Valor = 7;
                        obj.Reporte = "listado_productos.rdlc";
                    }
                    obj.ShowDialog();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.AddRange(listBox2.Items);
                listBox2.Items.Clear();
                cbEntidad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
