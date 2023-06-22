namespace PiedraPapelTijera
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Juego de Piedra, Papel o Tijera");

            Console.WriteLine("\n 1.Pieda \n 2.Papel \n 3.Tijera");

           void Jugando()
            {
                Jugador1 Jugador1 = new Jugador1();

                Jugador2 Jugador2 = new Jugador2();

                Conclusion conclusion = new Conclusion();

            }

            while (Jugando != null)
            {
                Jugando();
            }



        }
    }
}