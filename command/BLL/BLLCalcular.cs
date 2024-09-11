using Abstraccion;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCalcular
    {
        public bool PuedeCalcular(IOperacion operacion, double valor)
        {
            return !(operacion is Dividir & valor == 0);
        } 
        public double Calcular(IOperacion operacion, double resultado, double valor)
        {
            return operacion.ejecutar(resultado, valor);
        }
    }
}
