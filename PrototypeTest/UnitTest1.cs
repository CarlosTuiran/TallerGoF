using NUnit.Framework;
using PatronPrototype;

namespace PrototypeTest
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
            Bebida bebida;
            if (tipo.Equals("Alcohol"))
            {
                bebida = new Alcohol();

            }
            else
            {
                if (tipo.Equals("Cafe"))
                {
                    bebida = new Cafe();

                }
                else
                {
                    bebida = new Gaseosa();

                }
            }
            Bebida clonBebida = bebida.Clone();
            Assert.Pass(nombre, clonBebida.Nombre);

        }
    }
}