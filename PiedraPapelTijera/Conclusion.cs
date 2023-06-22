using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijera
{
    internal class Conclusion
    {


        public Conclusion() 
        {
            Jugador1 resultado1 = new Jugador1();
            Jugador2 resultado2 = new Jugador2();

            if (resultado1.getInfo1 == resultado2.getInfo2)
            {
                Console.WriteLine("Empate");
            }

            
        }
    }
}
