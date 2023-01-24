using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada
            //según los siguientes valores:
            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            // Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el
            //importe final con el descuento que corresponda.
            Console.WriteLine("Hello World!");

            float
                n1,
                calculo;
            float
                p1 = 0.18f,
                p2 = 0.10f;

            Console.WriteLine("Ingrese el importe: ");
            n1 = float.Parse(Console.ReadLine());

            if (n1 >= 5000)
            {
                calculo = n1 - (n1 * p1);
                Console
                    .WriteLine("El monto sería con un 18% de descuento, total: " +
                    calculo);
            }
            else if (n1 >= 1000)
            {
                if (n1 < 5000)
                {
                    calculo = n1 - (n1 * p2);
                    Console
                        .WriteLine("El monto sería con un 10%, total: " +
                        calculo);
                }
            }
            else
            {
                Console
                    .WriteLine("El importe es MENOR A 1000, no hay descuento chupapija. Precio total: " + n1);
            }
        }
    }
}
