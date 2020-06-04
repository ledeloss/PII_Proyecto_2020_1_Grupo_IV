using System.Collections.Generic;
namespace Library
{

/// <summary>
/// La clase Mensaje contiene todo lo correspondiente a los mensajes intercambiados con el usuario.
/// Setea el tipo, obtiene las frases clave y si son frases nuevas las agrega.
/// </summary>
    public class Mensaje
    {

/// <summary>
/// Aplicamos patrón Expert, ya que el dueño de los datos que es Mensaje setea todos los datos porque tiene toda la información
/// disponible para ello y es su responsabilidad
/// </summary>
        private string contenido;
        private TipoMensaje tipo;
        private List<string> frasesClave = new List<string>();

        public string Contenido()
        {
            return this.contenido;
        }
        public void SetContenido(string text)
        {
            this.contenido = text;
        }

        public TipoMensaje Tipo()
        {
            return this.tipo;
        }
        public void SetTipo(TipoMensaje tipoNuevo)
        {
            this.tipo = tipoNuevo;
        }
        public List<string> FrasesClave()
        {
            return this.frasesClave;
        }
        public void AddFraseClave (string fraseNueva)
        {
            this.frasesClave.Add(fraseNueva);
        }

        public Mensaje()
        {
        }
        public Mensaje (string cont, TipoMensaje tipoMensaje, List<string> claves)
        {
            this.contenido = cont;
            this.tipo = tipoMensaje;
            this.frasesClave = claves;
        }
    }
}