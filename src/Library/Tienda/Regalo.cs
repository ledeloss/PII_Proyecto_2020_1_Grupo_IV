using System;
using System.Collections.Generic;

namespace Library
{
/// <summary>
/// La clase Regalo tiene todos los atributos que necesitamos de un regalo
/// </summary>

    public class Regalo
    {
        public string Nombre
        {
            get;
            set;
        }
        public int Precio
        {
            get;
            set;
        }
        public string Descripcion
        {
            get;
            set;
        }
        public string Url
        {
            get;
            set;
        }
        public string Imagen
        {
            get;
            set;
        }

        /* Aplicamos patrón Expert, ya que el dueño de los datos que es Regalo devuelve el regalo en 
        forma de texto y es el encargado de hacerlo porque tiene toda la información disponible para ello 
        y es su responsabilidad.
        */
        public string DeRegaloATexto ()
        {
            return "";
        }
    }
}