using System.Collections.Generic;
namespace Library
{
    public interface IProcesador
    {
        string getContenido();
        List<string> getFrasesClave();
    }
}