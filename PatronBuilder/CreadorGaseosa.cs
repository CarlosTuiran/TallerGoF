using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder
{
    public class CreadorGaseosa : CreadorBebidas
    {
        public override void DefinirDatosFabricante()
        {
            Bebida.Nombre = "Gaxeos ExtraAzucarado";
            Bebida.Marca = "Coca Cola";
        }

        public override void DefinirDatosNumericos()
        {
            Bebida.Precio = 10000;
            Bebida.Azucar = 22.6;
        }
    }
}
