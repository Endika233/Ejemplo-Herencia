using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Hija hija1= new Hija(1,"Rita","Pollera",10,true);
            Console.WriteLine(hija1.GetNombre());
            Console.ReadLine();
        }
    }
}
