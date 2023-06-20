using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genéricos
{
    internal class CrearArrays
    {
        public CrearArrays(int z)
        {
            ArrayEjemplo = new object[z];
        }

        public void AgregarArray(object obj)
        {
            ArrayEjemplo[i]=obj;
            i++;
        }
        public object GetArray(int i)
        {
            return ArrayEjemplo[i];
        }


        object[] ArrayEjemplo;
        int i;

    }
}
