using System;
using System.Collections.Generic;

namespace Library
{
/// <summary>
/// La clase API es la encargada de crear la instancia de las API de mensajeria, implementa IPlataforma para la interaccion con aplicaciones.
/// </summary>
    
    public class API : IPlataforma
    {
        public string RecibirMensaje ()
        {
            return "";
        }
        public void EnviarMensaje (string mensaje)
        { }
        
/// <summary>
/// Aplicando el patrón Creator, la clase API es la encargada de crear la instancia de las API de Mensajeria, 
/// ya que la vida de Whatsapp o Telegram están condicionadas por el uso de API.
/// Tambien identificamos  Composicion - Delegacion, Se le delega la Responsabilidad de resolver todo lo relativo
/// a la Comunicacion con la Api de Mensajeria a la clase por ejemplo "ApiTelegram"
/// </summary>
         
        
        public void InstanciarApi ()
        {

        }

        public void ActulizarConfiguracion ()
        {

        }
    }
}