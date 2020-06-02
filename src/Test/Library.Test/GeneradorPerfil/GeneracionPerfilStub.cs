using System.Collections.Generic;
using Library;

namespace Library.Test
{
    internal class GeneradorPerfilStub: Library.GeneradorPerfil
    {

        public GeneradorPerfilStub() 
        {
            
        }
        
        //[edad, genero, precioMin, precioMax, intereses]
        public GeneradorPerfilStub(int posEdad , int posGenero , int posPrecioMin , int posPrecioMax ,int intereses )
    
        {
            this.preguntados[0]= posEdad;
            this.preguntados[1]= posGenero;
            this.preguntados[2]= posPrecioMin;
            this.preguntados[3]= posPrecioMax;
            this.preguntados[4]= intereses;

        }


      





    }
}