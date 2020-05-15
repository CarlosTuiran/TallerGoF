using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAbstract_Factory
{
    public class FabricaAlcohol : IFabricante
    {
        public IBebida crearBebida()
        {
            Alcohol Bebida = new Alcohol();
            return Bebida;
        }
    }
}
