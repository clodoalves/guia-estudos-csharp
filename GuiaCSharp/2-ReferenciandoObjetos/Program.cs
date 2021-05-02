using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenciandoObjetos
{
    /// <summary>
    /// <para> Este exemplo demostra: </para>
    /// <para> - Como a linguagem C# trabalha com a referencia de tipos. </para> 
    /// <para> - Como tipos podem ser gerenciados atraves da alocacao dinamica ou da alocacao estatica em memoria.</para>
    /// <para> - </para>
    /// </summary>
    class Program
    {
        public static  void MostrarValueTypes() 
        {
            int i = 10;
            string s = "Joao";
            bool b = false;

            Console.WriteLine(i);
            Console.WriteLine(s);
            Console.WriteLine(b);

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            MostrarReferenceType();
        }

        private static void MostrarReferenceType()
        {
            Cliente c1 = new Cliente();
            c1.Codigo = 1;
            c1.Nome = "Jose";
            c1.Telefone = "9999999999";

            Cliente c2;
            c2 = c1; //c2 aponta para a mesma posicao de memoria de c1
            c2.Nome = "Joao";

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            //Console.WriteLine(c.Codigo);
            //Console.WriteLine(c.Nome);
            //Console.WriteLine(c.Telefone);

            if (c1.Equals(c2)) 
            {
                Console.WriteLine("c1 e c2 sao o mesmo objeto");
            }

            Console.ReadLine();
        }
    }

    class Cliente //Reference type
    {
        public int Codigo;
        public string Nome;
        public string Telefone;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo: {Codigo}");
            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine($"Telefone: {Telefone}");

            return sb.ToString();
        }
    }
}
