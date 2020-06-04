using System;
namespace Library
{
/// <summary>
/// La clase PreguntasOrdenAleatorio implementa la interfase IGeneradorPreguntas. Implementando su metodo reutilizando codigo y evitando depender
/// de clases intermedias.
/// Se encarga de que las preguntas no sean arrojadas siempre en el mismo orden.
/// </summary>
    public class PreguntasOrdenAleatorio : IGeneradorPreguntas
    {
        protected int[] preguntados = new int[5]
        {
            0,
            0,
            0,
            0,
            0
        };
        //[edad, genero, precioMin, precioMax, intereses]
        private int ultimoPreguntado = -1;
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