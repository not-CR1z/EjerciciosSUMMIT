namespace Simulador_de_partidos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa simulador de 4tos de final, para determinar cada partido y la pocisión de los equipos

            Equipos[] Clasificado = new Equipos[8];


            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 5);


            Clasificado[0] = new Equipos ("Argentina", numeroAleatorio);
            Clasificado[1] = new Equipos ("Brasil", numeroAleatorio);
            Clasificado[2] = new Equipos ("Bolivia", numeroAleatorio);
            Clasificado[3] = new Equipos ("Chile", numeroAleatorio);
            Clasificado[4] = new Equipos ("Colombia", numeroAleatorio);
            Clasificado[5] = new Equipos ("Ecuador", numeroAleatorio);
            Clasificado[6] = new Equipos ("Uruguay", numeroAleatorio);
            Clasificado[7] = new Equipos ("Venezuela", numeroAleatorio);


           Equipos Seminifinalista(Equipos[] semifinalista)
            {

                for(int i = 0; i<8;i++)
                {
                    
                }

            }
        }
    }
}