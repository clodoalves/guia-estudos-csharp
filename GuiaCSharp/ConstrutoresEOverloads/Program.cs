using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresEOverloads
{
    /// <summary>
    /// 
    /// </summary>
    public class Contato 
    {
        public string Tipo;
        public string Descricao;
    }

    public class Cliente 
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Contato Contato { get; set; }

        public Cliente()
        {
            Codigo = 0;
            Nome = "sem nome";
            Contato = new Contato();
        }


        //overloads
        public Cliente(int codigo)
        {
            Codigo = codigo;
            Nome = "sem nome";
            Contato = new Contato();
        }

        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Contato = new Contato();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo: {Codigo}");
            sb.AppendLine($"Nome: {Nome}");

            return sb.ToString();
        }
    }

    public class ClienteVip:Cliente
    {
        public int QuantAno;

        public ClienteVip(int codigo, string nome) : base(codigo, nome) 
        {
            QuantAno = 12;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    /// <summary>
    /// <para> Este exemplo demostra: </para>
    /// <para> Classes com sobrecarga de construtor (overload)</para>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Codigo = 123;
            cliente.Nome = "Jose";
            cliente.Contato.Tipo = "Telefone";
            cliente.Contato.Descricao = "99999999";

            Cliente cliente2 = new Cliente();

            Cliente cliente3 = new Cliente(444);

            Cliente cliente4 = new ClienteVip(111, "Jose");

            Console.WriteLine(cliente);
            Console.WriteLine(cliente2);
            Console.WriteLine(cliente3);
            Console.WriteLine(cliente4);

            Console.ReadLine();
        }
    }
}
