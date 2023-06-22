namespace PiedraPaleTijeranew
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int seleccion1 = 1;

            while (seleccion1 != 0)
            {


                Console.WriteLine("\n\nJuego Piedra Papel o Tijera\n\n 1.Piedra \n 2.Papel \n 3.Tijera \n 0.Salir");


                Console.WriteLine("\nJugador 1, Marque una opción:");


                 seleccion1 = int.Parse(Console.ReadLine());



                switch (seleccion1)
                {
                    case 1:
                        Console.WriteLine("Seleccionaste Piedra");
                        break;


                    case 2:
                        Console.WriteLine("Seleccionaste Papel");
                        break;



                    case 3:
                        Console.WriteLine("Seleccionaste Tijera");
                        break;


                    default:
                        Console.WriteLine("Seleccione un digito valido");
                        break;

                }


                Console.WriteLine("\nJugador 2, Marque una opción:");


                int seleccion2 = int.Parse(Console.ReadLine());

                switch (seleccion2)
                {
                    case 1:
                        Console.WriteLine("Seleccionaste Piedra");
                        break;


                    case 2:
                        Console.WriteLine("Seleccionaste Papel");
                        break;



                    case 3:
                        Console.WriteLine("Seleccionaste Tijera");
                        break;

                }

                Console.Read();
                Console.Read();

                string[] MensajeVs = {"","Piedra", "Papel", "Tijera"};
                Console.WriteLine ($"\nJugador 1: {MensajeVs[seleccion1]} VS Jugador 2: {MensajeVs[seleccion2]}\n");

                


                if (seleccion1 == seleccion2)
                {
                    Console.WriteLine("\nEmpate");
                }
                else if (seleccion1 == 2 && seleccion2 < 2)
                {
                    Console.WriteLine("\nJugador 1 gana!");
                }
                else if (seleccion1 > 2 && seleccion2 == 2)
                {
                    Console.WriteLine("\nJugador 1 gana!");
                }
                else if (seleccion1 < 2 && seleccion2 > 2)
                {
                    Console.WriteLine("\nJugador 1 gana!");
                }
                else
                {
                    Console.WriteLine("\nJugador 2 gana!");
                }

                
                Console.WriteLine("Enter para continuar...");

                Console.Read();
                Console.Read();

            }
        }
    }
}