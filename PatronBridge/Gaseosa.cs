﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBridge
{
    public class Gaseosa : IBebida
    {
        public string Nombre => "Gaxeos ExtraAzucarado";

        public string Marca => "Coca Cola";

        public double Precio => 10000;

        public double Azucar => 22.9;

        public string MostrarAdvertencia()
        {
            return "Esta Bebida Contiene Mucha Azucar";
        }
    }
}
