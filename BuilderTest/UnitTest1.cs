using NUnit.Framework;
using PatronBuilder;
using System;

namespace BuilderTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Corona Light", "Alcohol", TestName ="Crear Alcohol")]
        [TestCase("Cafe Descafeinado", "Cafe", TestName = "Crear Cafe")]
        [TestCase("Gaxeos ExtraAzucarado", "Gaseosa", TestName = "Crear Gaseosa")]

        public void CrearBebida(string nombre,string tipo)
        {
            var BebidaService = new BebidasService();
            BebidaService.TipoBebida = tipo;
            var Bebida=BebidaService.CrearBebida();
            Assert.Pass(nombre, Bebida);
        }

        [Test]
        [TestCase("Operacion Invalida", "Falsi", TestName = "Crear Bebida no Definida")]
        public void CrearBebidaFalsa(string nombre, string tipo)
        {
            var BebidaService = new BebidasService();
            BebidaService.TipoBebida = tipo;
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => BebidaService.CrearBebida());
            Assert.Pass(nombre, ex.Message);
        }
    }
}