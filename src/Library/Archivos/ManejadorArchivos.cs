using System;
using System.Collections.Generic;
using System.IO;

namespace Library
{

/// <summary>
/// La clase ManejadorArchivos tendra todo lo necesario para trabajar con los archivos que utilizaremos tanto para la configuracion, la interaccion
/// o el armado del perfil del usuario. Sera la base para todo lo que respecta archivos, por medio de herencia reutilizaremos el codigo de esta clase.
/// Lo cual nos facilitara el desarrollo de las clases que manejan los archivos anteriormente mencionados.
/// </summary>

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