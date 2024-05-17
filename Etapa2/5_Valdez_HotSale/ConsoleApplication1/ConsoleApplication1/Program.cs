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

            int vendido;

            Console.WriteLine("cuanto productos se vendieron ");
            vendido = int.Parse(Console.ReadLine());

            int[] productos = new int[vendido];

            for (int i = 0; i < vendido; i++)
            {
                Console.WriteLine("cuanto costo el producto numero " + (i + 1));
                productos[i] = int.Parse(Console.ReadLine());
            }

            int mayor = productos[0];
            int menor = mayor;

            for (int i = 1; i < vendido; i++)
            {
                if (mayor < productos[i])
                {
                    mayor = productos[i];
                }
                else
                {
                    menor = productos[i];
                }
            }
            Console.WriteLine("el produto mayor vendido fue de " + mayor);
            Console.WriteLine("el produto menor vendido fue de " + menor);

            Console.ReadKey();
        }
    }
}
