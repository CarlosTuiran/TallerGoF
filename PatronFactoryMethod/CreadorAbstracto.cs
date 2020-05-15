using System;

namespace PatronFactoryMethod
{
    public abstract class CreadorAbstracto
    {

        public const string AlcoholType = "Alcohol";
        public const string CafeType = "Cafe";
        public const string GaseosaType = "Gaseosa";

        public string Alcohol { get => AlcoholType; }
        public string Cafe { get => CafeType; }
        public string Gaseosa { get => GaseosaType; }
        public abstract IBebida crearBebida(string Tipo);

    }
}
