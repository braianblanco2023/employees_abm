using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{   //ESTA INTERFACE SE USA PARA PASAR UNA REFERENCIA DEL formPadre AL formHijo, pasando datos del 2° al 1°
    public interface IContrato
    {
        void InsertarDataGrid(string[] datosForm, int id_retorno);
        void ActualizarDataGrid(string[] datosForm);
    }
}
