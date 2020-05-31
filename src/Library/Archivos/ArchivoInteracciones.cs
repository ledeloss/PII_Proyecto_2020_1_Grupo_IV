using System;
namespace Library
{
    /*Para respetar el principio de SRP,Se le asigna a estas clases una unica responsabilidad,y razon de cambio.
      Generearemos clases que hereden de ManejadorArchivos y manejen los distintos tipos de archivos que se van a necesitar. 
      En caso de ser necesario, se sobrecarga alguno de los métodos de la clase padre para adecuarlo al archivo que se necesite leer
     */
    public class ArchivoInteracciones : ManejadorArchivos
    {
        private static string interes = "interes";
        /*
        Esta clase maneja los archivos que contengan interacciones preestablecidas
        */

        public string GetInteraccion (string tipoInteraccion)
        {
            string path = $"\\..\\..\\..\\Interacciones\\{tipoInteraccion}.txt";
            return this.LeerLineaAleatoria (path);

        }

        public TipoMensaje BuscarEtiqueta(string text)
        {

            switch (text)
            {
                case "interes":
                    return TipoMensaje.Interes;
                case "numero":
                    return TipoMensaje.Numero;
                case "hombre":
                    return TipoMensaje.Genero;
                case "mujer":
                    return TipoMensaje.Genero;
                case "chau":
                    return TipoMensaje.Despedida;
                case "si":
                    return TipoMensaje.Positivo;
                case "no":
                    return TipoMensaje.Negativo;
                default:
                    return TipoMensaje.Otros;
            }

        }

    }
}