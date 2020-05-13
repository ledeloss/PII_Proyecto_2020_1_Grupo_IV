using System;
using System.Collections.Generic;

namespace Library
{

/* Interfase que sera el molde para manejar los archivos con los cuales trabajemos tanto para guardar información como para manipularla
utilizando asi reutilización de código
*/

    public interface IManejadorArchivos
    {
        String LeerArchivo(string archivo);
        void GenerarArchivo();
        void EscribeArchivo();
        void EliminarArchivo();
    }
}
