using System;
using System.Collections.Generic;
using System.Text;
using AliExpress.Interfaces;

namespace AliExpress
{
    public class Estafeta: IPaqueteria
    {
        public double obtenerMargenUtilidad()
        {
            return 0.02;
        }
        public string obtenerNombrePaqueteria()
        {
            return "Estafeta";
        }
    }
}
