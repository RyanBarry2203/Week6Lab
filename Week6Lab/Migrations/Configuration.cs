namespace Week6Lab.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Week6Lab.TeamData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Week6Lab.TeamData";
        }

        protected override void Seed(Week6Lab.TeamData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
