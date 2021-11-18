using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicializadoresDeObjetos
{
    class Program
    {
        /// <summary>
        /// Este exemplo demostra:
        /// <para>Como trabalhar com inicializadores de objeto, que permitem que parametros 
        /// para as propriedades de objetos sejam diretamente passados apos a construcao</para>
        /// <para>O uso de inicializadores de objetos evita o bad smell 'Chain Constructors', eliminando 
        /// a necessidade de inumeros overloads de contrutores em classes</para>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Ator ator1 = new Ator() 
            {
                Codigo = 10, 
                Nome = "Joao", 
                Filmes = new List<Filme>() 
                { 
                    new Filme(){Codigo = 1, Nome = "Filme1" },
                    new Filme(){Codigo = 2, Nome = "Filme2" },
                    new Filme(){Codigo = 3, Nome = "Filme3" },
                }
            };
        }
    }

    public class Ator 
    {
        public int Codigo;
        public string Nome;
        public IList<Filme> Filmes;


        // Bad Smell: Chain constructors
        public Ator(int codigo)
        {
            Codigo = codigo;
        }

        public Ator()
        {

        }

        public Ator(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public Ator(int codigo, string nome, List<Filme> filmes)
        {
            Codigo = codigo;
            Nome = nome;
            Filmes = filmes;
        }   
    }

    public class Filme 
    {
        public int Codigo;
        public string Nome;
    }
}
