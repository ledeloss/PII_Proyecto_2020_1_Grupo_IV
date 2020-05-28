using System.Collections.Generic;
namespace Library
{
    public class Mensaje
    {
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