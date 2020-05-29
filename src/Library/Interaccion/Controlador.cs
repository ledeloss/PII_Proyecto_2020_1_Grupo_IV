using System;

namespace Library
{
    public class Controlador : IMediador
    {
        private TaggerMensajes taggerMensajes;
       
        private Respuesta respuesta;
        private IBusqueda busqueda;
        private IGeneradorPerfil generadorPerfil;
        private TipoEnvio ultimoEnvio;
        private bool ProcesamientoExitoso = false;
        public Controlador(TaggerMensajes taggerMensajes,Respuesta respuesta,
        IBusqueda busqueda,IGeneradorPerfil generadorPerfil)
        {
            this.taggerMensajes = taggerMensajes;
            this.taggerMensajes.SetMediador(this);
            this.respuesta = respuesta;
            this.respuesta.SetMediador(this);
            this.busqueda = busqueda;
            this.busqueda.SetMediador(this);
            this.generadorPerfil = generadorPerfil;
            this.generadorPerfil.SetMediador(this);
        } 
        public void Notificar(Mensaje mensaje)
        {
            switch (mensaje.Tipo())
            {
                case TipoMensaje.Genero:
                    if ((ultimoEnvio==TipoEnvio.Genero) || (ultimoEnvio==TipoEnvio.Saludo))
                    {
                        generadorPerfil.SetGenero(mensaje.Contenido());
                        ProcesamientoExitoso=true;  
                    }
                    else 
                    {
                        ProcesamientoExitoso=false;
                    }
                    break;
            }

            if(ProcesamientoExitoso)
            {
                this.ultimoEnvio=generadorPerfil.getDatoFaltante();
                if(this.ultimoEnvio==TipoEnvio.Sugerencia)
                {
                    //Hacer busqueda
                }
                else 
                {
                    respuesta.Preguntar(ultimoEnvio);
                }  
            }
            else
            {
                respuesta.PedirAclaraciones(ultimoEnvio);
            }
        }
    }
}

