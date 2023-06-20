using System.Timers;

namespace Avisos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico Av1 = new AvisosTrafico();
            Av1.mostrarAviso();

            AvisosTrafico Av2 = new AvisosTrafico("DGT", "su coche ha sido enbargado", "El 10 de junio");
            Console.WriteLine(Av2.getFecha());
            Av2.mostrarAviso();
        }
    }
}