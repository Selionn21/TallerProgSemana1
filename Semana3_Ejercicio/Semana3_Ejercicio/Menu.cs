using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_Ejercicio
{
    internal class Menu
    {
        private List<Figura> figuras; 

        public void Ejecutar()
        {
            figuras = new List<Figura>();
            int seleccion = 0;

            do
            {
                Console.WriteLine(" ---- MENÚ ---- ");
                Console.WriteLine(" 1. Agregar figura ");
                Console.WriteLine(" 2. Mostrar figuras ");
                Console.WriteLine(" 3. Salir ");

                seleccion = int.Parse(Console.ReadLine());

                switch (seleccion)
                {
                    case 1: AgregarFigura(); break;
                    case 2: MostrarFigura(); break;
                }

            } while (seleccion != 3);
        }

        private void AgregarFigura()
        {
            Console.WriteLine(" Seleccione la figura: ");
            Console.WriteLine(" 1. Rectángulo, 2. Cuadrado, 3. Círculo o 4. Triangulo ");

           

            int tipoFigura = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre de la figura: ");
            string nombre = Console.ReadLine();

            switch (tipoFigura)
            {
                case 1:
                    Console.Write("Base del rectángulo: ");
                    float b = float.Parse(Console.ReadLine());

                    Console.Write("Altura del rectángulo: ");
                    float h = float.Parse(Console.ReadLine());

                    figuras.Add(new Rectangulo(nombre, b, h));
                    break;

                case 2:
                    Console.Write("Lado del cuadrado: ");
                    float lado = float.Parse(Console.ReadLine());

                    figuras.Add(new Cuadrado(nombre, lado));
                    break;

                case 3:
                    Console.Write("Radio del círculo: ");
                    float radio = float.Parse(Console.ReadLine());

                    figuras.Add(new Cuadrado(nombre, radio));
                    break;

                case 4:
                    Console.Write("Base del triángulo: ");
                    float ba = float.Parse(Console.ReadLine());

                    Console.Write("Altura del triángulo: ");
                    float hi = float.Parse(Console.ReadLine());

                    figuras.Add(new Triangulo(nombre, ba, hi));
                    break;
            }

            Console.WriteLine("Figura agregada correctamente");


        }

        private void MostrarFigura()
        {
            Console.WriteLine(" ---- Lista de figuras ---- ");

            foreach (Figura f in figuras)
            {
                Console.WriteLine("Nombre figura: " + f.Nombre);
                Console.WriteLine("Área figura: " + f.Area());
                Console.WriteLine("------------------");
            }
        }






    }
}
