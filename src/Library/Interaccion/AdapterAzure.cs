using System.Collections.Generic;
namespace Library
{

/// <summary>
/// La clase es una clase auxiliar que adapta los servicios de azure para utilizarlos en nuestro programa.
/// </summary>
    public class AdapterAzure: IProcesador
    {


        private IPlataforma plataforma;
        private readonly TextAnalyticsAzure azure;
        public AdapterAzure(TextAnalyticsAzure cerebro)
        {
            this.azure = cerebro;
        }
        public void SetPlataforma (IPlataforma plat)
        {
            this.plataforma = plat;
        }
        public string GetContenido()
        {
            return plataforma.RecibirMensaje();
        }
        public List<string> GetFrasesClave(string texto)
        {
            return this.azure.KeyPhraseExtraction(texto);
        }
    }
}