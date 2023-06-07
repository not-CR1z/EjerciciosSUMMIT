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
                    Console.WriteLine(convd.Dolares());
                }
                
                catch(FormatException e)
                {
                    Console.WriteLine("igrese un valor válido");
                }

            }
        }
    }

    class Conversor
    {
        public float dolar = 0;
        public float pesos = 4.214f;
        public float Dolares()
        {
            return dolar * pesos;
        }
    }
}
