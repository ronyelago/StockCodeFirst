using System.Data.Entity.ModelConfiguration;

namespace StockCodeFirst.Models.Mappings
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            this.HasKey(k => k.Id);
            this.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(64);
            this.ToTable("produto");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.IdCategoria).HasColumnName("IdCategoria");
            this.Property(p => p.Descricao).
                HasColumnName("Descricao")
                .HasMaxLength(200);
            this.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50);
            this.HasRequired(p => p.CategoriaProduto)
                .WithMany(c => c.Produtos)
                .HasForeignKey(f => f.IdCategoria);
        }
    }
}
