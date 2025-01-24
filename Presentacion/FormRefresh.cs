using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;

namespace Presentacion
{
    class FormRefresh
    {
        public void UpdateOrInsert(IContrato contrato, bool empleNuevo, string[] datos_Form)
        {
            int id_retorno;
            Controller controller = new Controller();
            if (empleNuevo == false)
            {
                controller.Update(datos_Form);
                contrato.ActualizarDataGrid(datos_Form);
            }
            else
            {
                id_retorno = controller.Insert(datos_Form);
                contrato.InsertarDataGrid(datos_Form, id_retorno);
            }
        }
    }
}
