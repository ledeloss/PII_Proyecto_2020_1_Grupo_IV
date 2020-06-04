using Library;
namespace Library.Test.GeneradorPerfil
{
    internal class PreguntasOrdenAleatorioStub: Library.PreguntasOrdenAleatorio
    {
        public void SetPreguntado(int indice)
        {
            this.preguntados[indice] = 1;
        }
        public void SetUltimaPregunta(int indice)
        {
            this.ultimoPreguntado = indice;
        }
    }
    
}