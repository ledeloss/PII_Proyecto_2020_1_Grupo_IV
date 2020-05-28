using System;
using System.Collections.Generic;

namespace Library
{
    /*
     Interfase que sera el molde para las diferentes API que utilizaremos, estas luego la implementaran Las clases 
     Console y API.
     Decidimos manejar las plataformas de esta manera para facilitar las eventuales adiciones de
    futuras plataformas sin afectar el funcionamiento (Clase Abierta a la Extension) las responsabilidades de la
    clase pueden ser exendidas y es cerrada a la modificacion, (no es posible ni necesario modificar el codigo de 
    dicha clase) Por tal motivo identificamos que el Principio OCP es justamente lo que utilzamos aqui.
    */
    public interface IPlataforma
    {
        string RecibirMensaje ();
        void EnviarMensaje (string mensaje);
    }
}