using System;
using System.Collections.Generic;
using System.Collections;

namespace Library
{

    /* Clase que genera la respuesta dependiendo el tipo de interaccion que tenga el usuario con el bot
        Se le da esta responsabiliadad para aplicar el Principio de SRP, inicialmente esto lo iba a hacer el mismo
        Procesador pero decidimos generar esta nueva clase y asignarle esta responsabilidad.
    */
    public class Respuesta
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
        public String PreguntarIntereses()
        {

            return Interacciones.GetInteraccion ("interes");

        }
           public String PreguntarPreciosMaximo()
        {

            return Interacciones.GetInteraccion ("maximo");

        }
        
           public String PreguntarPreciosMinimo()
        {

            return Interacciones.GetInteraccion ("minimo");

        }
        public String PedirAclaraciones()
        {

            return Interacciones.GetInteraccion ("aclaracion");

        }
        
        public String PresentarSugerencias(List<string> regalos )
        {
            string resultado = Interacciones.GetInteraccion ("presentaSugerencia");
            foreach (string regalo in regalos)
            {
                resultado += "\n"+ regalo;
            }
            return resultado;

        }
        public String ConfirmarSugerencia()
        {

            return Interacciones.GetInteraccion ("sugerencia");

        }



    }
}