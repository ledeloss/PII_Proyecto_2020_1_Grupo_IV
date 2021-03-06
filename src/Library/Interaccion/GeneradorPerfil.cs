using System;
using System.Collections.Generic;

namespace Library
{

    /// <summary>
    /// La clase GeneradorPerfil será la encargada de crear un objeto Perfil que luego sera necesario para la Busqueda de articulos 
    /// en las Tiendas como MercadoLibre.
    /// Esta Clase hereda de ComponenteBase lo cual mediante la abstraccion facilita la reutilizacion de código interactuando
    /// con la Clase Controlador (nuestro Mediador) y reduciendo el acoplamiento con el resto de las clases que intervienen en 
    /// el flujo.
    /// 
    /// </summary>
    public class GeneradorPerfil : ComponenteBase
    {
        private IGeneradorPreguntas pregunta ;
        private Perfil persona = new Perfil ();
        /// <summary>
        ///  El Procesamiento de Preguntas se separa para cumplir SRP.
        /// </summary>
        /// <param name="generador"></param>
        public void SetGeneradorPreguntas (IGeneradorPreguntas generador)
        {
            this.pregunta = generador;
        }
        public Perfil GetPersona ()
        {
            return this.persona;
        }

        /// <summary>
        /// Este metodo setea la edad, primero convierte el string que nos llega en un entero capturando la excepcion que puede llegar a dar.
        /// Conjuntamente clasifica a cada rango de edad en una generacion.
        /// Para esta entrega no tenemos Excepciones propias ,por lo que podran observar que en los bloques de 
        /// try,catch no se indican que tipo de Excepcion manejamos ,esto se deja pendiente para avanzar en la siguiente entrega.
        /// </summary>
        /// <param name="stringEdad"></param>
        public void SetEdad (string stringEdad)
        {
            int edad = 30;
            try
            {
                edad = Int32.Parse (stringEdad);
                this.ValidarEdad (edad);
            }
            catch
            {

            }
            if (edad == 0)
            {
                this.persona.Edad = TipoGeneraciones.RecienNacido;
            }
            else
            {
                if (edad > 0 && edad < 3)
                {
                    this.persona.Edad = TipoGeneraciones.Bebe;
                }
                else
                {
                    if (edad > 2 && edad < 6)
                    {
                        this.persona.Edad = TipoGeneraciones.Infante;
                    }
                    else
                    {
                        if (edad > 5 && edad < 11)
                        {
                            this.persona.Edad = TipoGeneraciones.Nino;
                        }
                        if (edad > 10 && edad < 14)
                        {
                            this.persona.Edad = TipoGeneraciones.PreAdolescente;
                        }
                    }
                }
            }
            if (edad > 13 && edad < 20)
            {
                this.persona.Edad = TipoGeneraciones.Adolescente;
            }
            else
            {
                if (edad > 19 && edad < 30)
                {
                    this.persona.Edad = TipoGeneraciones.Joven;
                }
                else
                {
                    if (edad > 29 && edad < 40)
                    {
                        this.persona.Edad = TipoGeneraciones.AdultoJoven;
                    }
                    else
                    {
                        if (edad > 39 && edad < 60)
                        {
                            this.persona.Edad = TipoGeneraciones.Adulto;
                        }
                        if (edad > 59)
                        {
                            this.persona.Edad = TipoGeneraciones.AdultoMayor;
                        }
                    }
                }
            }
        }

        public void ValidarEdad (int edad)
        {
            if (edad < 0 || edad > 120)
            {
                //no implementamos la excepcion que capturamos pero entendemos que debe arrojarla dadas estas condiciones
                throw new NotImplementedException ();
            }
        }

        public void SetPrecioMaximo (string precioMax)
        {
            try
            {
                int valor = Int32.Parse (precioMax);
                persona.PrecioMax = valor;

            }
            catch
            {

            }
        }

        public void SetPrecioMinimo (string precioMin)
        {
            try
            {
                int valor = Int32.Parse (precioMin);
                persona.PrecioMin = valor;

            }
            catch
            {

            }
        }

        public void SetInteres (string interes)
        {
            persona.AddInteres (interes);
        }
        /// <summary>
        /// Metodo que setea el genero si el usuario no desea especificarlo, este será "desconocido"
        /// </summary>
        /// <param name="genero"></param>
        public void SetGenero (string genero)
        {
            switch (genero.ToLower ())
            {
                case "femenino":
                    persona.Genero = TipoGenero.Femenino;
                    break;
                case "masculino":
                    persona.Genero = TipoGenero.Masculino;
                    break;
                case "no":
                    persona.Genero = TipoGenero.Desconocido;
                    break;
                default:
                    persona.Genero = TipoGenero.Desconocido;
                    break;

            }
        }

        public TipoEnvio getDatoFaltante ()
        {
            return this.pregunta.GetSiguientePregunta ();
        }

    }
}