using System;
using System.Collections;

namespace SortedListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList lista = new SortedList();

            lista.Add(4, "Quarto");
            lista.Add(2, "Segundo");
            lista.Add(1, "Segundo");
            lista.Add(3, "Terceiro");

            foreach (object chave in lista.Keys)
            {
                Console.WriteLine("{0}-{1}", chave.ToString(), lista[chave].ToString());
            }

            Console.ReadLine();
        }
    }
}
