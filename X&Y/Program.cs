using System;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }
        static void realizarTarea()
        {
            Punto distanciax = new Punto();
            Punto distanciay = new Punto( ,100);
            double ResultadoDistancia = distanciax.Distanciahasta(distanciay);
            Console.WriteLine($"La distancia de los puntos es igual a :{ResultadoDistancia}");

        }

    }
}