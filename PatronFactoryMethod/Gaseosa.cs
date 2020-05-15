using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactoryMethod
{
    public class Gaseosa : IBebida
    {
        public string Nombre => "Gaxeos ExtraAzucarado";

        public string Marca => "Coca Cola";

        public double Precio => 10000;

        public double Azucar => 22.9;
    }
}
