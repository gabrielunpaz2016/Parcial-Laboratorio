namespace WebAppParcial.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppParcial.Data.ParcialDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAppParcial.Data.ParcialDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Piezass.AddOrUpdate(
               r => r.Id,
               new Models.Piezas { Codigo = 100, Nombre = "ruleman" },
               new Models.Piezas { Codigo = 200, Nombre = "paragolpe" },
               new Models.Piezas { Codigo = 300, Nombre = "llanta" }

             );

            context.Proveedoress.AddOrUpdate(
              r => r.Id,
              new Models.Proveedores { Nombre = "Pepito Motors" },
              new Models.Proveedores { Nombre = "Juancito Motors" },
              new Models.Proveedores { Nombre = "Pedrito Motors" }

            );

            


        }
    }
}
