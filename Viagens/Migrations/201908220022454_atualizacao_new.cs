namespace Viagens.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualizacao_new : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FormasPagamentos", "Valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.FormasPagamentos", "DataPagamento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FormasPagamentos", "DataPagamento");
            DropColumn("dbo.FormasPagamentos", "Valor");
        }
    }
}
