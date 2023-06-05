using System;

namespace programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un número");

            int numeroMes = int.Parse(Console.ReadLine());
            Console.WriteLine(nombreDelMes(numeroMes));
            Console.WriteLine("Aquí termina el programa");
        }


        public static string nombreDelMes(int mes)
        {

            switch (mes)
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
                case 5:
                    return "Mayo";
                    break;
                case 6:
                    return "Junio";
                    break;
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                    break;
                case 9:
                    return "Septiembre";
                    break;
                case 10:
                    return "Octubre";
                    break;
                case 11:
                    return "Noviembre";
                    break;
                case 12:
                    return "Diciembre";
                    break;

                default:
                    return "Selección inválida";
                    break;

            }
        }
    }
}





