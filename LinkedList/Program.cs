namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int numero in new int[] { 10, 8, 6, 4, 2, 0 })
            {
                numeros.AddFirst(numero);
            }

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}


            //for (LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next) ;


            //practica[] ArrayObjeto = new practica[5];



            //ArrayObjeto[0] = new practica("héctor", 1200);
            //ArrayObjeto[1] = new practica("Pepe", 1500);
            //ArrayObjeto[2] = new practica("Juana", 4200);
            //ArrayObjeto[3] = new practica("Juana", 4010);
            //ArrayObjeto[4] = new practica("Juana", 4009);

            //foreach (practica i in ArrayObjeto)
            //{
            //    Console.WriteLine(i.getInfo());
            //}

        }

    }


    //class practica
    //{
    //    public practica(string nombre, double sueldo)
    //    {
    //        this.nombre = nombre;
    //        this.sueldo = sueldo;
    //    }
    //    private string nombre;
    //    private double sueldo;

    //    public string getInfo()
    //    {
    //        return $"Nombre del empleado: {nombre} Sueldo: {sueldo}";
    //    }
    //}
}