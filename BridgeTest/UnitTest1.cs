using NUnit.Framework;
using PatronBridge;
namespace BridgeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Expendedora de Cafe", 100, "Expendedora de Cafe. Capacidad Maxima: 100", "Esta Bebida No Contiene Cafe", TestName = "Crear Maquina de Cafe")]
        [TestCase("Maquina de Refrescos", 1999, "Maquina Expendedora de Refrescos del Año: 1999", "Esta Bebida Contiene Mucha Azucar", TestName = "Crear Maquina de Refrescos")]
        

        public void RegistrodeExpendedoras(string tipo, int value, string descripMaq, string descripBeb)
        {
            Expendedora Maquina;
            if (tipo.Equals("Expendedora de Cafe"))
            {
                IBebida Bebida = new Cafe();

                 Maquina = new ExpendedoraCafe(Bebida, value);
            }
            else
            {
                IBebida Bebida = new Gaseosa();

                Maquina = new MaquinaRefrescos(Bebida, value);
            }
            Assert.AreEqual(descripMaq, Maquina.mostrarDatosExp());
            Assert.AreEqual(descripBeb, Maquina.mostrarAdvertencia());

        }
    }
}