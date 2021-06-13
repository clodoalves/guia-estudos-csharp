using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeInferenciaEDynamic
{
 
    /// <summary>
    /// Este exemplo demonstra:
    /// <para>Como trabalhar com inferencia de tipo (inference type) e com a tipagem dinamica (dynamic)</para>
    /// <para>Com a inferencia de tipo, o compilador detecta o tipo pelo seu uso ou atribuicao, nao perdendo desempenho
    /// em tempo de execucao (runtime). Pode ser utilizada para tipos primitivos, classes especializadas, interfaces, funcoes, etc</para>
    /// <para>Por outro lado, os tipos dinamicos sao vinculados em tempo de execucao, seus atributos e metodos sao ignorados
    /// no processo de compilacao</para>
    /// </summary>


    class Program
    {
        static void Main(string[] args)
        {
            //var con = new Connection() { ConnectionString = "Database" };
            var con1 = Factory.GetConnection();
            con1.Conectar();
            con1.Fechar();

            dynamic con2 = Factory.GetConnection();
            con2.Conectar();
            con2.Fechar();

            Console.ReadLine();
        }
    }

    public class Connection
    {
        public string ConnectionString;
        public void Conectar()
        {
            Console.WriteLine("Conectando...");
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando...");
        }
    }

    public static class Factory
    {
        public static Connection GetConnection()
        {
            return new Connection();
        }
    }
}
