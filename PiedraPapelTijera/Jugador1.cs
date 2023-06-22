using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijera
{
    internal class Jugador1
    {

        private int J1 = int.Parse(Console.ReadLine());


        public Jugador1() 
        {
            Console.WriteLine("Opción Jugador 1");

            if (J1 == 1)
            {
                Console.WriteLine($"El jugador ha serleccionado Piedra");
            }

            else if (J1 == 2)
            {
                Console.WriteLine($"El jugador ha serleccionado Papel");   
            }

            else if (J1 == 3)
            {
                Console.WriteLine($"El jugador ha serleccionado Tijera");
            }

            else
            {
                Console.WriteLine("Selección no valida");
            }
        }

        public int getInfo1()
        {
            return J1;
        }
    }
}
