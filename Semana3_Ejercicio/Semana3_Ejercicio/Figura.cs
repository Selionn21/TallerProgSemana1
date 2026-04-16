using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_Ejercicio
{
    internal class Figura
    {

        protected string nombre;

        public string Nombre { get  { return nombre; } }

        public Figura(string nombre)
        {
            this.nombre  = nombre;
        }

        public virtual float Area()
        {
            return 0;
        }

    }
}
