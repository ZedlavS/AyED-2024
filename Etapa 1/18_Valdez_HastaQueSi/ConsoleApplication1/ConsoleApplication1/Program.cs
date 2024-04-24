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
            string si;
            bool para = true;
            while (para == true)
            {
                Console.WriteLine("deseseas terminar el programa");
                si = Console.ReadLine();
                if (si == "Si")
                {
                    para =false;
                    Console.WriteLine("chau");
                }
            }Console.ReadKey();
        }   
    }
}
