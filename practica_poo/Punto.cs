class Punto
{
    int x, y;

    public string Iniatialize()
    {
        try
        {
            Console.WriteLine("indique la medida del CA (cateto adyacente)");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("indique la medida del CA (cateto opuesto)");
            y = int.Parse(Console.ReadLine());

            double resultado = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            return $"La hipotenusa del triángulo es igual a {resultado}";
        }
        
        catch(Exception) 
        {
            return "Ingrese un dígito válido";
        }
    }

}
