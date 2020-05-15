using System;
using System.Collections.Generic;

namespace Library
{

    /*  Implementacion de IPlataforma para la interaccion con Aplicaciones
     */
    public class API : IPlataforma
    {
        public string RecibirMensaje ()
        {
            return "";
        }
        public void EnviarMensaje (string mensaje)
        { }
        /*
         Aplicando el patrón Creator, la clase API es la encargada de crear la instancia de las API de Mensajeria, 
         ya que la vida de Whatsapp o Telegram están condicionadas por el uso de API.
         Además, se va a restringir a solo una instancia de las API de Mensajeria que nos proporcionen los Profesores,
        aplicando Singleton.
        Tambien identificamos  Composicion - Delegacion, Se le delega la Responsabilidad de resolver todo lo relativo
        a la Comunicacion con la Api de Mensajeria a la clase por ejemplo "ApiTelegram"
        */
        public void InstanciarApi ()
        {

        }

        public void ActulizarConfiguracion ()
        {

        }
    }
}