
using System;
using System.Collections.Generic;

namespace Library
{

/* Interfase que sera quien genere la lista de regalos dependiendo de los filtros aplicados. Los tipos genéricos permiten
flexibilidad entre los filtros implementados por las distintas tiendas
*/
    public interface ITienda<T>
    {   
        List <Regalo> GenerarListaRegalos(IFiltro<T> filtro);
        void InstanciarApiTienda();

    }
}