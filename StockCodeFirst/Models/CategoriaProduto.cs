using System.Collections.Generic;

namespace StockCodeFirst.Models
{
    public class CategoriaProduto
    {
        public CategoriaProduto()
        {
            Produtos = new List<Produto>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Estado { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
