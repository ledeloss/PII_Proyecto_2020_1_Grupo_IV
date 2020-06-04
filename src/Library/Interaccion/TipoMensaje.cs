namespace Library
{

    /// <summary>
    /// TipoMensaje define todos los valores que aceptamos como categorías de interacciones Entrantes 
    /// desde la Plataforma , TaggerMensajes será el que se encargue de categorizar en uno de estos tipos al contenido entrante.
    /// </summary>
    public enum TipoMensaje
    {
        Numero,
        Genero,
        Interes,
        Saludo,
        Despedida,
        Positivo,
        Negativo,
        Otros
    }
}