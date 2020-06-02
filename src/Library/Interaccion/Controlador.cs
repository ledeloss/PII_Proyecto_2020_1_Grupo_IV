using System;

namespace Library
{

/// <summary>
/// La clase controlador se encarga de manejar la interaccion entre el usuario y el bot. Maneja los mensajes entre ambos.
/// Hereda de IMediador lo que nos permite reutilizar codigo, resulta util ya que esta interfaz contiene el metodo notificar que vamos a reutilizar
/// en la interaccion antes mencionada.
/// </summary>
    public class Controlador : IMediador
    {
        private TaggerMensajes taggerMensajes;

        private Respuesta respuesta;
        private IBusqueda busqueda;
        private GeneradorPerfil generadorPerfil;
        private TipoEnvio ultimoEnvio;
        private bool ProcesamientoExitoso = false;
        public Controlador (TaggerMensajes taggerMensajes, Respuesta respuesta,
            IBusqueda busqueda, GeneradorPerfil generadorPerfil)
        {
            this.taggerMensajes = taggerMensajes;
            this.taggerMensajes.SetMediador (this);
            this.respuesta = respuesta;
            this.respuesta.SetMediador (this);
            this.busqueda = busqueda;
            this.busqueda.SetMediador (this);
            this.generadorPerfil = generadorPerfil;
            this.generadorPerfil.SetMediador (this);
        }
        public void Dialogo()
        {
            this.ultimoEnvio = TipoEnvio.Saludo;
            this.respuesta.Saludar();

            while (this.ultimoEnvio != TipoEnvio.Despedida)
            {
                taggerMensajes.GetMensajeEntrante();
            }
        }

        public void Notificar (Mensaje mensaje)
        {
            switch (mensaje.Tipo ())
            {
                case TipoMensaje.Genero:

                    if ((ultimoEnvio == TipoEnvio.Genero) || (ultimoEnvio == TipoEnvio.Saludo))
                    {
                        generadorPerfil.SetGenero (mensaje.Contenido ());
                        ProcesamientoExitoso = true;
                    }
                    else
                    {
                        ProcesamientoExitoso = false;
                    }
                    break;

                case TipoMensaje.Numero:

                    switch (ultimoEnvio)
                    {
                        case TipoEnvio.Edad:
                            generadorPerfil.SetEdad (mensaje.Contenido ());
                            ProcesamientoExitoso = true;
                            break;

                        case TipoEnvio.PrecioMax:
                            generadorPerfil.SetPrecioMaximo (mensaje.Contenido ());
                            ProcesamientoExitoso = true;
                            break;

                        case TipoEnvio.PrecioMin:
                            generadorPerfil.SetPrecioMinimo (mensaje.Contenido ());
                            ProcesamientoExitoso = true;
                            break;

                        default:
                            ProcesamientoExitoso = false;
                            break;

                    }
                    break;

                case TipoMensaje.Interes:

                    if ((ultimoEnvio == TipoEnvio.Interes) || (ultimoEnvio == TipoEnvio.Saludo))
                    {
                        generadorPerfil.SetInteres (mensaje.Contenido ());
                        ProcesamientoExitoso = true;
                    }
                    else
                    {
                        ProcesamientoExitoso = false;
                    }
                    break;

                case TipoMensaje.Positivo:
                    if ((ultimoEnvio == TipoEnvio.Sugerencia))
                    {
                        ProcesamientoExitoso = true;
                    }
                    else
                    {
                        ProcesamientoExitoso = false;
                    }
                    break;

                case TipoMensaje.Negativo:
                    if ((ultimoEnvio == TipoEnvio.Sugerencia))
                    {
                        ultimoEnvio = TipoEnvio.Despedida;
                        ProcesamientoExitoso = true;
                    }
                    else
                    {
                        if ((ultimoEnvio == TipoEnvio.Genero))
                        { //TipoGenero Desconocido si no quiere brindar el Genero
                            generadorPerfil.SetGenero (mensaje.Contenido ());
                            ProcesamientoExitoso = true;
                        }
                        else
                        {
                            ProcesamientoExitoso = false;
                        }
                    }
                    
                    break;

                case TipoMensaje.Saludo:
                    ProcesamientoExitoso = (ultimoEnvio == TipoEnvio.Saludo);

                    break;

                case TipoMensaje.Despedida:
                    ultimoEnvio = TipoEnvio.Despedida;
                    ProcesamientoExitoso = false;

                    break;

                case TipoMensaje.Otros:
                    ProcesamientoExitoso = false;

                    break;

            }

            if (ProcesamientoExitoso)
            {
                this.ultimoEnvio = generadorPerfil.getDatoFaltante ();
                if (this.ultimoEnvio == TipoEnvio.Sugerencia)
                {
                    //Hacer busqueda
                }
                else
                {
                    respuesta.Preguntar (ultimoEnvio);
                }
            }
            else
            {
                respuesta.PedirAclaraciones (ultimoEnvio);
            }
        }
    }
}