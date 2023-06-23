using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_partidos
{
    internal class Equipos
    {
        public Equipos(string seleccion, int goles)
        {
            this.seleccion = seleccion;
            this.goles = goles;
        }

        string seleccion;
        int goles;
    }
}
