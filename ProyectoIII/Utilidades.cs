using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIII.Controles;

namespace ProyectoIII
{
    class Utilidades
    {
        public static bool ValidarForm2(Control objForm, ErrorProvider error)
        {
            bool valor = true;
            foreach (Control obj in objForm.Controls)
            {
                if (obj.Controls.Count > 0)
                {
                    valor = ValidarForm2(obj, error);
                    continue;
                }

                if (obj is textbox)
                {
                    textbox obj2 = (textbox)obj;
                    if (obj2.Validar)
                    {
                        if (string.IsNullOrEmpty(obj2.Text.Trim()))
                        {
                            valor = false;

                            error.SetError(obj, (string.IsNullOrEmpty(obj2.Text.Trim())) ? "Campo obligatorio" : "");
                        }
                    }
                }
            }
            return valor;
        }
        public static bool ValidarForm(Control objForm, ErrorProvider error)
        {
            bool valor = true;
            foreach (Control obj in objForm.Controls)
            {
                //if (obj.Controls.Count > 0)
                //{
                //    valor = ValidarForm2(obj, error);
                //    continue;
                //}

                if (obj is textbox)
                {
                    textbox obj2 = (textbox)obj;
                    if (obj2.Validar)
                    {
                        if (string.IsNullOrEmpty(obj2.Text.Trim()))
                        {
                            valor = false;

                            error.SetError(obj, (string.IsNullOrEmpty(obj2.Text.Trim())) ? "Campo obligatorio" : "");
                        }
                    }
                }
            }
            return valor;
        }
    }
}
