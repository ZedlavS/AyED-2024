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
            string num1;
            string num2;
            int x;
            int y;
            int perimetro;
            int area;
            int diagonal;
            double raiz;

            Console.WriteLine("cuanto de ancho tiene el rectangulo ");
            num1 = Console.ReadLine();
            x = int.Parse(num1);

            Console.WriteLine("cuanto la altura tiene el rectangulo ");
            num2 = Console.ReadLine();
            y = int.Parse(num2);

            perimetro = (x * 2) + (y * 2);
            area = x * y;
            diagonal = ((x * x) + (y * y));
            raiz = Math.Sqrt(diagonal);

            Console.WriteLine("perimetro = "+ perimetro);
            Console.WriteLine("area = " + area);
            Console.WriteLine("diagonal = " + raiz);

            Console.ReadKey();



        }
    }
}
