using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEstaticasEMembrosEstaticos
{
    /// <summary>
    /// Este exemplo demonstra
    /// <para>Como trabalhar com classes estáticas e com membros estaticos, como atributos</para>
    /// <para>O uso de metodos/atributos de classes estaticas com membros de instancia, que variam e 
    /// dependenm do operador new</para>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            TesteClasseEstatica();
            TesteMembroEstatico();
            Console.ReadLine();
        }

        private static void TesteClasseEstatica()
        {
            double temperaturaCelsius = 30;
            double temperaturaFahrenheit = ConversorStatic.CelsiusToFahrenheit(temperaturaCelsius);
            Console.WriteLine($"Temperatura Fahrenheit: { temperaturaFahrenheit}");
        }

        private static void TesteMembroEstatico() 
        {
            ConversorInstancia temperatura1 = new ConversorInstancia();
            ConversorInstancia temperatura2 = new ConversorInstancia();

            //o atributo Temperatura pertence somente a classe ConversorInstancia
            ConversorInstancia.Temperatura = 30;
            ConversorInstancia.Temperatura  = temperatura1.CelsiusToFahrenheit();
            Console.WriteLine($"Fahrenheit: {ConversorInstancia.Temperatura}");

            ConversorInstancia.Temperatura = 50;
            ConversorInstancia.Temperatura = temperatura2.FahrenheitToCelsius();
            Console.WriteLine($"Celsius: {ConversorInstancia.Temperatura}");
        }
    }

    public static class ConversorStatic 
    { 
        public static double CelsiusToFahrenheit(double temperatura) 
        {
            return (temperatura * 9 / 5.0) + 32;
        }

        public static double FahrenheitToCelsius(double temperatura)
        {
            return (temperatura - 32) * 5 / 9.0;
        }
    }

    public class ConversorInstancia
    {
        public static double Temperatura;

        public double CelsiusToFahrenheit()
        {
            return (Temperatura * 9 / 5.0) + 32;
        }

        public double FahrenheitToCelsius()
        {
            return (Temperatura - 32) * 5 / 9.0;
        }
    }
}
