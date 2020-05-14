using System.Collections.Generic;

namespace Library
{
    public class MercadoLibre : ITienda
    {
        public List<Regalo> GenerarListaRegalos(IFiltro filtro)
        {
            return new List<Regalo>();
        }

        public void InstanciarApiTienda()
        {
            /*
            Aplicando el patrón Creator, la clase MercadoLibre es la encargada de crear la instancia de API necesaria
            para comunicarse con el sitio, ya que la vida de ApiML está condicionada por el uso de MercadoLibre.
            Además, se va a generar una única instancia de ApiML, aplicando Singleton, para asegurar un único acceso al sitio 
            */

        }
    }
}