using System;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Si 1Byte tiene 8 bits, desarrolle una solución programática que permita calcular
               cuántos bits hay en cualquier combinación de x KBytes.
               Explique cómo llegó a esa conclusión. */

            // 1kb = 1024 bytes = 8192 (byyte * 8) bits entonces se multiplica la cantidad ingresada por 1024 y luego por 8

            float kb = 0, bytes = 0, b = 0;

            Console.WriteLine("Ingrese la cantidad de kb a calcular");
            kb = float.Parse(Console.ReadLine());

            bytes = (kb * 1024);
            b = (kb * 1024) * 8;

            Console.WriteLine("{0}kb son {2} bytes o {1} bits", kb, b, bytes);
        }
    }
}
