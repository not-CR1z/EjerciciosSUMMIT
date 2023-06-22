using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "Mi nombre es Juan y mi n° de tlfno es (+57)123-45-67 y mi código postal es 3232564";

            string patron = @"\d{3}-\d{2}";

            Regex MiRegex = new Regex(patron);

            MatchCollection elMatch= MiRegex.Matches(frase);
           
            if (elMatch.Count > 0)
           
            {
                Console.WriteLine("Se han encontrado números");
            }
           
            else Console.WriteLine("No se han encontrado números");

        }
    }
}