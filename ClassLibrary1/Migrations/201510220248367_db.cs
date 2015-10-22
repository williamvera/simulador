namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.logins",
                c => new
                    {
                        idlogin = c.Int(nullable: false, identity: true),
                        clave = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idlogin);
            
            CreateTable(
                "dbo.usuarios",
                c => new
                    {
                        idusuario = c.Int(nullable: false, identity: true),
                        nombre = c.Int(nullable: false),
                        apellido = c.Int(nullable: false),
                        telefono = c.Int(nullable: false),
                        login_idlogin = c.Int(),
                        login1_idlogin = c.Int(),
                    })
                .PrimaryKey(t => t.idusuario)
                .ForeignKey("dbo.logins", t => t.login_idlogin)
                .ForeignKey("dbo.logins", t => t.login1_idlogin)
                .Index(t => t.login_idlogin)
                .Index(t => t.login1_idlogin);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.usuarios", "login1_idlogin", "dbo.logins");
            DropForeignKey("dbo.usuarios", "login_idlogin", "dbo.logins");
            DropIndex("dbo.usuarios", new[] { "login1_idlogin" });
            DropIndex("dbo.usuarios", new[] { "login_idlogin" });
            DropTable("dbo.usuarios");
            DropTable("dbo.logins");
        }
    }
}
