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
            Carro carro = new Carro();
            
            carro.Cor = "Amarelo";
            carro.Modelo = "Modelo A";
            carro.Marca = "Marca 1";
            
            carro.Acelerar(200);

           var propriedades = ObterParametrosMetodos(carro);

           foreach (var propriedade in propriedades)
           {
               Console.WriteLine(propriedade);
           }
           
           Console.ReadLine();
        }

        private static List<string> ObterParametrosMetodos(Carro carro)
        {
            List<string> nomesParametrosMetodos = new List<string>();
            
            Type tipo = typeof(Carro);

            MethodInfo[] infoMetodos = tipo.GetMethods();

            foreach (var infoMetodo in infoMetodos)
            {
                ParameterInfo[] infoParametros = infoMetodo.GetParameters();

                foreach (var infoParametro in infoParametros)
                {
                    nomesParametrosMetodos.Add($"Metodo {infoMetodo.Name} - Parametro {infoParametro.Name}");
                }
            }
            
            return nomesParametrosMetodos;
        }

        private static List<string> ObterInterfaces(Carro carro)
        {
            List<string> nomesInterfaces = new List<string>();

            Type tipo = typeof(Carro);

            Type [] interfaces = tipo.GetInterfaces();
            
            foreach (var tipoInterface in interfaces)
            {
                nomesInterfaces.Add(tipoInterface.FullName);
            }
            
            return nomesInterfaces;
        }

        private static List<string> ObterNomesMetodos(Carro carro)
        {
            List<string> nomesMetodos = new List<string>();

            Type tipo = carro.GetType();

            MethodInfo[] infoMetodos = tipo.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public);

            foreach (var infoMetodo in infoMetodos)
            {
                nomesMetodos.Add(infoMetodo.Name);
            }
            
            return nomesMetodos;
        }
        
        private static Dictionary<string, object> ObterInformacoesAtributos(Carro carro)
        {
            Dictionary<string, object> informacoesAtributos = new Dictionary<string, object>();
            
            Type tipo = carro.GetType();

            FieldInfo[] infoAtributos = tipo.GetFields();

            foreach (var fieldInfo in infoAtributos)
            {
                string nome = fieldInfo.Name;
                var valor = tipo.GetField(fieldInfo.Name).GetValue(carro);
                informacoesAtributos[nome] = valor;
            }

            return informacoesAtributos;
        }

        private static Dictionary<string, object> ObterInformacoesPropriedades(Carro carro)
        {
            Dictionary<string, object> informacoesPropriedades = new Dictionary<string, object>();
             
            Type tipo = carro.GetType();

            PropertyInfo[] infoPropriedades = tipo.GetProperties();

            foreach (var propertyInfo in infoPropriedades)
            {
                string nome = propertyInfo.Name;
                var valor = tipo.GetProperty(propertyInfo.Name).GetValue(carro);
                informacoesPropriedades[nome] = valor;
            }

            return informacoesPropriedades;
        }
        
        private static void ObterPropriedadesTipo(Type t)
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

        private static void ObterTipoExemplo3()
        {
            Type tipo = typeof(Carro);
            Console.WriteLine(tipo.FullName);
        }

        private static void ObterTipoExemplo2()
        {
            Type tipo = Type.GetType("ReflexaoClasses.Carro", false, true);
            Console.WriteLine(tipo.FullName);
        }

        private static void ObterTipoExemplo1()
        {
            Carro carro = new Carro();
            Type tipo = carro.GetType();
            Console.WriteLine(tipo.FullName);
        }
    }
}