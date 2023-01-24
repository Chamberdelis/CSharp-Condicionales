using System;

namespace Ejerciciov3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Una importante marca de computadoras permite elegir cierta

            //configuración del equipo a comprar. Para ello existe la siguiente escala de precios:
            //               i5 (1)	     i7 (2)	  i9 (3)
            // 8 RAM (1)    USD 800	   USD 900	USD 1200
            // 16 RAM (2)	USD 900	   USD 1000	USD 1400
            // 32 RAM (3)	USD 1000   USD 1400	USD 2000
            //Además, el equipo viene con un disco que permite almacenar 500 GB de información y

            //que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300.
            //Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y

            //si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y

            //calcule y emita por pantalla el monto de la máquina seleccionada.
            int
                od,
                om,
                op;
            float total = 0;

            Console.WriteLine("Ingrese la opcion de procesador: ");
            op = int.Parse(Console.ReadLine());

            Console
                .WriteLine("Seleccione ahora la opción de memoria (1, 2 o 3).");
            om = int.Parse(Console.ReadLine());

            Console
                .WriteLine("¿Desea agradar el disco por $300 USD? Seleccione 1 (SI) o 2 (NO)");
            od = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    switch (om)
                    {
                        case 1:
                            total = 800;
                            break;
                        case 2:
                            total = 900;
                            break;
                        case 3:
                            total = 1000;
                            break;
                        default:
                            Console.WriteLine("Opcion Invalida.");
                            break;
                    }
                    break;
                case 2:
                    switch (om)
                    {
                        case 1:
                            total = 900;
                            break;
                        case 2:
                            total = 1000;
                            break;
                        case 3:
                            total = 1400;
                            break;
                        default:
                            Console.WriteLine("Opcion Invalida.");
                            break;
                    }
                    break;
                case 3:
                    switch (om)
                    {
                        case 1:
                            total = 1200;
                            break;
                        case 2:
                            total = 1400;
                            break;
                        case 3:
                            total = 2000;
                            break;
                        default:
                            Console.WriteLine("Opcion Invalida.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Opción Invalida, revise nuevamente.");
                    break;
            }

            if (od == 1)
            {
                total = total + 300;
                Console
                    .WriteLine("El importe total + la expansión es de: " +
                    total);
            }
            else
            {
                Console.WriteLine("El importe total es de: " + total);
            }
        }
    }
}
