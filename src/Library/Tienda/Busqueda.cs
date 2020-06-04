using System;
using System.Collections.Generic;

namespace Library
{
/// <summary>
/// La clase Busqueda es responsable de realizar la busqueda en las tiendas con los filtros proporcionados.
/// Decidimos hacer la busqueda en una clase independiente y que no tenga mas de una razon para cambiar, para simplificar el codigo 
/// y haciendolo mas simple de mantener, utilizando el Principio SRP.  
/// </summary>

    public class Busqueda: ComponenteBase
    {
        void GenerarBusqueda (ITienda tienda, IFiltro filtro)
        {

        }
    }
}