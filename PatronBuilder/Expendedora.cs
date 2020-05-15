using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder
{
    public class Expendedora
    {
        private CreadorBebidas CreadorBebidas;
        public void Crear(CreadorBebidas creadorBebidas)
        {
            this.CreadorBebidas = creadorBebidas;
        }
        public Bebida GetBebida()
        {
            return CreadorBebidas.GetBebida();
        }

        public void CrearBebida()
        {
            CreadorBebidas.Crear();
            CreadorBebidas.DefinirDatosFabricante();
            CreadorBebidas.DefinirDatosNumericos();
        }
    }
}
