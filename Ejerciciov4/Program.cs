using System;

namespace Ejerciciov4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //  Hacer un programa para ingresar tres números y

            //emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.
            int
                n1,
                n2,
                n3,
                suma,
                producto;

            Console.WriteLine("Ingrese el primr numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero: ");
            n3 = int.Parse(Console.ReadLine());

            suma = n1 + n2;
            producto = n2 * n3;

            if (suma > producto)
            {
                Console
                    .WriteLine(" La suma de N1 y N2 es mayor al producto de N2 X N3: " +
                    suma +
                    " VS " +
                    producto);
            }
            
        }
    }
}
