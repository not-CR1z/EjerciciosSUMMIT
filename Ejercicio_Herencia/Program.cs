using System.Security.Cryptography.X509Certificates;

namespace Ejercicio_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            avion Boeing = new avion("Boeing757");

            coche Camaro = new coche("Camaro zl1");

            Console.WriteLine(Boeing.getInfo());
            Boeing.Conducir();

            Console.WriteLine(Camaro.getInfo());
            Camaro.Conducir();
        }
    }

    class vehiculo
    {
        public vehiculo(string modelo)

        {
            string modeloVehiculo = modelo;
        }

        protected void arrancarMotor()
        {
            Console.WriteLine("Puedo arrancar mi motor");
        }

        protected void pararaMotor()

        {
            Console.WriteLine("Puedo parar mi motor");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Solo puedo ser conducido por un piloto");
        }
    }

    class avion : vehiculo
    {
        public avion(string modelo) : base(modelo)
        {
            Modelo = modelo;
        }
        public override void Conducir()
        {
            Console.WriteLine("Puedo conducir con un piloto o en automático");
        }
        string Modelo;
        public string getInfo()
        {
            return $"Soy un {Modelo}";
        }

    }
    class coche : vehiculo
    {
       public coche(string modelo) : base(modelo)
        {
            Modelo = modelo;
        }
        public string getInfo()
        {
            return $"Soy un {Modelo}";
        }
        string Modelo;
    }
}