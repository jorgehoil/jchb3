using System;
using System.Collections.Generic;
using System.Text;
using AliExpress.Entidades;
using AliExpress.Interfaces;
using System.IO;
using System.Linq;

namespace AliExpress
{
    class ObtenedorPedidosCSV : IObtenedorPedidos
    {
        public List<Pedido> obtenerPedidos(string cRuta)
        {
            List<string> lstPedidosCadenas;
            List<Pedido> lstPedidos = new List<Pedido>();
            string[] cTexto = File.ReadAllLines(cRuta);
            lstPedidosCadenas = cTexto.ToList();
            string[] cTemp;

            foreach (string a in lstPedidosCadenas)
            {
                cTemp = a.Split(',');
                if (cTemp.Length == 6)
                {
                    lstPedidos.Add(new Pedido(cTemp[0], cTemp[1], Convert.ToDouble(cTemp[2]), cTemp[3], cTemp[4], DateTime.Parse(cTemp[5])));
                }
            }
            return lstPedidos;
        }
    }
}
