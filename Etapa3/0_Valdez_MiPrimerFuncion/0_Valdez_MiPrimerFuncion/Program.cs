using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Valdez_MiPrimerFuncion
{
    class Program
    {
        static string saludo(string nombres)
        {

            string saludar = "HOLA " + nombres + " !";
            return saludar;
        }
        
        static void Main(string[] args)
        {
            string nombre;
            nombre = Console.ReadLine();

            Console.WriteLine(saludo(nombre));

            Console.ReadKey();

        }
    }
}
