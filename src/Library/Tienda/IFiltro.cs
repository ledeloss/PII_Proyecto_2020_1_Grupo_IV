using System;
using System.Collections.Generic;

namespace Library
{
/// <summary>
/// Interfase que sera el molde con los atributos de los diferentes filtros para llegar al regalo deseado, 
/// luego sera implementada por un Filtro especifico de una Tienda y alli estariamos utilizando reutilización de código
/// </summary>
    
    public interface IFiltro
    {
        List<string> interes
        {
            get;
            set;
        }
        int PrecioMin
        {
            get;
            set;
        }
        int PrecioMax
        {
            get;
            set;
        }
        string Genero
        {
            get;
            set;
        }
        int Edad
        {
            get;
            set;
        }
        void GenerarFiltro ();
    }
}