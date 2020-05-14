namespace Library
{
    /*Para respetar el principio de SRP, generamos clases que hereden de ManejadorArchivos que manejen los distintos
    tipos de archivos que se van a necesitar. En caso de ser necesario, se sobrecarga alguno de los métodos de 
    la clase padre para adecuarlo al archivo que se necesite leer
    */
    public class ArchivoConfiguracion: ManejadorArchivos
    {
        /*
        Esta clase se encarga de manejar los archivos que tengan los parámetros configurables que manejan el bot
        */

    }
}