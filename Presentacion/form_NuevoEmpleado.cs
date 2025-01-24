using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class form_NuevoEmpleado : Form
    {
        public IContrato contrato { get; set; }
        bool empleadoNuevo = true;
        FormRefresh refrescaForm = new FormRefresh();
        FormValidator formOk = new FormValidator();
        public form_NuevoEmpleado()
        {
            InitializeComponent();
            txt_Id.Enabled = false;
            cbx_Depto.SelectedItem = "Sin Asignar";
        }
        public form_NuevoEmpleado(DataGridView dgv)
        {
            InitializeComponent();
            txt_Id.Enabled = false;
            txt_Id.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txt_Nombre.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txt_Apellido.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            cbx_Depto.SelectedItem = dgv.CurrentRow.Cells[3].Value.ToString();
            empleadoNuevo = false;
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string[] datosForm = new string[4] { txt_Id.Text , txt_Nombre.Text, txt_Apellido.Text, cbx_Depto.SelectedItem.ToString() };
            if (ValidateChildren(ValidationConstraints.Enabled)){
                refrescaForm.UpdateOrInsert(contrato, empleadoNuevo, datosForm);
                this.Close();
            }
        }
        //VALIDACIONES--------------------------------------------------------

        private void txt_Nombre_Validating(object sender, CancelEventArgs e)
        {
            formOk.ValidarTextBox(txt_Nombre, e, errorProvider1);
        }
        private void txt_Apellido_Validating(object sender, CancelEventArgs e)
        {
            formOk.ValidarTextBox(txt_Apellido, e, errorProvider1);
        }
        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void txt_Apellido_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void form_NuevoEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
