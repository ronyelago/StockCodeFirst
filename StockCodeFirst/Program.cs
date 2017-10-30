using StockCodeFirst.Models;
using System;
using System.Linq;

namespace StockCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            StockContext contexto = new StockContext();
            Produto p1 = new Produto();
            var produtos = contexto.Produto.ToList();
            var categorias = contexto.CategoriaProduto.ToList();

            Console.WriteLine("*** Produtos ***\n\n");
            foreach (var item in produtos)
            {
                Console.WriteLine(item.Nome);
            }
            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("*** Novo Produto ***");
            Console.Write("Digite o nome do Produto: ");
            p1.Nome = Console.ReadLine();

            Console.WriteLine("Escolha uma Categoria\n\n");
            foreach (var c in categorias)
            {
                Console.WriteLine("{0} - {1}", c.Id, c.Nome);
            }

            Console.Write("Categoria: ");
            p1.IdCategoria = int.Parse(Console.ReadLine());
            Console.Write("\n\nDescrição: ");
            p1.Descricao = Console.ReadLine();

            try
            {
                contexto.Produto.Add(p1);
                contexto.SaveChanges();
                contexto.Entry(p1).Reload();
                produtos = contexto.Produto.ToList();
                Console.Clear();
                Console.WriteLine("*** Produtos ***\n\n");
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\nDeu merda. {0}\n", ex.Message);
                Console.ReadLine();
            }

        }
    }
}
