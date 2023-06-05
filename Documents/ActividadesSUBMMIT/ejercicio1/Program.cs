using System;
using System.Timers;

namespace Program
{
    class Program
    {
        static void Main(string[] args)

        {
            checked
            {
                int n1 = 0;
                int numero = int.MaxValue; 5241524
                int resultado = numero + 30;
                Console.WriteLine(resultado);
            }

            //"Random",Bucles While, Do While, Práctica de Exception3206+



            /*  Console.WriteLine("Seleccione un número del 1-100");
              Random numero = new Random();
              int numeroAleatorio = numero.Next(0, 100);

              int miNumero;
              int intentos = 0;

              do
              {
                  try
                  {
                      miNumero = int.Parse(Console.ReadLine());
                  }
                  catch (FormatException ex)
                  {
                      Console.WriteLine("Caracter inválido, lo tomaremos como un '0'");
                      miNumero = 0;
                  }
                  catch (OverflowException ex)
                  {
                      Console.WriteLine("Número muy grande, lo tomaremos como un '0'");
                      miNumero = 0;
                  }


                  intentos++;
                  if (miNumero > numeroAleatorio)
                      Console.WriteLine("Escoge un número más bajo");
                  if (miNumero < numeroAleatorio)
                      Console.WriteLine("Escoge un número más alto");
              }
              while (miNumero != numeroAleatorio);
              Console.WriteLine($"Le atinaste en {intentos} intentos!");
            */




            //newMethod(2, 5);

            //Conversión implicita y explícita

            /*  double example = 2.3;

                int example2 = 2;

                example = (int)example2;

                float temperatura = 27.23F;
                double temeratura2 = temperatura;
                Console.WriteLine(temeratura2);
            */


            //método parse,operaciones en consola y concatenación por interpretación por strings

            /*  Console.WriteLine("Escriba el primer valor");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba el segundo valor");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"El resultado de la suma de {num1} + {num2} va a ser igual a {num1 + num2}");
            */


            //Añadir más argumentos a un parámetro mediante la "," y selección de su pocisión {}

            /*
            int VALOR1 = 1;
            int VALOR2 = 2;   
            int VALOR3 = 3;

            Console.WriteLine("Imprimiendo el número {1}", VALOR1, VALOR2, VALOR3);
            */



        }

        //Método ejemplo básico Void

        /* static void newMethod(int n1, int n2)
         {
             Console.WriteLine($"en este campo irá impreso el valor de la suma entre el {0} y el {n2} cuyo resultado es {n1 + n2}");
         }
        */
    }
}