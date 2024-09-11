using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Dividir : IOperacion
    {
        public double ejecutar(double valor1, double valor2)
        {
            return valor1 / valor2;
        }
    }
}
