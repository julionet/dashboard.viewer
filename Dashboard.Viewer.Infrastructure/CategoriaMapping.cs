using Dashboard.Viewer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Viewer.Infrastructure
{
    public class CategoriaMapping : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMapping()
        {
            ToTable("Categoria");
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Descricao).HasMaxLength(80).IsRequired();
            Property(p => p.Ativo).IsRequired();
        }
    }
}
