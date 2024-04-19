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
            string numero;
            int grados;
            int kelvin;
            int fahrenheit;
            Console.WriteLine("cuantos grados centigrados? ");
            numero = Console.ReadLine();
            grados = int.Parse(numero);

            kelvin = grados + 273;
            fahrenheit = grados * (18 / 10) + 32;

            Console.WriteLine("grados kelvin: " + kelvin);
            Console.WriteLine("grados fahrenheit: " + fahrenheit);
            Console.ReadKey();

        }
    }
}
