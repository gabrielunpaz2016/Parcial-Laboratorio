namespace WebAppParcial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitParcial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Piezas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proveedores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suministras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Precio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suministras");
            DropTable("dbo.Proveedores");
            DropTable("dbo.Piezas");
        }
    }
}
