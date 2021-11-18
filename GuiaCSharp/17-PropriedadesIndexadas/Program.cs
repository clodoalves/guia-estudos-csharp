using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesIndexadas
{
    /// <summary>
    /// <para> Este exemplo demostra: </para>
    /// <para>Como trabalhar com propriedades indexadas, que permitem que um valor seja passado
    /// para um objeto usando colchetes [] logo após o nome da variavel</para>
    /// </summary>
    class Program
    {
        public class Produto 
        {
            private List<string> _itens;

            public Produto()
            {
                this._itens = new List<string>();
            }

            public string Get(int index) 
            {
                return this._itens[index];
            }

            public void Add(string item) 
            {
                this._itens.Add(item);
            }

            //propriedade indexada
            public string this [int index] 
            {
                get 
                {
                    return this.Get(index);
                }
            }

            public int this[string item] 
            {
                get 
                {
                    return this._itens.IndexOf(item);
                }
            }
        }

        static void Main(string[] args)
        {
            Produto produto = new Produto();

            produto.Add("Celular");
            produto.Add("Laptop");
            produto.Add("Desktop");

            //Abordagem sem uso de propriedades indexadas
            //Console.WriteLine(produto.Get(0));
            //Console.WriteLine(produto.Get(1));
            //Console.WriteLine(produto.Get(2));

            Console.WriteLine(produto[0]);
            Console.WriteLine(produto[1]);
            Console.WriteLine(produto[2]);
            //overload de propriedade indexada
            Console.WriteLine($"A posicao do item Laptop eh: {produto["Laptop"]}");

            Console.ReadLine();
        }
    }
}
