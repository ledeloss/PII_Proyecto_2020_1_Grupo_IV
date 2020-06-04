using System;
using System.Collections.Generic;

namespace Library
{
/// <summary>
/// La interfase IGeneradorPreguntas es implementada por preguntasOrdenAleatorio, tiene un unico metodo que sera util para avanzar en las preguntas
/// de la interaccion con el usuario. 
/// </summary>
    public interface IGeneradorPreguntas
    {
        TipoEnvio GetSiguientePregunta();   
       
    }
}