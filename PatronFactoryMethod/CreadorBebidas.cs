using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactoryMethod
{
    public class CreadorBebidas : CreadorAbstracto
    {
        public override IBebida crearBebida(string Tipo)
        {
            IBebida bebida;

            switch (Tipo)
            {
                case AlcoholType:
                    bebida = new Alcohol();
                    break;
                case CafeType:
                    bebida = new Cafe();
                    break;
                case GaseosaType:
                    bebida = new Gaseosa();
                    break;

                default:
                    throw new InvalidOperationException("Operacion Invalida");

            }
            return bebida;
        }
    }
}
