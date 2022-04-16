namespace AutoEF2022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatalogoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autos",
                c => new
                    {
                        AutoId = c.Int(nullable: false, identity: true),
                        Motor = c.String(nullable: false, maxLength: 50),
                        Modelo = c.String(nullable: false, maxLength: 50),
                        Marca = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.AutoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Autos");
        }
    }
}
