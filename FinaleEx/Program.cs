using System;

namespace AreaCirculo
{
    class Program
    {

        static public void Main(String[] args)
        {

            Console.WriteLine("Conversor de Dólares a peos Colombianos - Para salir de consola digite 'salir' ");
            Console.WriteLine("Por favor ingrese la cantidad de Dólares");

            ConversorPesosDolar cambio;
            cambio = new ConversorPesosDolar();
            Console.WriteLine(cambio.dolar + " Dólares son " + cambio.CambioDeMoneda() + "Pesos Colombianos");


            //Creación de objeto tipo Circulo/Instanciación de una clase

            /*   circulo miCirculo;
               miCirculo = new circulo();

               Console.WriteLine("El area del circulo es igual a: " + miCirculo.area(10));
            */
        }

    }

    class ConversorPesosDolar
    {

        public double dolar = double.Parse(Console.ReadLine());
        double pesos = 4286.48;
        public double CambioDeMoneda()
        { 
            return pesos * dolar;
        }

    }


    //Practica creación de objeto tipo Clase (Propiedad y Método)

    /* 
    class circulo
    {
        const double pi = 3.1426;

        public double area (int radio)
        {
            return pi * radio * radio;
        }

    }

    */
}

/*     Console.WriteLine("Practica finally");
     System.IO.StreamReader archivo = null;


     try
     {
         string linea;
         //int contador = 0;

         string path = @"D:\Users\cdurangoh\Documents\ActividadesSUBMMIT\finally.txt";

         archivo = new System.IO.StreamReader(path);

         while ((linea=archivo.ReadLine()) != null)
         {
             Console.WriteLine(linea);

             //contador++;

         }
     }
     catch (Exception e)
     {
         Console.WriteLine("Error en la lectura");
     }
     finally
     {
         if (archivo != null) archivo.Close();
         Console.WriteLine("Conexión cerrada");
     }
 }
*/

