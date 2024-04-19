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

            string ed;
            int edad;

            Console.WriteLine("Escribe tu edad ");
            ed = Console.ReadLine();
            edad = int.Parse(ed);

            if (edad < 18)
            {
                Console.WriteLine("Sos menor de edad ");

            }
            else
            {
                Console.WriteLine("Sos mayor de edad");

            }
            Console.ReadKey();


        }
    }
}