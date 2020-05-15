using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAdapter
{
    public interface IImpresoraEPSON
    {
        //interfaz que se necesita en el sistema actual
        public string ImprimirHD();
        public string Laser();   
    }
}
