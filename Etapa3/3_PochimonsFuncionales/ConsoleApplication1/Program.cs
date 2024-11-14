﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static string nom, tipo; 
        static int niv, opc = 0, val = 0, numin = 0, elec, aux;
        static string[,] mat = new string[76, 6]; 
        static Random rng = new Random(); 
        static bool par = true; 
        static string[] vec = new string[6]; 

        static void Main(string[] args)
        {
            vec[0] = "FILA";
            vec[1] = "NOMBRE";
            vec[2] = "TIPO";
            vec[3] = "NIVEL";
            vec[4] = "ESTADO";
            vec[5] = "NÚMERO DE INVESTIGADOR";

            while (par)
            {
                while (true)
                {
                    Console.WriteLine("-----------------MENÚ PRINCIPAL-----------------");
                    Console.WriteLine("________________________________________________");
                    Console.WriteLine("1. Registrar un Pochimon.");
                    Console.WriteLine("2. Asignar investigador a Pochimon.");
                    Console.WriteLine("3. Actualizar el nivel del Pochimon.");
                    Console.WriteLine("4. Marcar Pochimon como investigado.");
                    Console.WriteLine("5. Mostrar información de Pochimons.");
                    Console.WriteLine("6. Buscar Pochimons por tipo.");
                    Console.WriteLine("7. Mostrar Pochimons por investigador.");
                    Console.WriteLine("8. Mostrar Pochimons Messias.");
                    Console.WriteLine("9. Salir.");

                    Console.WriteLine("Coloque la opción que desea ejecutar: ");
                    opc = int.Parse(Console.ReadLine());

                    while (opc < 1 || opc > 9)
                    {
                        Console.WriteLine("wtf? Esa opción no se encuentra en el menú.");
                        opc = int.Parse(Console.ReadLine());
                    }


                    switch (opc)
                    {
                        case 1:
                            RegistrarPochimon();
                            break;
                        case 2:
                            AsignarInvestigador();
                            break;
                        case 3:
                            ActualizarNivel();
                            break;
                        case 4:
                            MarcarInvestigado();
                            break;
                        case 5:
                            MostrarInformacion();
                            break;
                        case 6:
                            BuscarPorTipo();
                            break;
                        case 7:
                            MostrarPorInvestigador();
                            break;
                        case 8:
                            Mostrarsuperiores();
                            break;
                        case 9:
                            Console.WriteLine("byeeeeeee");
                            return; // Salir del programa    
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
            }
        }

        static void RegistrarPochimon()
        {
            if (val >= 76)
            {
                Console.WriteLine("La Pochidex está llena :(");
                return;
            }

            Console.WriteLine("-----------------REGISTRO DE POCHIMON-----------------");
            Console.WriteLine("______________________________________________________");
            Console.Write("Ingrese nombre de su Pochimon: ");
            nom = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de " + nom);
            Console.WriteLine("Fuego / Agua / Planta / Eléctrico / Hada");
            Console.WriteLine("(Coloque solo la inicial del tipo).");
            tipo = (Console.ReadLine()).ToUpper();
            while (tipo != "F" && tipo != "A" && tipo != "P" && tipo != "E" && tipo != "H");
            {
                Console.WriteLine("Ahre que esa opción no está XDXDXD.");
                tipo = (Console.ReadLine()).ToUpper();
            }

            Console.WriteLine(" ");
            Console.Write("Ingrese el nivel de " + nom + ": ");
            niv = int.Parse(Console.ReadLine());

            while (niv < 0 || niv > 100)
            {
                Console.WriteLine("No. Pone un número del 1 al 100.");
                niv = int.Parse(Console.ReadLine());
            }
            mat[val, 0] = (val + 1).ToString();
            mat[val, 1] = nom;

            if (tipo == "F")
            {
                tipo = ("FUEGO");
            }
            if (tipo == "A")
            {
                tipo = "AGUA";
            }
            if (tipo == "P")
            {
                tipo = "PLANTA";
            }
            if (tipo == "E")
            {
                tipo = "ELECTRICO";
            }
            if (tipo == "H")
            {
                tipo = "HADA";
            }

            mat[val, 2] = tipo;
            mat[val, 3] = niv.ToString();
            mat[val, 4] = "0";
            mat[val, 5] = "000";
            val++;

            Console.Clear();
            Console.WriteLine(nom + " fue registrado con éxito.");
        }

        static void AsignarInvestigador()
        {
            Console.Clear();

            if (val == 0)
            {

                Console.WriteLine("Pochidex vacia.");
                Console.WriteLine(" ");
                return; 
            }

            Console.WriteLine("-----------------ASIGNACION INVESTIGADOR-----------------");
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine(" ");

            int aux = mat[0, 1].Length;

            for (int i = 1; i < val; i++)
            {
                if (aux < mat[i, 1].Length)
                {
                    aux = mat[i, 1].Length;
                }
            }

            for (int i = 0; i < val; i++)
            {
                mat[i, 1] = mat[i, 1].PadRight(aux);
            }

            for (int i = 0; i < vec.Length; i++)
            {
                Console.Write(" " + vec[i] + "\t" + "|");
            }
            Console.WriteLine();
            Console.WriteLine("________________________________________________");

            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(" " + mat[i, j] + "\t" + "|");
                }
                Console.WriteLine();
            }

            Console.Write("Ingrese el número de fila del Pochimon al cual desea asignarle un investigador: ");
            elec = int.Parse(Console.ReadLine());
            while (elec < 1 || elec > val)
            {
                Console.WriteLine("Fila no encontrada.");
                Console.Write("Ingresar una fila existente: ");
                elec = int.Parse(Console.ReadLine());
            }

            // Pedir al usuario el código del investigador
            Console.Write("Ingrese el código del Investigador: ");

            while (!int.TryParse(Console.ReadLine(), out numin))
            {
                Console.WriteLine("Por favor, ingrese un código de investigador válido.");
            }

            mat[elec - 1, 4] = "1"; 
            mat[elec - 1, 5] = numin.ToString(); 
            Console.Clear();
            Console.WriteLine("El investigador fue asignado con éxito.");
        }

        static void ActualizarNivel()
        {
            Console.Clear();

            if (val == 0)
            {
                Console.WriteLine("Pochidex vacia.");
                return;
            }

            Console.WriteLine("-----------------ACTUALIZACIÓN NIVEL-----------------");
            Console.WriteLine("_____________________________________________________");
            MostrarInformacion(); 

            Console.Write("Ingrese el número de fila del Pochimon que desea actualizar: ");
            elec = int.Parse(Console.ReadLine());

            while (elec < 1 || elec > val)
            {
                Console.WriteLine("Fila inválida.");
                Console.Write("Ingrese una fila válida: ");
                elec = int.Parse(Console.ReadLine());
            }

            Console.Write("Actualice el nuevo nivel: ");
            niv = int.Parse(Console.ReadLine());
            while (niv < 0 || niv > 100)
            {
                Console.WriteLine("No. Pone un número entre el 0 y 100");
                niv = int.Parse(Console.ReadLine());
            }

            mat[elec - 1, 3] = niv.ToString(); 
            Console.Clear();
            Console.WriteLine("Su nivel fue actualizado con correctamente.");
        }

        static void MarcarInvestigado()
        {
            Console.Clear();

            if (val == 0)
            {
                Console.WriteLine("Pochidex vacia.");
                return;
            }

            Console.WriteLine("-----------------MARCAR COMO INVESTIGADO-----------------");
            Console.WriteLine("_________________________________________________________");
            MostrarInformacion();

            Console.Write("Ingrese el número de fila del Pochimon que quiere marcar como investigado: ");
            elec = int.Parse(Console.ReadLine());

            while (elec < 1 || elec > val)
            {
                Console.WriteLine("Fila inexistente");
                Console.Write("Ingrese correctamente la fila: ");
                elec = int.Parse(Console.ReadLine());
            }

            mat[elec - 1, 4] = "1";
            Console.Clear();
            Console.WriteLine("Su pochimon fue marcado como investigado.");
        }

        static void MostrarInformacion()
        {
            Console.Clear();

            if (val == 0)
            {
                Console.WriteLine("Pochidex vacia.");
                return;
            }

            Console.WriteLine("-----------------INFORMACIÓN DE POCHIMONS-----------------");
            Console.WriteLine("__________________________________________________________");
            Console.WriteLine(" ");
            for (int i = 0; i < vec.Length; i++)
            {
                Console.Write(" " + vec[i] + "\t" + "|");
            }
            Console.WriteLine();
            Console.WriteLine("__________________________________________________________");

            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(" " + mat[i, j] + "\t" + "|");
                }
                Console.WriteLine();
            }
        }

        static void BuscarPorTipo()
        {
            Console.Clear();

            if (val == 0)
            {
                Console.WriteLine("Pochidex vacia.");
                return;
            }

            Console.WriteLine("-----------------BUSCAR POR TIPO-----------------");
            Console.WriteLine("_________________________________________________");
            Console.Write("Ingrese el tipo a buscar (Fuego / Agua / Planta / Elec / Hada): ");
            tipo = Console.ReadLine().ToUpper();

            while (tipo != "F" && tipo != "A" && tipo != "P" && tipo != "E" && tipo != "H")
            {
                Console.WriteLine("Dale. Pone bien.");
                tipo = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("Resultados: ");
            bool encontrado = false;

            for (int i = 0; i < val; i++)
            {
                if (mat[i, 2] == (tipo switch 
                {
                    "F" => "FUEGO",
                    "A" => "AGUA",
                    "P" => "PLANTA",
                    "E" => "ELECTRICO",
                    "H" => "HADA",

                }))
                {
                    Console.WriteLine($"Fila {i + 1}: {mat[i, 1]} - Nivel: {mat[i, 3]}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró a ningún pochimon con ese tipo.");
            }
        }

        static void MostrarPorInvestigador()
        {
            Console.Clear();

            if (val == 0)
            {
                Console.WriteLine("Pochidex vacia.");
                return;
            }

            Console.WriteLine("-----------------BUSCAR POR INVESTIGADOR-----------------");
            Console.WriteLine("_________________________________________________________");
            Console.Write("Coloque el número del investigador: ");
            numin = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultados: ");
            bool encon = false;

            for (int i = 0; i < val; i++)
            {
                if (mat[i, 5] == numin.ToString())
                {
                    Console.WriteLine($"Fila {i + 1}: {mat[i, 1]} - Tipo: {mat[i, 2]} - Nivel: {mat[i, 3]}");
                    encon = true;
                }
            }

            if (!encon)
            {
                Console.WriteLine("No hay pochimons con ese número de investigador.");
            }
        }

        static void Mostrarsuperiores()
        {
            Console.Clear();

            if (val == 0)
            {
                Console.WriteLine("Pochidex vacia.");
                return;
            }

            Console.WriteLine("----------------POCHIMONS MESSIAS----------------");
            Console.WriteLine("_________________________________________________");
            bool encon = false;

            for (int i = 0; i < val; i++)
            {
                if (mat[i, 3] == "100") 
                {
                    Console.WriteLine("Fila {i + 1}: {matriz[i, 1]} - Tipo: {matriz[i, 2]} - Nivel: {matriz[i, 3]}");
                    encon = true;
                }
            }

            if (!encon)
            {
                Console.WriteLine("Uy. No registraste a ningún pochimon messias.");
            }
        }
}