using System.Collections.Generic;

namespace Library
{
    /*
    Se implementa una ITienda,por definicion esta obligado a Implementar todos los metodos
    definidos en ITienda en este caso utilizando Amazon para procesar el resultado de la comunicacion
    con la APi de Amazon. Nos interesa obtener de esa Tienda una Lista de objetos Regalo.
    
     */

    public class Amazon : ITienda
    {
        public List<Regalo> GenerarListaRegalos (IFiltro filtro)
        {
            return new List<Regalo> ();
        }

        public void InstanciarApiTienda ()
        {
            /*
            Aplicando el patrón Creator, la clase Amazon es la encargada de crear la instancia de API necesaria
            para comunicarse con el sitio, ya que la vida de ApiAmazon está condicionada por el uso de Amazon.
            Además, se va a generar una única instancia de ApiAmazon, aplicando Singleton, para asegurar un único acceso al sitio 
            */

        }
    }
}