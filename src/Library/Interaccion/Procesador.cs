using System;
using System.Collections.Generic;

namespace Library
{

    /* Clase que se encarga de procesar los mensajes con el Usuario, revisa las reglas configuradas 
    para saber los tipos de interacciones esperados, tambien genera los filtros especifiocs necesarios para interactuar 
    con las Tiendas como MercaoLibre o Amazon.
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