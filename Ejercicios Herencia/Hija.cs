using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Herencia
{
    class Hija:Madre
    {
        private bool soltera;//EL atributo extra que añades a la clase madre
        public Hija()
        {
        }
        public Hija(int id, string nombre, string apellido, int edad,bool soltera):base(id,nombre,apellido,edad)
        {
            this.soltera = soltera;
        }

    }
}
