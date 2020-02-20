using System;
using System.Collections.Generic;
using System.Text;
using AliExpress.Interfaces;

namespace AliExpress 
{
    public class CreadorTren: IFactoryTransporte
    {
        public ITransporte crearTransporte()
        {
            return new Tren();
        }


    }
}
