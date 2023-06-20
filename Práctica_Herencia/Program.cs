namespace Práctica_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo Babioca = new Caballo("Babieca");
            Persona Juan = new Persona("Juan");
            Gorila Copito = new Gorila("Copito");
            Copito.getNombre();
        }
        
    }

    class Mamiferos
    {
        public Mamiferos(string nombre)
        {
            nombreSerVico = nombre;
        }
        public void getNombre()
        {
            Console.WriteLine($"Mi nombre es: {nombreSerVico}");
        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public void cuidarCria()
        {
            Console.WriteLine("Cuido de mis hijos hasta que vcalgan por sí mismos");
        }
        private string nombreSerVico;
    }

    class Caballo : Mamiferos
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Puedo galopar");
        }
    }
    class Persona : Mamiferos
    {
        public Persona(string nombrePersona) : base(nombrePersona)
        {

        }
        public void pensar()
        {
            Console.WriteLine("Puedo pensar ¿?");
        }
    }
    class Gorila : Mamiferos
    {
        public Gorila(string nombreGorila):base (nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Puedo trepar");
        }
    }
}