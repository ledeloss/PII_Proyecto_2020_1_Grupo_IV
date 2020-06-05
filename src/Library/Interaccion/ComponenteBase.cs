namespace Library
{
    /// <summary>
    /// Es una clase de la cual se heredaran los comportamientos necesarios para implementar el Patron Mediator.
    /// Las clases que herdean de esta clase ComponenteBase van a componer a la Clase Compuesta Controlador (nuestro Mediador)
    /// Manejarlo de esta manera permite que el mediador pueda eventualemte agregar nuevos componentes permitiendo la Extension.
    /// </summary>
    public class ComponenteBase
    {
        protected IMediador mediador;

        public ComponenteBase (IMediador mediador = null)
        {
            this.mediador = mediador;
        }
        
        public void SetMediador (IMediador mediador)
        {
            this.mediador = mediador;
        }
    }
}