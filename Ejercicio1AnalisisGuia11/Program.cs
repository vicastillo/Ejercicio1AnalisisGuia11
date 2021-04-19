using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1AnalisisGuia11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Impresión de los elementos de vectores.";

            Double[] Vectores = new Double[7];
            for (int i = 0; i < 7; i++)
            {
            Console.WriteLine("Ingrese el valor del vector " + (i + 1) + ":");
            Vectores[i] = Double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Los vectores ingresados son:");
            for (int i = 0; i < 7; i++)
            {
            Console.Write("\t" + Vectores[i]);
            }

            }
            catch (Exception error)
            {
            Console.WriteLine("Error: " + error.Message);
            }

            Console.ReadKey();
        }
    }
}
