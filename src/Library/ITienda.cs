
using System;
using System.Collections.Generic;

namespace Library
{

/* Interfase que sera quien genere la lista de regalos dependiendo de los filtros aplicados por esto hereda de IFiltro
utilizando asi reutilización de código
*/
    public interface ITienda: IFiltro
    {
        public List<Regalo> regalos = new List<IMagicalItem>();
        
        void GenerarListaRegalos(IFiltro filtro)
        {
            
        }

    }
}