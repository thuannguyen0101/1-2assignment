namespace lab3.Migrations
{
    using lab3.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<lab3.Data.UserContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(lab3.Data.UserContext context)
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
            var appRoles = new List<AppRole>
            {
            new AppRole{Name="Admin", Decription="Admin"},
            new AppRole{Name="User", Decription="User"},
            new AppRole{Name="Employee", Decription="Employee"},
            };

            appRoles.ForEach(s => context.Roles.Add(s));
            context.SaveChanges();
        }
    }
}
