using System;
using System.Collections.Generic;

namespace Library
{

    /* Clase que se encarga de procesar los mensajes con el Usuario, revisa las reglas configuradas 
    para saber los tipos de interacciones esperados, tambien genera los filtros especifiocs necesarios para interatuar 
    con las Tiendas como MercaoLibre o Amazon.
    */
    public class Procesador : IProcesador
    {
        public string getContenido()
        {
            throw new NotImplementedException();
        }

        public List<string> getFrasesClave()
        {
            throw new NotImplementedException();
        }

        public bool ValidarMensaje ()
        {
            return true;
        }

        void GenerarFiltro ()
        {

        }

        void InterpretarInteraccion ()
        {

        }
    }
}