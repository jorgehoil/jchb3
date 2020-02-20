using System;
using System.Collections.Generic;
using System.Text;
using AliExpress.Interfaces;
using AliExpress.Entidades;

namespace AliExpress
{
    class ProcesadorPedidos:IProcesadorPedidos
    {
        ITransporte iTransporte;
        IPaqueteria iPaqueteria;

        public ProcesadorPedidos(ITransporte _iTransporte, IPaqueteria _iPaqueteria)
        {
            iTransporte = _iTransporte;
            iPaqueteria = _iPaqueteria;
        }


        public string procesarPedido(Pedido pedido)
        {
            string cCadenaFinal = string.Empty;
            double dMargenUtilidad = iPaqueteria.obtenerMargenUtilidad();
            double dCostoEnvio = iTransporte.calcularCostoEnvio(pedido.dDistancia, dMargenUtilidad);

            cCadenaFinal = string.Format("Tu paquete {} de"+ pedido.cOrigen+" y llegará a "+pedido.cDestino +" el {}"+"y tendrá un costo de"+dCostoEnvio);
            return cCadenaFinal;

        }
    }

}
