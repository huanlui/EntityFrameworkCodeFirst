namespace Example.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Example.Data.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //Automatic migration was not applied because it would result in data loss.
            //Set AutomaticMigrationDataLossAllowed to 'true' on your DbMigrationsConfiguration to allow application of automatic migrations even
            //if they might cause data loss
            //IMPORTANT: Only to develop. 
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Example.Data.SchoolContext";
        }

        protected override void Seed(Example.Data.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
