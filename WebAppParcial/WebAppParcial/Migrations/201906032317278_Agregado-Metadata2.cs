namespace WebAppParcial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregadoMetadata2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Piezas", "Codigo", c => c.Int(nullable: false));
            AddColumn("dbo.Suministras", "CodigoPieza", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Suministras", "CodigoPieza");
            DropColumn("dbo.Piezas", "Codigo");
        }
    }
}
