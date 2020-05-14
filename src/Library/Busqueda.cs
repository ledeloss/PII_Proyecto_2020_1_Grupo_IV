using System;
using System.Collections.Generic;

namespace Library
{

/* Clase que realiza la busqueda en las tiendas con los filtros proporcionados, por esto implementa IFiltro e ITienda
Se utilizan tipos genéricos para considerar los casos de las distintas tiendas
*/
    public class Busqueda<T>
    {
        void GenerarBusqueda(ITienda<T> tienda , IFiltro<T> filtro)
        {

        }
    }
}