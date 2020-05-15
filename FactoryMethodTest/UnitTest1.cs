using NUnit.Framework;
using PatronFactoryMethod;

namespace FactoryMethodTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Corona Light", "Alcohol", TestName = "Crear Alcohol")]
        [TestCase("Cafe Descafeinado", "Cafe", TestName = "Crear Cafe")]
        [TestCase("Gaxeos ExtraAzucarado", "Gaseosa", TestName = "Crear Gaseosa")]

        public void CrearBebida(string nombre, string tipo)
        {
            var BebidaService = new CreadorBebidas();
            IBebida Bebida;
            if (tipo.Equals("Alcohol"))
            {
                 Bebida = BebidaService.crearBebida(BebidaService.Alcohol);

            }
            else
            {
                if (tipo.Equals("Cafe"))
                {
                     Bebida = BebidaService.crearBebida(BebidaService.Cafe);

                }
                else
                {
                     Bebida = BebidaService.crearBebida(BebidaService.Gaseosa);

                }
            }
            
            Assert.Pass(nombre, Bebida.Nombre);
        }

        
    }
}