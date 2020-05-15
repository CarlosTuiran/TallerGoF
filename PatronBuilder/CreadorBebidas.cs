using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder
{
    public abstract class CreadorBebidas
    {
        //Contructor Abstracto Capaz de Crear los Tipos de Bebida
        protected Bebida Bebida;

        public void Crear()
        {
            Bebida = new Bebida();
        }

        public Bebida GetBebida()
        {
            return Bebida;
        }

        public abstract void DefinirDatosFabricante();
        public abstract void DefinirDatosNumericos();

    }
}
