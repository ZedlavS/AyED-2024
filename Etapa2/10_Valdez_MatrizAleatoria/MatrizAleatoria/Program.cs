using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;

            Console.WriteLine("columnas");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("filas");
            m = int.Parse(Console.ReadLine());


            int[,] matriz = new int[n, m];

            Random rng = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = rng.Next(1,100);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();

        }
    }
}
