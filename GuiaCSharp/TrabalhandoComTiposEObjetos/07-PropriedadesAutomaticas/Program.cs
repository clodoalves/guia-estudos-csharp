using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesAutomaticas
{
    /// <summary>
    /// Este exemplo demonstra:
    /// <para>Uso de propriedades automaticas, que possibilita uma sintaxe mais resumida para a 
    /// declaracao de propriedades publicas em clases, que encapsulam atributos privados</para>
    /// <para>Internamente o codigo compilado ainda gerara o compo priados e os metodos acessores get e set,
    /// de forma semelhante ao que se obtem no uso de metodos get/set explicitos</para>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario(123, "Jose", 1000);
            Funcionario f2 = new Funcionario();

            Console.WriteLine(f);
            Console.WriteLine(f2);

            Console.ReadLine();
        }
    }

    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {
            Codigo = 0;
            Nome = "Sem nome";
            Salario = 0;
        }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo = {Codigo}");
            sb.AppendLine($"Nome = {Nome}");
            sb.AppendLine($"Salario = {Salario}");

            return sb.ToString();
        }
    }
}
