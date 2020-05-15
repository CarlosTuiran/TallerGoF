using System;

namespace PatronBridge
{
    public interface IBebida
    {
        //interfaz que representa cualquier tipo de bebida y sus funciones
        public string Nombre { get;  }
        public string Marca { get;  }

        public double Precio { get;  }
        public double Azucar { get;  }

        public string MostrarAdvertencia();
    }
}
