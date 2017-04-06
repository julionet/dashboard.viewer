using Dashboard.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Infrastructure
{
    public class DashboardViewerInitializer : CreateDatabaseIfNotExists<DashboardViewerContext>
    {
        protected override void Seed(DashboardViewerContext context)
        {
            context.Usuarios.Add(new Usuario { Login = "admin", Senha = "856B1702E2F5628D58A5034273F2717388E33ECD", Master = true, Bloqueado = false });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
