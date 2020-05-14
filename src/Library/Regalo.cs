using System;
using System.Collections.Generic;

namespace Library
{

/* Clase que realiza la busqueda en las tiendas con los filtros proporcionados, por esto implementa IFiltro e ITienda
*/
    public class Regalo
    {
        public string Nombre { get; set; }
        public int Precio{ get; set; } 
        public string Descripcion{ get; set; }
        public string Url{ get; set; }
        public string Imagen{ get; set; }


/* Aplicamos patrón Experto, ya que el dueño de los datos que es regalo devuelve el regalo en forma de texto y es el encargado 
de hacerlo porque tiene toda la información disponible para ello y es su responsabilidad
*/
        public string DeRegaloaTexto()
        {
            return "";
        }
    }
}