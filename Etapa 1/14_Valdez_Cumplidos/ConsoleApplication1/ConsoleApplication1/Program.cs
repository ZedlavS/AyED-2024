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

            int edad;
            int i = 0;

            Console.WriteLine("edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.Clear();

            while (i <= edad)
            {
                Console.WriteLine("cumpliste " + i + " años");
                i++;
            }
            Console.ReadKey();

        }
    }
}
