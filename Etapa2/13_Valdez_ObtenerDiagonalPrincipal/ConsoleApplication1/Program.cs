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
            int n;

            Console.Write("Indicar el tamaño del vector y de la matriz (solo un número): ");
            n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            int[] vector = new int[n];
            Random rango = new Random();

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = rango.Next(1, 10);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------");
            for (int i = 0; i < n; i++)
            {
                vector[i] = matriz[i, i];
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + "\t");
            }

            Console.ReadKey();
        }
    }
}