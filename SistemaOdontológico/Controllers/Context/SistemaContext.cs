using Controllers.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Context
{
    class SistemaContext : DbContext
    {
        public SistemaContext() : base("Server=DESKTOP-84MRSJ9\\SQLEXPRESS; Database=BD_Odonto; Integrated Security= True;")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new DentistaMap());
            modelBuilder.Configurations.Add(new PacienteMap());
            modelBuilder.Configurations.Add(new ConsultaMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
