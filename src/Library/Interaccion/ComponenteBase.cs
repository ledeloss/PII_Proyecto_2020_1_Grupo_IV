namespace Library
{
    public class ComponenteBase
    {
        protected IMediador mediador;

        public ComponenteBase(IMediador mediador = null)
        {
            this.mediador = mediador;
        }

        public void SetMediador(IMediador mediador)
        {
            this.mediador = mediador;
        }
    }
    }
