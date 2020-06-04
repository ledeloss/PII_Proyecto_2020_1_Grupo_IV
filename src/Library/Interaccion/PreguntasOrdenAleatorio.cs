using System;
namespace Library
{
/// <summary>
/// La clase PreguntasOrdenAleatorio implementa la interfase IGeneradorPreguntas parea definir 
/// el orden en que le enviamos las preguntas que tenemos pendientes para completar el Perfil de los usuarios. 
/// La idea de esta clase concreta es que cada pregunta que se realice sea de forma aleatoria (para que 
/// el flujo de interacción no sea siempre tan lineal).
/// 
/// Al utilizar la abstraccion, podriamos eventualmente crear otra clase concreta que Realice las preguntas en otro 
/// órden sin realizar demasiadas modificaciones.
/// </summary>
    public class PreguntasOrdenAleatorio : IGeneradorPreguntas
    {
        /// <summary>
        /// Esta lista de preguntados tiene el fin de almacenar cuales de las preguntas ya fueron realizadas y cuales estan 
        /// pendientes.
        /// Los posibles valores que tendrá  en cada posición será 0 o 1.
        /// 
        /// Se inicializa con cinco ceros (cada cero identifica que una pregunta no fue realizada aún)
        /// Las posiciones de la lista están dispuestas de la siguiente manera: 
        /// [edad, genero, precioMin, precioMax, intereses]
        /// 
        /// Por ejemplo: 
        /// -Si preguntados[0,1,1,1,1] tiene esta forma significa que ya hemos 
        /// preguntado todo menos la edad (primera posicion de la lista equivale a la edad y tiene un cero).
        ///-Si preguntados[0,1,0,0,1] tiene esta forma significa que ya hemos 
        /// preguntado el genero y también los intereses.
        /// </summary>
        /// <value></value>
        protected int[] preguntados = new int[5]
        {
            0,
            0,
            0,
            0,
            0
        };
        
        protected int ultimoPreguntado = -1;
        /// <summary>
        /// Para definir cual es la siguiente pregunta a realizar, se realiza de forma Aleatoria
        ///  pero con algunas consideraciones como ser: 
        /// Cuando se pregunta aleatoria es alguno de los precios (Maximo o Minimo) la seguiente pregunta debe ser también de precio
        /// para que ambas preguntas estén siempre juntas.  
        /// </summary>
        /// <returns></returns>
        public TipoEnvio GetSiguientePregunta()
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

        public void ActualizarPreguntados (int indice)
        {
            this.ultimoPreguntado = indice;
            this.preguntados[indice] = 1;
        }
    }
}