using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IProcesador procesador = new Procesador();
            ArchivoInteracciones archivoInteracciones = new ArchivoInteracciones();   
            TaggerMensajes taggerMensaje  = new TaggerMensajes(archivoInteracciones,procesador);
            IBusqueda busqueda = new IBusqueda();
            Respuesta respuesta = new Respuesta();
            IGeneradorPerfil generadorPerfil = new IGeneradorPerfil();
            Controlador controlador = new Controlador(taggerMensaje,respuesta,busqueda,generadorPerfil);

            //Inicializa el Dialogo.
            controlador.Dialogo();




        }
    }
}
