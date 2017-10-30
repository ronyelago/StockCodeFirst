using System.Data.Entity.ModelConfiguration;

namespace StockCodeFirst.Models.Mappings
{
    class CategoriaProdutoMap : EntityTypeConfiguration<CategoriaProduto>
    {
        public CategoriaProdutoMap()
        {
            this.HasKey(k => k.Id);
            this.Property(p => p.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasMaxLength(64);
            this.ToTable("CategoriaProduto");
            this.Property(p => p.Estado)
                .HasColumnName("Estado");
        }
    }
}
