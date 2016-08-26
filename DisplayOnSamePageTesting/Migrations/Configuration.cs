namespace DisplayOnSamePageTesting.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DisplayOnSamePageTesting.Models.DisplayContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DisplayOnSamePageTesting.Models.DisplayContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Items.AddOrUpdate(
              p => p.Name,
              new ItemWithProperties { Name = "Item 1", ConstantProperty = "Constant 1" },
              new ItemWithProperties { Name = "Item 2", ConstantProperty = "Constant 2" }
            );
            //
        }
    }
}
