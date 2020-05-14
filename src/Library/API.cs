using System;
using System.Collections.Generic;

namespace Library
{

/* Interfase que sera el molde para las diferentes API que utilizaremos, que la implementaran
utilizando asi reutilización de código
*/
    public class API : IPlataforma
    {
       public string RecibirMensaje()
       {
           return "";
       }
        public void EnviarMensaje()
        {}
/* Pretendemos utilizar Singleton aqui para crear instancias unicas de las APIs
*/
        public void InstanciarApi()
        {

        }
        
        public void ActulizarConfiguracion()
        {

        }
    }
}
