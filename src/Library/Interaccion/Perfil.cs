using System;
using System.Collections.Generic;

namespace Library
{
    public class Perfil
    {
        private TipoGenero genero;
        private TipoGeneraciones edad;
        private List<string> gustos;
        private int precioMin = 1;
        private int precioMax = 9999999;

        public TipoGenero Genero
        {
            get;
            set;
        }
        public TipoGeneraciones Edad
        {
            get;
            set;
        }
        public List<string> Gustos
        {
            get;
            set;
        }
        public int PrecioMax
        {
            get;
            set;
        }
        public int PrecioMin
        {
            get;
            set;
        }

    }

}