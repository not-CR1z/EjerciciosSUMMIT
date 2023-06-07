using System;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor Dólares a Pesos Colombianos");
            Conversor convd = new Conversor();
            while (convd.dolar >= 0)
            {
                Console.WriteLine("Por favor ingrese el valor de dólares a convertir");

                try
                {
                    convd.dolar = float.Parse(Console.ReadLine());
                    Console.WriteLine(convd.dolar + " Dólares son " + convd.Dolares() + " Pesos colombianos");
                }
                
                catch(FormatException)
                {
                    Console.WriteLine("igrese un valor válido");
                }

            }
        }
    }

    class Conversor
    {
        public float dolar;
        public float pesos = 4.214f;
        public float Dolares()
        {
            return dolar * pesos;
        }
    }
}
