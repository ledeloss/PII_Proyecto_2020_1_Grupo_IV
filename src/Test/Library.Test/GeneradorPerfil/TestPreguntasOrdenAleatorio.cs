using System;
using NUnit.Framework;

namespace Library.Test.GeneradorPerfil
{
    public class TestPreguntasOrdenAleatorio
    {

        [Test]

        public void TestCompletoDevuelveTrue ()
        {   //[edad, genero, precioMin, precioMax, intereses]
            PreguntasOrdenAleatorio preguntas = new PreguntasOrdenAleatorio();
            preguntas.
            Assert.AreEqual (generadorPerfil.IsPerfilCompleto (), true);
        }

        [Test]

        public void TestValidoSiPerfilCompletoDevuelvePerfilSugerencia ()
        {
            Library.GeneradorPerfil generadorPerfil = new GeneradorPerfilStub (1, 0, 1, 1, 1);
            Assert.AreEqual (generadorPerfil.getDatoFaltante (), TipoEnvio.Genero);
        }
        

        [Test]

        public void TestSoloFaltaGeneroDevuelveGenero ()
        {
            Library.GeneradorPerfil generadorPerfil = new GeneradorPerfilStub (1, 1, 1, 1, 1);
            Assert.AreEqual (generadorPerfil.getDatoFaltante (), TipoEnvio.Sugerencia);
        }

        [Test]

        public void TestValidoSiUltimoPreguntadoEsPrecioMinimoPidoPrecioMaximo ()
        {
            Library.GeneradorPerfil generadorPerfil = new GeneradorPerfilStub (0, 0, 0, 0, 0);
            generadorPerfil.ActualizarPreguntados (2);
            Assert.AreEqual (generadorPerfil.getDatoFaltante (), TipoEnvio.PrecioMax);
        }

        [Test]

        public void TestValidoSiUltimoPreguntadoEsPrecioMaximoPidoPrecioMinimo ()
        {
            Library.GeneradorPerfil generadorPerfil = new GeneradorPerfilStub (0, 0, 0, 0, 0);
            generadorPerfil.ActualizarPreguntados (3);
            Assert.AreEqual (generadorPerfil.getDatoFaltante (), TipoEnvio.PrecioMin);
        }

        [Test]

        public void Test ()
        {
            Library.GeneradorPerfil generadorPerfil = new GeneradorPerfilStub (0, 0, 1, 0, 0);
            generadorPerfil.ActualizarPreguntados (3);
            Assert.AreNotEqual (generadorPerfil.getDatoFaltante (), TipoEnvio.PrecioMin);
        }

    }
}