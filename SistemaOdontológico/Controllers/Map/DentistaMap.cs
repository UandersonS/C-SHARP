using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    class DentistaMap : EntityTypeConfiguration<Dentista>
    {
        public DentistaMap()
        {
            this.ToTable("Dentista");
            this.HasKey(d => d.Id);
            this.Property(d => d.Id).HasColumnName("ID_DENTISTA");
            this.Property(d => d.Name).HasColumnName("Nome_Dentista");
            this.Property(d => d.Email).HasColumnName("Email_Dentista");
            this.Property(d => d.Telefone).HasColumnName("Telefone_Dentista");
            this.Property(d => d.Celular).HasColumnName("Celular_Dentista");
            this.Property(d => d.CRO).HasColumnName("CRO");

        }
    }
}
