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
        [Test]

           public void TestSeteoEdadParaInfante ()
        {   generadorPerfil.SetEdad("4");
            Assert.AreEqual(TipoGeneraciones.Infante,generadorPerfil.GetPersona().Edad);

        }
         [Test]

           public void TestSeteoEdadParaNino ()
        {   generadorPerfil.SetEdad("7");
            Assert.AreEqual(TipoGeneraciones.Nino,generadorPerfil.GetPersona().Edad);

        }
         [Test]

           public void TestSeteoEdadParaPreAdolescente ()
        {   generadorPerfil.SetEdad("12");
            Assert.AreEqual(TipoGeneraciones.PreAdolescente,generadorPerfil.GetPersona().Edad);

        }
         [Test]

           public void TestSeteoEdadAdolescente ()
        {   generadorPerfil.SetEdad("16");
            Assert.AreEqual(TipoGeneraciones.Adolescente,generadorPerfil.GetPersona().Edad);

        }
         [Test]

           public void TestSeteoEdadParaJoven ()
        {   generadorPerfil.SetEdad("25");
            Assert.AreEqual(TipoGeneraciones.Joven,generadorPerfil.GetPersona().Edad);

        }
         [Test]

           public void TestSeteoEdadParaAdultoJoven ()
        {   generadorPerfil.SetEdad("34");
            Assert.AreEqual(TipoGeneraciones.AdultoJoven,generadorPerfil.GetPersona().Edad);

        }
         [Test]

           public void TestSeteoEdadParaAdulto ()
        {   generadorPerfil.SetEdad("50");
            Assert.AreEqual(TipoGeneraciones.Adulto,generadorPerfil.GetPersona().Edad);

        }
         [Test]

           public void TestSeteoEdadParaAdultoMayor ()
        {   generadorPerfil.SetEdad("70");
            Assert.AreEqual(TipoGeneraciones.AdultoMayor,generadorPerfil.GetPersona().Edad);

        }
     

    }
}