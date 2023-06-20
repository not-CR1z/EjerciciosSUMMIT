namespace Repaso_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ArraysMain = ArraysDeUsuario();
            Console.WriteLine("Datos creados en Main");
            foreach (int i in ArraysMain)
            { 
                Console.WriteLine(i);
            }
        }
        static int[] ArraysDeUsuario()
        {
            Console.WriteLine("¿Cuántos Arrays quieres que contenga?");
            string RespuestaDeUsario = Console.ReadLine();
            int Respúesta_Int = int.Parse(RespuestaDeUsario);
            int[] Valor_Crear = new int[Respúesta_Int];

            for(int i = 0; i < Valor_Crear.Length; i++)
            {
                Console.WriteLine($"¿Qué quieres que contenga la pocisión {i}?");
                string ValorIntroducido=Console.ReadLine();
                int ValorIntroducido_int=int.Parse(ValorIntroducido);
                Valor_Crear[i] = ValorIntroducido_int;              
            }


            return Valor_Crear;
        }
    }
}