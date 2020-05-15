using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAbstract_Factory
{
    public class FabricaAbstracta
    {
        IFabricante Fabricante;
        public FabricaAbstracta(IFabricante fabricante)
        {
            this.Fabricante = fabricante;
        }

        public void setFabrica(IFabricante fabricante)
        {
            this.Fabricante = fabricante;
        }

        public IBebida crearBebida()
        {
            return this.Fabricante.crearBebida();
        }

    }


}
