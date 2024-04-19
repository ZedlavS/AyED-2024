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
            string numero;
            int radio;
            double superficie;
            double volumen;

            Console.WriteLine("De cuanto es el radio? ");
            numero = Console.ReadLine();
            radio = int.Parse(numero);

            superficie = 4 * 3.14 * radio * radio;
            volumen = (4 / 3) * 3.14 * radio * radio * radio;

            Console.WriteLine("la superficie es: " + superficie);
            Console.WriteLine("El volumen es: " + volumen);

            Console.ReadKey();



    }
    }
}
