using System;

namespace Library
{
 class Controlador : IMediador
    {
        private string component1;
        private string component2;
/*
        public MediadorConcreto(Component1 component1, Component2 component2)
        {
            this._component1 = component1;
            this._component1.SetMediator(this);
            this._component2 = component2;
            this._component2.SetMediator(this);
        } 
*/
        public void Notificar(object sender, string ev)
        {
            if (ev == "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers folowing operations:");
                this.component2.DoC();
            }
            if (ev == "D")
            {
                Console.WriteLine("Mediator reacts on D and triggers following operations:");
                this.component1.DoB();
                this.component2.DoC();
            }
        }
    }
}

