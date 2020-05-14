using System;
using System.Collections.Generic;

namespace Library
{

/* Interfase que sera el molde para las diferentes API que utilizaremos, que la implementaran
utilizando asi reutilización de código
*/
    public interface IPlataforma
    {
        string RecibirMensaje();
        void EnviarMensaje(string mensaje);
    }
}
