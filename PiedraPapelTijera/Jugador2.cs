using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijera
{
    internal class Jugador2
    {

        int J2 = int.Parse(Console.ReadLine());


        public Jugador2()
        {
            Console.WriteLine("Opción Jugador 2");
       
            if (J2 == 1)
            {
                Console.WriteLine($"El jugador ha serleccionado Piedra");
            }

            else if (J2 == 2)
            {
                Console.WriteLine($"El jugador ha serleccionado Papel");
            }

            else if (J2 == 3)
            {
                Console.WriteLine($"El jugador ha serleccionado Tijera");
            }

            else
            {
                Console.WriteLine("Selección no valida");
            }
        }


        public int getInfo2()
        {
            return J2;
        }
    }
}
