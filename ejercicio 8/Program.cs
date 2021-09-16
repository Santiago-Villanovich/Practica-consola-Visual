using System;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag=1;

            while (flag!=0)
            {
                int numero = 0, fact = 1;
                do
                {
                    Console.WriteLine("Digite el numero positivo del que desea calcular factorial:");
                    numero = int.Parse(Console.ReadLine());

                    if (numero<0)
                    {
                        Console.WriteLine("Error en el numero ingresado\n\n");
                    }
                } while (numero<0);

                for (int i = numero; i >= 1; i--)
                {
                    fact *= i;
                }

                Console.WriteLine("{0}! = {1}", numero, fact);

                Console.WriteLine("\n-Para ingresar otro numero digite 1\n-Para terminar el programa digite 0");
                flag = int.Parse(Console.ReadLine());
                Console.Clear();
                
            }


            
            
        }
    }
}
