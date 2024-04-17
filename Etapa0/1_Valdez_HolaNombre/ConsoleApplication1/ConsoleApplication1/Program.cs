using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("¿Cual es su nombre?");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.ReadKey();

        }
    }
}
