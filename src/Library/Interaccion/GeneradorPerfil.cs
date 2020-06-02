using System;
using System.Collections.Generic;

namespace Library
{

/// <summary>
/// La clase GeneradorPerfil será la encargada de generar un perfil de usuario.
/// 
/// </summary>
    public class GeneradorPerfil : ComponenteBase
    {
        private int[] preguntados = new int[5]
        {
            0,
            0,
            0,
            0,
            0
        };
        //[edad, genero, precioMin, precioMax, intereses]
        private int ultimoPreguntado = -1;
        private Perfil persona = new Perfil ();
        public Perfil GetPersona ()
        {
            return this.persona;
        }

        public void SetEdad (string stringEdad)
        {
            int edad = Int32.Parse (stringEdad);
            try
            {
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
                throw new NotImplementedException ();
            }
        }

        public void SetPrecioMaximo (string precioMax)
        {
            int valor = Int32.Parse (precioMax);
            try
            {
                persona.PrecioMax = valor;

            }
            catch
            {

            }
        }

        public void SetPrecioMinimo (string precioMin)
        {
            int valor = Int32.Parse (precioMin);
            try
            {
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

        public void SetGenero (string genero)
        {
            switch (genero.ToLower())
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
            if ((this.ultimoPreguntado == 3) && (preguntados[2] == 0))
            {
                ActualizarPreguntados (2);
                return TipoEnvio.PrecioMin;
            }
            else
            {
                if (this.ultimoPreguntado == 2 && (preguntados[3] == 0))
                {
                    ActualizarPreguntados (3);
                    return TipoEnvio.PrecioMax;
                }
            }
            Random rnd = new Random ();
            if (!this.IsPerfilCompleto ())
            {
                int indice = rnd.Next (this.preguntados.Length);
                while (this.preguntados[indice] != 0)
                {
                    indice = rnd.Next (this.preguntados.Length);
                }
                switch (indice)
                {
                    case 0:
                        ActualizarPreguntados (0);
                        return TipoEnvio.Edad;

                    case 1:
                        ActualizarPreguntados (1);
                        return TipoEnvio.Genero;

                    case 2:
                        ActualizarPreguntados (2);
                        return TipoEnvio.PrecioMin;

                    case 3:
                        ActualizarPreguntados (3);
                        return TipoEnvio.PrecioMax;

                    case 4:
                        ActualizarPreguntados (4);
                        return TipoEnvio.Interes;
                }
            }
            return TipoEnvio.Sugerencia;
        }

        public bool IsPerfilCompleto ()
        {
            foreach (int item in preguntados)
            {
                if (item == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void ActualizarPreguntados (int indice)
        {
            this.ultimoPreguntado = indice;
            this.preguntados[indice] = 1;
        }
    }
}