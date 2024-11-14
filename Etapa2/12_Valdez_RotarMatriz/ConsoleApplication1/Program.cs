﻿using System;
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
            int n, m;

            Console.Write("Filas: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Columnas: ");
            m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];
            int[,] matriz2 = new int[m, n];

            Random rango = new Random();

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = rango.Next(1, 10);
                    matriz2[j, i] = matriz[i, j];
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Matriz normal");
            Console.WriteLine("-------------");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine(" ");
            Console.WriteLine("Matriz rotada");
            Console.WriteLine("-------------");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}