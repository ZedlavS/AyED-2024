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
            Console.Write("¿De qué tamaño quiere su vector? ");
            int[] tamañovector = new int[int.Parse(Console.ReadLine())];
            Random rango = new Random();

            for (int i = 0; i < tamañovector.Count(); i++)
            {
                tamañovector[i] = rango.Next(1, 100);
            }

            string opcion;
            bool salida = true;
            int num1, num2;
            
            while(salida == true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("----------MENÚ----------");
                Console.WriteLine(" ");
                Console.WriteLine("a) Imprimir los elementos del vector.");
                Console.WriteLine("b) Buscar un valor.");
                Console.WriteLine("c) Ordenar el vector.");
                Console.WriteLine("d) Salir del programa.");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "a":
                        for (int i = 0; i < tamañovector.Count(); i++)
                        {
                            Console.WriteLine(tamañovector[i]);
                        }
                        break;
                    case "b":
                        Console.Clear();
                        Console.Write("¿Qué número desea buscar? ");
                        num1 = int.Parse(Console.ReadLine());
                        for (int i = 0; i < tamañovector.Count(); i++)
                        {
                            if(tamañovector[i] == num1)
                            {
                                Console.WriteLine("El número que buscas se encuentra en la posición: " + i);
                            }
                            else
                            {
                                Console.WriteLine("Lamento informarte que el número que buscas no esta.");
                            }
                        }
                        break;
                    case "c":
                        Console.Clear();
                        Console.WriteLine("¿Cómo queres ordenar el vector?");
                        Console.WriteLine("1) Ascendente.");
                        Console.WriteLine("2) Descendente.");
                        num2 = int.Parse(Console.ReadLine());
                        if (num2 == 1)
                        {
                            for (int i = 0; i < tamañovector.Count(); i++)
                            {
                                for (int j = 0; j < tamañovector.Count(); j++)
                                {
                                    if (tamañovector[j] > tamañovector[i])
                                    {
                                        num2 = tamañovector[j];
                                        tamañovector[j] = tamañovector[i];
                                        tamañovector[i] = num2;
                                        
                                    }
                                }
                            }
                        }
                        if (num2 == 2)
                        {
                            for (int i = 0; i < tamañovector.Count(); i++)
                            {
                                for (int j = 0; j < tamañovector.Count(); j++)
                                {
                                    if (tamañovector[j] < tamañovector[i])
                                    {
                                        num2 = tamañovector[j];
                                        tamañovector[j] = tamañovector[i];
                                        tamañovector[i] = num2;
                                        
                                    }
                                }
                            }
                        }
                        for (int i = 0; i < tamañovector.Count(); i++)
                        {
                            Console.WriteLine(tamañovector[i]);
                        }
                        break;
                    case "d":
                        Console.Clear();
                        Console.Write("Bye");
                        salida = false;
                        break;
                }
            }
            

            Console.ReadKey();
        }
    }
}