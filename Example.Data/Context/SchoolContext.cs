using Example.Data.Entities;

namespace Example.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SchoolContext : DbContext
    {
        // Your context has been configured to use a 'SchoolContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Example.Data.SchoolContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SchoolContext' 
        // connection string in the application configuration file.
        public SchoolContext()
            : base("name=SchoolContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }


}