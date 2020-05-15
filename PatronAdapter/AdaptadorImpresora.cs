using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAdapter
{
    public class AdaptadorImpresora : IImpresoraEPSON
    {
        private ImpresoraHP impresora;

        public AdaptadorImpresora()
        {
            impresora = new ImpresoraHP();
        }
        public string ImprimirHD()
        {
            return Imprimir();
        }

        public string Laser()
        {
            return ImprimirLaser();
        }

        private string  Imprimir()
        {
            string rta=impresora.Imprimir();
            return rta;
        }

        private string ImprimirLaser()
        {
            string rta = impresora.Imprimir();
            return rta;
        }
    }
}
