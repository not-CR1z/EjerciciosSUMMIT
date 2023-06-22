namespace NuevoDelegadoPredicado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Personas> gente = new List<Personas>();

            Personas P1 = new Personas();
            P1.Nombre = "Juan";
            P1.Edad = 18;


            Personas P2 = new Personas();
            P2.Nombre = "Ana";
            P2.Edad = 34;


            Personas P3 = new Personas();
            P3.Nombre = "maría";
            P3.Edad = 26;

            gente.AddRange(new Personas[] { P1, P2, P3 });

            Predicate<Personas> elPredicado = new Predicate<Personas>(ExisteJuan);

            bool existe = gente.Exists(elPredicado);

            if (existe)
            {
                Console.WriteLine("Si hay personas que se llaman Juan");
            }

            else
            { 
                Console.WriteLine("No hay personas que se llaman Juan"); 
            }
        }

        static bool ExisteJuan(Personas personas)
        {
            if (personas.Nombre == "Juan")
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }


    class Personas
    {

        private string nombre;

        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }


}