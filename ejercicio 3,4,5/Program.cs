using System;

namespace ejercicio_3_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 3
              Dados los lados de un triangulo calcular el perímetro.

              Ejercicio 4
              Dados los datos necesarios de un Cuadrado calcular la superficie.

              Ejercicio 5
              Dados los datos necesarios de un Rectángulo calcular la superficie.*/

            int opcion = 0;
            
            Console.WriteLine("-- Calcular perimetro o superficie -- ");
            Console.WriteLine("\t 1: Perimetro de un triangulo");
            Console.WriteLine("\t 2: Superficie de un cuadrado");
            Console.WriteLine("\t 3: Superficie de un rectangulo");

            opcion = int.Parse(Console.ReadLine());

            while (opcion != 0)
            {
                Console.Clear();

                if (opcion==1)
                {   
                    int A =0, B =0, C =0;
                    

                    Console.WriteLine("\nIngrese el lado A del triangulo:");
                    A = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el lado B del triangulo:");
                    B = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el lado C del triangulo:");
                    C = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nEl perimetro de su triangulo es de {0}cm", A + B + C);
                }
         
                if (opcion==2)
                {
                    int lado =0 ;

                    Console.WriteLine("\nIngrese la base del cuadrado:");
                    lado = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nLa superficie de su cuadrado es de {0}cm", lado*lado);
                }

                if (opcion==3)
                {
                    int Base = 0, altura = 0;

                    Console.WriteLine("\nIngrese la base del rectangulo:");
                    Base = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del rectangulo:");
                    altura = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nLa superficie de su cuadrado es de {0}cm", Base * altura);
                }

                Console.WriteLine("\n\n-- Para hacer un nuevo calculo seleccione alguna de las opciones --");
                
                Console.WriteLine("\t 1: Perimetro de un triangulo");
                Console.WriteLine("\t 2: Superficie de un cuadrado");
                Console.WriteLine("\t 3: Superficie de un rectangulo");
                Console.WriteLine("\n\t 0: Cerrar programa");

                opcion = int.Parse(Console.ReadLine());
            }

        }
    }
}
