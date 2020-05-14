using System;
using System.Collections.Generic;

namespace Library
{

/* Interfase que sera el molde para las diferentes API que utilizaremos, que la implementaran
utilizando asi reutilización de código
*/
    public class Consola : IPlataforma
    {
       public string RecibirMensaje()
       {
           return "";
       }
        public void EnviarMensaje()
        {}
    }
}
