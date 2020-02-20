using System;
using System.Collections.Generic;
using System.Text;
using AliExpress.Interfaces;
using AliExpress.Entidades;

namespace AliExpress.Interfaces
{
    interface IProcesadorPedidos
    {
        string procesarPedido(Pedido pedido);
    }
}
