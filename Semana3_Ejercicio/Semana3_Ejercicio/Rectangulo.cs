using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_Ejercicio
{
    internal class Rectangulo : Figura
    {

        protected float b;
        protected float h;

        public Rectangulo(string nombre, float b, float h) : base(nombre)
        {

            this.b = b;
            this.h = h;

        }

        public override float Area()
        {
            return b * h;
        }
    }
}
