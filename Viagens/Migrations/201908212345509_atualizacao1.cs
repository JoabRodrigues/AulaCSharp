namespace Viagens.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualizacao1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Passagems", newName: "Passagens");
            RenameTable(name: "dbo.FormaPagamentoes", newName: "FormasPagamentos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.FormasPagamentos", newName: "FormaPagamentoes");
            RenameTable(name: "dbo.Passagens", newName: "Passagems");
        }
    }
}
