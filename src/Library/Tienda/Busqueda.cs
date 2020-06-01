using System;
using System.Collections.Generic;

namespace Library
{

    /* Clase responsable de realizar la busqueda en las tiendas con los filtros proporcionados.
        Decidimos hacer la busqueda en una clase independiente y que no tenga mas de una razon para cambiar,
        utilizando el Principio SRP. 
    */
    public class Busqueda: ComponenteBase
    {
        void GenerarBusqueda (ITienda tienda, IFiltro filtro)
        {

        }
    }
}