using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
/// <summary>
/// La clase Respuesta genera la respuesta dependiendo del tipo de interacción que tenga el usuario con el bot.
/// Le asignamos la responsabilidad a respuesta teniendo un solo tipo de cambio, ya que en principio el tipo de respuesta seran mensajes,
/// aplicamos SRP.
/// </summary>
    public class Respuesta: ComponenteBase
    {
        
        private IPlataforma plataforma;
        private static ArchivoInteracciones Interacciones = new ArchivoInteracciones ();

        public void SetPlataforma(IPlataforma plat)
        {
            this.plataforma=plat;
        }
        public void Saludar ()
        {
            plataforma.EnviarMensaje(Interacciones.GetInteraccion ("saludar"));
        }
        public void Despedirse ()
        {
            plataforma.EnviarMensaje(Interacciones.GetInteraccion ("despedir"));
        }
        public void PreguntarGenero ()
        {

            plataforma.EnviarMensaje(Interacciones.GetInteraccion ("genero"));

        }
        public void PreguntarEdad ()
        {

            plataforma.EnviarMensaje(Interacciones.GetInteraccion ("edad"));

        }
        public void PreguntarIntereses ()
        {

            plataforma.EnviarMensaje(Interacciones.GetInteraccion ("interes"));

        }
        public void PreguntarPrecioMaximo ()
        {

            plataforma.EnviarMensaje(Interacciones.GetInteraccion ("maximo"));

        }

        public void PreguntarPrecioMinimo ()
        {

            plataforma.EnviarMensaje(Interacciones.GetInteraccion ("minimo"));

        }
        public void PedirAclaraciones (TipoEnvio tipo)
        {
            string envio = "";
            envio += Interacciones.GetInteraccion ("aclaracion");
            envio += "\n";
            string tipoString = tipo.ToString().ToLower();
            envio += Interacciones.GetInteraccion(tipoString);
        }

        public void PresentarSugerencias (List<string> regalos)
        {
            string resultado = Interacciones.GetInteraccion ("presentaSugerencia");
            foreach (string regalo in regalos)
            {
                resultado += "\n" + regalo;
            }
            plataforma.EnviarMensaje(resultado);

        }
        public void ConfirmarSugerencia ()
        {

            plataforma.EnviarMensaje(Interacciones.GetInteraccion ("sugerencia"));

        }

        public void Preguntar (TipoEnvio tipo)
        {
            switch (tipo)
            {
                case TipoEnvio.Genero:
                    this.PreguntarGenero ();
                    break;

                case TipoEnvio.Despedida:
                    this.Despedirse ();
                    break;

                case TipoEnvio.Edad:
                    this.PreguntarEdad ();
                    break;

                case TipoEnvio.Interes:
                    this.PreguntarIntereses ();
                    break;

                case TipoEnvio.PrecioMax:
                    this.PreguntarPrecioMaximo ();
                    break;

                case TipoEnvio.PrecioMin:
                    this.PreguntarPrecioMinimo ();
                    break;

                case TipoEnvio.Saludo:
                    this.Saludar ();
                    break;
                    
                case TipoEnvio.Sugerencia:
                    List<string> lista = new List<string>();
                    lista.Add("Regalo1");
                    this.PresentarSugerencias (lista);
                    break;

            }
        }
    }
}