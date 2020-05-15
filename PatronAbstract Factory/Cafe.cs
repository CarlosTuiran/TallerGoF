using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAbstract_Factory
{
    public class Cafe : IBebida
    {
        public string Nombre => "Cafe Descafeinado";

        public string Marca =>"Juan Valdes" ;

        public double Precio =>8000 ;

        public double Azucar => 2.9;
    }
}
