using System;
using System.Collections.Generic;
using System.Text;
using AliExpress.Interfaces;

namespace AliExpress
{
    class Tren : ITransporte
    {
        public double calcularCostoEnvio(double dDistancia, double dMargenUtilidad)
        {
            double dCostoEnvio = (5 * dDistancia) * (1 + dMargenUtilidad);
            return dCostoEnvio;
        }

        public double calculaTiempoTraslado(double dDistancia)
        {
            double dTiempo = (46 / dDistancia);
            return dTiempo;
        }
    }
}
