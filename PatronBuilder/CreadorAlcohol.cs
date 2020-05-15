using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder
{
    public class CreadorAlcohol : CreadorBebidas
    {
        public override void DefinirDatosFabricante()
        {
            Bebida.Nombre = "Corona Light";
            Bebida.Marca = "Corona";
        }

        public override void DefinirDatosNumericos()
        {
            Bebida.Precio = 12000;
            Bebida.Azucar = 2.6;
        }
    }
}
