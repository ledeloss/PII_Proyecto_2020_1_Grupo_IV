using System;
using System.Collections.Generic;

namespace Library
{
/// <summary>
/// La interfase ITienda sera quien genere la lista de regalos dependiendo de los filtros aplicados.
/// Decidimos manejar las Tiendas de esta manera para facilitar las eventuales adiciones de futuras plataformas
/// pudiendo extender nuestro programa sin tener que modificar otras clases, por tal motivo identificamos aqui 
/// el Patron OCP es justamente lo que utilzamos aqui.
/// </summary>

    public interface ITienda
    {
        List<Regalo> GenerarListaRegalos (IFiltro filtro);

        void InstanciarApiTienda ();

    }
}