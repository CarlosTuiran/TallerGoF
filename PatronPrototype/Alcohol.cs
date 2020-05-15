using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPrototype
{
    public class Alcohol:Bebida
    {
        public Alcohol()
        {
            this.Nombre = "Corona Light";
            this.Marca = "Corona";
            this.Precio = 18000;
            this.Azucar = 6.6;
        }
        public override Bebida Clone()
        {
            return new Alcohol();
        }
    }
}
