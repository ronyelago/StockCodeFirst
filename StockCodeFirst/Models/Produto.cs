namespace StockCodeFirst.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public virtual CategoriaProduto CategoriaProduto { get; set; }
    }
}
