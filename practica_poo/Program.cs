namespace practica_poo2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Circulo MiCirculo = new Circulo(); //Objeto clase circulo

            Cuadrado MiCuadrado = new Cuadrado(); //objeto clase cuadrado

            Cubo MiCubo = new Cubo();//Objeto clase Cubo

            Punto distanciaCa = new Punto(); //Cateto adyacente
            Punto distanciaCo = new Punto(); //Cateto Opuesto


            int calculo = 0;
            while (calculo <= 4)
            {
                Console.WriteLine("\nCALCULADORA DE MAGNITUDES");
                Console.WriteLine("\n 1.Calcular área de un circulo\n 2.Calcular área del cuadrado\n 3.Calcular área de un cubo\n 4.Calcular la hipotenusa");

                calculo = int.Parse(Console.ReadLine());

                switch (calculo)

                {
                    case 1:
                        Console.WriteLine("Vas a medir el area de un círculo");
                        Console.WriteLine(MiCirculo.CalculoArea());
                        break;

                    case 2:
                        Console.WriteLine("Vas a medir el area de un cuadrado");
                        Console.WriteLine(MiCuadrado.CalculoArea());
                        break;


                    case 3:
                        Console.WriteLine("Vas a obtener un area cubica");
                        Console.WriteLine(MiCubo.MedidaDeCubo());
                        break;

                    case 4:
                        Console.WriteLine("Usted va a determinar el valor de la hipotenusa");
                        Console.WriteLine(distanciaCa.Iniatialize());
                        break;

                    default:
                        Console.WriteLine("seleción inválida");
                        break;
                }
                }

            } 

            
    }
}