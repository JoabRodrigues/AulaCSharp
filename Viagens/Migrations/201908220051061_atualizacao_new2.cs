namespace Viagens.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualizacao_new2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Voos", "Destino_Id", "dbo.Cidades");
            DropForeignKey("dbo.Voos", "Origem_Id", "dbo.Cidades");
            DropIndex("dbo.Voos", new[] { "Destino_Id" });
            DropIndex("dbo.Voos", new[] { "Origem_Id" });
            AddColumn("dbo.Voos", "FimPrevisto", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Voos", "Destino_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Voos", "Origem_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Pessoas", "Nome", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Voos", "Destino_Id");
            CreateIndex("dbo.Voos", "Origem_Id");
            AddForeignKey("dbo.Voos", "Destino_Id", "dbo.Cidades", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Voos", "Origem_Id", "dbo.Cidades", "Id", cascadeDelete: true);
            DropColumn("dbo.Voos", "FimInicio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Voos", "FimInicio", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Voos", "Origem_Id", "dbo.Cidades");
            DropForeignKey("dbo.Voos", "Destino_Id", "dbo.Cidades");
            DropIndex("dbo.Voos", new[] { "Origem_Id" });
            DropIndex("dbo.Voos", new[] { "Destino_Id" });
            AlterColumn("dbo.Pessoas", "Nome", c => c.String());
            AlterColumn("dbo.Voos", "Origem_Id", c => c.Int());
            AlterColumn("dbo.Voos", "Destino_Id", c => c.Int());
            DropColumn("dbo.Voos", "FimPrevisto");
            CreateIndex("dbo.Voos", "Origem_Id");
            CreateIndex("dbo.Voos", "Destino_Id");
            AddForeignKey("dbo.Voos", "Origem_Id", "dbo.Cidades", "Id");
            AddForeignKey("dbo.Voos", "Destino_Id", "dbo.Cidades", "Id");
        }
    }
}
