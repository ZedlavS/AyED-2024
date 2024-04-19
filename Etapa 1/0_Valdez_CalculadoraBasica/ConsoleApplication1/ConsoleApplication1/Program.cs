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
            string numusu;
            string numusu1;
            int numero;
            int numero1;
            int suma;
            int resta;
            int multi;
            int div;
            int rest;

            

            Console.WriteLine("escriba su primer numero");

            numusu = Console.ReadLine();

            numero = int.Parse(numusu);

            Console.WriteLine("escriba su segundo numero");

            numusu1 = Console.ReadLine();

            numero1 = int.Parse(numusu1);

            suma = numero + numero1;

            resta = numero - numero1;

            multi = numero * numero1;

            div = numero / numero1;

            rest = numero % numero1;



            Console.WriteLine("suma: "+ suma );
            Console.WriteLine("resta: " + resta);
            Console.WriteLine("multiplicacion: " + multi);
            Console.WriteLine("division: " + div);
            Console.WriteLine("resto: " + rest);

            Console.ReadKey();


             
        }
    }
}
