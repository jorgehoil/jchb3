﻿using System;
using System.Collections.Generic;
using System.Text;
using AliExpress.Interfaces;

namespace AliExpress
{
   public class DHL:IPaqueteria
    {
        public double obtenerMargenUtilidad()
        {
            return 0.04m;
        }
        public string obtenerNombrePaqueteria()
        {
            return "DHL";
        }

    }
}
