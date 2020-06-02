namespace Library.Test.GeneradorPerfil
{
    internal class GeneradorPreguntasStub : IGeneradorPreguntas
    {
        private TipoEnvio siguientePregunta;
        private TipoEnvio ultimaPregunta;
        public GeneradorPreguntasStub (TipoEnvio siguiente)
        {
            this.siguientePregunta = siguiente;
        }
         public GeneradorPreguntasStub (TipoEnvio siguiente, TipoEnvio ultimo)
        {
            this.siguientePregunta = siguiente;
            this.ultimaPregunta = ultimo;
        }

        public TipoEnvio GetSiguientePregunta()
        {
            return this.siguientePregunta;
        }


    }
}