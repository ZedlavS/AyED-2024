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
            string cadena;
            int entero;
            bool bolean;
            float flotante;
            double doble;
            char caracter;

            cadena = "15.557294";
            entero = 15;
            bolean = false;
            flotante = 15.557294f;
            doble = 15.557294;
            caracter = '1';

            Console.WriteLine("string " + cadena);
            Console.WriteLine("int " + entero);
            Console.WriteLine("bool " + bolean);
            Console.WriteLine("float " + flotante);
            Console.WriteLine("double " + doble);
            Console.WriteLine("char " + caracter);

            entero = int.Parse(Console.ReadLine());

            Console.WriteLine(entero);

            Console.ReadKey();

        }
    }
}
