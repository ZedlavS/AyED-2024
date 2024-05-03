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
            int total = 0;
            int prom = 0;

            int vuelta;
            int segundo;

            int mayor1;

            int mayor = 0;


            Console.WriteLine("cuantas vueltas da el rayo");
            vuelta = int.Parse(Console.ReadLine());

            int[] vueltas = new int[vuelta];

            for (int i = 0; i < vuelta; i++)
            {
                Console.WriteLine("cuanto tardo en la vuelta " + i);
                segundo = int.Parse(Console.ReadLine());

                vueltas[i] = segundo;

            }
            for (int i = 0; i < vuelta; i++)
            {
                total = vueltas[i] + total;


            }

            mayor1 = vueltas[0];

            for (int i = 1; i < vuelta; i++)
            {


                if (mayor1 > vueltas[i])
                {
                    mayor = vueltas[i];
                    mayor1 = vueltas[i];

                }
                else
                {
                    mayor = mayor1;
                }

            }


            prom = total / vuelta;
            Console.Clear();
            Console.WriteLine("tardo un total de " + total);
            Console.WriteLine("el promedio de tiempo es " + prom);
                Console.WriteLine("la mejor vuelta es de "+mayor);
                
                Console.ReadKey();


            }
        }
    }

