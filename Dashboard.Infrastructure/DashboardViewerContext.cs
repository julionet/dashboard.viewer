using Dashboard.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Infrastructure
{
    public class DashboardViewerContext : DbContext
    {
        public DashboardViewerContext() : base("DashboardViewerConnectionString")
        {
            Database.SetInitializer<DashboardViewerContext>(new DashboardViewerInitializer());

            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !String.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Entity.Dashboard> Dashboards { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
