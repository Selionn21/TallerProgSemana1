using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_TallerProgramación
{
    internal class FigurasGeo
    {

        public void EjecucionFiguras()
        {
            string continuar = "si";

            while (continuar == "si")
            {
                string figuraEleg = PreguntarPorFigura();

                if (figuraEleg == "c")
                {
                    int operacionEleg = SeleccionOperacion();

                    if (operacionEleg == 1)
                    {
                        float areaCir = CalcularAreaCirculo();
                        Console.WriteLine("El área del círculo es igual a: " + areaCir);
                    }
                    else if (operacionEleg == 2)
                    {
                        float perimCir = CalcularPerimCirculo();
                        Console.WriteLine("El perímetro del círculo es igual a: " + perimCir);
                    }
                    else Console.WriteLine("Operación ingresada no válida");

                }
                else if (figuraEleg == "r")
                {
                    int operacionEleg = SeleccionOperacion();

                    if (operacionEleg == 1)
                    {
                        float areaRect = CalcularAreaRect();
                        Console.WriteLine("El área del rectángulo es igual a: " + areaRect);
                    }
                    else if (operacionEleg == 2)
                    {
                        float perimRect = CalcularPerimRect();
                        Console.WriteLine("El perímetro del rectángulo es igual a: " + perimRect);
                    }
                    else Console.WriteLine("Operación ingresada no válida");

                }
                else if (figuraEleg == "t")
                {
                    float areaTri = CalcularAreaTriangulo();
                    Console.WriteLine("El área del triángulo es igual a: " + areaTri);
                }
                else
                {
                    Console.WriteLine("Figura ingresada no válida");
                }


                Console.Write("¿Desea seguir realizando operaciones? (si/no): ");
                continuar = Console.ReadLine().ToLower();

                if (continuar == "no")
                {
                    Console.WriteLine("Gracias por utilizar nuestro programa");
                }

            }
        }

        public string PreguntarPorFigura()
        {
            string figuraElegida;

            Console.Write("Seleccione la figura geométrica a trabajar (c: círculo, r: rectángulo o t: triángulo): ");
            figuraElegida = Console.ReadLine().ToLower();

            return figuraElegida;

        }

        public int SeleccionOperacion()
        {
            Console.Write("Elige la operación que deseas reaizar (a: área o p: perímetro): ");
            string operacionIndex = Console.ReadLine().ToLower();

            int operacion = 0;


            switch (operacionIndex)
            {
                case "a": operacion = 1; break;
                case "p": operacion = 2; break;
                default: Console.WriteLine("Opción inválida"); break;
            }

            return operacion;
        }

        public float CalcularAreaCirculo()
        {
            float areaCir = 0; 

            while (areaCir == 0)
            {
                Console.Write("Ingrese el radio del círculo: ");
                float rad = float.Parse(Console.ReadLine());

                if (rad > 0)
                {
                    areaCir = (rad * rad) * 3.14f;
                }
                else
                {
                    Console.WriteLine("El radio no puede ser negativo");
                }
            }

            return areaCir;


        }

        public float CalcularPerimCirculo()
        {
            float perimCir = 0;

            while (perimCir == 0)
            {
                Console.Write("Ingrese el radio del círculo: ");
                float rad = float.Parse(Console.ReadLine());

                if (rad > 0)
                {
                    perimCir = (2 * rad) * 3.14f;


                }
                else
                {
                    Console.WriteLine("El radio no puede ser negativo o letra");
                }
            }

  
            return perimCir;


        }

        public float CalcularAreaRect()
        {

            float areaRect = 0;

            while (areaRect == 0)
            {
                Console.Write("Ingrese la base del rectángulo: ");
                float ba = float.Parse(Console.ReadLine());
                Console.Write("Ingrese la altura del rectángulo:");
                float h = float.Parse(Console.ReadLine());

                if (ba > 0 && h > 0)
                {
                    areaRect = h * ba;
                }
                else
                {
                    Console.WriteLine("La base o la altura no pueden ser negativas");
                }
            }

      

            return areaRect;

        }

        public float CalcularPerimRect()
        {
            float perimRect = 0;

            while(perimRect == 0)
            {

                Console.Write("Ingrese la base del rectángulo: ");
                float ba = float.Parse(Console.ReadLine());
                Console.Write("Ingrese la altura del rectángulo:");
                float h = float.Parse(Console.ReadLine());

                if (ba > 0 && h > 0)
                {
                    perimRect = (2 * h) + (2 * ba);
                }
                else
                {
                    Console.WriteLine("La base o algura no pueden ser negativas");
                }

            }

            return perimRect;

        }

        public float CalcularAreaTriangulo()
        {
            float areaTri = 0;

            while (areaTri == 0)
            {
                Console.Write("Ingrese la base del triángulo: ");
                float ba = float.Parse(Console.ReadLine());
                Console.Write("Ingrese la altura del triángulo:");
                float h = float.Parse(Console.ReadLine());

                if (ba > 0 && h > 0)
                {
                    areaTri = (h * ba) / 2f;
                }
                else
                {
                    Console.WriteLine("El radio no puede ser negativo o letra");
                }
            }

            return areaTri;

        }
    }
}