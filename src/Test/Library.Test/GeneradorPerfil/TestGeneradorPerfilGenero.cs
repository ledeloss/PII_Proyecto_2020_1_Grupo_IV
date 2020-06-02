using System;
using NUnit.Framework;

namespace Library.Test.GeneradorPerfil
{
    public class TestGeneradorPerfilGenero
    {

        private Library.GeneradorPerfil generadorPerfil = new GeneradorPerfilStub ();

        [Test]

        public void TestSeteoGeneroMasculino ()
        {
            generadorPerfil.SetGenero ("Masculino");
            Assert.AreEqual (TipoGenero.Masculino, generadorPerfil.GetPersona ().Genero);

        }

        [Test]

        public void TestSeteoGeneroFemenino ()
        {
            generadorPerfil.SetGenero ("femenino");
            Assert.AreEqual (TipoGenero.Femenino, generadorPerfil.GetPersona ().Genero);

        }

        [Test]

        public void TestSeteoGeneroDesconocido()
        {
            generadorPerfil.SetGenero ("N/A");
            Assert.AreEqual (TipoGenero.Desconocido, generadorPerfil.GetPersona ().Genero);

        }

    }
}