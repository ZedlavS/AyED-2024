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
            int objetos;
            int filtro;

            Console.WriteLine("cuantos objetos deseas analizar ");
            objetos = int.Parse(Console.ReadLine());

            int[] elementos = new int[objetos];

            Console.WriteLine("di el valor nminimo para que los objetos entren en el filtro");
            filtro = int.Parse(Console.ReadLine());

            for ( int i = 0; i < objetos; i++)
            {
                Console.WriteLine("dime el valor del objeto numero " + (i + 1));
                elementos[i] = int.Parse(Console.ReadLine());
            }

           

            for ( int i= 0; i < objetos; i++)
            {
                if (filtro < elementos[i])
                {
                    Console.WriteLine("el objeto en la posicion numero " + (i + 1) + " paso el filtro");

                }
            }
            Console.ReadKey();


        }
    }
}
