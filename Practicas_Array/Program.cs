namespace Practicas_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ArrayEmleados = new string[4];

            ArrayEmleados[0]= "Ana";
            ArrayEmleados[1]= "Andrés";
            ArrayEmleados[2]= "Alexis";
            ArrayEmleados[3]= "Arturo";

            Metodo LeerEmpleados= new Metodo();

            LeerEmpleados.MetodoSobreArray(ArrayEmleados);

            foreach (string str in ArrayEmleados)
            {
                Console.WriteLine(str);
            }
        }

    }
}