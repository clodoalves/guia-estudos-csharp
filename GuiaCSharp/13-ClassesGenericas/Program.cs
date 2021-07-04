using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesGenericas
{
    /// <summary>
    /// Este exemplo demonstra:
    /// <para>A cricao de classes genericas personalizadas, permitindo assim
    /// a construcao de estruturas mais flexiveis e reutilizaveis.</para>
    /// <para>A criacao de classes genericas reduz a necessidade do uso 
    /// de tipos mais primitivos para efetuas operacoes sobre varios tipos.
    /// Tambem possibilita maior performance, pois o tipo eh resolvido de 
    /// forma estatica, nao necessitando type casts dinamicos</para>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Pilha<string> p1 = new Pilha<string>();
            p1.Push("Teste"); ;
            p1.Push("Teste2");
            p1.Push("Teste3");

            Pilha<int> p2 = new Pilha<int>();
            p2.Push(1);
            p2.Push(2);
            p2.Push(3);
            
            Pilha<Cliente> p3 = new Pilha<Cliente>();
            p3.Push(new Cliente() {Codigo = 1, Nome= "Jose" });
            p3.Push(new Cliente() {Codigo = 2, Nome = "Joao" });

            //var retorno = (Cliente) p3.Pop(); cast nao eh mais necessario
            var retorno = p3.Pop();

            Console.WriteLine($"Ultimo item removido da pilha => {retorno.Nome}");
            Console.ReadLine();
        }
    }

    public class Pilha<T>
    {
        private int Indice = 0;
        private T[] Itens = new T[100];

        public void Push(T novoItem)
        {
            Itens[Indice] = novoItem;
            Indice++;
        }

        public T Pop()
        {
            Indice--;
            return Itens[Indice];
        }
    }

    public class Cliente
    {
        public int Codigo;
        public string Nome;

    }
}
