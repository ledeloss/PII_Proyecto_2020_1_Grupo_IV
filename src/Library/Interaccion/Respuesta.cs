using System;
using System.Collections.Generic;

namespace Library
{

    /* Clase que genera la respuesta dependiendo el tipo de interaccion que tenga el usuario con el bot
        Se le da esta responsabiliadad para aplicar el Principio de SRP, inicialmente esto lo iba a hacer el mismo
        Procesador pero decidimos generar esta nueva clase y asignarle esta responsabilidad.
    */
    public class Respuesta
    {
        public String GenerarRespuesta (string TipoInteraccion)
        {
            return "";
        }
    }
}