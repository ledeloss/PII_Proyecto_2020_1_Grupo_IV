using System;
using System.Collections.Generic;
using System.Globalization;
using Azure;
using Azure.AI.TextAnalytics;

namespace Library
{
/// <summary>
/// La clase TextAnalyticsAzure contiene lo necesario para vincularnos con los servicios de Azure.
/// </summary>
    public class TextAnalyticsAzure
    {
        private static readonly AzureKeyCredential credentials = new AzureKeyCredential ("3eefe592346b436184724d709cb10572");
        private static readonly Uri endpoint = new Uri ("https://eastus.api.cognitive.microsoft.com/");
        public List<string> KeyPhraseExtraction (string texto)
        {
            List<string> frasesClave = new List<string>();
            var client = new TextAnalyticsClient (endpoint, credentials);
            var response = client.ExtractKeyPhrases (texto, "ES");
            Console.WriteLine ("Key phrases:");

            foreach (string keyphrase in response.Value)
            {
                frasesClave.Add(keyphrase);
            }
            return frasesClave;

        }


    }
}