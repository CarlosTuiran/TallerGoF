using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAbstract_Factory
{
    public interface IFabricante
    {
        //Interfaz que permitira crear bebidas a todas las clases que la implementen
        public IBebida crearBebida(); 
    }
}
