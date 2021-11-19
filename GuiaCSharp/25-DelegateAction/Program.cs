using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DelegateAction
{
    class Cliente 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente() { Id = 1, Nome = "Joao" };
            Cliente cliente2 = new Cliente() { Id = 2, Nome = "Maria" };
            Cliente cliente3 = new Cliente() { Id = 3, Nome = "Jose" };
            Cliente cliente4 = new Cliente() { Id = 4, Nome = "Severino" };

            List<Cliente> clientes = new List<Cliente>
            {
                cliente1,
                cliente2,
                cliente3,
                cliente4
            };

            //Action<Cliente> exibirClientesAction = new Action<Cliente>(cliente => Console.WriteLine(cliente.Nome));
            Action<Cliente> exibirClientesAction = new Action<Cliente>(ExibirClientes);
            clientes.ForEach(exibirClientesAction);

            Console.ReadLine();
        }

        public static void ExibirClientes(Cliente cliente) 
        {
            Console.WriteLine(cliente.Nome);
        }
    }
}
