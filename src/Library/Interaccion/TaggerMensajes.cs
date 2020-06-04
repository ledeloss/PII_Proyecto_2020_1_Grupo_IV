using System.Collections.Generic;
namespace Library
{
/// <summary>
/// La clase TaggerMensajes hereda de ComponenteBase,lo utilizamos como componente utilizado por 
/// el Controlador (nuestro Mediador) para ser parte de un flujo de ejecuciones ordenado y sin tantas comunicaciones 
/// entre clases.
/// Su Función es tomar el input recibido en la plataforma para con él conformar un mensaje utilizando el Patrón Creeator.
/// 
/// </summary>
    public class TaggerMensajes: ComponenteBase
    {
        private IProcesador procesador;
        private ArchivoInteracciones interacciones;
        public TaggerMensajes( ArchivoInteracciones archInteracciones, IProcesador proc)
        {
            this.procesador = proc;
            this.interacciones = archInteracciones;
        }
        
        /// <summary>
        /// Método que categoriza inputs, dándole una etiqueta que defina qué tipo de interacción es.
        /// </summary>
        /// <returns>Objeto Mensaje (contiene el contenido original del mensaje en un string, las frases clave 
        /// en una lista de strings y un campo de TipoMensaje.</returns>
        /// 
        //Aplicamos patrón Creator porque TaggerMensajes contiene los datos que serán provistos para
        //inicializar instancias de Mensaje, y tiene un método que devuelve objetos del tipo Mensaje 
        //(TaggerMensajes usa de forma muy cercana objetos Mensaje)
        public void GetMensajeEntrante()
        {
           
            Mensaje mensaje = this.EtiquetarMensaje();
            this.mediador.Notificar(mensaje);
           
        }
        public Mensaje EtiquetarMensaje()
        {
            string cont = procesador.GetContenido();
            List<string> claves = procesador.GetFrasesClave(cont);
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
            return new Mensaje(cont, etiqueta, claves);
        }


       
    }
}