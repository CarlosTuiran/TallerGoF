using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder
{
    public class BebidasService
    {
        public string TipoBebida { get; set; }
        private Expendedora Expendedora { get; set; }
        private CreadorBebidas CreadorBebidas { get; set; }
        public BebidasService()
        {
            this.Expendedora = new Expendedora();
        }

        public Bebida CrearBebida()
        {
            if (TipoBebida.Equals("Alcohol"))
            {
                CreadorBebidas = new CreadorAlcohol();
            }
            else
            {
                if (TipoBebida.Equals("Cafe"))
                {
                    CreadorBebidas = new CreadorCafe();

                }
                else
                {
                    if (TipoBebida.Equals("Gaseosa"))
                    {
                        CreadorBebidas = new CreadorGaseosa();

                    }
                    else
                    {
                        throw new InvalidOperationException("Operacion Invalida");
                    }
                }   
            }
            Expendedora.Crear(CreadorBebidas);
            Expendedora.CrearBebida();
            return Expendedora.GetBebida();
        }
    }
}
