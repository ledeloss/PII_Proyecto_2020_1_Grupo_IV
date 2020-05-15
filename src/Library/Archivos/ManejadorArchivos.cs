using System;
using System.Collections.Generic;

namespace Library
{

    /* Clase la cual por medio de Herencia se podra servira de molde para manejar los archivos con los cuales trabajemos tanto para guardar información como para manipularla
    utilizando asi reutilización de código.
    */

    public class ManejadorArchivos
    {
        protected virtual String LeerArchivo (string archivo)
        {
            return "";
        }
        public virtual void GenerarArchivo ()
        { }
        public virtual void ModificarArchivo ()
        { }
        public virtual void EliminarArchivo ()
        { }
    }
}