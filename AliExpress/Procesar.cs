using System;
using System.Collections.Generic;
using System.Text;
using AliExpress.Interfaces;
using AliExpress.Entidades;


namespace AliExpress
{
    public class Procesar
    {
        IObtenedorPedidos iObtenedorPedidos;
        IProcesadorPedidos iProcesadorPedidos;
        ITransporte iTransporte;
        IPaqueteria iPaqueteria;
        IFactoryTransporte factoryTransporte;

       
        public void procesar()
        {

            
            iObtenedorPedidos = new ObtenedorPedidosCSV();
            List<Pedido> lstPedidos = iObtenedorPedidos.obtenerPedidos(@"C:\Users\carlos.hoil\source\repos\AliExpress\AliExpress\bin\Pedidos.csv");

            foreach (Pedido pedido in lstPedidos)
            {
                switch (pedido.cMedioTransporte)
                {
                    case "Avion":
                        break;
                    case "Barco": ///Lo Logre realizar la unión
                        break;
                    case "Tren":
                        break;

                }
                switch(pedido.cPaqueteria)
                {
                    case "DHL":
                        break;
                    case "Estafeta":///Lo Logre realizar la unión
                        break;
                    case "Fedex":
                        break;
                }
                iProcesadorPedidos = new ProcesadorPedidos(iTransporte,iPaqueteria);
                iProcesadorPedidos.procesarPedido();
                MostrarResultados();




            }


        }

        public void MostrarResultados()
        {

        }

    }
}
