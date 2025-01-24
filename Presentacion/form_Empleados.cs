using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class form_Empleados : Form , IContrato
    {
        ButtonEnabler updateDeleteOk = new ButtonEnabler();
        Controller controller = new Controller();
        List<Empleado> empleados = new List<Empleado>();

        public form_Empleados()
        {
            InitializeComponent();
            cbx_BuscarX.SelectedItem = "Nombre";
        }
        private void form_Empleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aBM_EFDataSet.Empleadoes' Puede moverla o quitarla según sea necesario.
            this.empleadoesTableAdapter.Fill(this.aBM_EFDataSet.Empleadoes);
            btn_Buscar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_Eliminar.Enabled = false;
        }
        public void InsertarDataGrid(string[] datos_Form, int id_retorno)       //implementacion del metodo de la interfaz
        {
            datos_Form[0] = id_retorno.ToString();
            dgv_Empleados.Rows.Clear();
            dgv_Empleados.Rows.Add(datos_Form);          //se trae lo pasado desde el formHijo al DataGrid
            //al presionar boton guardar, trae algo al DataGrid, por tanto
            btn_Modificar.Enabled = true;
            btn_Eliminar.Enabled = true;
        }
        public void ActualizarDataGrid(string[] datos_form)    //implementacion del metodo de la interfaz
        {
            dgv_Empleados.Rows.Remove(dgv_Empleados.CurrentRow);    //primero borra lo editado
            dgv_Empleados.Rows.Add(datos_form);          //se trae lo pasado desde el formHijo al DataGrid
            btn_Modificar.Enabled = true;               
            btn_Eliminar.Enabled = true;
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            dgv_Empleados.Rows.Clear();
            empleados = controller.Select(txt_Buscar.Text, cbx_BuscarX.SelectedItem.ToString());
            
            foreach (Empleado emp in empleados)
            {
                dgv_Empleados.Rows.Add(emp.Id, emp.Nombre, emp.Apellido, emp.Departamento);
            }
            
            btn_Modificar.Enabled = updateDeleteOk.HabilitarUpdateDelete(dgv_Empleados);
            btn_Eliminar.Enabled = updateDeleteOk.HabilitarUpdateDelete(dgv_Empleados);
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            form_NuevoEmpleado form_EditaEmp = new form_NuevoEmpleado();
            form_EditaEmp.BringToFront();
            form_EditaEmp.contrato = this;
            form_EditaEmp.Show();
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            form_NuevoEmpleado form_EditaEmp = new form_NuevoEmpleado(dgv_Empleados);
            form_EditaEmp.BringToFront();
            form_EditaEmp.contrato = this;
            form_EditaEmp.Show();
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            controller.Delete(int.Parse(dgv_Empleados.CurrentRow.Cells[0].Value.ToString()));
            dgv_Empleados.Rows.Remove(dgv_Empleados.CurrentRow);
        }
        //VALIDACIONES------------------------------
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Buscar.Text))
            {
                btn_Buscar.Enabled = false;
            }
            else
            {
                btn_Buscar.Enabled = true;
            }
        }
        private void dgv_Empleados_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            btn_Modificar.Enabled = updateDeleteOk.HabilitarUpdateDelete(dgv_Empleados);
            btn_Eliminar.Enabled = updateDeleteOk.HabilitarUpdateDelete(dgv_Empleados);
        }
    }
}
