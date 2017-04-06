using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Infrastructure
{
    public class DashboardTransaction
    {
        private DashboardTransaction()
        {

        }

        public static DbContextTransaction CreateDbContextTransaction(DashboardContext db)
        {
            if (db.Database.Connection is SqlConnection)
                return db.Database.BeginTransaction(IsolationLevel.ReadUncommitted);
            else
                return db.Database.BeginTransaction(IsolationLevel.ReadCommitted);
        }
    }
}
