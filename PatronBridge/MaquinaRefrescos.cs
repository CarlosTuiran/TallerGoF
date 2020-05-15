using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBridge
{
    public class MaquinaRefrescos : Expendedora
    {
        public int añoCreacion;

        public MaquinaRefrescos(IBebida bebida, int año):base(bebida)
        {
            this.añoCreacion = año;
        }
        public override string mostrarDatosExp()
        {
            return "Maquina Expendedora de Refrescos del Año: "+añoCreacion;
        }
    }
}
