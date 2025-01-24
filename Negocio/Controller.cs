using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocio
{
    public class Controller
    {
        List<Empleado> empleados;
        DataTable tabla = new DataTable();

        public List<Empleado> SelectByDpto(string txt_buscar)
        {
            using (Contexto db = new Contexto())
            {
                empleados = db.Empleados.Where(x => x.Departamento == txt_buscar).ToList();
            }
            return empleados;
        }
        public List<Empleado> SelectByName(string txt_buscar)
        {
            using (Contexto db = new Contexto())
            {
                empleados = db.Empleados.Where(x => x.Nombre == txt_buscar).ToList();
            }
            return empleados;
        }
        public int Insert(string[] datos_Form)
        {
            int id_retorno;
            using (Contexto db = new Contexto())
            {
                Empleado emp = new Empleado();
                emp.Nombre = datos_Form[1];
                emp.Apellido = datos_Form[2];
                emp.Departamento = datos_Form[3];
                db.Empleados.Add(emp);
                db.SaveChanges();
                id_retorno = emp.Id;
            }
            return id_retorno;
        }
        public void Update(string[] datos_Form)
        {
            int id = int.Parse(datos_Form[0]);
            using (Contexto db = new Contexto())
            {
                Empleado emp;
                emp = db.Empleados.Where(x => x.Id == id).FirstOrDefault();
                emp.Nombre = datos_Form[1];
                emp.Apellido = datos_Form[2];
                emp.Departamento = datos_Form[3];
                db.SaveChanges();
            }
        }
        public void Delete(int dgv_idEmpleado)
        {
            using (Contexto db = new Contexto())
            {
                Empleado emp;
                emp = db.Empleados.Where(x => x.Id == dgv_idEmpleado).FirstOrDefault();
                db.Empleados.Remove(emp);
                db.SaveChanges();
            }
        }
        public List<Empleado> Select(string txt_buscar, string buscarX)
        {
            if (buscarX == "Departamento")
            {
                empleados = SelectByDpto(txt_buscar);
            }
            else if (buscarX == "Nombre")
            {
                empleados = SelectByName(txt_buscar);
            }
            return empleados;
        }
    }
}
