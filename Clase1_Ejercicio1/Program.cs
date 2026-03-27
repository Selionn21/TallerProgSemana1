using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figuras fig = new Figuras();
            Año año = new Año();
            Calculadora calc = new Calculadora();

            fig.calcularAreaPerRectangulo();
            Console.WriteLine("-----------------");

            fig.calcularAreaTriángulo();
            Console.WriteLine("-----------------");

            año.ComprobarAñoBisiesto();
            Console.WriteLine("----------------");

            calc.EjecucionCalculadora();

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();



        }
    }
}
