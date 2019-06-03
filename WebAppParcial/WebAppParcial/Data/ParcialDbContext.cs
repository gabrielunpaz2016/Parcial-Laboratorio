using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppParcial.Models;

namespace WebAppParcial.Data
{
    public class ParcialDbContext : DbContext
    {
        public ParcialDbContext() :base("ParcialDbContext")
        {

        }
        public DbSet<Proveedores> Proveedoress { get; set; }
        public DbSet<Suministra> Suministras { get; set; }
        public DbSet<Piezas> Piezass { get; set; }
    }
}