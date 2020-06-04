using System.Collections.Generic;
namespace Library
{

/// <summary>
/// La interfase IProcesador sera implementada por procesador y sera el molde para el procesamiento de las frases obtenidas del usuario.
/// Al igual que con IPlataforma reutilizamos codigo y dejamos abierto a la extension el procesamiento, podremos extenderlo sin tener que modificarlo
/// si decidimos realizar con otro software que no sea Azure, o adicionar otro, podriamos extender sin modificar, por lo cual nos fue útil
/// aplicar OCP.
/// </summary>
    public interface IProcesador
    {
        string GetContenido();
        List<string> GetFrasesClave(string texto);
    }
}