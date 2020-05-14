using System.Collections.Generic;

namespace Library
{
    public class Amazon : ITienda
    {
        public List<Regalo> GenerarListaRegalos(IFiltro filtro)
        {
            return new List<Regalo>();
        }

        public void InstanciarApiTienda()
        {
            /*
            Aplicando el patrón Creator, la clase Amazon es la encargada de crear la instancia de API necesaria
            para comunicarse con el sitio, ya que la vida de ApiAmazon está condicionada por el uso de Amazon.
            Además, se va a generar una única instancia de ApiAmazon, aplicando Singleton, para asegurar un único acceso al sitio 
            */

        }
    }
}