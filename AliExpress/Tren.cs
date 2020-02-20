using System;
using System.Collections.Generic;
using System.Text;
using AliExpress.Interfaces;

namespace AliExpress
{
    class Tren : ITransporte
    {
        double ITransporte.calcularCostoEnvio(double dDistancia, double dMargenUtilidad)
        {
           
        }

        string ITransporte.calcularFechaEntrega(double dTiempoTraslado)
        {
           
        }

        DateTime ITransporte.calculaTiempoTraslado(double dDistancia)
        {
            
        }
    }
}
