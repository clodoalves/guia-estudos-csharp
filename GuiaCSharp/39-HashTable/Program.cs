using System;
using System.Collections;

namespace _39_HashTable
{
    internal class Cliente
    {
        public string Nome;
        public string Endereco;
        public string Telefone;

        public override string ToString()
        {
            return $"Nome: {Nome} | Endereco: {Endereco}, Telefone: {Telefone}";
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente() { Nome = "Jose", Endereco = "Rua A", Telefone = "88888888" };
            Cliente cliente2 = new Cliente() { Nome = "Joao", Endereco = "Rua B", Telefone = "77777777" };
            Cliente cliente3 = new Cliente() { Nome = "Maria", Endereco = "Rua C", Telefone = "99999999" };

            Hashtable clientes = new Hashtable();
            
            clientes.Add("1", cliente1);
            clientes.Add("2", cliente2);
            clientes.Add("3", cliente3);

            if (clientes.ContainsKey("3"))
            {
                Console.WriteLine(clientes["3"]);
            }

            foreach (var cliente  in clientes.Values)
            {
                //Type casting eh necessario para obter item
                Console.WriteLine((cliente as Cliente)?.Nome);
            }
            
            Console.ReadLine();
        }
    }
}