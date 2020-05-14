using System;
using System.Collections.Generic;


namespace Library
{

/* Interfase que sera el molde con los atributos de los diferentes filtros para llegar al regalo deseado, que la implementaran
utilizando asi reutilización de código
*/
    public interface IFiltro<T>
    {
        List<T> interes { get; set; } 
        int PrecioMin { get; set; }
        int PrecioMax { get; set; }
        string Genero { get; set; }
        int Edad { get; set; }
    }
}
