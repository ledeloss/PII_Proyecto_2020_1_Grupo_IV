
using System;
using System.Collections.Generic;

namespace Library
{

/* Interfase que sera quien genere la lista de regalos dependiendo de los filtros aplicados. 
*/
    public interface ITienda
    {   
        List <Regalo> GenerarListaRegalos(IFiltro filtro);
        void InstanciarApiTienda();

    }
}