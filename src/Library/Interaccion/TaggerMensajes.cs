using System.Collections.Generic;
namespace Library
{
    public class TaggerMensajes: ComponenteBase
    {
        private IProcesador procesador;
        private ArchivoInteracciones interacciones;
        public TaggerMensajes( ArchivoInteracciones archInteracciones, IProcesador proc, IMediador mediador = null)
        {
            this.mediador = mediador;
            this.procesador = proc;
            this.interacciones = archInteracciones;
        }
        
        /// <summary>
        /// Método que categoriza inputs, dándole una etiqueta que defina qué tipo de interacción es.
        /// </summary>
        /// <returns>Objeto Mensaje (contiene el contenido original del mensaje en un string, las frases clave 
        /// en una lista de strings y un campo de TipoMensaje.</returns>
        public Mensaje EtiquetarMensaje()
        {
            string cont = procesador.getContenido();
            List<string> claves = procesador.getFrasesClave();
            TipoMensaje etiqueta = TipoMensaje.Otros;
            //Si el procesador no encuentra palabras clave 
            if (claves.Count == 0)
            {
                //Verifico el caso de que sea una interacción Positiva, Negativa o Despedida
                etiqueta = interacciones.BuscarEtiqueta(cont);
                //Si no lo reconoce como alguno de los anteriores, chequeo que haya números
                if (etiqueta == TipoMensaje.Otros)
                {
                    foreach(string palabra in cont.Split())
                    {
                        int n;
                        //Si encuentra números, etiqueto el mensaje
                        if (int.TryParse(palabra, out n))
                        {
                            etiqueta = TipoMensaje.Numero;
                        }
                    }
                }
            }
            //Si contiene frases clave, etiqueto según el archivo de interacciones
            else
            {
                foreach (string clave in claves)
                {
                    etiqueta = interacciones.BuscarEtiqueta(clave);
                }
            } 
            //
            Mensaje mensaje = new Mensaje(cont, etiqueta, claves);
            return mensaje;
        }
    }
}