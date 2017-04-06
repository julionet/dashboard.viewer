using Dashboard.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Infrastructure.Mapping
{
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            ToTable("Usuario");
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Login).HasMaxLength(50).IsRequired();
            Property(p => p.Senha).HasMaxLength(50).IsRequired();
            Property(p => p.Master).IsRequired();
            Property(p => p.Bloqueado).IsRequired();
            HasMany(p => p.Dashboard).WithMany(p => p.Usuario);
            Ignore(p => p.ListaDashboard);
        }
    }
}
