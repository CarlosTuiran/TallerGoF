using System;
using System.Runtime.CompilerServices;

namespace PatronSingleton
{
    public class Bebida
    {
        private static Bebida instance = new Bebida();
        public string Nombre { get; set; }
        public string Marca { get; set; }

        public double Precio { get; set; }
        public double Cant { get; set; }

        private Bebida()
        {

        }
        public static Bebida getIsntance()
        {
            return instance;
        }
    }
}
