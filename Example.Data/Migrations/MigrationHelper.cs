using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Data.Migrations
{
    public class MigrationHelper
    {
        public static void EnableAutomaticMigrations()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, Configuration>()); 
        }
    }
}
