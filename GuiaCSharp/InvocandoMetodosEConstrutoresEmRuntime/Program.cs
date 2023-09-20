using System;
using System.Reflection;

namespace InvocandoMetodosEConstrutoresEmRuntime
{
    public class Cliente
    {
        private string _nome;
        
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public Cliente(string nome)
        {
            _nome = nome;
        }
        public void ImprimirSaudacao(string saudacao)
        {
            Console.WriteLine($"{saudacao}, {this.Nome}");
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Type tipo = Type.GetType("InvocandoMetodosEConstrutoresEmRuntime.Cliente");

            ConstructorInfo infoConstrutor = tipo.GetConstructor(new Type[] { typeof(string) });

            var objeto = infoConstrutor.Invoke(new object[] { "Joao" });

            MethodInfo methodInfo = tipo.GetMethod("ImprimirSaudacao");

            methodInfo.Invoke(objeto, new object[] { "Bom dia" });

            Console.ReadLine();
        }
    }
}