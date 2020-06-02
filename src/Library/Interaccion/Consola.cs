using System;
using System.Collections.Generic;

namespace Library
{
/// <summary>
/// La clase Consola es una alternativa de comunicación con el usuario, para interactuar con el bot mediante la consola
/// Implementa a la interface IPlataforma por lo que se ve obligada a proporcionar una  implementación de los miembros definidos en la interfaz.
/// Contiene los Metodos basicos para interactuar con un usuaurio mediante la entrada y salida de mensajes.      
/// </summary>

   
    public class Consola : IPlataforma
    {
        public string RecibirMensaje ()
        {
            string input = Console.ReadLine();
            return input;
        }
        public void EnviarMensaje (string mensaje)
        {
            Console.WriteLine (mensaje);
        }

    }
}