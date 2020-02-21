using System;
using System.Collections.Generic;
using System.Text;
using AliExpress.Interfaces;

namespace AliExpress
{
    class Barco : ITransporte
    {
        public double calcularCostoEnvio(double dDistancia, double dMargenUtilidad)
        {
            double dCostoEnvio = (1 * dDistancia) * (1 + dMargenUtilidad);
            return dCostoEnvio;
        }

        public double calculaTiempoTraslado(double dDistancia)
        {
            double dTiempo = (80 / dDistancia);
            return dTiempo;
        }
    }
}
