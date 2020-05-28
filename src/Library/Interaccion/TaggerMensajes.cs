using System;
namespace Library
{
    public class TaggerMensajes: ComponenteBase
    {
        protected IMediador mediador;
        public TaggerMensajes(IMediador mediador = null)
        {
            this.mediador = mediador;
        }
        public void SetMediador(IMediador mediador)
        {
            this.mediador = mediador;
        }
    }
}