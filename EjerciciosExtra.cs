using System;
namespace EstructuraSwitch
{
    class Program
    {
        public static void Main(string[] args)
        {

        }



       //REPASAR LLAMADO A MÉTODOS DESDE MAIN!! 

       /*
        public static void Main(string[] args)
        {
                Console.WriteLine("Escoge un mes del año");

            int NumeroMes = int.Parse(Console.ReadLine());
            Console.WriteLine(MesSeleccionado(NumeroMes));
        }


        public static string MesSeleccionado(int mes)
        {
            
            switch(mes)
            {
                case 1:
                    return "Enero";
                    break;

                case 2:
                    return "Febrero";
                    break;

                case 3:
                    return "Marzo";
                    break;

                case 4:
                    return "Abril";
                    break;

                default:
                    return "selección inválida";
                    break;

            }
        }

            */
        /*
        Console.WriteLine("Caso Fizzbuzz");

            int v1 = 0;

            while (v1< 101)
            {
                v1++;

                if (v1 % 3 == 0 && v1 % 5 == 0) Console.WriteLine("fizzbuzz");
                else if (v1 % 3 == 0) Console.WriteLine("fizz");
                else if (v1 % 5 == 0) Console.WriteLine("buzz");
                else Console.WriteLine(v1);
            }
            */

    //Ejercicio "Adivinar el número"

    /*    Random numero = new Random();
        int numeroAleatorio = numero.Next(0, 100);

        Console.WriteLine("Escoge un número del 1-100");
        int miNumero = 101;
        int intentos = 0;

        while (numeroAleatorio != miNumero)
        {
            miNumero = int.Parse(Console.ReadLine());
            intentos++;

            if (numeroAleatorio < miNumero) Console.WriteLine("Escoge un número más pequeño");
            else if (numeroAleatorio > miNumero) Console.WriteLine("Escoge un número más grande");
            else if (numeroAleatorio==miNumero) Console.WriteLine();
            else Console.WriteLine("Selección inválida");
        }

        Console.WriteLine($"Felicidades {miNumero} es el número correcto!");
        Console.WriteLine($"{intentos} intentos");
    */


    //caso1

    /*  string respuesta = Console.ReadLine();
       Console.WriteLine("Bucle WHILE");

       Console.WriteLine("¿deseas continuar?");
       respuesta = Console.ReadLine();

       while (respuesta != "no")
       {
           Console.WriteLine("vas a continuar con el proceso");

           Console.WriteLine("¿Cuál es tu nombre?");
           string nombre = Console.ReadLine();

           Console.WriteLine($"ok, {nombre} para terminar con el proceso escribe 'no'");
           respuesta = Console.ReadLine();

       }
       Console.WriteLine("Fin del bucle"); 
       */


    /* Console.WriteLine("Selecciona un país");
     Console.WriteLine("1. Colombia, 2. Bolivia, 3. México, 4. Argentina");

     string pais = Console.ReadLine();

     switch (pais)
     {
         case "1":
             Console.WriteLine("La capital de Colombia es Bogotá");
             break;
         case "2":
             Console.WriteLine("La capital de Bolivia es La Paz");
             break;
         case "3":
             Console.WriteLine("La capital de México es CD México");
             break;
         case "4":
             Console.WriteLine("La capital de Argentina es Buenos Aires");
             break;
         default:
             Console.WriteLine("selección inválida");
             break;

     }
     Console.WriteLine("ha terminado el programa"); */
}
}