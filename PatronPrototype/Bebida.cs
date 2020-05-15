using System;

namespace PatronPrototype
{
    public abstract class Bebida
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }

        public double Precio { get; set; }
        public double Azucar { get; set; }

        /*public Bebida(string nombre, string marca, double precio, double azucar)
        {
            this.Nombre = nombre;
            this.Marca = marca;
            this.Precio = precio;
            this.Azucar = azucar;
        }*/
        public abstract Bebida Clone();
    }
}
