using System.Collections.Generic;

namespace Library
{
    /*Dado que cada tienda puede tener parámetros distintos para filtrar sus publicaciones, por SRP, generamos clases
    individuales para que la única razón de cambio de la clase sea que cambia el sistema de filtrado de la
    página a la que brindan acceso.
    */
    public class FiltroAmazon : IFiltro
    {
        public List<string> interes { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int PrecioMin { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int PrecioMax { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Genero { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Edad { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public void GenerarFiltro()
        {
            /*Por Expert, esta clase tiene todos los datos para generar el filtro requerido por la página*/
        }
    }
}