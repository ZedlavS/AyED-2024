﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static string calarea(double area, double altu)
        {
            string cadena;
            double volu, radio = area * area;

            area = (3.14 * (area * area));
            volu = (3.14 * altu * radio);

            cadena = "El area es: " + area.ToString() + " El volumnen es: " + volu.ToString();
            
            return cadena;
        }
        static void Main(string[] args)
        {
            double area, altu;
            Console.Write("Escriba el radio: ");
            area = int.Parse(Console.ReadLine());
            Console.Write("Escriba la altura de su cilíndro: ");
            altu = int.Parse(Console.ReadLine());
            Console.Write(calarea(area,altu));
            Console.ReadKey();
        }
    }
}