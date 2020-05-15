using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPrototype
{
    public class Gaseosa: Bebida
    {
        public Gaseosa()
        {
            this.Nombre = "Gaxeos ExtraAzucarado";
            this.Marca = "Coca Cola";
            this.Precio = 10000;
            this.Azucar = 22.6;
        }
        public override Bebida Clone()
        {
            return new Gaseosa();
        }
    }
}
