﻿using System;

namespace Ejerciciov5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Hacer un programa para ingresar 4 números.

            //Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
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

            if ((n1 > n2) && (n2 > n3) && (n3 > n4))
            {
                Console.WriteLine("Los numeros estan de forma decreciente.");
            }
            else
            {
                Console.WriteLine("Los numeros NO estan de forma decreciente.");
            }
        }
    }
}
