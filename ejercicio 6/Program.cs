using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Si la circunferencia de un círculo es pi * Diámetro,
              desarrollar una aplicación que dada la circunferencia
              calcule el diámetro.*/

            float circunferencia = 0;

            Console.WriteLine("Ingrese el valor de la circunferencia a calcular");
            circunferencia = int.Parse(Console.ReadLine());

            Console.WriteLine("El diametro de su circunferencia es de {0}", circunferencia / 3, 1416);
        }
    }
}
