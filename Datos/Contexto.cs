using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;

namespace Datos
{
    public class Contexto : DbContext
    {
        public Contexto () : base(/*ref DB*/) { }

        public DbSet<Entidades.Empleado> Empleados { get; set; } 
    }
}
