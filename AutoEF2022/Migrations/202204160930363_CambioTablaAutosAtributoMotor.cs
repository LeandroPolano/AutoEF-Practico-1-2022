using System.Data.Entity.Infrastructure.Design;

namespace AutoEF2022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioTablaAutosAtributoMotor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Autos", "MotorCil", c => c.String(nullable: false, maxLength: 50));
            Sql("UPDATE Autos SET MotorCil=Motor");
            DropColumn("dbo.Autos", "Motor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Autos", "Motor", c => c.String(nullable: false, maxLength: 50));
            Sql("UPDATE Autos SET Motor=MotorCil");
            DropColumn("dbo.Autos", "MotorCil");
        }
    }
}
