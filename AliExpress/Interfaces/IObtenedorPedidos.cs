using System;
using System.Collections.Generic;
using System.Text;
using AliExpress.Entidades;
namespace AliExpress.Interfaces
{
    interface IObtenedorPedidos
    {
        List<Pedido> obtenerPedidos(string cRuta);
    }
}
