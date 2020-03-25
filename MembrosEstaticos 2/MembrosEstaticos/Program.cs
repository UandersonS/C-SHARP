using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Entre com o valor do raio");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double cir = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + cir.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("PI: " + Calculadora.Pi);
        }
    }
}
