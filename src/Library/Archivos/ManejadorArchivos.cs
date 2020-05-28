using System;
using System.Collections.Generic;
using System.IO;

namespace Library
{

    /* Clase la cual por medio de Herencia  servira de molde para manejar los archivos con los cuales trabajemos tanto para guardar información como para manipularla
    utilizando asi reutilización de código.
    */

    public class ManejadorArchivos
    {
        protected virtual String LeerArchivo (string archivo)
        {
            return "";
        }

        protected virtual String LeerLineaAleatoria (string path)
        {

            string[] lines = File.ReadAllLines (path);
            var r = new Random ();
            int randomLineNumber = r.Next (0, lines.Length - 1);
            string line = lines[randomLineNumber];
            return line;

        }
        public virtual void GenerarArchivo (string nombre, string contenido)
        { }
        public virtual void ModificarArchivo (string nombre, string contenido)
        { }
        public virtual void EliminarArchivo (string archivo)
        { }
    }
}