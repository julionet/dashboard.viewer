using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Viewer.Infrastructure
{
    public class DashboardViewerInitializer : CreateDatabaseIfNotExists<DashboardViewerContext>
    {
        protected override void Seed(DashboardViewerContext context)
        {
            base.Seed(context);
        }
    }
}
