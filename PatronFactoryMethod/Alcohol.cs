using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactoryMethod
{
    public class Alcohol:IBebida
    {
        public string Nombre => "Corona Light";

        public string Marca => "Corona";

        public double Precio => 18000;

        public double Azucar => 1.9;
    }
}
