using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MetodosDeExtensao
{
    /// <summary>
    /// Este exemplo demonstra:
    /// <para>Como os metodos de extensao conseguem injetar um novo metodo em uma classe, sem uso de heranca ou acesso
    /// ao codigo fonte da classe que o recebera</para>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DataSet dataset = new DataSet();
            dataset.WriteJSON("sample.js");

            string urlSample = "teste.com";
            Console.WriteLine(urlSample.ToUrl());
            Console.ReadLine();
        }
    }

    public static class MyExtensions 
    { 
        public static void WriteJSON(this DataSet ds, string fileName) 
        { 
             //...
        }

        public static string ToUrl(this string str) 
        {
            return $"http://{str}";
        }
    }
}
