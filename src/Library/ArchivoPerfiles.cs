namespace Library
{
    /*Para respetar el principio de SRP, generamos clases que hereden de ManejadorArchivos que manejen los distintos
    tipos de archivos que se van a necesitar. En caso de ser necesario, se sobrecarga alguno de los métodos de 
    la clase padre para adecuarlo al archivo que se necesite leer
    */
    public class ArchivoPerfiles: ManejadorArchivos
    {
        /*
        Esta clase maneja los archivos que contengan perfiles de usuarios estándares, para complementar los filtros
        */

    }
}