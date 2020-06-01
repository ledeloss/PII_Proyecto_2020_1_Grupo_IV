using System;

namespace Library
{
    public class GeneradorPerfil: ComponenteBase
    {
        private Perfil persona = new Perfil();
        
        public void SetEdad(string v)
        {
            throw new NotImplementedException();
        }

        public void SetPrecioMaximo(string precioMax)
        {
            int valor = Int32.Parse(precioMax);
            try
            {
                persona.PrecioMax = valor;
            
            }
            catch 
            {

            }
        }

        public void SetPrecioMinimo(string precioMin)
        {
            int valor = Int32.Parse(precioMin);
            try
            {
                persona.PrecioMin = valor;
            
            }
            catch 
            {

            }
        }

        public void SetInteres(string interes)
        {
            persona.AddInteres(interes);
        }

        public void SetGenero(string genero)
        {
            switch (genero)
            {
                case "femenino":
                    persona.Genero = TipoGenero.Femenino;
                    break;
                case "masculino":
                    persona.Genero = TipoGenero.Femenino;
                    break;
                case "no":
                    persona.Genero = TipoGenero.Desconocido;
                    break;
            }
        }

        public TipoEnvio getDatoFaltante()
        {
            throw new NotImplementedException();
        }
    }
}