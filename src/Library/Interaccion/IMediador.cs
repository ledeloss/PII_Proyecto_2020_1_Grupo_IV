namespace Library
{
/// <summary>
/// La interface IMedidador es implementada por controlador, clase que implementará el método notificar.
/// Aplicamos DIP, para que controlador no dependa de otra clase, creamos la interfaz si se producen cambios en los detalles de las abstracciones, 
/// no se produzcan en las clases, para que el diseño sea más fácil de cambiar.
/// </summary>
 
    public interface IMediador
    {         

        void Notificar(Mensaje mensaje);
        
    }

   
}








