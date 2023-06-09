class Cubo
{
    static string medidaDeCubo()
    {
        try
        {
            Console.WriteLine("digite la medida de un lado del cubo");
            int medidaLado = int.Parse(Console.ReadLine());
            double resultado = Math.Pow(medidaLado, 2);
            return $"La medida de un cubo cuyos lados miden: {medidaLado} es igual a: {resultado} ^3";
        }
        catch (Exception)
        {
            return "Ingrese un dígito válido";
        }
    }
    public string MedidaDeCubo()
    {
        return medidaDeCubo();
    }
}