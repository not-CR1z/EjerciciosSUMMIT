using System.Threading.Channels;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numeros = new List<int>(); //Declaración de lista 

            Console.WriteLine("Introduce elementos en la colección ('0' para salir)");

            int elem = 1;
            while (elem != 0)
            {
                elem = int.Parse(Console.ReadLine());

                Numeros.Add(elem);
            }
            Console.WriteLine("Elementos introducidos; ");

            foreach (int elemento in Numeros)
            {
                Console.WriteLine(elemento);
            }

        }
    }
}