class Circulo
{
    private double pi = Math.PI;

    public string calculoArea()
    {
        Console.WriteLine("Igrese la longitud del radio");
        int radio = int.Parse(Console.ReadLine());

        while (radio >= 0)
        {
            try
            {
                double function = pi * Math.Pow(radio, 2);

                return ($"el area de un circulo con un radio de: {radio} es igual a: {function} ");

            }
            catch (Exception)
            {
                return "Selección no válida";
            }
        }
        return "opción inválida";

    }

    public string CalculoArea()
    {
        return calculoArea();
    }

}
