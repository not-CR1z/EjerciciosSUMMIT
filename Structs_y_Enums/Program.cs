namespace Structs_y_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1200, 300);
            empleado1.CambiaSalarrio(empleado1, 300);
            Console.WriteLine(empleado1.ToString());
        }

       public class Empleado
        {
            public double salarioBase, comision;
            
            public Empleado(int salarioBase, int comision)
            {
                this.salarioBase = salarioBase;
                this.comision = comision;
            }

            public override string ToString()
            {
                return string.Format("salario y comision del empleado({0},{1}))", this.salarioBase, this.comision);
            }


            public void CambiaSalarrio(Empleado emp, double incremento)
            {
                emp.salarioBase += incremento;
                emp.comision += incremento;
            }
        }

    }
}