using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
            // OTRA FORMA MAS SENCILLA ES:
            // Agregar a las variables definidas una llamada menor.
            // if (a < b){
            //   menor = a
            //}
            //else{
            //    menor = b
            //}
            //if (c < menor){
            //    menor = c

            //}
            //else {
            //    menor = d
            //}
            int
                n1,
                n2,
                n3,
                n4;

            Console.WriteLine("Ingrese el primer numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero: ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto numero: ");
            n4 = int.Parse(Console.ReadLine());

            if (n1 < n2)
            {
                if (n1 < n3)
                {
                    if (n1 < n4)
                    {
                        Console.WriteLine(" El menor de los cuatro es: " + n1);
                    }
                    else
                    {
                        Console.WriteLine("El menor es: " + n4);
                    }
                }
                else if (n3 < n4)
                {
                    Console.WriteLine("El menor es: " + n3);
                }
                else
                {
                    Console.WriteLine("El menor es: " + n4);
                }
            }
            else if (n2 < n3)
            {
                if (n2 < n4)
                {
                    Console.WriteLine("El menor es: " + n2);
                }
                else
                {
                    Console.WriteLine(" El menor es: " + n4);
                }
            }
            else if (n3 < n4)
            {
                Console.WriteLine("El menor es: " + n3);
            }
            else
            {
                Console.WriteLine("El menor es: " + n4);
            }
        }
    }
}
