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
            string ciudad;

            Console.WriteLine("Tu nombre? ");
            nombre = Console.ReadLine();
            Console.WriteLine("Y el nombre de la ciudad? ");
            ciudad = Console.ReadLine();

            Console.WriteLine("Hola " + nombre +  " bienvenido a " + ciudad);
            Console.ReadKey();
        }
    }
}
