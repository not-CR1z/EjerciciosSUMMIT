namespace SalarioEmpleado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado("Juan");

            Juan.SALARIO = 1200;
            Juan.SALARIO += 500;
            Console.WriteLine("El salario del em pleado es:" + Juan.SALARIO);
        }
    }


    class Empleado
    {
        public Empleado(string nombre) 
        {
            this.nombre = nombre;
        }

        private double evaluaSalario(double salario)
        {
            if(salario<0)return 0;
            
            else return salario;
        }

        //CREACIÓN DE PROPIEDAD

        public double SALARIO
        {
            get { return this.salario;}
            set { this.salario =evaluaSalario(value);}
        }

        public int MyProperty { get; set; }

        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
            
        }
        public string getApellido()
        {
            return this.apellido;
        }

        private string nombre;
        private double salario;

        private string apellido;
    }
}