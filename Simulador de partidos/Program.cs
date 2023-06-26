namespace PracticaPOO2306
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encuentros Cuartos de final
            string[] match1 = { "Argentina", "Venezuela" };
            string[] match2 = { "Brasil", "Chile" };
            string[] match3 = { "Colombia", "Perú" };
            string[] match4 = { "Bolivia", "Ecuador" };

            //Afición



            Jugar M1 = new Jugar();
            Jugar M2 = new Jugar();
            Jugar M3 = new Jugar();
            Jugar M4 = new Jugar();

            Jugar S1 = new Jugar();
            Jugar S2 = new Jugar();

            Jugar champion = new Jugar();


            M1.selecciones = match1;
            string clasificado1 = M1.Jugando();
            Console.WriteLine($"Avanza {clasificado1}");

            M2.selecciones = match2;
            string clasificado2 = M2.Jugando();
            Console.WriteLine($"Avanza {clasificado2}");


            M3.selecciones = match3;
            string clasificado3 = M3.Jugando();
            Console.WriteLine($"Avanza {clasificado3}");


            M4.selecciones = match4;
            string clasificado4 = M4.Jugando();
            Console.WriteLine($"Avanza {clasificado4}");




            string[] semis1 = { clasificado1, clasificado2 };

            string[] semis2 = { clasificado3, clasificado4 };


            S1.selecciones= semis1;
            string finalista1 = S1.Jugando();
            Console.WriteLine($"Avanza {finalista1}");

            S2.selecciones = semis2;
            string finalista2 = S2.Jugando();
            Console.WriteLine($"Avanza {finalista2}");


            string[] final = { finalista1, finalista2 };

            champion.selecciones= final;
            string Champion = champion.Jugando();
            Console.WriteLine($"\nEl campeón es {Champion}");

        }
    }
}