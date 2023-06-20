namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> edades = new Dictionary<string, int>();

            edades.Add("Ana", 12);
            edades.Add("Jhon", 18);
            edades["Jesús"] = 45;
            edades["Andrea"] = 28;


            foreach(KeyValuePair <string, int> persona in edades) 
            {
                Console.WriteLine($"La eda de {persona.Key} es {persona.Value} años");
            }



            Queue<string> Cola = new Queue<string>();

            Cola.Enqueue("a");
            Cola.Enqueue("b");
            Cola.Enqueue("c");
            Cola.Enqueue("d");

            Console.WriteLine("Imprimiendo colas");

            foreach (string letras in Cola)
            {
                Console.WriteLine(letras);
            }

            Console.WriteLine("Eliminando Colas");

            Cola.Dequeue();

            foreach (string letras in Cola)
            {
                Console.WriteLine();
            }



            Stack<int> Mistack = new Stack<int>();


            //Agregar archivos

            Console.WriteLine("Rellenando Archivos");
            foreach (int stack in new int[4] { 2, 4, 6, 8 })
            {
                Mistack.Push(stack);
            }


            Console.WriteLine("Leyendo Archivos");
            //Lectura de Archivos
            foreach (int stack in Mistack)
            {
                Console.WriteLine(stack);
            }


            Console.WriteLine("Eliminando Archivos");
            //Eliminando Archivo
            Mistack.Pop();
            foreach (int stack in Mistack)
            {
                Console.WriteLine(stack);
            }



        }
    }
}