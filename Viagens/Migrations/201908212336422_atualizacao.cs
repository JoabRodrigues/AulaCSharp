namespace Viagens.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualizacao : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Aviaos", newName: "Avioes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Avioes", newName: "Aviaos");
        }
    }
}
