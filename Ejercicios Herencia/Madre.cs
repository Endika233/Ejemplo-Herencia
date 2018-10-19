using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Herencia
{
    class Madre
    {
        private int id,edad;
        private string nombre, apellido;
        public Madre()
        {
        }
        public Madre(int id,string nombre,string apellido,int edad)
        {
            
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
