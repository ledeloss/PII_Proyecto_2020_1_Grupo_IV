using System.Collections.Generic;
using NUnit.Framework;
using System;
using Library;


namespace Library.Test
{

    public class TestAdapterAzure
    {
        [Test]
        public void TestDevuelvaFormatoCorrectoDeFrasesClaves()
        {
            PlataformaStub plataforma = new PlataformaStub("me gusta el futbol");
            AdapterAzure adapter = new AdapterAzure();
            List<string> frases = new List<string> ();
            List<string> frasesAzure = adapter.GetFrasesClave(plataforma.RecibirMensaje());
            frases.Add("futbol");
            Assert.AreEqual(frases,frasesAzure);
        }
    }
}