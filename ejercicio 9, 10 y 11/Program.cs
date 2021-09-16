using System;

namespace ejercicio_9__10_y_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9)Dadas dos frases concatenarlas y mostrar el resultado. 

             10)Dada una frase cualquiera llamada x, mostrar como resultado una frase
             formada por la segunda mitad de x más la primer mitad de x. (usar el método substring)

             11)Dada una frase informar la cantidad de caracteres que tiene.*/

            // string frase1, frase2;

            Console.WriteLine("\t-- actvidad string -- ");
            Console.WriteLine("\t 1: concatenar frases");
            Console.WriteLine("\t 2: substring de frase");
            Console.WriteLine("\t 3: caracteres de una frase");
            Console.WriteLine("\t 0: terminar programa");

            int opcion = int.Parse(Console.ReadLine());

            while (opcion!=0)
            {
                if (opcion==1)
                {
                    Console.WriteLine("\n-ingrese la primer frase:-");
                    string frase1 = Console.ReadLine();
                    Console.WriteLine("-ingrese la segunda frase:-");
                    string frase2 = Console.ReadLine();

                    Console.WriteLine("\n{0} {1}",frase1, frase2);
                }

                if (opcion==2)
                {
                    Console.WriteLine("\n-ingrese una frase a continuacion:-");
                    string frase = Console.ReadLine();

                    Console.WriteLine("\n{1} {0}",frase.Substring(0, frase.Length / 2), frase.Substring(frase.Length / 2, frase.Length / 2));               
                    
                }

                if (opcion==3)
                {
                    Console.WriteLine("\n-ingrese una frase a continuacion:-");
                    string frase = Console.ReadLine();

                    Console.WriteLine("\nLa frase \n'{0}'\ntiene un total de {1} caracteres",frase,frase.Length);
                }

                Console.WriteLine("\n\n----------------------------------------");
                Console.WriteLine("\t 1: concatenar frases");
                Console.WriteLine("\t 2: substring de frase");
                Console.WriteLine("\t 3: caracteres de una frase");
                Console.WriteLine("\t 0: terminar programa");

                opcion = int.Parse(Console.ReadLine());

            }
            

        }
    }
}
