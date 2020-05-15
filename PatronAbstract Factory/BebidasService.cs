using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAbstract_Factory
{
    public class BebidasService
    {
        FabricaAbstracta FabricaAbstracta;
        IBebida Bebida;
        public string TipoBebida;
        public IBebida CrearBebida()
        {
            if (TipoBebida.Equals("Alcohol"))
            {
                FabricaAbstracta = new FabricaAbstracta(new FabricaAlcohol());
            }
            else
            {
                if (TipoBebida.Equals("Cafe"))
                {
                    FabricaAbstracta = new FabricaAbstracta(new FabricaCafe());

                }
                else
                {
                    if (TipoBebida.Equals("Gaseosa"))
                    {
                        FabricaAbstracta = new FabricaAbstracta(new FabricaGaseosa());

                    }
                    else
                    {
                        throw new InvalidOperationException("Operacion Invalida");
                    }
                }
            }
            Bebida = FabricaAbstracta.crearBebida();
            return Bebida;
        }
    }
}
