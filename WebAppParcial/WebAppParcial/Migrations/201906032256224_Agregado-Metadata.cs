namespace WebAppParcial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregadoMetadata : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Piezas", "Nombre", c => c.String(maxLength: 100));
            AlterColumn("dbo.Proveedores", "Nombre", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Proveedores", "Nombre", c => c.String());
            AlterColumn("dbo.Piezas", "Nombre", c => c.String());
        }
    }
}
