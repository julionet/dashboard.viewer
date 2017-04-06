using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Infrastructure.Mapping
{
    public class DashboardMapping : EntityTypeConfiguration<Entity.Dashboard>
    {
        public DashboardMapping()
        {
            ToTable("Dashboard");
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Descricao).HasMaxLength(80).IsRequired();
            Property(p => p.Xml).IsMaxLength();
            Property(p => p.Ativo).IsRequired();
            Property(p => p.CategoriaId).IsRequired();
            HasRequired(p => p.Categoria).WithMany(p => p.Dashboard).HasForeignKey(p => p.CategoriaId);
        }
    }
}
