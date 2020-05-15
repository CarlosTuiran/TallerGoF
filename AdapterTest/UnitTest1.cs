using NUnit.Framework;
using PatronAdapter;

namespace AdapterTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Imprimiendo desde HP", TestName = "Imprimir HD EPSON por Impresora HP")]
        public void ImprimiendoHDdesdeEPSON(string rta)
        {
            IImpresoraEPSON impresora = new AdaptadorImpresora();
            Assert.AreEqual(rta, impresora.ImprimirHD());
        }

        [Test]
        [TestCase("Imprimiendo desde HP", TestName = "Imprimir Laser EPSON por Impresora HP")]
        public void ImprimiendoLaserdesdeEPSON(string rta)
        {
            IImpresoraEPSON impresora = new AdaptadorImpresora();
            Assert.AreEqual(rta, impresora.Laser());
        }
    }
}