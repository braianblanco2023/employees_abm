using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    class ButtonEnabler
    {
        //VALIDADOR DE CONTROLES cuando el GridView esta vacio o contiene una seleccion
        public bool HabilitarUpdateDelete(DataGridView dgv)
        {
            bool habilitar = false;
            if (dgv.DisplayedRowCount(true) > 0)
            {
                habilitar = true;
            }
            else if (dgv.DisplayedRowCount(true) == 0)
            {
                habilitar = false;
            }
            return habilitar;
        }
    }
}
