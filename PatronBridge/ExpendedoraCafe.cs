using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBridge
{
    public class ExpendedoraCafe : Expendedora
    {
        private  int Cantidad;

        public ExpendedoraCafe(IBebida bebida, int cantidad): base(bebida)
        {
            this.Cantidad = cantidad;
        }
        public override string mostrarDatosExp()
        {
            return "Expendedora de Cafe. Capacidad Maxima: "+Cantidad;
        }
    }
}
