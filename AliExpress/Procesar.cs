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
        IFactoryPaqueteria factoryPaqueteria;

       
        public void procesar()
        {
            string cRespuesta = string.Empty;
            iObtenedorPedidos = new ObtenedorPedidosCSV();
            List<Pedido> lstPedidos = iObtenedorPedidos.obtenerPedidos(@"C:\Users\carlos.hoil\source\repos\AliExpress\AliExpress\bin\Pedidos.csv");

            foreach (Pedido pedido in lstPedidos)
            {
                switch (pedido.cMedioTransporte)
                {
                    case "Avion":
                        factoryTransporte = new CreadorAvion();
                        iTransporte = factoryTransporte.crearTransporte();
                        break;
                    case "Barco":
                        factoryTransporte = new CreadorBarco();
                        iTransporte = factoryTransporte.crearTransporte();
                        ///Lo Logre realizar la unión
                        break;
                    case "Tren":
                        factoryTransporte = new CreadorTren();
                        iTransporte = factoryTransporte.crearTransporte();
                        break;

                }
                switch(pedido.cPaqueteria)
                {
                    case "DHL":
                        factoryPaqueteria = new CreadorDHL();
                        iPaqueteria = factoryPaqueteria.crearPaqueteria();
                        
                        break;
                    case "Estafeta":///Lo Logre realizar la unión
                        factoryPaqueteria = new CreadorEstafeta();
                        iPaqueteria = factoryPaqueteria.crearPaqueteria();
                        break;
                    case "Fedex":
                        factoryPaqueteria = new CreadorFedex();
                        iPaqueteria = factoryPaqueteria.crearPaqueteria();
                        break;
                }
                iProcesadorPedidos = new ProcesadorPedidos(iTransporte,iPaqueteria);
                Console.WriteLine(iProcesadorPedidos.procesarPedido(pedido));
                
                //MostrarResultados(;);
            }


        }

        public void MostrarResultados()
        {

        }

    }
}
