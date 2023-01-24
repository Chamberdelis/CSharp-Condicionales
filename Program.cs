using System;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Ingrese la edad: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 >= 18)
            {
                Console.WriteLine("El usuario es MAYOR de edad");
            }
            else
            {
                Console.WriteLine("El usuario es MENOR de edad");
            }
            
        }
    }
}
