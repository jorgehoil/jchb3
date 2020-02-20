using System;
using System.Collections.Generic;
using System.Text;
using AliExpress.Interfaces;

namespace AliExpress
{
    public class Fedex:IPaqueteria
    {
        public double obtenerMargenUtilidad()
        {
            return 0.05;
        }

        public string obtenerNombrePaqueteria()
        {
            return "Fedex";
        }
    }
}
