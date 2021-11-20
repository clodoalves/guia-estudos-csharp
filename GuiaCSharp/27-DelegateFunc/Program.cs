using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFunc
{
    class Program
    {
        class Produto  
        {
            public int Id;
            public string Nome;
            public double Preco;

            public override string ToString()
            {
                return $"{Id}-{Nome}-{Preco}";
            }
        }

        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>() 
            {
                new Produto(){ Id = 1, Nome = "Produto1", Preco = 2000.50 },
                new Produto(){ Id = 2, Nome = "Produto2", Preco = 2500.00 },
                new Produto(){ Id = 3, Nome = "Produto3", Preco = 1010.30 },
                new Produto(){ Id = 4, Nome = "Produto4", Preco = 1832.75 },
                new Produto(){ Id = 5, Nome = "Produto5", Preco = 2300.99 }
            };

            Func<Produto, bool> BuscarPorPrecoFunc = new Func<Produto, bool>(produto => produto.Preco >= 2000.00);

            foreach(var produto in produtos.Where(BuscarPorPrecoFunc))
            {
                Console.WriteLine(produto);
            }

            Console.ReadLine();
        }
    }
}
