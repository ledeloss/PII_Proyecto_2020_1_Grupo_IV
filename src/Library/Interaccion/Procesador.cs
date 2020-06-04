using System;
using System.Collections.Generic;

namespace Library
{

    /* Procesador es una clase de la cual se heredarán otras clases como por ejemplo 
     para vincular una determinada Plataforma (En este caso una abrstraccion IPlataforma)
    */
    public class Procesador : IProcesador
    {
        private string UltimoMensaje;
        private IPlataforma plataforma;
        public void SetPlataforma(IPlataforma plat)
        {
            this.plataforma = plat;
        }
        public string GetContenido() //1ero
        {
            string mensaje = plataforma.RecibirMensaje();
            this.UltimoMensaje = mensaje;
            return mensaje;
        }


        public List<string> GetFrasesClave(string texto)//2do
        {
            throw new NotImplementedException();
        }

        public bool ValidarMensaje ()
        {
            return true;
        }
        

    }
}