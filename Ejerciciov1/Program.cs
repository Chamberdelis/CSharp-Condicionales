using System;

namespace Ejerciciov1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Hacer un programa que solicite el ingreso de dos números y luego calcular:
            // La resta si el primero es mayor que el segundo.
            // La suma si son iguales.
            // El producto si el primero es menor.
            // Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            int
                n1,
                n2,
                operacion;

            Console.WriteLine("Ingrese el primer numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                operacion = n1 - n2;
                Console.WriteLine("La resta da como resultado: " + operacion);
            }
            else if (n1 == n2)
            {
                operacion = n1 + n2;
                Console.WriteLine("La suma es: " + operacion);
            }
            else
            {
                operacion = n1 * n2;
                Console.WriteLine("El producto de ambos es: " + operacion);
            }
        }
    }
}
