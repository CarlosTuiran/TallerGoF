using System;

namespace PatronBridge
{
    public abstract class Expendedora
    {
        //Abstracion que encapsula la interfaz IBebida
        protected IBebida Bebida;
        
        protected Expendedora(IBebida bebida)
        {
            this.Bebida = bebida;
        }

        public string mostrarAdvertencia()
        {
            return Bebida.MostrarAdvertencia();
        }

        public abstract string mostrarDatosExp();
    }
}
