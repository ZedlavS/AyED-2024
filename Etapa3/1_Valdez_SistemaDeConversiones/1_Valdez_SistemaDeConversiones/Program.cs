using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Valdez_SistemaDeConversiones
{
    class Program
    {
        static string decbin(int dec)
        {
            string bina = "";
            while (dec > 0)
            {
                bina = (dec % 2) + bina;
                dec = dec / 2;
            }
            return bina;
        }

        static double bindec(string bin)
        {
            double numdec = 0;
            double  carac = bin.Length;
            double basenum = 2;
            double resultado;
            for (int i = 0; i < bin.Length; i++)
            {
                char detecto = bin[i];
                
                if (detecto == '1')
                {
                    resultado = Math.Pow(basenum, carac);
                    numdec = numdec + resultado;

                    
                }
                
            }
            carac -= 1;

            return numdec;

        }

        static void Main(string[] args)
        {

            
            Console.WriteLine("decimal a binario");
            Console.WriteLine(decbin(int.Parse(Console.ReadLine())));
            Console.WriteLine("binario a decimal");
            Console.WriteLine(bindec(Console.ReadLine()));
            Console.ReadKey();

        }
    }
}
