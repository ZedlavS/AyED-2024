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
            int ingresos;
            int edad;


            Console.WriteLine("edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresos mensuales: ");
            ingresos = int.Parse(Console.ReadLine());

            if (edad >= 19 & ingresos >= 100000)
            {
                Console.WriteLine("podes cobrar la beca Juan Pedro ");
            } else if (edad < 19)
            {
                Console.WriteLine("sos menor de 19 ");
            }else if (ingresos < 100000)
            {
                Console.WriteLine("tus ingesos mensuale son menor a 100.000");
            }
            Console.ReadKey();
        }
    }
}
