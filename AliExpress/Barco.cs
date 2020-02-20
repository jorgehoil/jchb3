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
            throw new NotImplementedException();
        }

        public string calcularFechaEntrega(double dTiempoTraslado)
        {
            throw new NotImplementedException();
        }

        public DateTime calculaTiempoTraslado(double dDistancia)
        {
            throw new NotImplementedException();
        }

       
    }
}
