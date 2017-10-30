using StockCodeFirst.Models.Mappings;
using System.Data.Entity;

namespace StockCodeFirst.Models
{
    public partial class StockContext : DbContext
    {
        static StockContext()
        {
            Database.SetInitializer<StockContext>(null);
        }

        public StockContext() : base("Name=StockContext")
        {
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new CategoriaProdutoMap());

            // diz ao EF para entender que todos os campos string são varchar
            // ao invés de nvarchar (universal).
            modelBuilder.Properties<string>()
                .Configure(s => s.HasColumnType("varchar"));

            // padroniza o tamanho máximo dos tipos varchar (o padrão é max).
            modelBuilder.Properties<string>()
                .Configure(s => s.HasMaxLength(100));
        }

        /*
         * enable-migrations (parameter -force se já existir)
         * update-database -Script (gera o script do que será executado sem executar)
         * add-migration initial -ignoreChanges
         * update-database -verbose
         */
    }
}
