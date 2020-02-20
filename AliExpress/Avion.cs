using System;
using System.Collections.Generic;
using System.Text;
using AliExpress.Interfaces;

namespace AliExpress
{
    class Avion : ITransporte
    {
        public double calcularCostoEnvio(double dDistancia, double dMargenUtilidad)
        {
            double dCostoEnvio = (10 * dDistancia) * (1 + dMargenUtilidad);

            return dCostoEnvio;

        }

        public DateTime calculaTiempoTraslado(double dDistancia)
        {
            
            
        }      
    }
}
