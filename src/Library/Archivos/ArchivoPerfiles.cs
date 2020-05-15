namespace Library
{
    /*Para respetar el principio de SRP,Se le asigna a estas clases una unica responsabilidad,y razon de cambio.
      Generearemos clases que hereden de ManejadorArchivos y manejen los distintos tipos de archivos que se van a necesitar. 
      En caso de ser necesario, se sobrecarga alguno de los métodos de la clase padre para adecuarlo al archivo que se necesite leer
     */
    public class ArchivoPerfiles : ManejadorArchivos
    {
        /*
        Esta clase maneja los archivos que contengan perfiles de usuarios estándares para complementar los filtros
        */

    }
}