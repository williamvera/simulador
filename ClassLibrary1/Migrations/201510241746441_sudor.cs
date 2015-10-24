namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sudor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.clientes",
                c => new
                    {
                        idcliente = c.Int(nullable: false, identity: true),
                        nombre_rsocial = c.Int(nullable: false),
                        dni_ruc = c.Int(nullable: false),
                        telefono = c.Int(nullable: false),
                        email = c.Int(nullable: false),
                        password = c.Int(nullable: false),
                        idtasas_cliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idcliente)
                .ForeignKey("dbo.tasas_cliente", t => t.idtasas_cliente, cascadeDelete: true)
                .Index(t => t.idtasas_cliente);
            
            CreateTable(
                "dbo.tasas_cliente",
                c => new
                    {
                        idtasas_cliente = c.Int(nullable: false, identity: true),
                        monto = c.Int(nullable: false),
                        nombre_entidad = c.Int(nullable: false),
                        direccion = c.Int(nullable: false),
                        tipo_entidad = c.Int(nullable: false),
                        nombre_rsocial = c.Int(nullable: false),
                        tipo_tasas = c.Int(nullable: false),
                        descripcion = c.Int(nullable: false),
                        fecha = c.Int(nullable: false),
                        identidad = c.Int(nullable: false),
                        idcliente = c.Int(nullable: false),
                        idusuario = c.Int(),
                        nombre = c.Int(),
                        telefono = c.Int(),
                        dni = c.Int(),
                        email = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.idtasas_cliente);
            
            CreateTable(
                "dbo.entidad_financiera",
                c => new
                    {
                        identidad_financiera = c.Int(nullable: false, identity: true),
                        descripcion = c.Int(nullable: false),
                        direccion = c.Int(nullable: false),
                        nombre_entidad = c.Int(nullable: false),
                        tipo_entidad = c.Int(nullable: false),
                        nombre_cliente = c.Int(nullable: false),
                        idtas_cliente = c.Int(nullable: false),
                        tasas_cliente_idtasas_cliente = c.Int(),
                    })
                .PrimaryKey(t => t.identidad_financiera)
                .ForeignKey("dbo.tasas_cliente", t => t.tasas_cliente_idtasas_cliente)
                .Index(t => t.tasas_cliente_idtasas_cliente);
            
            CreateTable(
                "dbo.logins",
                c => new
                    {
                        idlogin = c.Int(nullable: false, identity: true),
                        password = c.Int(nullable: false),
                        idcliente = c.Int(nullable: false),
                        usuario_idtasas_cliente = c.Int(),
                    })
                .PrimaryKey(t => t.idlogin)
                .ForeignKey("dbo.clientes", t => t.idcliente, cascadeDelete: true)
                .ForeignKey("dbo.tasas_cliente", t => t.usuario_idtasas_cliente)
                .Index(t => t.idcliente)
                .Index(t => t.usuario_idtasas_cliente);
            
            CreateTable(
                "dbo.tasas",
                c => new
                    {
                        idtasas = c.Int(nullable: false, identity: true),
                        Fecha = c.Int(nullable: false),
                        Monto = c.Int(nullable: false),
                        d_ahorro = c.Int(nullable: false),
                        d_plazos = c.Int(nullable: false),
                        d_cts = c.Int(nullable: false),
                        d_plazos_pn = c.Int(nullable: false),
                        d_plazos_pj = c.Int(nullable: false),
                        ientidad_financiera = c.Int(nullable: false),
                        entidad_financiera_identidad_financiera = c.Int(),
                    })
                .PrimaryKey(t => t.idtasas)
                .ForeignKey("dbo.entidad_financiera", t => t.entidad_financiera_identidad_financiera)
                .Index(t => t.entidad_financiera_identidad_financiera);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tasas", "entidad_financiera_identidad_financiera", "dbo.entidad_financiera");
            DropForeignKey("dbo.logins", "usuario_idtasas_cliente", "dbo.tasas_cliente");
            DropForeignKey("dbo.logins", "idcliente", "dbo.clientes");
            DropForeignKey("dbo.entidad_financiera", "tasas_cliente_idtasas_cliente", "dbo.tasas_cliente");
            DropForeignKey("dbo.clientes", "idtasas_cliente", "dbo.tasas_cliente");
            DropIndex("dbo.tasas", new[] { "entidad_financiera_identidad_financiera" });
            DropIndex("dbo.logins", new[] { "usuario_idtasas_cliente" });
            DropIndex("dbo.logins", new[] { "idcliente" });
            DropIndex("dbo.entidad_financiera", new[] { "tasas_cliente_idtasas_cliente" });
            DropIndex("dbo.clientes", new[] { "idtasas_cliente" });
            DropTable("dbo.tasas");
            DropTable("dbo.logins");
            DropTable("dbo.entidad_financiera");
            DropTable("dbo.tasas_cliente");
            DropTable("dbo.clientes");
        }
    }
}
