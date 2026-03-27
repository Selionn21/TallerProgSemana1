using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_Ejercicio1
{
    internal class Calculadora
    {

        public void EjecucionCalculadora()
        {
            string continuar = "s";

            while (continuar == "s")
            {
                Console.WriteLine("\n--- Calculadora ---");
                Console.Write("1er número: ");
                float n1 = float.Parse(Console.ReadLine());

                Console.Write("2do número: ");
                float n2 = float.Parse(Console.ReadLine());

                Console.Write("Operación ( +, -, *, /): ");
                string operacion = Console.ReadLine();

                float resultado = 0;

                switch(operacion)
                {
                    case "+": resultado = n1 + n2; break;
                    case "-": resultado = n1 - n2; break;
                    case "*": resultado = n1 * n2; break;
                    case "/": resultado = n1 / n2; break;
                }

                Console.WriteLine("El resultado es: " + resultado);

                Console.WriteLine("¿Desea seguir realizando operaciones? (s/n): ");
                continuar = Console.ReadLine().ToLower();
            }
        }


    }
}
