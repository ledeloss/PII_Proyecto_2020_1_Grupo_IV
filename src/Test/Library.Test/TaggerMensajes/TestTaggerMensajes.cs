using System.Collections.Generic;
using NUnit.Framework;


namespace Library.Test
{

    public class TestTaggerMensaje
    {
        [Test]
        public void TestSiRecibeNumeroDevuelveTipoNumero()
        {
            ArchivoInteraccionesStub archivo = new ArchivoInteraccionesStub();
            PlataformaStub plataforma = new PlataformaStub("500");
            ProcesadorStub procesador = new ProcesadorStub ();
            procesador.SetPlataforma(plataforma);

            TaggerMensajes tagger = new TaggerMensajes(archivo,procesador);
            Mensaje mensaje = tagger.EtiquetarMensaje();
            Assert.AreEqual(mensaje.Tipo(),TipoMensaje.Numero);



        }
        [Test]
        public void TestSiRecibeNumeroYAlgoMasDevuelveTipoNumero()
        {
            ArchivoInteraccionesStub archivo = new ArchivoInteraccionesStub();
            PlataformaStub plataforma = new PlataformaStub("500 Pesos");
            ProcesadorStub procesador = new ProcesadorStub ();
            procesador.SetPlataforma(plataforma);

            TaggerMensajes tagger = new TaggerMensajes(archivo,procesador);
            Mensaje mensaje = tagger.EtiquetarMensaje();
            Assert.AreEqual(mensaje.Tipo(),TipoMensaje.Numero);



        }
        [Test]
        public void TestSiRecibeNumeroAlFinalDevuelveTipoNumero()
        {
            ArchivoInteraccionesStub archivo = new ArchivoInteraccionesStub();
            PlataformaStub plataforma = new PlataformaStub("Pesos 500");
            ProcesadorStub procesador = new ProcesadorStub ();
            procesador.SetPlataforma(plataforma);

            TaggerMensajes tagger = new TaggerMensajes(archivo,procesador);
            Mensaje mensaje = tagger.EtiquetarMensaje();
            Assert.AreEqual(mensaje.Tipo(),TipoMensaje.Numero);



        }
        [Test]
        public void TestSiRecibeDesconocidoDevuelveTipoOtros()
        {
            ArchivoInteraccionesStub archivo = new ArchivoInteraccionesStub();
            PlataformaStub plataforma = new PlataformaStub("ajklsdfhnkajbsacbkzdbajkbf");
            ProcesadorStub procesador = new ProcesadorStub ();
            procesador.SetPlataforma(plataforma);

            TaggerMensajes tagger = new TaggerMensajes(archivo,procesador);
            Mensaje mensaje = tagger.EtiquetarMensaje();
            Assert.AreEqual(mensaje.Tipo(),TipoMensaje.Otros);
        }

    }
}