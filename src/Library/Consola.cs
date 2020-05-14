using System;
using System.Collections.Generic;

namespace Library
{

/* Alternativa de comunicación con el usuario, para interactuar con el bot mediante la consola
*/
    public class Consola : IPlataforma
    {
       public string RecibirMensaje()
       {
           return "";
       }
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
