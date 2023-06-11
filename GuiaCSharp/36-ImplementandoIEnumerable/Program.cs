using System;

namespace ImplementandoIEnumerable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ListaClientes clientes = new ListaClientes();
            
            clientes.Add("Joao");
            clientes.Add("Jose");
            clientes.Add("Maria");
            clientes.Add("Severina");

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            Console.ReadLine();
        }
    }
}