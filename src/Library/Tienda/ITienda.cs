using System;
using System.Collections.Generic;

namespace Library
{

    /* Interfase que sera quien genere la lista de regalos dependiendo de los filtros aplicados.
        Decidimos manejar las Tiendas de esta manera para facilitar las eventuales adiciones de
        futuras plataformas sin afectar el funcionamiento (Clase Abierta a la Extension) las responsabilidades de la
        clase pueden ser exendidas y es cerrada a la modificacion, (no es posible ni necesario modificar el codigo de dicha clase)
        Por tal motivo identificamos aqui el Patron OCP es justamente lo que utilzamos aqui.
       
    */
    public interface ITienda
    {
        List<Regalo> GenerarListaRegalos (IFiltro filtro);

        /*
            Identificamos Composicion - Delegacion - y Singleton aqui:
            Mediante este metodo de instanciarApiTienda() , crearemos intancias unicas por ejemplo de MercadoLibre (utilizando Singleton) y observamos
            que esta clase es una clase Compuesta, el componente es la clase en que vamos a Delegar la responsabilidad de 
            conocer como es el funcionamiento de Mercado Libre.
         */
        void InstanciarApiTienda ();

    }
}