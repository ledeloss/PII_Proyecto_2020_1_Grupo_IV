using System;
using NUnit.Framework;

namespace Library.Test.GeneradorPerfil
{
    public class TestPreguntasOrdenAleatorio
    {
        [Test]
        public void TestCompletoDevuelveTrue ()
        {   //[edad, genero, precioMin, precioMax, intereses]
            PreguntasOrdenAleatorioStub preguntas = new PreguntasOrdenAleatorioStub();
            preguntas.SetPreguntado(0);
            preguntas.SetPreguntado(1);
            preguntas.SetPreguntado(2);
            preguntas.SetPreguntado(3);
            preguntas.SetPreguntado(4);

            Assert.AreEqual (preguntas.IsPerfilCompleto(), true);
        }

        [Test]

        public void TestValidoSiPerfilIncompletoDevuelveGenero ()
        {
            PreguntasOrdenAleatorioStub preguntas = new PreguntasOrdenAleatorioStub();
            preguntas.SetPreguntado(0);
            preguntas.SetPreguntado(2);
            preguntas.SetPreguntado(3);
            preguntas.SetPreguntado(4);
            Assert.AreEqual (preguntas.GetSiguientePregunta(), TipoEnvio.Genero);
        }
        [Test]
        public void TestPerfilCompletoDevuelveSugerencia ()
        {
            PreguntasOrdenAleatorioStub preguntas = new PreguntasOrdenAleatorioStub();
            preguntas.SetPreguntado(0);
            preguntas.SetPreguntado(1);
            preguntas.SetPreguntado(2);
            preguntas.SetPreguntado(3);
            preguntas.SetPreguntado(4);

            Assert.AreEqual (preguntas.GetSiguientePregunta(), TipoEnvio.Sugerencia);
        }

        [Test]

        public void TestValidoSiUltimoPreguntadoEsPrecioMinimoPidoPrecioMaximo ()
        {
            PreguntasOrdenAleatorioStub preguntas = new PreguntasOrdenAleatorioStub();
            preguntas.SetPreguntado(2);
            preguntas.SetUltimaPregunta(2);
            Assert.AreEqual (preguntas.GetSiguientePregunta (), TipoEnvio.PrecioMax);
        }

        [Test]

        public void TestValidoSiUltimoPreguntadoEsPrecioMaximoPidoPrecioMinimo ()
        {
            PreguntasOrdenAleatorioStub preguntas = new PreguntasOrdenAleatorioStub();
            preguntas.SetPreguntado(3);
            preguntas.SetUltimaPregunta(3);
            Assert.AreEqual (preguntas.GetSiguientePregunta(), TipoEnvio.PrecioMin);
        }

        [Test]

        public void TestValidoSiUltimoPreguntadoEsPrecioMinimoNoPidoPrecioMaximoNuevamente ()
        {
            PreguntasOrdenAleatorioStub preguntas = new PreguntasOrdenAleatorioStub();
            preguntas.SetPreguntado(2);
            preguntas.SetPreguntado(3);
            preguntas.SetUltimaPregunta(2);
            Assert.AreNotEqual (preguntas.GetSiguientePregunta (), TipoEnvio.PrecioMax);
        }

        [Test]
        public void TestValidoSiUltimoPreguntadoEsPrecioMaximoNoPidoPrecioMinimoNuevamente ()
        {
            PreguntasOrdenAleatorioStub preguntas = new PreguntasOrdenAleatorioStub();
            preguntas.SetPreguntado(2);
            preguntas.SetPreguntado(3);
            preguntas.SetUltimaPregunta(3);
            Assert.AreNotEqual (preguntas.GetSiguientePregunta (), TipoEnvio.PrecioMin);
        }

    }
}