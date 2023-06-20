using Genéricos;
using System;

namespace Practica_Genericos;

class program
{
    static void Main(string[] args)
    {
        CrearArrays NuevoArray = new CrearArrays(5);


        NuevoArray.AgregarArray("pocision 0");
        NuevoArray.AgregarArray("pocisión 1");
        NuevoArray.AgregarArray("pocision 2");
        NuevoArray.AgregarArray("pocisión 3");
        NuevoArray.AgregarArray("pocision 4");

        object pocision = NuevoArray.GetArray(3);
        Console.WriteLine(pocision);

    }

}
