using System;
using System.Collections.Generic;
using System.Text;

namespace AliExpress.Entidades
{
    public class Pedido
    {
        public string cOrigen;
        public string cDestino;
        public double dDistancia;
        public string cPaqueteria;
        public string cMedioTransporte;
        public DateTime dtFechaPedido;

        public Pedido(string _cOrigen, string _cDestino, double _dDistancia, string _cPaqueteria, string _cMedioTransporte, DateTime _dtFechaPedido)
        {

            cOrigen = _cOrigen;
            cDestino = _cDestino;
            dDistancia = _dDistancia;
            cPaqueteria = _cPaqueteria;
            cMedioTransporte = _cMedioTransporte;
            dtFechaPedido = _dtFechaPedido;

        }
    }
}
