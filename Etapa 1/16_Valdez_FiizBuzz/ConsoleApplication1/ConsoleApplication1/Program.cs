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
            int i = 0;

            while (i < 100)
            {
                

                if (i % 3 == 0 & i % 5 == 0) 
                {   
                    i++;                   
                    Console.WriteLine("FizzBuzz");
                    
                }else if (i % 3 == 0 & i % 5 != 0)
                {
                    i++;
                    Console.WriteLine("Fizz");
                }else if (i % 5 == 0 & i % 3 != 0)
                {
                    i++;
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                    i++;
                }
                
                
            }
            Console.ReadKey();

        }
    }
}
