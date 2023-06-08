using System;

namespace ConceptosPOO
{
    class Punto
    {
        int x, y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Punto()
        {
            this.x = 0;
            this.y = 0;
        }

        public double Distanciahasta(Punto nuevoPunto)
        {
            double xDif = this.x - nuevoPunto.x;
            double yDif = this.y - nuevoPunto.y;
            double resultado = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            return resultado;
        }
    }
}
    
