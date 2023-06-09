class Cuadrado
{
    string calculoArea()
    {
        try
        {
            Console.WriteLine("digita la medida de un lado del cuadrado");
            double longitud = double.Parse(Console.ReadLine());
            double operacion = Math.Pow(longitud, 2);
            return $"El área de un cuadrado un cuyos lados miden {longitud} es de: {operacion} ^2";
        }
        catch (Exception)
        {
            return "Ingrese un dígito válido";

        }
    }

    public string CalculoArea()
    {
        return calculoArea();
    }
}