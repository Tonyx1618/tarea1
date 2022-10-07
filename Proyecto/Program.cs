using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Program
    {
        private static void Main(string[] args) // void Para procedimientos
        {
            // Tipos de datos
            // Leccio 1

            int num1, num2;
            byte opcion = 0;
/*
            Console.WriteLine("Digite un valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro valor: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Suma de {0} + {1} = {2}", num1, num2, (num1 + num2));//Parametro
            Console.WriteLine("Suma de "+num1+" + "+num2+" es"+" "+(num1+num2)); //Concatenar
            Console.WriteLine($"Suma de {num1} + {num2} = {num1+num2}");//Referencia
            */
            //Console.Read();//Hace que la consola espere a que se le de enter para cerrarce
            
            // Condiciones y ciclos 
            /*
            if (num1 > num2)
            {
                Console.WriteLine("{0} es mayor que {1}", num1,num2);
            }
            else
            {
                Console.WriteLine("{0} es mayor que {1}", num1,num2);
            }
           */

            do
            {
                opcion = 1;
                Console.WriteLine("Digite un valor: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite otro valor: ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Suma de {0} + {1} = {2}", num1, num2, (num1 + num2));//Parametro
                Console.WriteLine("Suma de " + num1 + " + " + num2 + " es" + " " + (num1 + num2)); //Concatenar
                Console.WriteLine($"Suma de {num1} + {num2} = {num1 + num2}");//Referencia

                //Console.Read();//Hace que la consola espere a que se le de enter para cerrarce

                // Condiciones y ciclos 
                //if, do while

                if (num1 > num2)
                {
                    Console.WriteLine("{0} es mayor que {1}", num1, num2);
                }
                else
                {
                    Console.WriteLine("{0} es mayor que {1}", num1, num2);
                }
                Console.WriteLine("Digite una opcion 1-Continuar o 2-Salir");
                opcion = byte.Parse(Console.ReadLine());

              

            } while (opcion != 2);

            Console.Read();
        }
    }
}


