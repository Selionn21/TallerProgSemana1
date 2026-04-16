using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_Ejercicio
{
    internal class Triangulo : Figura
    {

        protected float ba;
        protected float hi;

        public Triangulo(string nombre, float ba, float hi) : base(nombre)
        {

            this.ba = ba;
            this.hi = hi;

        }

        public override float Area()
        {
            return (ba * hi) / 2;
        }



    }
}
