using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{

    /* Clase que genera la respuesta dependiendo el tipo de interaccion que tenga el usuario con el bot
        Se le da esta responsabiliadad para aplicar el Principio de SRP, inicialmente esto lo iba a hacer el mismo
        Procesador pero decidimos generar esta nueva clase y asignarle esta responsabilidad.
    */
    public class Respuesta: ComponenteBase
    {

        private static ArchivoInteracciones Interacciones = new ArchivoInteracciones ();
        public String Saludar ()
        {
            return Interacciones.GetInteraccion ("saludar");
        }
        public String Despedirse ()
        {
            return Interacciones.GetInteraccion ("despedir");
        }
        public String PreguntarGenero ()
        {

            return Interacciones.GetInteraccion ("genero");

        }
        public String PreguntarEdad ()
        {

            return Interacciones.GetInteraccion ("edad");

        }
        public String PreguntarIntereses ()
        {

            return Interacciones.GetInteraccion ("interes");

        }
        public String PreguntarPrecioMaximo ()
        {

            return Interacciones.GetInteraccion ("maximo");

        }

        public String PreguntarPrecioMinimo ()
        {

            return Interacciones.GetInteraccion ("minimo");

        }
        public void PedirAclaraciones ()
        {

            Interacciones.GetInteraccion ("aclaracion");

        }

        public String PresentarSugerencias (List<string> regalos)
        {
            string resultado = Interacciones.GetInteraccion ("presentaSugerencia");
            foreach (string regalo in regalos)
            {
                resultado += "\n" + regalo;
            }
            return resultado;

        }
        public String ConfirmarSugerencia ()
        {

            return Interacciones.GetInteraccion ("sugerencia");

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
                    this.PresentarSugerencias ();
                    break;

            }
        }
    }
}