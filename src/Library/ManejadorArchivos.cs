using System;
using System.Collections.Generic;

namespace Library
{

/* Interfase que sera el molde para manejar los archivos con los cuales trabajemos tanto para guardar información como para manipularla
utilizando asi reutilización de código
*/

    public class ManejadorArchivos
    {
        protected virtual String LeerArchivo(string archivo)
        {
            return "";
        }
        public virtual void GenerarArchivo(){}
        public virtual void ModificarArchivo(){}
        public virtual void EliminarArchivo(){}
    }
}
