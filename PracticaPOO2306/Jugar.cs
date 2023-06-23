using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO2306
{
    internal class Jugar
    {
        Random ganador = new Random();
        public string[] selecciones = new string[2];
        public string Jugando() 
        {
            Console.WriteLine($"{selecciones[0]} vs {selecciones[1]}");

            int clasificado = ganador.Next(0,2);

            Console.WriteLine($"El ganador es: {selecciones[clasificado]}\n");

            return selecciones[clasificado];
        }
    }
}
