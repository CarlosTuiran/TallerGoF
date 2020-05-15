using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBridge
{
    public class Cafe : IBebida
    {
        public string Nombre => "Cafe Descafeinado";

        public string Marca =>"Juan Valdes" ;

        public double Precio =>8000 ;

        public double Azucar => 2.9;

        public string MostrarAdvertencia()
        {
            return "Esta Bebida No Contiene Cafe";
        }
    }
}
