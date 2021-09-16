using System;

namespace Ejercicio_1_y_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dados dos valores ingresados por teclado mostrar la suma de ambos.
            // Desarrollar una aplicación de consola que tomando 2 números informe cuantos números hay entre los dos.


            int opcion = 0;
            Console.WriteLine("Elija el ejercicio, 1 o 2: ");
            opcion = int.Parse(Console.ReadLine());

            while (opcion != 0)
            {
                if (opcion == 1)
                {
                    int Numero = 0;
                    int Numero2 = 0;

                    Console.WriteLine("Ingrese un número por favor: ");
                    Numero = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese otro número por favor: ");
                    Numero2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("La suma es {0} ", Numero + Numero2);
                    Console.ReadKey();
                }

                if(opcion == 2)
                {
                    int Numero3 = 0;
                    int numero4 = 0;
                    int cont = 1;

                    Console.WriteLine("Ingrese un numero por favor: ");
                    Numero3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese otro numero por favor: ");
                    numero4 = int.Parse(Console.ReadLine());

                    for (int i = Numero3; i < numero4; i++)
                    {
                        cont++;
                    }

                    Console.WriteLine("La cantidad es de {0} numeros",cont);

                }

                Console.WriteLine("/nPara terminar el programa presione 0, sino 1 o 2 para los respectivos ejercicios");
                opcion = int.Parse(Console.ReadLine());
            }

            

        }
    }
}
