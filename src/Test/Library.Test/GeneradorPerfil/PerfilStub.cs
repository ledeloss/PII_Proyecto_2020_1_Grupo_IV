using System.Collections.Generic;

namespace Library.Test
{

    internal class PerfilStub : Perfil
    {
        public PerfilStub ()
        {

        }
        //Precio Maximo y Precio Minimo se van a preguntar de forma consecutiva  
        public PerfilStub (TipoGenero genero, TipoGeneraciones edad, List<string> intereses, int precioMin, int PrecioMax)
        {
            this.Genero = genero;
            this.Edad = edad;
            foreach (string interes in intereses)
            {
                this.AddInteres (interes);
            }
            this.PrecioMin = precioMin;
            this.PrecioMin = PrecioMax;

        }
        public PerfilStub (int precioMin, int precioMax)
        {
            this.PrecioMin = precioMin;
            this.PrecioMax = precioMax;
        }

    }
}