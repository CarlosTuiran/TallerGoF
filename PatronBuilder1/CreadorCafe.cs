using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder
{
    public class CreadorCafe:CreadorBebidas
    {
        public override void DefinirDatosFabricante()
        {
            Bebida.Nombre = "Cafe Descafeinado";
            Bebida.Marca = "Juan Valdes";
        }

        public override void DefinirDatosNumericos()
        {
            Bebida.Precio = 8000;
            Bebida.Azucar = 5.26;
        }
    }
}
