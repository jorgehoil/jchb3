using System;
using System.Collections.Generic;
using System.Text;

namespace AliExpress.Interfaces
{
   public interface ITransporte
    {
        double calcularCostoEnvio(double dDistancia, double dMargenUtilidad);
        double calculaTiempoTraslado(double dDistancia);

        
    }
}
