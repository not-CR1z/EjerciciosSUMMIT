namespace DelegadoPredicado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();

            listaNumeros.AddRange(new int[] { 1,2,3,4,5,6,7,8,9,10 });


            //Declaración de delegado predicado

            Predicate<int> eldelegadoPred = new Predicate<int>(DamePares);

            //Creación de lista para el uso del find all (FindAll nos devuelve una lisrta con las condiciones que le hayamos establecido - Método en .Net)

            List<int> numPares = listaNumeros.FindAll(eldelegadoPred);

            //Foreach para recorrer la lista creaa por FindAll

            foreach (int i in numPares) 
            {
                Console.WriteLine(i);
            }
        }

        static bool DamePares(int num)
        {

            if (num % 2 == 0) return true;
            else return false;
            
        }
    }
}