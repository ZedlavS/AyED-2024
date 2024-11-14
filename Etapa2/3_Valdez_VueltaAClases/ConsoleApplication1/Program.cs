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
            Console.Write("Ingrese la cantidad de pruebas: ");
            int[] laspruebas = new int[int.Parse(Console.ReadLine())];
            Console.Write("Ahora la cantidad de trabajos prácticos: ");
            int[] lostrabajos = new int[int.Parse(Console.ReadLine())];

            int notaprueba = 0, notatp = 0;

            for (int i = 0; i < laspruebas.Count(); i++)
            {
                Console.Write("La nota " + i + " es: ");
                notaprueba = int.Parse(Console.ReadLine());

                laspruebas[i] = notaprueba;

            }
            notaprueba = 0;
            for (int j = 0; j < laspruebas.Count(); j++)
            {
                notaprueba = laspruebas[j] + notaprueba;
            }
            notaprueba = notaprueba / laspruebas.Count();
 
            if (notaprueba >= 6)
            {
                Console.WriteLine("Aprobaste con un promedio de: " + notaprueba);
            }
            else
            {
                Console.WriteLine("Jaja no aprobaste. Tu promedio es de: " + notaprueba);
            }
            
            for (int i = 0; i < lostrabajos.Count(); i++)
            {
                Console.Write("La nota " + i + " es: ");
                notatp = int.Parse(Console.ReadLine());

                lostrabajos[i] = notatp;
            }
            notatp = 0;
            for (int j = 0; j < lostrabajos.Count(); j++)
            {
                if (lostrabajos[j] >= 6)
                {
                   notatp++;
                }
            }
            Console.WriteLine(0.75 * lostrabajos.Count());

            if (0.75 * lostrabajos.Count() <= notatp)
            {
                Console.WriteLine("Aprobaste.");
            }
            else
            {
                Console.WriteLine("Desaprobaste");
            }

            Console.ReadKey();
        }
    }
}