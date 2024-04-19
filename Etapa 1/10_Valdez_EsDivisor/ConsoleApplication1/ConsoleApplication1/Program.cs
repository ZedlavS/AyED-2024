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

            
            double primernum;
            
            double segundonum;
            double resultado;

            Console.WriteLine("dame un numero");
            primernum = int.Parse(Console.ReadLine());

            Console.WriteLine("dame otro numero");
            segundonum = int.Parse(Console.ReadLine());

            resultado = primernum / segundonum;

            if (segundonum == 0)
            {
                Console.WriteLine("la division no se puede hacer ");

            }
            else
            {
                Console.WriteLine("la division da: " + resultado);
            }

            Console.ReadKey();

            


            







        }
    }
}
