namespace Fibonacci.Core.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Fibonacci.Core.DataBase.FibonacciDBContext>
    {
        //SELECT 'drop table ' + name FROM sysobjects WHERE XTYPE='U'
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Fibonacci.Core.DataBase.FibonacciDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
