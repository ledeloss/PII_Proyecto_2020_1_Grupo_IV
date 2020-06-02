using System.Collections.Generic;
namespace Library
{
    public interface IProcesador
    {
        string GetContenido();
        List<string> GetFrasesClave(string texto);
    }
}