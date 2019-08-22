namespace Viagens
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelViagens : DbContext
    {
        // Your context has been configured to use a 'ModelViagens' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Viagens.ModelViagens' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelViagens' 
        // connection string in the application configuration file.
        public ModelViagens()
            : base("name=ModelViagens")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public virtual DbSet<Aviao> Avioes { get; set; }
        public virtual DbSet<Cidade> Cidades { get; set; }
        public virtual DbSet<FormaPagamento> FormasPagamentos { get; set; }
        public virtual DbSet<Passagem> Passagens { get; set; }
        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<Poltrona> Poltronas { get; set; }
        public virtual DbSet<Voo> Voos { get; set; }

    }
}