using System.Collections.Generic;

namespace Library.Test
{

    internal class PlataformaStub:IPlataforma
    {
        private string texto ;
        public PlataformaStub(string texto)
        {
            this.texto = texto;

        }
        public string RecibirMensaje()
        {
            return this.texto;
        }

        public void EnviarMensaje(string mensaje)
        {
        }

    }
}