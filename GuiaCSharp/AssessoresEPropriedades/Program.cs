using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasCSharp
{

    /// <summary>
    /// <para> Este exemplo demostra: </para>
    /// <para> - Como definir algumas estruturas de dados na linguagem C#, usando 
    /// a abordagem de alocacao dinamica (referencia) e estatica (valor) </para> 
    /// <para> - A diferenca entre os tipos de dados criados, como com insta.</para>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MostrarReferenceType();
            MostrarValueType();
            FormasPagto formaPagto = FormasPagto.Boleto;
            Role role = Role.Developer;
            Color cor = Color.Blue;

            Console.WriteLine(formaPagto);
            Console.WriteLine(role);
            Console.WriteLine(cor);

            Console.ReadLine();
        }

        private static void MostrarValueType()
        {
            PosicaoStruct pos3 = new PosicaoStruct();
            pos3.X = 40;
            pos3.Y = 50;
            PosicaoStruct pos4;

            pos4 = pos3; //Value type. Deep copy. 
            pos4.X = 100;

            Console.WriteLine(pos3);
            Console.WriteLine(pos4);
        }

        private static void MostrarReferenceType()
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.X = 10;
            pos1.Y = 20;

            PosicaoClass pos2;

            pos2 = pos1; //Reference type. pos2 aponta para o mesmo endereco de memoria de pos1.
            pos2.X = 30;

            if (pos2.Equals(pos1))
            {
                Console.WriteLine("pos2 e pos1 sao o mesmo objeto");
            }

            Console.WriteLine(pos1);
            Console.WriteLine(pos2);
        }
    }

    class PosicaoClass //Reference type
    {
        public int X;
        public int Y;
        public override string ToString() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"X: {X}");
            sb.AppendLine($"Y: {Y}");

            return sb.ToString();        
        }
    }

    struct PosicaoStruct //Value type
    {
        public int X;
        public int Y;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"X: {X}");
            sb.AppendLine($"Y: {Y}");

            return sb.ToString();
        }
    }

    public enum Role 
    {
        Arquiteto, Developer, Tester
    }

    public enum Color 
    {
        Red = 0,
        Green = 1,
        Blue = 2
    }

    public enum FormasPagto 
    {
        Boleto, Cartao, Cheque
    }
}
