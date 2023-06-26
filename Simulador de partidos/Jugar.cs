using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO2306
{
    internal class Jugar
    {
        public string[] selecciones = new string[2];
        public string Jugando() 
        {
            Console.WriteLine($"{selecciones[0]} vs {selecciones[1]}");

            int equipo1, equipo2;

            {
                Random goles = new Random();
                equipo1 = goles.Next(0,5);
                equipo2 = goles.Next(0,5);
            }



            if (equipo1 > equipo2)
            {
               string mensaje = $"Resultado final: {selecciones[0]} {equipo1} - {equipo2} {selecciones[1]}";
                Console.WriteLine(mensaje);
                return selecciones[0];
            }

            else if (equipo1 == equipo2)
            {
               string mensaje = $"Resultado final: {selecciones[0]} {equipo1} - {equipo2} {selecciones[1]} (Selección {selecciones[0]} ganó tandas de penaltis)";
                Console.WriteLine(mensaje);
                return selecciones[0];
            }

            else
            { 
                string mensaje = $"Resultado final: {selecciones[0]} {equipo1} - {equipo2} {selecciones[1]}";
                Console.WriteLine(mensaje);
                return selecciones[1];

            }

        }
    }
}
