using System;

namespace Practica_Examen_1er_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int mil = 18;
            int quinientos = 19;
            int doscientos = 23;
            int cien = 100;
            string enter = "";
            int monto = 0;
            int inicial = 0;
            menu();
            

            void menu()
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al Banco FDP INVERSMENTS");
                Console.WriteLine("");
                Console.WriteLine("Eliga opcion:");
                Console.WriteLine("1. Retiro");
                Console.WriteLine("2. Ver cantidad de billetes disponibles");
                Console.WriteLine("3. Salir");
                Console.WriteLine("");
                enter = Console.ReadLine();
                if (enter == "1") 
                {
                    retiro();
                }
                else if (enter == "2")
                {
                    verBilletes();
                }
                else if (enter == "3")
                {
                    
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Numero invalido");
                    menu();
                }


            }

            void retiro()
            {
                Console.Clear();
                Console.WriteLine("Introduzca Banco:");
                enter = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Introduzca monto:");
                do
                {
                    try
                    {
                        monto = int.Parse(Console.ReadLine());

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Introduce cantidad valida");
                        continue;
                    }

                    if (monto <= 100)
                    {
                        Console.WriteLine("El monto debe ser superior a 100");
                        continue;
                    }
                    else { 

                    if (enter == "FDP INVERSMENTS")
                    {
                            if (monto == 10000)
                            {
                                break;
                            }
                            else if (monto == 20000)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("El limite de retiro para el banco " + enter + " es de 10000 y 20000");
                                continue;
                            }
                        }
                        else
                        {
                            break;
                        }
                }
                } while (1 + 1 ==2);

                inicial = monto;

                do
                {
                    if (mil == 0)
                    {
                        Console.WriteLine("Ya no hay billetes de 1000");
                        break;
                    }
                    if (monto >= 1000)
                    {
                        monto = monto - 1000;
                        mil--;
                    }
                    else
                    {
                        break;
                    }

                } while (monto >= 0);

                do
                {
                    if (quinientos == 0)
                    {
                        Console.WriteLine("Ya no hay billetes de 500");
                        break;
                    }
                    if (monto >= 500)
                    {
                        monto = monto - 500;
                        quinientos--;
                    }
                    else
                    {
                        break;
                    }
                } while (monto >= 0);

                do
                {
                    if (doscientos == 0)
                    {
                        Console.WriteLine("Ya no hay billetes de 200");
                        break;
                    }
                    if (monto >= 200)
                    {
                        monto = monto - 200;
                        doscientos--;
                    }
                    else
                    {
                        break;
                    }
                } while (monto >= 0);

                do
                {
                    if (cien == 0)
                    {
                        Console.WriteLine("Ya no hay billetes de 100");
                        break;
                    }
                    if (monto >= 100)
                    {
                        monto = monto - 100;
                        cien--;
                    }
                    else
                    {
                        break;
                    }
                } while (monto >= 0);
                Console.WriteLine("");
                Console.WriteLine("Retirados: " + (inicial - monto) + " de " + inicial );
                Console.WriteLine("Retiro  exitosamente completado");
                do
                {

                    Console.WriteLine("Pulse 0 Para volver al menu principal");
                    enter = Console.ReadLine();
                } while (enter != "0");
                menu();
            }

            void verBilletes()
            {
                Console.Clear();
                Console.WriteLine("Billetes disponibles");
                Console.WriteLine("");
                Console.WriteLine(mil + " billetes de 1,000");
                Console.WriteLine(quinientos + " billetes de 500");
                Console.WriteLine(doscientos + " billetes de 200");
                Console.WriteLine(cien + " billetes de 100");
                Console.WriteLine("");
                do
                {
                    
                    Console.WriteLine("Pulse 0 Para volver al menu principal");
                    enter = Console.ReadLine();
                } while (enter != "0");
                menu();
            }

        }

      

     
    }
}