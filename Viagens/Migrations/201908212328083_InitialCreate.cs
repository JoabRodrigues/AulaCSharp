namespace Viagens.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aviaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Voos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InicioPrevisto = c.DateTime(nullable: false),
                        InicioReal = c.DateTime(nullable: false),
                        FimInicio = c.DateTime(nullable: false),
                        FimReal = c.DateTime(nullable: false),
                        Aviao_Id = c.Int(),
                        Destino_Id = c.Int(),
                        Origem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aviaos", t => t.Aviao_Id)
                .ForeignKey("dbo.Cidades", t => t.Destino_Id)
                .ForeignKey("dbo.Cidades", t => t.Origem_Id)
                .Index(t => t.Aviao_Id)
                .Index(t => t.Destino_Id)
                .Index(t => t.Origem_Id);
            
            CreateTable(
                "dbo.Poltronas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Coluna = c.Int(nullable: false),
                        Fileira = c.Int(nullable: false),
                        Assento = c.String(),
                        Voo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Voos", t => t.Voo_Id)
                .Index(t => t.Voo_Id);
            
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Passagems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Double(nullable: false),
                        Assento_Id = c.Int(),
                        Destino_Id = c.Int(),
                        FormaPagamento_Id = c.Int(),
                        Origem_Id = c.Int(),
                        Passageiro_Id = c.Int(),
                        Voo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Poltronas", t => t.Assento_Id)
                .ForeignKey("dbo.Cidades", t => t.Destino_Id)
                .ForeignKey("dbo.FormaPagamentoes", t => t.FormaPagamento_Id)
                .ForeignKey("dbo.Cidades", t => t.Origem_Id)
                .ForeignKey("dbo.Pessoas", t => t.Passageiro_Id)
                .ForeignKey("dbo.Voos", t => t.Voo_Id)
                .Index(t => t.Assento_Id)
                .Index(t => t.Destino_Id)
                .Index(t => t.FormaPagamento_Id)
                .Index(t => t.Origem_Id)
                .Index(t => t.Passageiro_Id)
                .Index(t => t.Voo_Id);
            
            CreateTable(
                "dbo.FormaPagamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pagamento = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sobrenome = c.String(),
                        Documento = c.String(),
                        Nascimento = c.DateTime(nullable: false),
                        Telefone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passagems", "Voo_Id", "dbo.Voos");
            DropForeignKey("dbo.Passagems", "Passageiro_Id", "dbo.Pessoas");
            DropForeignKey("dbo.Passagems", "Origem_Id", "dbo.Cidades");
            DropForeignKey("dbo.Passagems", "FormaPagamento_Id", "dbo.FormaPagamentoes");
            DropForeignKey("dbo.Passagems", "Destino_Id", "dbo.Cidades");
            DropForeignKey("dbo.Passagems", "Assento_Id", "dbo.Poltronas");
            DropForeignKey("dbo.Voos", "Origem_Id", "dbo.Cidades");
            DropForeignKey("dbo.Voos", "Destino_Id", "dbo.Cidades");
            DropForeignKey("dbo.Voos", "Aviao_Id", "dbo.Aviaos");
            DropForeignKey("dbo.Poltronas", "Voo_Id", "dbo.Voos");
            DropIndex("dbo.Passagems", new[] { "Voo_Id" });
            DropIndex("dbo.Passagems", new[] { "Passageiro_Id" });
            DropIndex("dbo.Passagems", new[] { "Origem_Id" });
            DropIndex("dbo.Passagems", new[] { "FormaPagamento_Id" });
            DropIndex("dbo.Passagems", new[] { "Destino_Id" });
            DropIndex("dbo.Passagems", new[] { "Assento_Id" });
            DropIndex("dbo.Poltronas", new[] { "Voo_Id" });
            DropIndex("dbo.Voos", new[] { "Origem_Id" });
            DropIndex("dbo.Voos", new[] { "Destino_Id" });
            DropIndex("dbo.Voos", new[] { "Aviao_Id" });
            DropTable("dbo.Pessoas");
            DropTable("dbo.FormaPagamentoes");
            DropTable("dbo.Passagems");
            DropTable("dbo.Cidades");
            DropTable("dbo.Poltronas");
            DropTable("dbo.Voos");
            DropTable("dbo.Aviaos");
        }
    }
}
