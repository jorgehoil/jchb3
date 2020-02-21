using System;
using AliExpress.Interfaces;

namespace AliExpress
{
    public class Program
    {

        static void Main(string[] args)
        {
            Procesar obj = new Procesar();
            obj.procesar();
            Console.ReadKey();
            

        }
    }
}
