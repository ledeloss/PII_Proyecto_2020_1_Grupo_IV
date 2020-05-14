
using System;
using System.Collections.Generic;

namespace Library
{

/* Interfase que sera quien genere la lista de regalos dependiendo de los filtros aplicados por esto hereda de IFiltro
utilizando asi reutilización de código
*/
    public interface ITienda
    {
        //public List<T> regalos = new List<T>();
        
        void GenerarListaRegalos(IFiltro<T> filtro)
        {
            
        }
         void InstanciarApiTienda(IFiltro<T> filtro)
        {
            
        }

    }
}