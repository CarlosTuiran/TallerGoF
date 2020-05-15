using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAbstract_Factory
{
    public class FabricaCafe:IFabricante
    {
        public IBebida crearBebida()
        {
            Cafe Bebida = new Cafe();
            return Bebida;
        }
    }
}
