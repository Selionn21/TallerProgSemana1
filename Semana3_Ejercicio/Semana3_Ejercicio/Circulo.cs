using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_Ejercicio
{
    internal class Circulo : Figura
    {

        protected float radio;
        protected float pi = 3.1416f;

        public Circulo(string nombre, float radio) : base(nombre)
        {

            this.radio = radio;

        }

        public override float Area()
        {
            return radio * radio * pi;
        }


    }
}
