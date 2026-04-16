using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_Ejercicio
{
    internal class Cuadrado : Figura
    {
        protected float lado;

        public Cuadrado(string nombre, float lado) : base(nombre)
        {
            this.lado = lado;
        }

        public override float Area()
        {
            return lado * lado;
        }




    }
}
