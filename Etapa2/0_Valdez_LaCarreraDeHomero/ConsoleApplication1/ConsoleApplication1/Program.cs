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
            bool para = true;
            int num;
            int total;
            string sino;
            total = 0;
            Console.WriteLine("cuantos obstaculo hay?");
            num = int.Parse(Console.ReadLine());

            int[] cont = new int[num];

            for (int i = 0; i < num; ++i)
            {
                Console.WriteLine("lo supera? (Si o No)");
                sino = Console.ReadLine();


                if (sino != "No" || sino != "no" || sino != "Si" || sino != "si") { 
                    while (para==true)
                    {
                        Console.WriteLine("escribi de nuevo");
                        sino = Console.ReadLine();
                        if (sino == "No" || sino == "no" || sino == "Si" || sino== "si")
                        {
                            para = false;
                        }
                    }
                }




                if (sino == "Si" || sino == "si")
                {
                    cont[i] = 1;

                }
                else if (sino == "No" || sino == "no")
                {
                    cont[i] = 0;


                } 
            }
            Console.Clear();
            for (int b = 0; b < (num); ++b)
                
                {
                    if (cont[b] == 1) 
                    {
                    total = total + 10;
                }
                else
                {
                    total = total - 5;
                }
                }Console.WriteLine("gano = " + total);
            
            Console.ReadKey();
        }
    }
}
