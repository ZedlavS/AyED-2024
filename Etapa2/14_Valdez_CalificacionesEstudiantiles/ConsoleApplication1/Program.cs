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
            int est;

            Console.Write("Ingrese la cantidad de estudiantes: ");
            est = int.Parse(Console.ReadLine());
            Console.Write("Colocar el nombre, edad y calificacion (en ese orden): ");
            Console.WriteLine();
            string[,] matriz = new string[3, est];
            for (int i = 0; i < est; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[j, i] = Console.ReadLine();

                    Console.Clear();
                }
                Console.WriteLine();
            }
            for (int i = 0; i < est; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[j, i] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}