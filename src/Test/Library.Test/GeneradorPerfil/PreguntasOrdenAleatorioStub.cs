namespace Library.Test.GeneradorPerfil
{
    internal class PreguntasOrdenAleatorioStub: PreguntasOrdenAleatorio
    {
        public void SetPreguntado(int indice)
        {
            this.preguntados[indice] = 1;
        }
    }
}