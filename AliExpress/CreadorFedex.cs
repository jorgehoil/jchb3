﻿using System;
using System.Collections.Generic;
using System.Text;
using AliExpress.Interfaces;

namespace AliExpress
{
    public class CreadorFedex:IFactoryPaqueteria
    {
        public IPaqueteria crearPaqueteria()
        {
            return new Fedex();
        }
    }
}
