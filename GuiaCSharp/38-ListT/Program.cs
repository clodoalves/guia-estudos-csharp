using System;
using System.Collections.Generic;

namespace ListT
{
    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public string CPF;

        public override string ToString()
        {
            return $"Codigo: {Codigo} | Nome: {Nome} | CPF: {CPF}";
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>()
            {
                new Cliente(){Codigo = 1, Nome = "Jose", CPF = "123"},
                new Cliente(){Codigo = 2, Nome = "Maria", CPF = "456"},
                new Cliente(){Codigo = 3, Nome = "Joao", CPF = "789"}
            };

            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            Console.ReadLine();
        }
    }
}