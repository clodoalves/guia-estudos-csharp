using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePredicate
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa { Nome = "Jose", Idade = 43 },
                new Pessoa { Nome = "Maria", Idade = 36 },
                new Pessoa { Nome = "Joao", Idade = 25 },
                new Pessoa { Nome = "Francisco", Idade = 34 },
                new Pessoa { Nome = "Paula", Idade = 35 }
            };

            //Predicate<Pessoa> buscarPorIdadePredicate = new Predicate<Pessoa>(BuscarPorIdade);
            Predicate<Pessoa> buscarPorIdadePredicate = new Predicate<Pessoa>(p => p.Idade > 30);
            var pessoasAcimaTrintaAnos = pessoas.FindAll(buscarPorIdadePredicate);

            foreach (var p in pessoasAcimaTrintaAnos)
            {
                Console.WriteLine(p.Nome);
            }

            Console.ReadLine();
        }

        public static bool BuscarPorIdade(Pessoa pessoa)
        {
            return pessoa.Idade >= 30;
        }
    }
}
