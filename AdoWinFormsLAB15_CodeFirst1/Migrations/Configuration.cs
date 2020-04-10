namespace AdoWinFormsLAB15_CodeFirst1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AdoWinFormsLAB15_CodeFirst1.dbContext.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AdoWinFormsLAB15_CodeFirst1.dbContext.LibraryContext";
        }

        protected override void Seed(AdoWinFormsLAB15_CodeFirst1.dbContext.LibraryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
