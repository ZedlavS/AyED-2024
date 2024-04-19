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

            int numero;
            int i = 0;
            int guarda;

            Console.WriteLine("decime un numero");
            numero = int.Parse(Console.ReadLine());

            Console.Clear();

            guarda = numero;

            while (i < numero)
            {
                Console.WriteLine(guarda);
                guarda--;
                i++;
                
            }
            Console.ReadKey();
        }
    }
}
