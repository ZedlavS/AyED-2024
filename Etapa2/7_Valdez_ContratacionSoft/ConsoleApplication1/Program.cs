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
            Console.Write("¿Cuántas personas realizaron el examen?: ");
            int[] loscandidatos = new int[int.Parse(Console.ReadLine())];

            int nota = 0;

            for (int i = 0; i < loscandidatos.Count(); i++)
            {
                Console.Write("La nota del candidato " + i + " es: ");
                nota = int.Parse(Console.ReadLine());
                loscandidatos[i] = nota;
            }

            for (int j = 0; j < loscandidatos.Count(); j++)
            {
                for (int k = 0; k < loscandidatos.Count(); k++)
                {
                    if (loscandidatos[k] > loscandidatos[j])
                    {
                        nota = loscandidatos[k];
                        loscandidatos[k] = loscandidatos[j];
                        loscandidatos[j] = nota;

                    }
                }


            }
            for (int i = 0; i < loscandidatos.Count(); i++)
            {
                Console.WriteLine(loscandidatos[i]);
            }

            Console.ReadKey();
        }
    }
}