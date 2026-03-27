using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_Ejercicio1
{
    internal class Figuras
    {
        public void calcularAreaPerRectangulo()
        {

            Console.Write("Ingrese la base del rectangulo: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura del rectángulo: ");
            float h = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la operación a realizar: a (área) o p (perímetro): ");
            string operación = Console.ReadLine().ToLower();

            if (operación == "a")
            {
                float area = b * h;
                Console.WriteLine("Área: " + area);

            }
            else if (operación == "p")
            {
                float perímetro = 2 * (b + h);
                Console.WriteLine("Perímetro: " + perímetro);
            }
            else Console.WriteLine("Operacion ingresada no válida");

            
        }


        public void calcularAreaTriángulo()
        {
            Console.Write("Ingrese la base del triángulo: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura del triángulo: ");
            float h = float.Parse(Console.ReadLine());

            float areaT = (b * h) / 2;
            Console.WriteLine("Área: " + areaT);
        }
    }
}
