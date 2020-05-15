using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAbstract_Factory
{
    public class FabricaGaseosa: IFabricante
    {
        public IBebida crearBebida()
        {
            Gaseosa Bebida = new Gaseosa();
            return Bebida;
        }
    }
}
