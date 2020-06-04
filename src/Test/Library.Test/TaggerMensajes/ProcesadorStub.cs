using System.Collections.Generic;

namespace Library.Test
{

    internal class ProcesadorStub : IProcesador
    {
        private IPlataforma plataforma;
        public void SetPlataforma (IPlataforma plat)
        {
            this.plataforma = plat;
        }
        public string GetContenido()
        {
           return plataforma.RecibirMensaje();
        }

        public List<string> GetFrasesClave(string texto)
        {
           return new List<string>();
        }
    }
}