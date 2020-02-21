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

        public double calculaTiempoTraslado(double dDistancia)
        {
             double dTiempo = (600 / dDistancia);
            return dTiempo;
        }
    }
}
