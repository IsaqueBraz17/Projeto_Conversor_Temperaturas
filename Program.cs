using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApredendoProgramacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversão de temperaturas

            Console.WriteLine("### CONVERSOR DE TEMPERATURAS ###");
            Console.Write("Insira a temperatura em Celcius: ");
            var celcius = double.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Convertendo...");
            Console.WriteLine();

            // Operação de conversão
            var fahrenheit = (celcius * 9 / 5) + 32;

            var kelvin = celcius + 273.15;

            Console.WriteLine(celcius + " graus celcius = " + fahrenheit + " graus fahrenheit");
            Console.WriteLine(celcius + " graus celcius = " + kelvin + " graus kelvin");
            Console.WriteLine();

            Console.WriteLine("Encerrando...");
        }
    }
}
