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
            int numentero;

            int result;
            int comprobacion;


            Console.WriteLine("dame un numero");
            numentero = int.Parse(Console.ReadLine());

            result = numentero / 2;

            comprobacion = result * 2;

            if (numentero == comprobacion)
            {
                Console.WriteLine("es par");

            }else
            {
                Console.WriteLine("es impar");
            }

            Console.ReadKey();



            
        }
    }
}
