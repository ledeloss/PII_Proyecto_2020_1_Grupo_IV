using System;
using System.Collections.Generic;

namespace Library
{
    public class Perfil
    {
        private TipoGenero genero;
        private TipoGeneraciones edad;
        private List<string> intereses;
        private int precioMin = 1;
        private int precioMax = 9999999;

        public TipoGenero Genero
        {
            
            get {return this.genero;}
            set {this.genero = value;}
        }
        public TipoGeneraciones Edad
        {
            get {return this.edad;}
            set {this.edad = value;}
        }
        public List<string> Intereses
        {
            get {return this.intereses;}
                        
        }

        public void AddInteres(string interes)
        {
            if (!intereses.Contains(interes))
            {
                intereses.Add(interes);
            }
            
        }
        public int PrecioMax
        {
            get {return this.precioMin;}
            set {this.precioMin = value;} // generar excepcion
        }
        public int PrecioMin
        {
            get {return this.precioMax;}
            set {this.precioMax = value;} // generar excepcion
        }

    }

}