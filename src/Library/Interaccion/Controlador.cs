using System;

namespace Library
{
 class Controlador : IMediador
    {
        private TaggerMensajes componente1;
        private Procesador componente2;
        private IRespuesta componente3;
        private IBusqueda componente4;
        private IGeneradorPerfil componente5;

        public MediadorConcreto(TaggerMensajes componente1,Procesador componente2,IRespuesta componente3,IBusqueda componente4,IGeneradorPerfil componente5)
        {
            this.componente1 = componente1;
            this.componente1.SetMediador(this);
            this.componente2 = componente2;
            this.componente2.SetMediador(this);
            this.componente3 = componente3;
            this.componente3.SetMediador(this);
            this.componente4 = componente4;
            this.componente4.SetMediador(this);
            this.componente5 = componente5;
            this.componente5.SetMediador(this);
        } 
        public void Notificar(object sender, Mensaje mensaje)
        {
            if (mensaje.Tipo() == TipoMensaje.Despedida)
            {
                Console.WriteLine("Mediator reacts on A and triggers folowing operations:");
                this.componente3.Responder();
            }
            if (mensaje.Tipo() == TipoMensaje.)
            {
                Console.WriteLine("Mediator reacts on D and triggers following operations:");
                this.component1.DoB();
                this.component2.DoC();
            }
        }
    }
}

