using NUnit.Framework;
using PatronSingleton;

namespace SingletonTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2, 4, 6,12, TestName = "Aumentar Cantidad de la misma Bebida")]
        
        public void crearBebida(double cant1, double cant2, double cant3, double cantE)
        {
            Bebida bebida1 = Bebida.getIsntance();
            bebida1.Cant = cant1;

            Bebida bebida2 = Bebida.getIsntance();
            bebida2.Cant += cant2;

            Bebida bebida3 = Bebida.getIsntance();
            bebida3.Cant += cant3;

            Bebida bebidaFinal = Bebida.getIsntance();

            Assert.AreEqual(cantE, bebidaFinal.Cant);

        }
    }
}