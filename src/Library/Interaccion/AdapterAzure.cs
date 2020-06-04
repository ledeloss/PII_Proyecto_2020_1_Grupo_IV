using System.Collections.Generic;
namespace Library
{

/// <summary>
/// AdapterAzure es una clase que fue creada para interactuar con los servicios externos de Azure para asi utilizarlos en nuestro programa.
/// Esta Clase sirve de traductor entre la clase de la API Externa (Azure-TextAnalytics) y la clase TaggerMensaje .
/// Utilizamos el Patron Adapter,para manejar unicamente temas relacionados a adaptacion de datos y no involucrarnos con conocer
/// el funcionamiento interno del Servicio externo.
/// Se le Delega a TextAnalyticsAzure (Clase Externa) la responsabiliad de conocer como conseguir las Palabras clave dado un texto de entrada.
/// </summary>
    public class AdapterAzure: IProcesador
    {
        private IPlataforma plataforma;
        private readonly TextAnalyticsAzure azure = new TextAnalyticsAzure();

        public AdapterAzure()
        {
            
        }
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