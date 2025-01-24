using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Presentacion
{
    class FormValidator
    {
        //VALIDADOR de textbox general
        public bool ValidarTextBox(TextBox txtBox, CancelEventArgs e, ErrorProvider eP)
        {
            if (string.IsNullOrEmpty(txtBox.Text))
            {
                e.Cancel = true;
                txtBox.Focus();
                eP.SetError(txtBox, "Campo obligatorio");
            }
            else
            {
                e.Cancel = false;
                eP.SetError(txtBox, null);
            }
            return e.Cancel;
        }
    }
}
