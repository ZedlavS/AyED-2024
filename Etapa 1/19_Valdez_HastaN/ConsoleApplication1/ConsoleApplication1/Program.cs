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
            bool para = true;
            Console.WriteLine("numero?");
            num = int.Parse(Console.ReadLine());
            int i = 0;
            while (i<num)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
                i++;
            }Console.ReadKey();

        }
    }
}
