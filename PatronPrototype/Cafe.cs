using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPrototype
{
    public class Cafe : Bebida
    {
        public Cafe()
        {
            this.Nombre = "Cafe Descafeinado";
            this.Marca="Juan Valdes";
            this.Precio = 8000;
            this.Azucar = 2.6;
        }
        public override Bebida Clone()
        {
            return new Cafe();
        }
    }
}
