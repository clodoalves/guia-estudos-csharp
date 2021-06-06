using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocacaoMemoriaDotNet
{
    /// <summary>
    /// <para> Este exemplo demostra: </para>
    /// <para> - Como a linguagem C# e a plataforma .NET gerenciam objetos e dados dependendo do seu tipo. </para> 
    /// <para> - Os tipos de objetos presentes na plataforma, como criar novos tipos e gerenciar seu tempo de vida (life cycle) em memória.</para>
    /// <para> - Como valores são passados diretamente sem a necessidade de referências e ponteiros, ou instâncias.</para>
    /// </summary>
    class AlocaoMemoriaDotNet
    {
        static void Main(string[] args)
        {
            int x = 10;

            DobrarValueType(x);
            Console.WriteLine(x); //Copia criada para outra posicao de memoria. O valor original sera alterado.  

            DobrarValueType(ref x); //O parametro eh tratado como valor de referencia. O valor original sera alterado. 
            Console.WriteLine(x);

            PosicaoClass pos = new PosicaoClass();
            pos.X = 30;
            pos.Y = 40;

            DobrarReferenceType(pos); //Os valores originais serao alterados.
            Console.WriteLine(pos.X) ;
            Console.WriteLine(pos.Y);

            Console.ReadLine();
        }

        private static void ReferenceType()
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.X = 10;
            pos1.Y = 20;

            PosicaoClass pos2 = new PosicaoClass();
            pos2.X = 30;
            pos2.Y = 40;

            pos2 = pos1; ; //pos2 aponta para a mesma posicao de memoria de pos1. Nao eh feita uma copia
            pos2.X = 50;

            Console.WriteLine(pos1.X);
            Console.WriteLine(pos1.Y);
            Console.WriteLine(pos2.X);
            Console.WriteLine(pos2.Y);

            Console.ReadLine();
        }

        private static void ValueType()
        {
            int x = 10;
            int y = 20;
            y = x; // deep copy

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadLine();
        }

        private static void DobrarValueType(int valor) 
        {
            valor = valor * 2;           
        }

        private static void DobrarValueType(ref int valor)
        {
            ;
            valor = valor * 2;
        }

        private static void DobrarReferenceType(PosicaoClass pos) 
        {
            pos.X = pos.X * 2;
            pos.Y = pos.Y * 2;
        }
    }

    class PosicaoClass //reference type
    {
        public int X;
        public int Y;
    }
}
