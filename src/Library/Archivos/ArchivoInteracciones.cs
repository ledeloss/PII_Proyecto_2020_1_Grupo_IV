using System;
namespace Library
{
/// <summary>
/// La clase ArchivoInteracciones se encarga de manejar los archivos que contengan las interacciones preestablecidas.
/// Aplicamos aqui herencia como metodo de reutilizacion de codigo, ya que vamos a reutilizar lo referente al manejador de archivos. 
/// </summary>
    public class ArchivoInteracciones : ManejadorArchivos
    {
        private static string interes = "interes";

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