using System;
using System.Collections.Generic;

namespace Library
{

    /* Interfase que sera el molde para las diferentes API que utilizaremos, que la implementaran
    utilizando asi reutilización de código.
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
         Aplicando el patrón Creator, la clase API es la encargada de crear la instancia de las API de Mensajeria, ya que la vida de Whatsapp o Telegram están condicionadas por el uso de API.
         Además, se va a restringir a solo uns instancia de las API de Mensajeria que nos proporcionen los Profesores, aplicando Singleton, para asegurar una unica instancia.
         */
        public void InstanciarApi ()
        {

        }

        public void ActulizarConfiguracion ()
        {

        }
    }
}