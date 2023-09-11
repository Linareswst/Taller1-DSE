namespace LL191567Taller1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empleadoes", "Codigo", c => c.String(nullable: false));
            AlterColumn("dbo.Empleadoes", "Nombres", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Empleadoes", "Apellidos", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Empleadoes", "Direccion", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Empleadoes", "Telefono", c => c.String(nullable: false));
            AlterColumn("dbo.Empleadoes", "Cargo", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Empleadoes", "AñosLaborados", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empleadoes", "AñosLaborados", c => c.Int());
            AlterColumn("dbo.Empleadoes", "Cargo", c => c.String());
            AlterColumn("dbo.Empleadoes", "Telefono", c => c.String());
            AlterColumn("dbo.Empleadoes", "Direccion", c => c.String());
            AlterColumn("dbo.Empleadoes", "Apellidos", c => c.String());
            AlterColumn("dbo.Empleadoes", "Nombres", c => c.String());
            AlterColumn("dbo.Empleadoes", "Codigo", c => c.String());
        }
    }
}
