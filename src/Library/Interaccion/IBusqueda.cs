namespace Library
{

/// <summary>
/// La interfase IBusqueda se encargara de ser el molde las busquedas.
/// Hereda de componenteBase con el fin de reutilizar codigo y formar parte de los componentes que se 
/// vinculan con Controlador (nuestro Mediador).
/// La idea es que las clases concretas que implementen esta interface puedan vincularse con el Controlador mediante
/// esta abstraccion.
/// Esta clase no forma parte del core de procesamiento por lo que sera desarrollada en la proxima entrega.
/// </summary>
    public class IBusqueda: ComponenteBase
    {

    }
}