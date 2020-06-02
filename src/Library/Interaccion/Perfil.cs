using System;
using System.Collections.Generic;

namespace Library
{
    public class Perfil
    {
        private TipoGenero genero;
        private TipoGeneraciones edad;
        private List<string> intereses = new List<string> ();
        private int precioMin = 1;
        private int precioMax = 9999999;

        public TipoGenero Genero
        {

            get
            {
                return this.genero;
            }
            set
            {
                this.genero = value;
            }
        }
        public TipoGeneraciones Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }
        public List<string> Intereses
        {
            get
            {
                return this.intereses;
            }

        }

        public void AddInteres (string interes)
        {
            if (!intereses.Contains (interes))
            {
                intereses.Add (interes);
            }

        }
        public int PrecioMax
        {
            get
            {
                return this.precioMax;
            }
            set
            {
                if (value < this.PrecioMin || value <= 0)
                {
                    throw new Exception ("Precio Incorrecto");
                }

                this.precioMax = value;

            }
        }
        public int PrecioMin
        {
            get
            {
                return this.precioMin;
            }
            set
            {
                if (value > this.PrecioMax || value < 0)
                {
                    throw new Exception ("Precio Incorrecto");
                }

                this.precioMin = value;
            } // generar excepcion
        }

    }

}