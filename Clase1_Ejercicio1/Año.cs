using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_Ejercicio1
{
    internal class Año
    {
        public void ComprobarAñoBisiesto()
        {
            Console.Write("Ingrese el año a comprobar: ");
            string añoTexto = Console.ReadLine();
            int año = int.Parse(añoTexto);

            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
            {
                Console.WriteLine("Resultado: Es bisiesto");
            }
            else Console.WriteLine("Resultado: No es bisiesto");
        }




    }
}
