using System;

namespace Library
{

/// <summary>
/// Esta es una clase compuesta  que permite mediante sus componentes (heredeados de ComponenteBase) manejar 
/// el flujo de los diferentes objetos involucrados (TaggerMensajes,Respuesta,GeneradorPerfil,etc) 
/// 
/// Decidimos utilizar el Patron Mediator para que la comunicacion entre las diferentes clases se presente de 
/// una forma independiente entre si (reduciendo su acoplamiento), para manejar el Flujo de la aplicacion de una 
/// forma mas clara, mas mantenible y aprovechar la estructura para reutilizar codigo.
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
/// <summary>
/// El metodo Dialogo sera encargado del dialogo con el usuario, si es el ultimo mensaje saluda, de caso contrario recibe los mensajes,
/// continuando con la interacción.
/// </summary>
        public void Dialogo()
        {
            this.ultimoEnvio = TipoEnvio.Saludo;
            this.respuesta.Saludar();

            while (this.ultimoEnvio != TipoEnvio.Despedida)
            {
                taggerMensajes.GetMensajeEntrante();
            }
        }

/// <summary>
/// El método notificar recibe un mensaje y según su tipo continúa con el flujo de comunicación interna.
/// </summary>
/// <param name="mensaje"></param>
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