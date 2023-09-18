using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflexaoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
           var propriedades = ObterNomeEValorPropriedade();

           foreach (var propriedade in propriedades)
           {
               Console.WriteLine($"{propriedade.Key} - {propriedade.Value}");
           }
           
           Console.ReadLine();
        }

        private static Dictionary<string, object> ObterNomeEValorAtributo()
        {
            Dictionary<string, object> attributesInformation = new Dictionary<string, object>();
            Carro carro = new Carro();

            carro.Cor = "Amarelo";
            carro.Modelo = "Modelo A";
            carro.Marca = "Marca 1";
            
            carro.Acelerar(200);

            Type tipo = carro.GetType();

            FieldInfo[] fieldInfos = tipo.GetFields();

            foreach (var fieldInfo in fieldInfos)
            {
                string nome = fieldInfo.Name;
                var valor = tipo.GetField(fieldInfo.Name).GetValue(carro);
                attributesInformation[nome] = valor;
                //Console.WriteLine($"{fieldInfo.Name} - {valor}");
            }

            return attributesInformation;
        }

        private static Dictionary<string, object> ObterNomeEValorPropriedade()
        {
            Dictionary<string, object> propertyInformation = new Dictionary<string, object>();
            Carro carro = new Carro();

            carro.Cor = "Cinza";
            carro.Modelo = "Modelo B";
            carro.Marca = "Marca 3";
            
            carro.Acelerar(200);

            Type tipo = carro.GetType();

            PropertyInfo[] propertyInfos = tipo.GetProperties();

            foreach (var propertyInfo in propertyInfos)
            {
                string nome = propertyInfo.Name;
                var valor = tipo.GetProperty(propertyInfo.Name).GetValue(carro);
                propertyInformation[nome] = valor;
                
                //Console.WriteLine($"{propertyInfo.Name} - {valor}");
            }

            return propertyInformation;
        }
        
        private static Dictionary<string, object> ObterNomeEValorMetodo()
        {
            Dictionary<string, object> propertyInformation = new Dictionary<string, object>();
            Carro carro = new Carro();

            carro.Cor = "Cinza";
            carro.Modelo = "Modelo B";
            carro.Marca = "Marca 3";
            
            carro.Acelerar(200);

            Type tipo = carro.GetType();

            MethodInfo[] methodInfos = tipo.GetMethods();

            foreach (var methodInfo in methodInfos)
            {
                string nome = methodInfo.Name;
                var valor = tipo.GetMethod(methodInfo.Name).GetParameters();
                propertyInformation[nome] = valor;
                
                //Console.WriteLine($"{propertyInfo.Name} - {valor}");
            }

            return propertyInformation;
        }
        
        
        private static void ObterPropriedades(Type t)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Informações do tipo: " + t.Name);
            str.AppendLine("Nome completo: " + t.FullName);
            str.AppendLine("Namespace: " + t.Name);
            Type tipoBase = t.BaseType;
            if (tipoBase != null)
            {
                str.AppendLine("Tipo base: " + t.BaseType.Name);
            }
            MemberInfo[] membros = t.GetMembers();
            foreach (var m in membros)
            {
                str.AppendLine(m.MemberType + " " + m.Name);
            }
            Console.WriteLine(str);
        }

        private static void Exemplo3()
        {
            Type tipo = typeof(Carro);
            Console.WriteLine(tipo.FullName);
        }

        private static void Exemplo2()
        {
            Type tipo = Type.GetType("ReflexaoClasses.Carro", false, true);
            Console.WriteLine(tipo.FullName);
        }

        private static void Exemplo1()
        {
            Carro carro = new Carro();
            Type tipo = carro.GetType();
            Console.WriteLine(tipo.FullName);
        }
    }
}