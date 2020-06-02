using System;
using NUnit.Framework;

namespace Library.Test.GeneradorPerfil
{
    public class TestGeneradorPerfilPrecios
    {

        private Library.GeneradorPerfil generadorPerfil = new GeneradorPerfilStub ();

        [Test]

        public void TestPrecioMinimoNegativoLanzaExcepcion ()
        {
            Perfil perfil = new PerfilStub ();
            Assert.Throws<Exception> (() => perfil.PrecioMin = -1);
        }

        [Test]

        public void TestPrecioMaximoNegativoLanzaExcepcion ()
        {
            Perfil perfil = new PerfilStub ();
            Assert.Throws<Exception> (() => perfil.PrecioMax = -1);
        }

        [Test]
        public void TestPrecioMaximoMenorQuePrecioMinimoLanzaExcepcion ()
        {
            Perfil perfil = new PerfilStub (5, 10);
            Assert.Throws<Exception> (() => perfil.PrecioMax = 2);
        }
            [Test]
        public void TestPrecioMinimoMayorQuePrecioMaximoLanzaExcepcion ()
        {
            Perfil perfil = new PerfilStub (10, 20);
            Assert.Throws<Exception> (() => perfil.PrecioMin = 40);
        }

    }
}