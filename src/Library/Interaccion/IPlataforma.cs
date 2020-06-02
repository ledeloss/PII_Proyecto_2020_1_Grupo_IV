using System;
using System.Collections.Generic;

namespace Library
{

/// <summary>
/// La interfase IPlataforma sera el molde para las comunicaciones ya sea API o Consola. Reutilizamos codigo, y decidimos utilizar esta interfase
/// de forma tal que nos permita extender a futuras plataformas sin romper el funcionamiento. Utilizamos aqui OCP.
/// Cuando extendamos no tendremos que modificar el codigo simplemente utilizando la interfase IPlataforma podremos hacerlo. Para esto nos fue
/// util utilizar OCP (clase abierta a la extension y cerrada a la modificacion)
/// </summary>
    
    public interface IPlataforma
    {
        string RecibirMensaje ();
        void EnviarMensaje (string mensaje);
    }
}