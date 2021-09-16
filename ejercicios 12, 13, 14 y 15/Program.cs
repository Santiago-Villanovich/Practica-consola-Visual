using System;

namespace ejercicios_12__13__14_y_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*12)Mostrar la fecha y hora actual.

              13)Dada una fecha mostrarla en el formato AAAAMMDD.

              14)Dadas dos fechas calcular la diferencia en días entre una y la otra.

              15)Informar cuantos días faltan para el 25 / 12 / 2021.*/

            Console.WriteLine("\t-- actvidad date -- ");
            Console.WriteLine("\t 1: fecha y hora actual");
            Console.WriteLine("\t 2: fecha en AAAA/MM/DD");
            Console.WriteLine("\t 3: dias entre dos fechas");
            Console.WriteLine("\t 4: dias faltantes para 25/12/2021");

            int opcion = int.Parse(Console.ReadLine());

            while (opcion!=0)
            {
                if (opcion==1)
                {
                    Console.WriteLine("\nla fecha y hora actual es: {0}", DateTime.Now);
                }

                if (opcion==2)
                {
                    DateTime fecha = DateTime.Now;
                    
                    Console.WriteLine("\n{0}/{1}/{2}",fecha.Year,fecha.Month,fecha.Day); 
                }

                if (opcion==3)
                {
                   Console.WriteLine("\nIngrese la primer fecha con formato dd/mm/aaaa : ");
                   DateTime fecha1 = DateTime.Parse(Console.ReadLine());
                   Console.WriteLine("Ingrese la segunda fecha con formato dd/mm/aaaa : ");
                   DateTime fecha2 = DateTime.Parse(Console.ReadLine());
                   
                   int cont = 0;
                   
                    do
                    {
                        cont++;
                        fecha1= fecha1.AddDays(1);
                        
                    } while (fecha1<fecha2);

                    Console.WriteLine("\nLa cantidad de dias entre las fechas es {0}",cont);
                }

                if (opcion==4)
                {
                   int cont = 0;
                   DateTime fecha = DateTime.Now;
                   var limite = new DateTime(2021,12,25);

                    if (fecha<limite)
                    {
                        do
                        {
                            cont++;
                            fecha = fecha.AddDays(1);

                        } while (fecha < limite);
                    }
                    else
                    {
                        
                    }
                    

                    Console.WriteLine("\nLa cantidad de dias hasta el 25/12/2021 es de {0} dias", cont);
                }

                Console.WriteLine("\n\n----------------------------------------");
                Console.WriteLine("\n\t 1: fecha y hora actual");
                Console.WriteLine("\t 2: fecha en AAAA/MM/DD");
                Console.WriteLine("\t 3: dias entre dos fechas");
                Console.WriteLine("\t 4: dias faltantes para 25/12/2021");

                opcion = int.Parse(Console.ReadLine());
            }
        }
    }
}
