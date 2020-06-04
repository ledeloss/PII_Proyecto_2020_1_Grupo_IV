using System.Collections.Generic;
using Library;
/// <summary>
/// Generamos los tests de forma tal de chequear en primera instancia todos los comportamientos, interacciones y condiciones que puedan afectar
/// nuestro core, y luego el core mismo. Buscamos con esto evitar interpretar un mal funcionamiento del procesador por aspectos externos al mismo.
/// </summary>

namespace Library.Test
{
    internal class GeneradorPerfilStub: Library.GeneradorPerfil
    {

        public GeneradorPerfilStub() 
        {
            
        }    
    }
}