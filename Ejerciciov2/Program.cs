using System;

namespace Ejerciciov2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Un importante negocio de desinfectante líquido realiza
            //descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
            // Si vende menos de 100 litros, no hay descuento.
            // Si vende entre 101 y 300 litros, el descuento es del 10%.
            // Si vende entre 301 y 500 litros, el descuento es del 15%.
            // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            // Hacer un programa que solicite el ingreso del importe total de la venta y
            //la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado.
            float
                importe,
                litros,
                operacion;

            Console.WriteLine("Ingrese el importe total: ");
            importe = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los litros totales: ");
            litros = float.Parse(Console.ReadLine());

            if (litros > 500)
            {
                operacion = importe - (importe * 0.25F);
                Console
                    .WriteLine("Se aplico un descuento del 25%, importe final: " +
                    operacion);
            }
            else if (
                litros >= 301 && litros <= 500 // O TAMBIEN if (litros > 300)
            )
            {
                operacion = importe - (importe * 0.15F);
                Console
                    .WriteLine("Se aplico un descuento del 15%, importe final: " +
                    operacion);
            }
            else if (
                litros >= 101 && litros <= 300 // O TAMBIEN if(litros > 100)
            )
            {
                operacion = importe - (importe * 0.10F);
                Console
                    .WriteLine("Se aplico un descuento del 10%, importe final: " +
                    operacion);
            }
            else
            {
                Console
                    .WriteLine("No se aplico descuento, importe final: " +
                    importe);
            }
        }
    }
}
