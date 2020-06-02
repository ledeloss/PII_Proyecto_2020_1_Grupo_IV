using System;
using NUnit.Framework;

namespace Library.Test.GeneradorPerfil
{
    public class TestGeneradorPerfilGeneraciones
    {

        private Library.GeneradorPerfil generadorPerfil = new GeneradorPerfilStub ();

        [Test]

        public void TestNoValidoEdadSuperiorAlRangoValido ()
        {

            Assert.Throws<NotImplementedException> (() => generadorPerfil.ValidarEdad (130));

        }

        [Test]

        public void TestNoValidoEdadInferiorAlRangoValido ()
        {

            Assert.Throws<NotImplementedException> (() => generadorPerfil.ValidarEdad (-10));

        }

        [Test]

        public void TestValidoEdadDentroDelRangoValido ()
        {

            Assert.DoesNotThrow (() => generadorPerfil.ValidarEdad (70));

        }

        [Test]

        public void TestSeteoEdadQueLanzaExcepcion ()
        {
            Assert.Throws<Exception> (() => generadorPerfil.SetEdad ("-10"));

        }
        [Test]

           public void TestSeteoEdadParaRecienNacido ()
        {   generadorPerfil.SetEdad("0");
            Assert.AreEqual(TipoGeneraciones.RecienNacido,generadorPerfil.GetPersona().Edad);

        }
         [Test]

           public void TestSeteoEdadParaBebe ()
        {   generadorPerfil.SetEdad("1");
            Assert.AreEqual(TipoGeneraciones.Bebe,generadorPerfil.GetPersona().Edad);

        }

     

    }
}