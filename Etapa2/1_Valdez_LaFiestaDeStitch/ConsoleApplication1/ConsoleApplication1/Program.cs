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
            int num;
            int com;

            int total = 0;

            bool para = true;

            Console.WriteLine("cuantos invitados hay?");

            num = int.Parse(Console.ReadLine());


            int[] invits = new int[num];

            Console.Clear();

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("cuanto come el invitado " + i);
                com = int.Parse(Console.ReadLine());
                while (com < 0 || com > 100)
                {
                    Console.WriteLine("tiene que ser entre 0 y 100");
                    com = int.Parse(Console.ReadLine());
                }
                invits[i] = com;
                total = total + invits[i];

            }
           
             Console.WriteLine("come un promedio de = " + (total / num));

            Console.ReadKey();
            




        }
    }
}
